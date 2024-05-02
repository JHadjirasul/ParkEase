using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ParkEase
{
    public partial class Admin : Form
    {
        bool sidebarExpand;
        AdminUsers users;
        ParkingStatus status;
        AdminHome adminhome;
        public Admin()
        {
            InitializeComponent();
            dragpanel.Attach(pan2, this);
            this.DoubleBuffered = true;
            mdiProp();
        }
        private void mdiProp()
        {
            this.SetBevel(false);
            var mdiClient = Controls.OfType<MdiClient>().FirstOrDefault();
            mdiClient.BackColor = Color.Lavender;

        }
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(100, 101, 104);
            btnUsers.BackColor = Color.FromArgb(23, 24, 29);
            btnStatus.BackColor = Color.FromArgb(23, 24, 29);

            if (adminhome == null)
            {
                adminhome = new AdminHome();
                adminhome.FormClosed += Adminhome_FormClosed;
                adminhome.MdiParent = this;
                adminhome.Dock = DockStyle.Fill;
                adminhome.Show();
            }
            else
            {
                adminhome.Activate();
            }
        }
        private void Adminhome_FormClosed(object sender, FormClosedEventArgs e)
        {
            adminhome = null;
        }
        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(23, 24, 29);
            btnUsers.BackColor = Color.FromArgb(100, 101, 104);
            btnStatus.BackColor = Color.FromArgb(23, 24, 29);

            if (users == null)
            {
                users = new AdminUsers();
                users.FormClosed += Users_FormClosed;
                users.MdiParent = this;
                users.Dock = DockStyle.Fill;
                users.Show();
            }
            else
            {
                users.Activate();
            }
        }
        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            users = null;
        }
        private void btnStatus_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(23, 24, 29);
            btnUsers.BackColor = Color.FromArgb(23, 24, 29);
            btnStatus.BackColor = Color.FromArgb(100, 101, 104);

            if (status == null)
            {
                status = new ParkingStatus();
                status.FormClosed += Status_FormClosed;
                status.MdiParent = this;
                status.Dock = DockStyle.Fill;
                status.Show();
            }
            else
            {
                status.Activate();
            }
        }
        private void Status_FormClosed(object sender, FormClosedEventArgs e)
        {
            status = null;
        }
        private void btnLogout_Click_2(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar2.Width -= 10;
                if (sidebar2.Width == sidebar2.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
                sidebar2.Width += 10;
                if (sidebar2.Width == sidebar2.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer1.Stop();
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
    }
}
