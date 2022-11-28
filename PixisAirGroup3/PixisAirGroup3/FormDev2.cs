using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PixisAirGroup3
{
    public partial class FormDev2 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
        DataTable table;

        public FormDev2()
        {
            InitializeComponent();
        }

        private void btnReshist2_Click(object sender, EventArgs e)
        {
            string connectionString = "DataSource=deathstar.gtc.edu";
            string SQL = "SELECT * FROM RESHIST ";
            try
            {
                
                dataGridView1.DataSource = bindingSource1;
                dataAdapter = new iDB2DataAdapter(SQL, connectionString);
                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(dataAdapter);
                table = new DataTable();

                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
            }
            catch (Exception ex)
            {
                txtMake.Text = ex.Message;
            }
        }

        private void FormDev2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "DataSource=deathstar.gtc.edu";
            string SQL = "INSERT INTO CARS(Make,Model,ID) VALUES('" + txtMake.Text + "','" + txtModel.Text + "'," + txtID.Text + ")";
            try
            {

                dataGridView1.DataSource = bindingSource1;
                dataAdapter = new iDB2DataAdapter(SQL, connectionString);
                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(dataAdapter);
                table = new DataTable();

                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                txtState.Text = "File has been inserted";
            }
            catch (Exception ex)
            {
                txtState.Text = ex.Message;
            }
        }

        private void btnCars2_Click(object sender, EventArgs e)
        {
            string connectionString = "DataSource=deathstar.gtc.edu";
            string SQL = "SELECT * FROM CARS";
            try
            {

                dataGridView1.DataSource = bindingSource1;
                dataAdapter = new iDB2DataAdapter(SQL, connectionString);
                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(dataAdapter);
                table = new DataTable();

                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
            }
            catch (Exception ex)
            {
                txtState.Text = ex.Message;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEscape2_Click(object sender, EventArgs e)
        {
            Form FormMain = new FormMain();
            FormMain.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
