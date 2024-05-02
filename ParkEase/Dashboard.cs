using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkEase
{
    public partial class Dashboard : Form
    {

        bool sidebarExpand;
        bool paymentCollapse;
        Home home;
        Parking parking;
        About about;
        public Dashboard()
        {
            InitializeComponent();
            dragpanel.Attach(pan2, this);
            mdiProp();
            this.DoubleBuffered = true;

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(100, 101, 104);
            button1.BackColor = Color.FromArgb(23, 24, 29);
            btnOnline.BackColor = Color.FromArgb(32, 33, 36);
            btnPayment.BackColor = Color.FromArgb(23, 24, 29);
            btnOTC.BackColor = Color.FromArgb(32, 33, 36);
            btnAbout.BackColor = Color.FromArgb(23, 24, 29);
            btnParking.BackColor = Color.FromArgb(23, 24, 29);

            if (home == null)
            {
                home = new Home();
                home.FormClosed += Home_FormClosed1;
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;

                home.Show();
            }
            else
            {
                home.Activate();
            }

        }
        private void Home_FormClosed1(object sender, FormClosedEventArgs e)
        {
            home = null;
        }
        private void button4_Click(object sender, EventArgs e) //btnParking
        {
            btnHome.BackColor = Color.FromArgb(23, 24, 29);
            button1.BackColor = Color.FromArgb(23, 24, 29);
            btnOnline.BackColor = Color.FromArgb(32, 33, 36);
            btnPayment.BackColor = Color.FromArgb(23, 24, 29);
            btnOTC.BackColor = Color.FromArgb(32, 33, 36);
            btnAbout.BackColor = Color.FromArgb(23, 24, 29);
            btnParking.BackColor = Color.FromArgb(100, 101, 104);

            if (parking == null)
            {
                parking = new Parking();
                parking.FormClosed += Parking_FormClosed1;
                parking.MdiParent = this;
                parking.Dock = DockStyle.Fill;
                parking.WindowState = FormWindowState.Maximized;

                parking.Show();
            }
            else
            {
                parking.Activate();
            }
        }
        private void Parking_FormClosed1(object sender, FormClosedEventArgs e)
        {
            parking = null;
        }
        private void button5_Click(object sender, EventArgs e) //btnPayment
        {
            timer2.Start();
            btnHome.BackColor = Color.FromArgb(23, 24, 29);
            button1.BackColor = Color.FromArgb(23, 24, 29);
            btnOnline.BackColor = Color.FromArgb(32, 33, 36);
            btnPayment.BackColor = Color.FromArgb(100, 101, 104);
            btnOTC.BackColor = Color.FromArgb(32, 33, 36);
            btnAbout.BackColor = Color.FromArgb(23, 24, 29);
            btnParking.BackColor = Color.FromArgb(23, 24, 29);
        }
        private void btnOTC_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(23, 24, 29);
            button1.BackColor = Color.FromArgb(23, 24, 29);
            btnOnline.BackColor = Color.FromArgb(32, 33, 36);
            btnPayment.BackColor = Color.FromArgb(23, 24, 29);
            btnOTC.BackColor = Color.FromArgb(100, 101, 104);
            btnAbout.BackColor = Color.FromArgb(23, 24, 29);
            btnParking.BackColor = Color.FromArgb(23, 24, 29);

            MessageBox.Show("Bring your parking ticket and proceed to the exit for onsite payments.", "Message");
        }
        private void btnOnline_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(23, 24, 29);
            button1.BackColor = Color.FromArgb(23, 24, 29);
            btnOnline.BackColor = Color.FromArgb(100, 101, 104);
            btnPayment.BackColor = Color.FromArgb(23, 24, 29);
            btnOTC.BackColor = Color.FromArgb(32, 33, 36);
            btnAbout.BackColor = Color.FromArgb(23, 24, 29);
            btnParking.BackColor = Color.FromArgb(23, 24, 29);

            this.Hide();
            OnlinePayment onlinePaymentForm = new OnlinePayment();
            onlinePaymentForm.ShowDialog();
        }
        private void button9_Click(object sender, EventArgs e) //btnAbout
        {
            btnHome.BackColor = Color.FromArgb(23, 24, 29);
            button1.BackColor = Color.FromArgb(23, 24, 29);
            btnOnline.BackColor = Color.FromArgb(32, 33, 36);
            btnPayment.BackColor = Color.FromArgb(23, 24, 29);
            btnOTC.BackColor = Color.FromArgb(32, 33, 36);
            btnAbout.BackColor = Color.FromArgb(100, 101, 104);
            btnParking.BackColor = Color.FromArgb(23, 24, 29);

            if (about == null)
            {
                about = new About();
                about.FormClosed += About_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }
        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;
        }
        private void button1_Click(object sender, EventArgs e) // btnLogout
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void mdiProp()
        {
            this.SetBevel(false);
            var mdiClient = Controls.OfType<MdiClient>().FirstOrDefault();
            mdiClient.BackColor = Color.Lavender;
        }   
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer1.Stop();
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (paymentCollapse)
            {
                PaymentContainer.Height += 10;
                if (PaymentContainer.Height == PaymentContainer.MaximumSize.Height)
                {
                    paymentCollapse = false;
                    timer2.Stop();
                }
            }
            else
            {
                PaymentContainer.Height -= 10;
                if (PaymentContainer.Height == PaymentContainer.MinimumSize.Height)
                {
                    paymentCollapse = true;
                    timer2.Stop();
                }
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
        private void tbxPlate_Load(object sender, EventArgs e)
        {

        }
        private void panMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pan2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
