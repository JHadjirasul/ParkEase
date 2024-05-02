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

namespace ParkEase
{
    public partial class AdminHome : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\OneDrive\Desktop\MS ACCESS\ParkEaseDatabase.accdb;Persist Security Info=False;";
        private Dictionary<string, Panel> parkingPanels = new Dictionary<string, Panel>();
        private int availableSlots = 0;
        private int totalSlots = 136;
        private int occupiedSlots = 0;
        private int reservedSlots = 0;
        public AdminHome()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            bar1.Value = 0;
            LoadDataGrid();
            UpdateSlotCounts();
            InitializeParkingPanels();
            UpdatePanelColorsFromDatabase();
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
        private void AdminHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
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
        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private Panel GetPanelByParkingCode(string parkingCode)
        {
            if (parkingPanels.ContainsKey(parkingCode))
                return parkingPanels[parkingCode];
            else
                return null;
        }
        private void UpdatePanelColorsFromDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT [Parking Code], Status FROM Parking";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string parkingCode = row["Parking Code"].ToString();
                        string status = row["Status"].ToString();

                        Panel panel = GetPanelByParkingCode(parkingCode);
                        if (panel != null)
                        {
                            if (status == "OCCUPIED")
                            {
                                panel.BackColor = Color.Red;
                                if (parkingPanels.ContainsKey(parkingCode))
                                    parkingPanels[parkingCode].BackColor = Color.Red;
                            }
                            else if (status == "AVAILABLE")
                            {
                                panel.BackColor = Color.Silver;
                                if (parkingPanels.ContainsKey(parkingCode))
                                    parkingPanels[parkingCode].BackColor = Color.Silver;
                            }
                            else if (status == "RESERVED")
                            {
                                panel.BackColor = Color.LightSkyBlue;
                                if (parkingPanels.ContainsKey(parkingCode))
                                    parkingPanels[parkingCode].BackColor = Color.LightSkyBlue;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void InitializeParkingPanels()
        {
            parkingPanels.Add("A11", A11);
            parkingPanels.Add("A12", A12);
            parkingPanels.Add("A21", A21);
            parkingPanels.Add("A22", A22);
            parkingPanels.Add("A23", A23);
            parkingPanels.Add("A31", A31);
            parkingPanels.Add("A32", A32);
            parkingPanels.Add("A33", A33);
            parkingPanels.Add("A34", A34);
            parkingPanels.Add("A41", A41);
            parkingPanels.Add("A42", A42);
            parkingPanels.Add("A43", A43);
            parkingPanels.Add("A44", A44);

            parkingPanels.Add("B11", B11);
            parkingPanels.Add("B12", B12);
            parkingPanels.Add("B21", B21);
            parkingPanels.Add("B22", B22);
            parkingPanels.Add("B23", B23);
            parkingPanels.Add("B31", B31);
            parkingPanels.Add("B32", B32);
            parkingPanels.Add("B33", B33);
            parkingPanels.Add("B34", B34);
            parkingPanels.Add("B41", B41);
            parkingPanels.Add("B42", B42);
            parkingPanels.Add("B43", B43);
            parkingPanels.Add("B44", B44);

            parkingPanels.Add("C11", C11);
            parkingPanels.Add("C12", C12);
            parkingPanels.Add("C21", C21);
            parkingPanels.Add("C22", C22);
            parkingPanels.Add("C23", C23);
            parkingPanels.Add("C31", C31);
            parkingPanels.Add("C32", C32);
            parkingPanels.Add("C33", C33);
            parkingPanels.Add("C34", C34);
            parkingPanels.Add("C41", C41);
            parkingPanels.Add("C42", C42);
            parkingPanels.Add("C43", C43);
            parkingPanels.Add("C44", C44);

            parkingPanels.Add("D11", D11);
            parkingPanels.Add("D12", D12);
            parkingPanels.Add("D21", D21);
            parkingPanels.Add("D22", D22);
            parkingPanels.Add("D23", D23);
            parkingPanels.Add("D31", D31);
            parkingPanels.Add("D32", D32);
            parkingPanels.Add("D33", D33);
            parkingPanels.Add("D34", D34);
            parkingPanels.Add("D41", D41);
            parkingPanels.Add("D42", D42);
            parkingPanels.Add("D43", D43);
            parkingPanels.Add("D44", D44);

            parkingPanels.Add("E11", E11);
            parkingPanels.Add("E12", E12);
            parkingPanels.Add("E21", E21);
            parkingPanels.Add("E22", E22);
            parkingPanels.Add("E23", E23);
            parkingPanels.Add("E31", E31);
            parkingPanels.Add("E32", E32);
            parkingPanels.Add("E33", E33);
            parkingPanels.Add("E34", E34);
            parkingPanels.Add("E41", E41);
            parkingPanels.Add("E42", E42);
            parkingPanels.Add("E43", E43);
            parkingPanels.Add("E44", E44);

            parkingPanels.Add("F11", F11);
            parkingPanels.Add("F12", F12);
            parkingPanels.Add("F21", F21);
            parkingPanels.Add("F22", F22);
            parkingPanels.Add("F23", F23);
            parkingPanels.Add("F31", F31);
            parkingPanels.Add("F32", F32);
            parkingPanels.Add("F33", F33);
            parkingPanels.Add("F34", F34);
            parkingPanels.Add("F41", F41);
            parkingPanels.Add("F42", F42);
            parkingPanels.Add("F43", F43);
            parkingPanels.Add("F44", F44);

            parkingPanels.Add("G11", G11);
            parkingPanels.Add("G12", G12);
            parkingPanels.Add("G21", G21);
            parkingPanels.Add("G22", G22);
            parkingPanels.Add("G23", G23);
            parkingPanels.Add("G31", G31);
            parkingPanels.Add("G32", G32);
            parkingPanels.Add("G33", G33);
            parkingPanels.Add("G34", G34);
            parkingPanels.Add("G41", G41);
            parkingPanels.Add("G42", G42);
            parkingPanels.Add("G43", G43);
            parkingPanels.Add("G44", G44);

            parkingPanels.Add("H11", H11);
            parkingPanels.Add("H12", H12);
            parkingPanels.Add("H13", H13);
            parkingPanels.Add("H21", H21);
            parkingPanels.Add("H22", H22);
            parkingPanels.Add("H23", H23);
            parkingPanels.Add("H31", H31);
            parkingPanels.Add("H32", H32);
            parkingPanels.Add("H33", H33);

            parkingPanels.Add("I11", I11);
            parkingPanels.Add("I12", I12);
            parkingPanels.Add("I13", I13);
            parkingPanels.Add("I21", I21);
            parkingPanels.Add("I22", I22);
            parkingPanels.Add("I23", I23);
            parkingPanels.Add("I31", I31);
            parkingPanels.Add("I32", I32);
            parkingPanels.Add("I33", I33);

            parkingPanels.Add("J11", J11);
            parkingPanels.Add("J12", J12);
            parkingPanels.Add("J13", J13);
            parkingPanels.Add("J21", J21);
            parkingPanels.Add("J22", J22);
            parkingPanels.Add("J23", J23);
            parkingPanels.Add("J31", J31);
            parkingPanels.Add("J32", J32);
            parkingPanels.Add("J33", J33);

            parkingPanels.Add("K11", K11);
            parkingPanels.Add("K12", K12);
            parkingPanels.Add("K13", K13);
            parkingPanels.Add("K21", K21);
            parkingPanels.Add("K22", K22);
            parkingPanels.Add("K23", K23);
            parkingPanels.Add("K31", K31);
            parkingPanels.Add("K32", K32);
            parkingPanels.Add("K33", K33);

            parkingPanels.Add("L11", L11);
            parkingPanels.Add("L12", L12);
            parkingPanels.Add("L13", L13);
            parkingPanels.Add("L21", L21);
            parkingPanels.Add("L22", L22);
            parkingPanels.Add("L23", L23);
            parkingPanels.Add("L31", L31);
            parkingPanels.Add("L32", L32);
            parkingPanels.Add("L33", L33);
        }
    }
}
