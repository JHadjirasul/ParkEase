using Org.BouncyCastle.Ocsp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ParkEase
{
    public partial class Parking : Form
    {
        private const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\OneDrive\Desktop\MS ACCESS\ParkEaseDatabase.accdb;Persist Security Info=False;";
        private Dictionary<string, Panel> parkingPanels = new Dictionary<string, Panel>();
        public Parking()
        {
            InitializeComponent();
            InitializeParkingPanels();
            HideArrows();
            UpdatePanelColorsFromDatabase();
            this.DoubleBuffered = true;

        }
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;

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

            foreach (var panelPair in parkingPanels)
            {
                panelPair.Value.Click += ParkingPanel_Click;
            }
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
        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                string parkingCode = tbxParkingCode.Text.Trim().ToUpper();
                string status = "RESERVED";
                string userType = cbxType.SelectedItem.ToString();
                string vtype = "";

                if (userType != "Employee")
                {
                    MessageBox.Show("Only employees are allowed to reserve parking spots.");
                    return;
                }

                string empID = tbxID.Text;
                if (userType == "Regular" || userType == "Senior Citizen")
                {
                    empID = RetrieveEmployeeID(empID);
                    vtype = RetrieveVehicleType(empID, userType);
                }
                else if (userType == "Employee")
                {
                    empID = RetrieveEmployeeID(empID);
                    vtype = RetrieveVehicleType(empID, userType);
                }

                if (string.IsNullOrEmpty(empID))
                {
                    MessageBox.Show("Employee ID not found. Reservation unsuccessful.");
                    return;
                }

                bool hasReservation = CheckReservation(empID);
                if (hasReservation)
                {
                    MessageBox.Show("You already have a reservation. You cannot reserve again.");
                    return;
                }

                bool hasOccupation = CheckExistingOccupation(empID);
                if (hasOccupation)
                {
                    MessageBox.Show("You have already occupied a parking spot. You cannot reserve parking spot.");
                    return;
                }

                string spotStatus = CheckParkingSpotStatus(parkingCode);
                if (spotStatus == "OCCUPIED")
                {
                    MessageBox.Show("This parking spot is already occupied.");
                    return;
                }
                else if (spotStatus == "RESERVED")
                {
                    MessageBox.Show("This parking spot is already reserved.");
                    return;
                }

                bool statusChanged = UpdateStatus(parkingCode, status);
                if (statusChanged)
                {
                    tbxParkingCode.Clear();

                    Panel panel = GetPanelByParkingCode(parkingCode);
                    if (panel != null)
                        panel.BackColor = Color.LightSkyBlue;
                    else
                        MessageBox.Show("Parking slot not found for the given parking code.");

                    string ticketNumber = InsertBookingRecord(empID, parkingCode, userType, vtype, "RESERVED");
                    if (string.IsNullOrEmpty(ticketNumber))
                    {
                        UpdateStatus(parkingCode, "AVAILABLE");
                        return;
                    }

                    MessageBox.Show($"Reserved successfully. Ticket Number: {ticketNumber}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid or Missing inputs!");
            }
            finally
            {
                tbxParkingCode.Clear();
                tbxID.Clear();
            }
        }
        private void btnOccupy_Click(object sender, EventArgs e)
        {
            try
            {
                string parkingCode = tbxParkingCode.Text.Trim().ToUpper();
                string status = "OCCUPIED";
                string userType = cbxType.SelectedItem.ToString();
                string userID = tbxID.Text;

                if (userType == "Regular" || userType == "Senior Citizen")
                {
                    userID = RetrieveUserID(userID, userType);
                }
                else if (userType == "Employee")
                {
                    userID = RetrieveEmployeeID(userID);

                }

                if (string.IsNullOrEmpty(userID))
                {
                    MessageBox.Show("User ID not found.");
                    return;
                }

                string vtype = RetrieveVehicleType(userID, userType);

                bool hasOccupation = CheckExistingOccupation(userID);
                if (hasOccupation)
                {
                    MessageBox.Show("You have already occupied a parking spot. You cannot occupy another one.");
                    return;
                }

                string spotStatus = CheckParkingSpotStatus(parkingCode);
                if (spotStatus == "RESERVED")
                {
                    bool hasReservation = CheckReservation(userID);

                    if (hasReservation)
                    {
                        bool statusChanged = UpdateStatus(parkingCode, "OCCUPIED");
                        if (statusChanged)
                        {
                            tbxParkingCode.Clear();
                            Panel panel = GetPanelByParkingCode(parkingCode);
                            if (panel != null)
                                panel.BackColor = Color.Red;
                            else
                                MessageBox.Show("Parking slot not found for the given parking code.");

                            UpdateBookingStatus(userID, parkingCode, "OCCUPIED");

                            InsertParkingLogEntry(GetTicketNumberByUserID(userID));
                            MessageBox.Show("Occupied successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to occupy the parking spot. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You do not have a reservation for this parking spot.");
                    }

                }
                else if (spotStatus == "OCCUPIED")
                {
                    MessageBox.Show("This parking spot is already occupied.");
                }
                else
                {
                    bool hasReservation = CheckReservation(userID);
                    if (hasReservation)
                    {
                        MessageBox.Show("You already have a reservation. You cannot reserve again.");
                        return;
                    }

                    bool statusChanged = UpdateStatus(parkingCode, status);
                    if (statusChanged)
                    {
                        tbxParkingCode.Clear();
                        Panel panel = GetPanelByParkingCode(parkingCode);
                        if (panel != null)
                        {
                            panel.BackColor = Color.Red;

                            string ticketNumber = InsertBookingRecord(userID, parkingCode, userType, vtype, "OCCUPIED");
                            if (string.IsNullOrEmpty(ticketNumber))
                            {
                                UpdateStatus(parkingCode, "AVAILABLE");
                                return;
                            }
                            InsertParkingLogEntry(ticketNumber);
                            MessageBox.Show($"Occupied successfully. Ticket Number: {ticketNumber}");
                        }
                        else
                        {
                            MessageBox.Show("Parking slot not found for the given parking code.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to occupy the parking spot. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid or Missing inputs!");
            }
            finally
            {
                tbxParkingCode.Clear();
                tbxID.Clear();
            }
        }
        private bool CheckReservation(string userID)
        {
            string query = "SELECT COUNT(*) FROM Bookings WHERE [User ID] = @userID AND Status = 'RESERVED'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@userID", userID);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }
        private bool CheckExistingOccupation(string userID)
        {
            string query = "SELECT COUNT(*) FROM Bookings WHERE [User ID] = @userID AND Status = 'OCCUPIED'";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@userID", userID);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }
        private string RetrieveVehicleType(string userID, string userType)
        {
            string query = "";
            string parameterName = "";

            if (userType == "Employee")
            {
                query = "SELECT [Vehicle Type] FROM Employees WHERE [Employee ID] = @EmployeeID";
                parameterName = "@EmployeeID";
            }
            else
            {
                query = "SELECT [Vehicle Type] FROM Users WHERE [User ID] = @UserID";
                parameterName = "@UserID";
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue(parameterName, userID);

                    object result = command.ExecuteScalar();
                    if (result != null)
                        return result.ToString();
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        private bool UpdateBookingStatus(string userID, string parkingCode, string status)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Bookings SET Status = @Status WHERE [User ID] = @UserID AND [Parking Code] = @ParkingCode";
                    OleDbCommand command = new OleDbCommand(query, connection);

                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@ParkingCode", parkingCode);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        private string RetrieveEmployeeID(string empID)
        {
            string query = "SELECT [Employee ID] FROM Employees WHERE [Employee ID] = @EmployeeID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeID", empID);

                    object result = command.ExecuteScalar();
                    if (result != null)
                        return result.ToString();
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Employee ID not found!");
                    return null;
                }
            }
        }
        private string RetrieveUserID(string userID, string userType)
        {
            string query = "";
            string parameterName = "";

            if (userType == "Employee")
            {
                query = "SELECT [Employee ID] FROM Employees WHERE [Employee ID] = @EmployeeID";
                parameterName = "@EmployeeID";
            }
            else
            {
                query = "SELECT [User ID] FROM Users WHERE [User ID] = @UserID";
                parameterName = "@UserID";
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue(parameterName, userID);

                    object result = command.ExecuteScalar();
                    if (result != null)
                        return result.ToString();
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User ID not found!");
                    return null;
                }
            }
        }
        private string InsertBookingRecord(string userID, string parkingCode, string userType, string vtype, string status)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Bookings ([User ID], [Parking Code], [User Type], [Vehicle Type], [Status], [Ticket Number]) VALUES (@UserID, @ParkingCode, @UserType, @VType, @Status, @TicketNumber)";
                    OleDbCommand command = new OleDbCommand(query, connection);

                    string ticketNumber = $"{parkingCode}-{userID.Substring(userID.Length - 3)}";

                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@ParkingCode", parkingCode);
                    command.Parameters.AddWithValue("@UserType", userType);
                    command.Parameters.AddWithValue("@VType", vtype);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@TicketNumber", ticketNumber);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return ticketNumber;
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert booking record. No rows affected.");
                        return null;
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Error inserting booking record: {ex.Message}");
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                    return null;
                }
            }
        }
        private void InsertParkingLogEntry(string ticketNumber)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Parking_Log ([Ticket Number], [Time In], [Parking Date]) VALUES (@TicketNumber, @TimeIn, @Date)";
                    OleDbCommand command = new OleDbCommand(query, connection);

                    DateTime currentTime = DateTime.Now;
                    DateTime timeIn = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, currentTime.Minute, 0);

                    command.Parameters.AddWithValue("@TicketNumber", ticketNumber);
                    command.Parameters.AddWithValue("@TimeIn", timeIn.ToShortTimeString());
                    command.Parameters.AddWithValue("@Date", currentTime.ToShortDateString());

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected <= 0)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private string GetTicketNumberByUserID(string ticketNumber)
        {
            string query = "SELECT [Ticket Number] FROM Bookings WHERE [User ID] = @UserID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@TicketNumber", ticketNumber);

                    object result = command.ExecuteScalar();
                    if (result != null)
                        return result.ToString();
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User ID not found!");
                    return null;
                }
            }
        }
        private string CheckParkingSpotStatus(string parkingCode)
        {
            string query = "SELECT Status FROM Parking WHERE [Parking Code] = @ParkingCode";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@ParkingCode", parkingCode);

                    object result = command.ExecuteScalar();
                    if (result != null)
                        return result.ToString();
                    else
                        return "NOT_FOUND";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return "ERROR";
                }
            }
        }
        private bool UpdateStatus(string parkingCode, string status)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Parking SET Status = @Status WHERE [Parking Code] = @ParkingCode";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ParkingCode", parkingCode);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
        private Panel GetPanelByParkingCode(string parkingCode)
        {
            if (parkingPanels.ContainsKey(parkingCode))
                return parkingPanels[parkingCode];
            else
                return null;
        }
        private void HideArrows()
        {
            p1.Hide();
            p2.Hide();
            p3.Hide();
            p4.Hide();
            p5.Hide();
            p6.Hide();
            p8.Hide();
            p9.Hide();
            p10.Hide();
            p11.Hide();
            p12.Hide();
            p13.Hide();
            p14.Hide();
            p15.Hide();
            p16.Hide();
            p17.Hide();
            p18.Hide();
            p19.Hide();
            p20.Hide();
            p21.Hide();
            p22.Hide();
            p23.Hide();
            p24.Hide();
            p25.Hide();
            p26.Hide();
            p27.Hide();
            p28.Hide();
            p29.Hide();
            p30.Hide();
            p31.Hide();
            p32.Hide();
            p33.Hide();
            p34.Hide();
            p35.Hide();
            p36.Hide();
            p37.Hide();
            p38.Hide();
            p39.Hide();
            p40.Hide();
            p41.Hide();
            p42.Hide();
            p43.Hide();
            p44.Hide();
            p45.Hide();
            p46.Hide();
            p47.Hide();
            p48.Hide();
        }
        private void ShowArrows()
        {
            p1.Show();
            p2.Show();
            p3.Show();
            p4.Show();
            p5.Show();
            p6.Show();
            p8.Show();
            p9.Show();
            p10.Show();
            p11.Show();
            p12.Show();
            p13.Show();
            p14.Show();
            p15.Show();
            p16.Show();
            p17.Show();
            p18.Show();
            p19.Show();
            p20.Show();
            p21.Show();
            p22.Show();
            p23.Show();
            p24.Show();
            p25.Show();
            p26.Show();
            p27.Show();
            p28.Show();
            p29.Show();
            p30.Show();
            p31.Show();
            p32.Show();
            p33.Show();
            p34.Show();
            p35.Show();
            p36.Show();
            p37.Show();
            p38.Show();
            p39.Show();
            p40.Show();
            p41.Show();
            p42.Show();
            p43.Show();
            p44.Show();
            p45.Show();
            p46.Show();
            p47.Show();
            p48.Show();
        }
        private bool arrowsVisible = false;
        private void guna2Button1_Click_1(object sender, EventArgs e) //btnShowPath
        {
            if (arrowsVisible)
            {
                HideArrows();
            }
            else
            {
                ShowArrows();
            }

            arrowsVisible = !arrowsVisible;
        }
        private void ParkingPanel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = (Panel)sender;

            if (clickedPanel.BackColor == Color.Red)
            {
                MessageBox.Show("Parking spot is already occupied!");
                tbxParkingCode.Clear();
            }
            else if (clickedPanel.BackColor == Color.LightSkyBlue)
            {
                MessageBox.Show("Parking spot is already reserved.");
                tbxParkingCode.Clear();
            }
            else
            {
                string parkingCode = clickedPanel.Name;
                tbxParkingCode.Text = parkingCode;
            }
        }
        private void Parking_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

        }
        bool pan1Expand;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pan1Expand)
            {
                pan1.Height -= 10;
                if (pan1.Height == pan1.MinimumSize.Height)
                {
                    pan1Expand = false;
                    timer1.Stop();
                }
            }
            else
            {
                pan1.Height += 10;
                if (pan1.Height == pan1.MaximumSize.Height)
                {
                    pan1Expand = true;
                    timer1.Stop();
                }
            }
        }
        private void btnOptions_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
