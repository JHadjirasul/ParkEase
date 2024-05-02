using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkEase
{
    public partial class ParkingStatus : Form
    {

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\OneDrive\Desktop\MS ACCESS\ParkEaseDatabase.accdb;";
        public ParkingStatus()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;
        private void ParkingStatus_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

        }
        private void tbxTN_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbxTicket.Text;
            DateTime selectedDate = datetimepicker1.Value.Date;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [Ticket Number], Format([Time In], 'Short Time') AS [Time In], Format([Time Out], 'Short Time') AS [Time Out], [Parking Fee], [Parking Date] FROM Parking_Log WHERE [Ticket Number] LIKE @TN AND [Parking Date] = @Date";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@TN", "%" + searchValue + "%");
                    adapter.SelectCommand.Parameters.AddWithValue("@Date", selectedDate);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    dgvParkingLog.DataSource = dataSet.Tables[0];
                }
            }
        }
        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(95, 74, 211);
            panel3.BackColor = Color.Silver;
            panel1.BackColor = Color.Silver;
            lbLog.ForeColor = Color.DimGray;
            lbBooking.ForeColor = Color.Gray;
            lbSales.ForeColor = Color.Gray;

            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\OneDrive\\Desktop\\MS ACCESS\\ParkEaseDatabase.accdb");

                da = new OleDbDataAdapter("SELECT [Ticket Number], Format([Time In], 'Short Time') AS [Time In], Format([Time Out], 'Short Time') AS [Time Out], [Parking Fee], [Parking Date] FROM Parking_Log", myConn);

                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Parking_Log");
                dgvParkingLog.DataSource = ds.Tables["Parking_Log"];
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\OneDrive\\Desktop\\MS ACCESS\\ParkEaseDatabase.accdb");


                string deleteEmployeesQuery = "DELETE FROM Bookings";
                OleDbCommand deleteEmployeesCmd = new OleDbCommand(deleteEmployeesQuery, myConn);

                string updateParkingStatusQuery = "UPDATE Parking SET Status='AVAILABLE'";
                OleDbCommand updateParkingStatusCmd = new OleDbCommand(updateParkingStatusQuery, myConn);

                string deleteSalesReportQuery = "DELETE FROM Sales_Report";
                OleDbCommand deleteSalesReportCmd = new OleDbCommand(deleteSalesReportQuery, myConn);

                myConn.Open();

                int rowsAffectedEmployees = deleteEmployeesCmd.ExecuteNonQuery();
                int rowsAffectedParkingStatus = updateParkingStatusCmd.ExecuteNonQuery();
                int rowsAffectedSalesReport = deleteSalesReportCmd.ExecuteNonQuery();

                myConn.Close();

                if (rowsAffectedEmployees > 0)
                {
                    MessageBox.Show("All records cleared successfully.");
                    btnLoad_Click_1(sender, e);
                    dgvParkingLog.DataSource = null;
                }
                else if (rowsAffectedSalesReport > 0)
                {
                    MessageBox.Show("All records cleared successfully.");
                    btnLoad_Click_1(sender, e);
                    dgvParkingLog.DataSource = null;
                }
                else
                {
                    MessageBox.Show("No records found to clear.");
                }

                myConn.Open();

                string selectQuery = "SELECT [Parking Date], SUM([Parking Fee]) AS TotalFee FROM Parking_Log GROUP BY [Parking Date]";
                OleDbCommand selectCommand = new OleDbCommand(selectQuery, myConn);
                OleDbDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    DateTime date = (DateTime)reader["Parking Date"];
                    decimal totalFee = (decimal)reader["TotalFee"];

                    string insertQuery = "INSERT INTO Sales_Report ([Parking Date], [Total Sales]) VALUES (@Date, @TotalSales)";
                    OleDbCommand insertCommand = new OleDbCommand(insertQuery, myConn);
                    insertCommand.Parameters.AddWithValue("@Date", date);
                    insertCommand.Parameters.AddWithValue("@TotalSales", totalFee);
                    insertCommand.ExecuteNonQuery();
                }

                myConn.Close();

                MessageBox.Show("Sales report updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string ticketNumber = tbxTicket.Text;

            string query = "SELECT [Parking Code], [User ID] FROM Bookings WHERE [Ticket Number] = @TicketNumber";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@TicketNumber", ticketNumber);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string parkingCode = reader["Parking Code"].ToString();
                        string userID = reader["User ID"].ToString();

                        DateTime currentTime = DateTime.Now;
                        DateTime timeOut = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, currentTime.Minute, 0);

                        string timeInQuery = "SELECT [Time In] FROM Parking_Log WHERE [Ticket Number] = @TicketNumber";
                        OleDbCommand timeInCommand = new OleDbCommand(timeInQuery, connection);
                        timeInCommand.Parameters.AddWithValue("@TicketNumber", ticketNumber);
                        DateTime timeIn = (DateTime)timeInCommand.ExecuteScalar();
                        TimeSpan parkingDuration = timeOut.TimeOfDay - timeIn.TimeOfDay;
                        double durationMinutes = parkingDuration.TotalMinutes;


                        double parkingFee;
                        const double initialFee = 30;
                        const double subsequentFeePerMinute = 20;

                        if (durationMinutes <= 3)
                        {
                            parkingFee = initialFee;
                        }
                        else
                        {

                            parkingFee = initialFee;

                            parkingFee += (durationMinutes - 3) * subsequentFeePerMinute;
                        }

                        parkingFee *= 1.12;

                        string userTypeQuery = "SELECT [User Type] FROM Bookings WHERE [Ticket Number] = @TicketNumber";
                        OleDbCommand userTypeCommand = new OleDbCommand(userTypeQuery, connection);
                        userTypeCommand.Parameters.AddWithValue("@TicketNumber", ticketNumber);
                        string userType = userTypeCommand.ExecuteScalar()?.ToString();

                        if (userType == "Senior Citizen")
                        {

                            parkingFee *= 0.8;
                        }
                        else if (userType == "Employee")
                        {
                            parkingFee = 0;
                        }

                        double discount = 0;

                        if (userType == "Senior Citizen")
                        {
                            discount = 0.8;
                        }
                        else if (userType == "Employee")
                        {
                            discount = 1;
                        }

                        string updateParkingLogQuery = "UPDATE Parking_Log SET [Time Out] = @TimeOut, [Parking Fee] = @ParkingFee WHERE [Ticket Number] = @TicketNumber";
                        OleDbCommand updateParkingLogCommand = new OleDbCommand(updateParkingLogQuery, connection);
                        updateParkingLogCommand.Parameters.AddWithValue("@TimeOut", timeOut.ToShortTimeString());
                        updateParkingLogCommand.Parameters.AddWithValue("@ParkingFee", parkingFee);
                        updateParkingLogCommand.Parameters.AddWithValue("@TicketNumber", ticketNumber);
                        updateParkingLogCommand.ExecuteNonQuery();

                        string plateNumber = "";
                        string vehicleType = "";
                        string userInfoQuery = "SELECT [Plate Number], [Vehicle Type] FROM Users WHERE [User ID] = @UserID";
                        OleDbCommand userInfoCommand = new OleDbCommand(userInfoQuery, connection);
                        userInfoCommand.Parameters.AddWithValue("@UserID", userID);
                        OleDbDataReader userInfoReader = userInfoCommand.ExecuteReader();

                        if (userInfoReader.Read())
                        {
                            plateNumber = userInfoReader["Plate Number"].ToString();
                            vehicleType = userInfoReader["Vehicle Type"].ToString();
                        }

                        Random random = new Random();
                        string serialNumber = new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10).Select(s => s[random.Next(s.Length)]).ToArray());

                        using (OleDbTransaction transaction = connection.BeginTransaction())
                        {
                            OleDbCommand deleteCommand = connection.CreateCommand();
                            deleteCommand.Transaction = transaction;

                            try
                            {
                                deleteCommand.CommandText = "DELETE FROM Bookings WHERE [Ticket Number] = @TicketNumber";
                                deleteCommand.Parameters.AddWithValue("@TicketNumber", ticketNumber);
                                deleteCommand.ExecuteNonQuery();

                                transaction.Commit();

                                string updateParkingQuery = "UPDATE Parking SET [Status] = 'AVAILABLE' WHERE [Parking Code] = @ParkingCode";
                                OleDbCommand updateParkingCommand = new OleDbCommand(updateParkingQuery, connection);
                                updateParkingCommand.Parameters.AddWithValue("@ParkingCode", parkingCode);
                                updateParkingCommand.ExecuteNonQuery();

                                string receiptDirectory = @"C:\Users\admin\OneDrive\Desktop\MS ACCESS\Receipts\4-26-24";
                                string receiptFileName = Path.Combine(receiptDirectory, $"Receipt_{ticketNumber}.pdf");

                                if (!Directory.Exists(receiptDirectory))
                                {
                                    Directory.CreateDirectory(receiptDirectory);
                                }

                                using (FileStream fs = new FileStream(receiptFileName, FileMode.Create, FileAccess.Write, FileShare.None))
                                {
                                    Document doc = new Document();
                                    PdfWriter.GetInstance(doc, fs);
                                    doc.Open();

                                    doc.Add(new Paragraph("\n\n"));
                                    doc.Add(new Paragraph("                                                                    Elizabeth Mall"));
                                    doc.Add(new Paragraph("                                          Natalio B. Bacalso Ave, Cebu City, 6000 Cebu"));
                                    doc.Add(new Paragraph("                                          Parking Reservation and Management System"));
                                    doc.Add(new Paragraph("                                                         Tel. No. 417-7735 to 38  Fax"));
                                    doc.Add(new Paragraph("                                                    VAT REG. TIN #. 005-255-946 000"));
                                    doc.Add(new Paragraph($"                                                              Serial # {serialNumber}"));
                                    doc.Add(new Paragraph("                                                      Permit # 0111-082-89826-000"));
                                    doc.Add(new Paragraph("                                                                     MN 110193842"));
                                    doc.Add(new Paragraph("\n\n"));
                                    doc.Add(new Paragraph($"Date: {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}"));
                                    doc.Add(new Paragraph($"Ticket #: {ticketNumber}"));
                                    doc.Add(new Paragraph($"Time In: {timeIn.ToShortTimeString()}"));
                                    doc.Add(new Paragraph($"Time Out: {timeOut.ToShortTimeString()}"));
                                    doc.Add(new Paragraph($"Elapsed: {parkingDuration}"));
                                    doc.Add(new Paragraph($"Plate #: {plateNumber}"));
                                    doc.Add(new Paragraph($"User Type: {userType}"));
                                    doc.Add(new Paragraph($"Vehicle Type: {vehicleType}"));
                                    doc.Add(new Paragraph("----------------------------------------------------------------------------------------------------------------------------------"));
                                    doc.Add(new Paragraph($"Charge:                    {parkingFee / 1.12:F2}"));
                                    doc.Add(new Paragraph($"Vat Tax:                    {parkingFee * 0.12:F2}"));
                                    doc.Add(new Paragraph($"Discount:                   {discount * 100}%"));
                                    doc.Add(new Paragraph("Payment Method:     CASH"));
                                    doc.Add(new Paragraph($"Total:                         {parkingFee}"));
                                    doc.Add(new Paragraph("\n\n"));
                                    doc.Add(new Paragraph("                                                    THIS IS AN UNOFFICIAL RECEIPT"));
                                    doc.Add(new Paragraph("                                                      THANK YOU... GOD BLESS!!!"));
                                    doc.Close();
                                }
                                MessageBox.Show("Payment successful.");
                                System.Diagnostics.Process.Start(receiptFileName);
                                tbxTicket.Clear();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Error: " + ex.Message, "Error");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ticket number not found.", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
        private void lbLog_Click(object sender, EventArgs e)
        {
            tbxTicket.Show();
            tbxParkingTicket.Hide();
            panel4.BackColor = Color.FromArgb(95, 74, 211);
            panel3.BackColor = Color.Silver;
            panel1.BackColor = Color.Silver;
            lbLog.ForeColor = Color.DimGray;
            lbBooking.ForeColor = Color.Gray;
            lbSales.ForeColor = Color.Gray;

            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\OneDrive\\Desktop\\MS ACCESS\\ParkEaseDatabase.accdb");

                DateTime selectedDate = datetimepicker1.Value.Date;

                string selectQuery = $"SELECT [Ticket Number], Format([Time In], 'Short Time') AS [Time In], Format([Time Out], 'Short Time') AS [Time Out], [Parking Fee], [Parking Date] FROM Parking_Log WHERE [Parking Date] = #{selectedDate.ToShortDateString()}#";

                da = new OleDbDataAdapter(selectQuery, myConn);

                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Parking_Log");
                dgvParkingLog.DataSource = ds.Tables["Parking_Log"];
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void lbBooking_Click(object sender, EventArgs e)
        {
            tbxTicket.Hide();
            tbxParkingTicket.Show();
            panel3.BackColor = Color.FromArgb(95, 74, 211);
            panel4.BackColor = Color.Silver;
            panel1.BackColor = Color.Silver;
            lbBooking.ForeColor = Color.DimGray;
            lbLog.ForeColor = Color.Gray;
            lbSales.ForeColor = Color.Gray;

            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\OneDrive\\Desktop\\MS ACCESS\\ParkEaseDatabase.accdb");

                da = new OleDbDataAdapter("SELECT [Parking Code], [User ID], [Ticket Number], [User Type], [Vehicle Type], [Status] FROM Bookings", myConn);

                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Bookings");
                dgvParkingLog.DataSource = ds.Tables["Bookings"];
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void lbSales_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(95, 74, 211);
            panel4.BackColor = Color.Silver;
            panel3.BackColor = Color.Silver;
            lbSales.ForeColor = Color.DimGray;
            lbBooking.ForeColor = Color.Gray;
            lbLog.ForeColor = Color.Gray;

            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\OneDrive\\Desktop\\MS ACCESS\\ParkEaseDatabase.accdb");

                da = new OleDbDataAdapter("SELECT [Parking Date], [Total Sales] FROM Sales_Report", myConn);

                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Sales_Report");
                dgvParkingLog.DataSource = ds.Tables["Sales_Report"];
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void datetimepicker_ValueChanged(object sender, EventArgs e)
        {
            tbxTicket.Show();
            tbxParkingTicket.Hide();
            panel4.BackColor = Color.FromArgb(95, 74, 211);
            panel3.BackColor = Color.Silver;
            panel1.BackColor = Color.Silver;
            lbLog.ForeColor = Color.DimGray;
            lbBooking.ForeColor = Color.Gray;
            lbSales.ForeColor = Color.Gray;
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\admin\\OneDrive\\Desktop\\MS ACCESS\\ParkEaseDatabase.accdb");

                DateTime selectedDate = datetimepicker1.Value.Date;

                string selectQuery = $"SELECT [Ticket Number], Format([Time In], 'Short Time') AS [Time In], Format([Time Out], 'Short Time') AS [Time Out], [Parking Fee], [Parking Date] FROM Parking_Log WHERE [Parking Date] = #{selectedDate.ToShortDateString()}#";

                da = new OleDbDataAdapter(selectQuery, myConn);

                ds = new DataSet();
                myConn.Open();
                da.Fill(ds, "Parking_Log");
                dgvParkingLog.DataSource = ds.Tables["Parking_Log"];
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void tbxParkingTicket_TextChanged(object sender, EventArgs e)
        {
            string searchValue = tbxTicket.Text;
            DateTime selectedDate = datetimepicker1.Value.Date;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [Parking Code], [User ID], [Ticket Number], [User Type], [Vehicle Type], [Status] FROM Bookings WHERE [Ticket Number] LIKE @TN";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@TN", "%" + searchValue + "%");
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    dgvParkingLog.DataSource = dataSet.Tables[0];
                }
            }
        }
    }
}
