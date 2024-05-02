using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkEase
{
    public partial class Home : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\OneDrive\Desktop\MS ACCESS\ParkEaseDatabase.accdb;Persist Security Info=False;";
        private int totalSlots = 136;
        private int occupiedSlots = 0;
        private int reservedSlots = 0;
        private int availableSlots = 0;
        public Home()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            bar1.Value = 0;
            LoadDataGrid();
            UpdateSlotCounts();
        }
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;
        private void UpdateSlotCounts()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string availableQuery = "SELECT COUNT(*) FROM Parking WHERE Status = 'AVAILABLE'";
                    OleDbCommand availableCommand = new OleDbCommand(availableQuery, connection);
                    availableSlots = (int)availableCommand.ExecuteScalar();

                    string reservedQuery = "SELECT COUNT(*) FROM Parking WHERE Status = 'RESERVED'";
                    OleDbCommand reservedCommand = new OleDbCommand(reservedQuery, connection);
                    reservedSlots = (int)reservedCommand.ExecuteScalar();

                    string occupiedQuery = "SELECT COUNT(*) FROM Parking WHERE Status = 'OCCUPIED'";
                    OleDbCommand occupiedCommand = new OleDbCommand(occupiedQuery, connection);
                    occupiedSlots = (int)occupiedCommand.ExecuteScalar();

                    int totalUsedSlots = occupiedSlots + reservedSlots;
                    int totalAvailableSlots = totalSlots - totalUsedSlots;

                    double occupiedPercentage = (double)occupiedSlots / totalSlots * 100;
                    double reservedPercentage = (double)reservedSlots / totalSlots * 100;

                    bar1.Value = (int)(occupiedPercentage + reservedPercentage);
                    labelAvailable.Text = $"{totalAvailableSlots}";
                    labelReserved.Text = $"{reservedSlots}";
                    labelOccupied.Text = $"{occupiedSlots}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void LoadDataGrid()
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\OneDrive\\Desktop\\MS ACCESS\\ParkEaseDatabase.accdb");

                string query = "SELECT [Parking Code], [Status] FROM Parking";

                da = new OleDbDataAdapter(query, myConn);

                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Parking");
                dgvParking.DataSource = ds.Tables["Parking"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void rdbAvailable_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\OneDrive\\Desktop\\MS ACCESS\\ParkEaseDatabase.accdb");

                string query = "SELECT [Parking Code], [Status] FROM Parking WHERE [Status] = 'AVAILABLE'";

                da = new OleDbDataAdapter(query, myConn);

                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Parking");
                dgvParking.DataSource = ds.Tables["Parking"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        private void rdbReserved_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\OneDrive\\Desktop\\MS ACCESS\\ParkEaseDatabase.accdb");

                string query = "SELECT [Parking Code], [Status] FROM Parking WHERE [Status] = 'RESERVED'";

                da = new OleDbDataAdapter(query, myConn);

                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Parking");
                dgvParking.DataSource = ds.Tables["Parking"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        private void rdbOccupied_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\OneDrive\\Desktop\\MS ACCESS\\ParkEaseDatabase.accdb");

                string query = "SELECT [Parking Code], [Status] FROM Parking WHERE [Status] = 'OCCUPIED'";

                da = new OleDbDataAdapter(query, myConn);

                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Parking");
                dgvParking.DataSource = ds.Tables["Parking"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
