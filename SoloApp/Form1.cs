using MySql.Data.MySqlClient;
using System.Data;

namespace SoloApp
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        string sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        string server = "localhost";
        string username = "root";
        string password = "DREADhead2638!";
        string database = "transportationapp";
        public Form1()
        {
            InitializeComponent();
        }
        private void uploadData()
        {
            sqlConn.ConnectionString = "server =" + server + ";"
               + "username =" + username + ";"
               + "password =" + password + ";"
               + "database =" + database;

            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "select * from transportationapp.vehicles";
            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();

            dataGridView1.DataSource = sqlDt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uploadData();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;

                iExit = MessageBox.Show("Do you want to exit?", "Confirm you want to exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
               foreach (Control c in panel4.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Clear();
                    }
                }
                searchTb.Clear();
                makeCb.Text = "";
                yearCb.Text = "";
                engineTypeCb.Text = "";
                typeCb.Text = "";
                bookedCb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn.ConnectionString = "server =" + server + ";"
               + "username =" + username + ";"
               + "password =" + password + ";"
               + "database =" + database;

                sqlConn.Open();
                // table compoments
                sqlQuery = "insert into transportationapp.vehicles(license_plate,make,model,year,engine,color,mileage,type,booked)" +
                    "values('" + licensePlateTb.Text + "', '" + makeCb.Text + "', '" + modelTb.Text + "', '" + yearCb.Text + "', '"
                    + engineTypeCb.Text + "', '" + colorTb.Text + "', '" + mileageTb.Text + "', '" + typeCb.Text + "', '" + bookedCb.Text + "')"; 

                // command to take query and connector, along with reading the info
                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();
                sqlConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            uploadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                licensePlateTb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                makeCb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                modelTb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                yearCb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                engineTypeCb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                colorTb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                mileageTb.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                typeCb.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                bookedCb.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}