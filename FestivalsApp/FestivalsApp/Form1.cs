using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace FestivalsApp
{
    public partial class Form1 : Form
    {
        // Configuration strings
        readonly string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        readonly string parentTableName = ConfigurationManager.AppSettings["ParentTableName"];
        readonly string childTableName = ConfigurationManager.AppSettings["ChildTableName"];
        readonly string parentTableIdName = ConfigurationManager.AppSettings["ParentTableIdName"];
        readonly string childTableIdName = ConfigurationManager.AppSettings["ChildTableIdName"];
        readonly string childTableNameField = ConfigurationManager.AppSettings["ChildTableNameField"];

        // Variables to hold references to database-related objects
        SqlConnection _connection;
        DataSet _dataSet;
        SqlDataAdapter _parentsDA;
        SqlDataAdapter _childrenDA;
        BindingSource _parentsBS;
        BindingSource _childrenBS;

        // SqlCommandBuilder object for building SQL commands
        [SuppressMessage("CodeQuality", "IDE0052:Remove unread private members", Justification = "False positive warning")]
        SqlCommandBuilder _commandBuilder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Set up the connection
            _connection = new SqlConnection(connectionString);

            // Create database-related objects
            _dataSet = new DataSet();
            _parentsDA = new SqlDataAdapter("SELECT * FROM " + parentTableName, _connection);
            _childrenDA = new SqlDataAdapter("SELECT * FROM " + childTableName, _connection);
            _commandBuilder = new SqlCommandBuilder(_childrenDA);

            _parentsDA.Fill(_dataSet, parentTableName);
            _childrenDA.Fill(_dataSet, childTableName);

            string relationName = "FK_" + parentTableName + "_" + childTableName;
            var parentChildRelation = new DataRelation(relationName,
                _dataSet.Tables[parentTableName].Columns[parentTableIdName],
                _dataSet.Tables[childTableName].Columns[parentTableIdName]);
            _dataSet.Relations.Add(parentChildRelation);

            _parentsBS = new BindingSource
            {
                DataSource = _dataSet,
                DataMember = parentTableName
            };

            _childrenBS = new BindingSource
            {
                DataSource = _parentsBS,
                DataMember = relationName
            };

            // Set up data binding
            locationsDGV.DataSource = _parentsBS;
            locationsDGV.Columns[parentTableIdName].Visible = false;
            childrenDGV.DataSource = _childrenBS;
            childrenDGV.Columns[childTableIdName].Visible = false;
            childrenDGV.Columns[parentTableIdName].Visible = false;

            recordNameTB.DataBindings.Add("Text", _childrenBS, childTableNameField);

            // Set labels
            parentsL.Text = parentTableName;
            childrenL.Text = childTableName;
        }

        private void FestivalsDGV_SelectionChanged(object sender, EventArgs e)
        {
            // Update the recordNameL Label with information about the current record being displayed
            recordNameL.Text = "Record " + (_childrenBS.Position + 1).ToString() + "/" +
                _childrenBS.Count.ToString() + ":";

            // Enable the removeB Button if a record is selected
            removeB.Enabled = (_childrenBS.Position >= 0);
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            try
            {
                _childrenDA.Update(_dataSet, childTableName);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error:"); }
        }

        private void RemoveB_Click(object sender, EventArgs e)
        {
            // Get the current selected row in the children DataGridView.
            var currentRow = childrenDGV.CurrentRow;
            if (currentRow == null)
                return;
            var childRow = ((DataRowView)currentRow.DataBoundItem).Row;

            // Remove the row from the children table in the DataSet.
            childRow.Delete();
        }
    }
}
