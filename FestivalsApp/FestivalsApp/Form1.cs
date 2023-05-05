using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace FestivalsApp
{
    public partial class Form1 : Form
    {
        // Variables to hold references to database-related objects
        SqlConnection _connection;
        DataSet _dataSet;
        SqlDataAdapter _locationsDA;
        SqlDataAdapter _festivalsDA;
        BindingSource _locationsBS;
        BindingSource _festivalsBS;

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
            _connection = new SqlConnection("Data Source=DESKTOP-REAU09T; Initial Catalog=dbms; Integrated Security=true");

            // Create database-related objects
            _dataSet = new DataSet();
            _locationsDA = new SqlDataAdapter("Select * from Locations", _connection);
            _festivalsDA = new SqlDataAdapter("Select * from Festivals", _connection);
            _commandBuilder = new SqlCommandBuilder(_festivalsDA);

            _locationsDA.Fill(_dataSet, "Locations");
            _festivalsDA.Fill(_dataSet, "Festivals");

            var locationFestivalRelation = new DataRelation("FK_Locations_Festivals",
                _dataSet.Tables["Locations"].Columns["location_id"],
                _dataSet.Tables["Festivals"].Columns["location_id"]);
            _dataSet.Relations.Add(locationFestivalRelation);

            _locationsBS = new BindingSource
            {
                DataSource = _dataSet,
                DataMember = "Locations"
            };

            _festivalsBS = new BindingSource
            {
                DataSource = _locationsBS,
                DataMember = "FK_Locations_Festivals"
            };

            // Set up data binding
            locationsDGV.DataSource = _locationsBS;
            locationsDGV.Columns["location_id"].Visible = false;
            festivalsDGV.DataSource = _festivalsBS;
            festivalsDGV.Columns["festival_id"].Visible = false;
            festivalsDGV.Columns["location_id"].Visible = false;

            recordNameTB.DataBindings.Add("Text", _festivalsBS, "festival_name");
        }

        private void FestivalsDGV_SelectionChanged(object sender, EventArgs e)
        {
            // Update the recordNameL Label with information about the current record being displayed
            recordNameL.Text = "Record " + (_festivalsBS.Position + 1).ToString() + "/" +
                _festivalsBS.Count.ToString() + ":";

            // Enable the removeB Button if a record is selected
            removeB.Enabled = (_festivalsBS.Position >= 0);
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            try
            {
                _festivalsDA.Update(_dataSet, "Festivals");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error:"); }
        }

        private void RemoveB_Click(object sender, EventArgs e)
        {
            // Get the current selected row in the festivals DataGridView.
            var currentRow = festivalsDGV.CurrentRow;
            if (currentRow == null)
                return;
            var festivalRow = ((DataRowView)currentRow.DataBoundItem).Row;

            // Remove the row from the festivals table in the DataSet.
            festivalRow.Delete();
        }
    }
}
