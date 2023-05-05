using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace s2_926
{
    public partial class Form1 : Form
    {
        SqlConnection _connection;
        DataSet _dataSet;
        SqlDataAdapter _locationsDA;
        SqlDataAdapter _festivalsDA;
        BindingSource _locationsBS;
        BindingSource _festivalsBS;

        [SuppressMessage("CodeQuality", "IDE0052:Remove unread private members", Justification = "<Pending>")]
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

            /*daSongs.InsertCommand = new SqlCommand(".... where idS = @idS", conn);
            daSongs.InsertCommand.Parameters.Add("@idS", SqlDbType.Int).Value = 24;*/

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

            dataGridViewAlbums.DataSource = _locationsBS;
            dataGridViewAlbums.Columns["location_id"].Visible = false;
            dataGridViewSongs.DataSource = _festivalsBS;
            dataGridViewSongs.Columns["festival_id"].Visible = false;
            dataGridViewSongs.Columns["location_id"].Visible = false;

            textBox1.DataBindings.Add("Text", _festivalsBS, "festival_name");
        }

        private void dataGridViewSongs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSongs.ClearSelection();
            dataGridViewSongs.Rows[_festivalsBS.Position].Selected = true;
            label1.Text = "No. record: " + (_festivalsBS.Position + 1).ToString() + "/" +
                _festivalsBS.Count.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _festivalsDA.Update(_dataSet, "Festivals");
        }
    }
}
