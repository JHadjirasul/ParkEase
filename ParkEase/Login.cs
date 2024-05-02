using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkEase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            dragpanel.Attach(panel1, this);
            this.DoubleBuffered = true;
            this.Load += Login_Load;
        }
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\OneDrive\Desktop\MS ACCESS\ParkEaseDatabase.accdb;";
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;
        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            string userInput = tbxUserLogin.Text;
            string password = tbxPassLogin.Text;

            if (string.IsNullOrWhiteSpace(userInput) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username/ID and password.");
                return;
            }

            bool userExists = false;
            string userID = "";

            try
            {
                if (userInput.ToLower() == "admin" && password.ToLower() == "admin")
                {
                    MessageBox.Show("Login successful as admin!");
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                    return;
                }

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string userQuery = "SELECT [User ID] FROM Users WHERE Username = @Username AND [Password] = @Password";
                    using (OleDbCommand command = new OleDbCommand(userQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", userInput);
                        command.Parameters.AddWithValue("@Password", password);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            userExists = true;
                            userID = result.ToString();
                        }
                    }
                    if (!userExists)
                    {
                        string employeeQuery = "SELECT COUNT(*) FROM Employees WHERE [Employee ID] = @EmployeeID AND [Employee ID] = @Password";
                        using (OleDbCommand command = new OleDbCommand(employeeQuery, connection))
                        {
                            command.Parameters.AddWithValue("@EmployeeID", userInput);
                            command.Parameters.AddWithValue("@Password", password);
                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                userExists = true;
                                userID = tbxUserLogin.Text;
                            }
                        }
                    }
                }
                if (userExists)
                {
                    MessageBox.Show("Login successful! User ID: " + userID);
                    Dashboard parking = new Dashboard();
                    parking.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username/ID or password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                string vehicle = cbxVType.Text;
                string platenumber = tbxPN.Text;
                string fullName = tbxSignName.Text;
                string username = tbxSignUser.Text;
                string password = tbxSignPass.Text;
                string confirmPassword = tbxSignConPass.Text;
                string contact = tbxCN.Text;

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please try again.");
                    return;
                }

                Random rand = new Random();
                int userID = rand.Next(10000, 99999);

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users ([User ID], [Vehicle Owner], [Vehicle Type], [Plate Number], [Contact Number], Username, [Password]) VALUES (@UserID, @VehicleOwner, @VehicletType, @PlateNumber, @Contact, @Username, @Password)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@VehicleOwner", fullName);
                        command.Parameters.AddWithValue("@VehicleType", vehicle);
                        command.Parameters.AddWithValue("@PlateNumber", platenumber);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User registered successfully! User ID: " + userID.ToString());
                tbxSignName.Clear();
                tbxPN.Clear();
                tbxCN.Clear();
                tbxSignUser.Clear();
                tbxSignPass.Clear();
                tbxSignConPass.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void btnPassUpdate_Click(object sender, EventArgs e)
        {
            string newPassword = tbxNewPass.Text;
            string confirmPassword = tbxConfirmNewPass.Text;
            string username = tbxUsername2.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Users SET [Password] = @NewPassword WHERE Username = @Username";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        command.Parameters.AddWithValue("@Username", username);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Username not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            this.Close();
        }
        private void tbxPassLogin_TextChanged_1(object sender, EventArgs e)
        {
            tbxPassLogin.PasswordChar = '*';
        }
        private void tbxSignPass_TextChanged(object sender, EventArgs e)
        {
            tbxSignPass.PasswordChar = '*';
        }
        private void tbxSignConPass_TextChanged(object sender, EventArgs e)
        {
            tbxSignConPass.PasswordChar = '*';
        }
        private void tbxNewPass_TextChanged(object sender, EventArgs e)
        {
            tbxNewPass.PasswordChar = '*';
        }
        private void tbxConfirmNewPass_TextChanged(object sender, EventArgs e)
        {
            tbxConfirmNewPass.PasswordChar = '*';
        }
        private void btnTabSign_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = true;
            panelLogin.Visible = false;
            panelForgotPass.Visible = false;
        }
        private void btnSignupTab_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = true;
            panelLogin.Visible = false;
            panelForgotPass.Visible = false;
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            panelSignup.Visible = true;
            panelLogin.Visible = false;
            panelForgotPass.Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelSignup.Visible = false;
            panelForgotPass.Visible = false;
        }
        private void btnTabLog_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelSignup.Visible = false;
            panelForgotPass.Visible = false;
        }
        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelSignup.Visible = false;
            panelForgotPass.Visible = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            btnHidePass.BringToFront();
            if (tbxPassLogin.PasswordChar == '*')
            {
                tbxPassLogin.PasswordChar = '\0';
            }

        }
        private void btnHidePass_Click(object sender, EventArgs e)
        {
            btnShowPass.BringToFront();
            if (tbxPassLogin.PasswordChar == '\0')
            {
                tbxPassLogin.PasswordChar = '*';
            }
        }
        private void btnShowSignupPass_Click(object sender, EventArgs e)
        {
            btnHideSignupPass.BringToFront();

            if (tbxSignPass.PasswordChar == '*')
            {
                tbxSignPass.PasswordChar = '\0';
            }
        }
        private void btnHideSignupPass_Click(object sender, EventArgs e)
        {
            btnShowSignupPass.BringToFront();

            if (tbxSignPass.PasswordChar == '\0')
            {
                tbxSignPass.PasswordChar = '*';
            }
        }
        private void btnHideConPass_Click(object sender, EventArgs e)
        {
            btnShowConPass.BringToFront();

            if (tbxSignConPass.PasswordChar == '\0')
            {
                tbxSignConPass.PasswordChar = '*';
            }
        }
        private void btnShowConPass_Click(object sender, EventArgs e)
        {
            btnHideConPass.BringToFront();

            if (tbxSignConPass.PasswordChar == '*')
            {
                tbxSignConPass.PasswordChar = '\0';
            }
        }
        private void btnHideForgotPass_Click(object sender, EventArgs e)
        {
            btnShowForgotPass.BringToFront();

            if (tbxNewPass.PasswordChar == '\0')
            {
                tbxNewPass.PasswordChar = '*';
            }
        }
        private void btnShowForgotPass_Click(object sender, EventArgs e)
        {
            btnHideForgotPass.BringToFront();

            if (tbxNewPass.PasswordChar == '*')
            {
                tbxNewPass.PasswordChar = '\0';
            }
        }
        private void btnHideFCPass_Click(object sender, EventArgs e)
        {
            btnShowFCPass.BringToFront();

            if (tbxConfirmNewPass.PasswordChar == '\0')
            {
                tbxConfirmNewPass.PasswordChar = '*';
            }
        }
        private void btnShowFCPass_Click(object sender, EventArgs e)
        {
            btnHideFCPass.BringToFront();

            if (tbxConfirmNewPass.PasswordChar == '*')
            {
                tbxConfirmNewPass.PasswordChar = '\0';
            }
        }
        private void btnForgotPass_MouseEnter(object sender, EventArgs e)
        {
            Label hoveredLabel = sender as Label;
            if (hoveredLabel != null)
            {
                hoveredLabel.ForeColor = Color.LightGray;
            }
        }
        private void btnForgotPass_MouseLeave(object sender, EventArgs e)
        {
            Label hoveredLabel = sender as Label;
            if (hoveredLabel != null)
            {
                hoveredLabel.ForeColor = Color.White;
            }
        }
        private void btnTabSign_MouseEnter(object sender, EventArgs e)
        {
            Label hoveredLabel = sender as Label;
            if (hoveredLabel != null)
            {
                hoveredLabel.ForeColor = Color.LightGray;
            }
        }
        private void btnTabSign_MouseLeave(object sender, EventArgs e)
        {
            Label hoveredLabel = sender as Label;
            if (hoveredLabel != null)
            {
                hoveredLabel.ForeColor = Color.White;
            }
        }
        private void btnTabLog_MouseEnter(object sender, EventArgs e)
        {
            Label hoveredLabel = sender as Label;
            if (hoveredLabel != null)
            {
                hoveredLabel.ForeColor = Color.LightGray;
            }
        }
        private void btnTabLog_MouseLeave(object sender, EventArgs e)
        {
            Label hoveredLabel = sender as Label;
            if (hoveredLabel != null)
            {
                hoveredLabel.ForeColor = Color.White;
            }
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Label hoveredLabel = sender as Label;
            if (hoveredLabel != null)
            {
                hoveredLabel.ForeColor = Color.LightGray;
            }
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Label hoveredLabel = sender as Label;
            if (hoveredLabel != null)
            {
                hoveredLabel.ForeColor = Color.White;
            }
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Label hoveredLabel = sender as Label;
            if (hoveredLabel != null)
            {
                hoveredLabel.ForeColor = Color.LightGray;
            }
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label hoveredLabel = sender as Label;
            if (hoveredLabel != null)
            {
                hoveredLabel.ForeColor = Color.White;
            }
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
        private void Login_Load(object sender, EventArgs e)
        {

        } 
    }

}