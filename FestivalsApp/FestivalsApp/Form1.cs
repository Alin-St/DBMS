using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace FestivalsApp
{
    public partial class Form1 : Form
    {
        SqlConnection _connection;
        DataSet _dataSet;
        SqlDataAdapter _locationsDA;
        SqlDataAdapter _festivalsDA;
        BindingSource _locationsBS;
        BindingSource _festivalsBS;

        [SuppressMessage("CodeQuality", "IDE0052:Remove unread private members", Justification = "False positive warning")]
        SqlCommandBuilder _commandBuilder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _connection = new SqlConnection("Data Source=DESKTOP-REAU09T; Initial Catalog=dbms; Integrated Security=true");
            _dataSet = new DataSet();
            _locationsDA = new SqlDataAdapter("Select * from Locations", _connection);
            _festivalsDA = new SqlDataAdapter("Select * from Festivals", _connection);
            _commandBuilder = new SqlCommandBuilder(_festivalsDA);

            _locationsDA.Fill(_dataSet, "Locations");
            _festivalsDA.Fill(_dataSet, "Festivals");
            var dr = new DataRelation("FK_Locations_Festivals",
                _dataSet.Tables["Locations"].Columns["location_id"],
                _dataSet.Tables["Festivals"].Columns["location_id"]);
            _dataSet.Relations.Add(dr);

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

            locationsDGV.DataSource = _locationsBS;
            locationsDGV.Columns["location_id"].Visible = false;
            festivalsDGV.DataSource = _festivalsBS;
            festivalsDGV.Columns["festival_id"].Visible = false;
            festivalsDGV.Columns["location_id"].Visible = false;

            recordNameTB.DataBindings.Add("Text", _festivalsBS, "festival_name");
        }

        private void FestivalsDGV_SelectionChanged(object sender, EventArgs e)
        {
            recordNameL.Text = "Record " + (_festivalsBS.Position + 1).ToString() + "/" +
                _festivalsBS.Count.ToString() + ":";
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            try
            {
                _festivalsDA.Update(_dataSet, "Festivals");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error:"); }
        }
    }
}
