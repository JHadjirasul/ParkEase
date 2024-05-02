using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkEase
{
    public partial class OnlinePayment : Form
    {
        private const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\OneDrive\Desktop\MS ACCESS\ParkEaseDatabase.accdb;Persist Security Info=False;";
        public OnlinePayment()
        {
            InitializeComponent();
            dragpanel.Attach(panel1, this);
        }
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds; 

        private void btnPay_Click(object sender, EventArgs e)
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
                                    doc.Add(new Paragraph("Payment Method:     ONLINE"));
                                    doc.Add(new Paragraph($"Total:                         {parkingFee}"));
                                    doc.Add(new Paragraph("\n\n"));
                                    doc.Add(new Paragraph("                                                    THIS IS AN UNOFFICIAL RECEIPT"));
                                    doc.Add(new Paragraph("                                                      THANK YOU... GOD BLESS!!!"));
                                    doc.Close();
                                }
                                MessageBox.Show("Payment successful.");
                                System.Diagnostics.Process.Start(receiptFileName);
                                tbxTicket.Clear();
                                tbxAN.Clear();
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
        private void pbxGcash_Click(object sender, EventArgs e)
        {
            rdbGcash.Checked = true;
        }
        private void pbxPaypal_Click(object sender, EventArgs e)
        {
            rdbPaypal.Checked = true;
        }
        private void pbxPaymaya_Click(object sender, EventArgs e)
        {
            rdbPaymaya.Checked = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
        private MethodPanel dragpanel = new MethodPanel();
        public class MethodPanel
        {
            private bool isDragging;
            private Point lastLocation;

            public void Attach(Control panel, Form form)
            {
                panel.MouseDown += Panel_MouseDown;
                panel.MouseMove += Panel_MouseMove;
                panel.MouseUp += Panel_MouseUp;
            }

            private void Panel_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isDragging = true;
                    lastLocation = e.Location;
                }
            }
            private void Panel_MouseMove(object sender, MouseEventArgs e)
            {
                if (isDragging)
                {
                    Form form = (sender as Control).FindForm();
                    form.Location = new Point(
                        form.Location.X + (e.X - lastLocation.X),
                        form.Location.Y + (e.Y - lastLocation.Y));
                }
            }

            private void Panel_MouseUp(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isDragging = false;
                }
            }
        }
    }
}
