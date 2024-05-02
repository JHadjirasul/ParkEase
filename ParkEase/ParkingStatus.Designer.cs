namespace ParkEase
{
    partial class ParkingStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTicket = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvParkingLog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnClearLog = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoad = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbLog = new System.Windows.Forms.Label();
            this.lbBooking = new System.Windows.Forms.Label();
            this.lbSales = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.datetimepicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tbxParkingTicket = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParkingLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 45);
            this.label1.TabIndex = 42;
            this.label1.Text = "Parking Status";
            // 
            // tbxTicket
            // 
            this.tbxTicket.BorderColor = System.Drawing.Color.Silver;
            this.tbxTicket.BorderRadius = 20;
            this.tbxTicket.BorderThickness = 2;
            this.tbxTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTicket.DefaultText = "";
            this.tbxTicket.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTicket.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTicket.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTicket.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tbxTicket.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTicket.Location = new System.Drawing.Point(1054, 142);
            this.tbxTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxTicket.Name = "tbxTicket";
            this.tbxTicket.PasswordChar = '\0';
            this.tbxTicket.PlaceholderText = "Search Ticket Number";
            this.tbxTicket.SelectedText = "";
            this.tbxTicket.Size = new System.Drawing.Size(264, 47);
            this.tbxTicket.TabIndex = 48;
            this.tbxTicket.TextChanged += new System.EventHandler(this.tbxTN_TextChanged);
            // 
            // dgvParkingLog
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvParkingLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvParkingLog.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParkingLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvParkingLog.ColumnHeadersHeight = 10;
            this.dgvParkingLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParkingLog.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvParkingLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvParkingLog.Location = new System.Drawing.Point(41, 211);
            this.dgvParkingLog.Name = "dgvParkingLog";
            this.dgvParkingLog.RowHeadersVisible = false;
            this.dgvParkingLog.RowHeadersWidth = 20;
            this.dgvParkingLog.Size = new System.Drawing.Size(1277, 476);
            this.dgvParkingLog.TabIndex = 51;
            this.dgvParkingLog.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvParkingLog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvParkingLog.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvParkingLog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvParkingLog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvParkingLog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvParkingLog.ThemeStyle.BackColor = System.Drawing.Color.GhostWhite;
            this.dgvParkingLog.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvParkingLog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvParkingLog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvParkingLog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParkingLog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvParkingLog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvParkingLog.ThemeStyle.HeaderStyle.Height = 10;
            this.dgvParkingLog.ThemeStyle.ReadOnly = false;
            this.dgvParkingLog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvParkingLog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParkingLog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParkingLog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvParkingLog.ThemeStyle.RowsStyle.Height = 22;
            this.dgvParkingLog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvParkingLog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnClearLog
            // 
            this.btnClearLog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(5)))));
            this.btnClearLog.BorderRadius = 5;
            this.btnClearLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(5)))));
            this.btnClearLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClearLog.ForeColor = System.Drawing.Color.White;
            this.btnClearLog.Image = global::ParkEase.Properties.Resources.clear30;
            this.btnClearLog.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClearLog.Location = new System.Drawing.Point(40, 142);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(143, 44);
            this.btnClearLog.TabIndex = 55;
            this.btnClearLog.Text = "      Clear Log";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(124)))));
            this.btnCheckOut.BorderRadius = 5;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(124)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Image = global::ParkEase.Properties.Resources.checkout30;
            this.btnCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckOut.Location = new System.Drawing.Point(905, 145);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(143, 44);
            this.btnCheckOut.TabIndex = 54;
            this.btnCheckOut.Text = "      CHECK OUT";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.btnLoad.BorderRadius = 10;
            this.btnLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(200)))));
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Image = global::ParkEase.Properties.Resources.load30;
            this.btnLoad.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLoad.Location = new System.Drawing.Point(1190, 40);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(128, 48);
            this.btnLoad.TabIndex = 53;
            this.btnLoad.Text = "  Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(122, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 2);
            this.panel4.TabIndex = 57;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(12, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 2);
            this.panel3.TabIndex = 56;
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLog.ForeColor = System.Drawing.Color.Gray;
            this.lbLog.Location = new System.Drawing.Point(139, 90);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(108, 23);
            this.lbLog.TabIndex = 60;
            this.lbLog.Text = "Parking Log";
            this.lbLog.Click += new System.EventHandler(this.lbLog_Click);
            // 
            // lbBooking
            // 
            this.lbBooking.AutoSize = true;
            this.lbBooking.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBooking.ForeColor = System.Drawing.Color.Gray;
            this.lbBooking.Location = new System.Drawing.Point(37, 90);
            this.lbBooking.Name = "lbBooking";
            this.lbBooking.Size = new System.Drawing.Size(76, 23);
            this.lbBooking.TabIndex = 59;
            this.lbBooking.Text = "Booking";
            this.lbBooking.Click += new System.EventHandler(this.lbBooking_Click);
            // 
            // lbSales
            // 
            this.lbSales.AutoSize = true;
            this.lbSales.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSales.ForeColor = System.Drawing.Color.Gray;
            this.lbSales.Location = new System.Drawing.Point(269, 90);
            this.lbSales.Name = "lbSales";
            this.lbSales.Size = new System.Drawing.Size(115, 23);
            this.lbSales.TabIndex = 61;
            this.lbSales.Text = "Sales Report";
            this.lbSales.Click += new System.EventHandler(this.lbSales_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(258, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 2);
            this.panel1.TabIndex = 62;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(394, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(955, 2);
            this.panel5.TabIndex = 63;
            // 
            // datetimepicker1
            // 
            this.datetimepicker1.Checked = true;
            this.datetimepicker1.FillColor = System.Drawing.Color.MediumAquamarine;
            this.datetimepicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetimepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetimepicker1.Location = new System.Drawing.Point(224, 150);
            this.datetimepicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetimepicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetimepicker1.Name = "datetimepicker1";
            this.datetimepicker1.Size = new System.Drawing.Size(200, 36);
            this.datetimepicker1.TabIndex = 64;
            this.datetimepicker1.Value = new System.DateTime(2024, 4, 25, 16, 21, 33, 548);
            this.datetimepicker1.ValueChanged += new System.EventHandler(this.datetimepicker_ValueChanged);
            // 
            // tbxParkingTicket
            // 
            this.tbxParkingTicket.BorderColor = System.Drawing.Color.Silver;
            this.tbxParkingTicket.BorderRadius = 20;
            this.tbxParkingTicket.BorderThickness = 2;
            this.tbxParkingTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxParkingTicket.DefaultText = "";
            this.tbxParkingTicket.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxParkingTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxParkingTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxParkingTicket.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxParkingTicket.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxParkingTicket.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tbxParkingTicket.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxParkingTicket.Location = new System.Drawing.Point(1054, 142);
            this.tbxParkingTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxParkingTicket.Name = "tbxParkingTicket";
            this.tbxParkingTicket.PasswordChar = '\0';
            this.tbxParkingTicket.PlaceholderText = "Search Ticket Number";
            this.tbxParkingTicket.SelectedText = "";
            this.tbxParkingTicket.Size = new System.Drawing.Size(264, 47);
            this.tbxParkingTicket.TabIndex = 65;
            this.tbxParkingTicket.TextChanged += new System.EventHandler(this.tbxParkingTicket_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = global::ParkEase.Properties.Resources.search301;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1273, 150);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 66;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ParkingStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1368, 782);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.datetimepicker1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSales);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.lbBooking);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvParkingLog);
            this.Controls.Add(this.tbxTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxParkingTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParkingStatus";
            this.Text = "ParkingStatus";
            this.Load += new System.EventHandler(this.ParkingStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParkingLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbxTicket;
        private Guna.UI2.WinForms.Guna2DataGridView dgvParkingLog;
        private Guna.UI2.WinForms.Guna2Button btnLoad;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnClearLog;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbLog;
        private System.Windows.Forms.Label lbBooking;
        private System.Windows.Forms.Label lbSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetimepicker1;
        private Guna.UI2.WinForms.Guna2TextBox tbxParkingTicket;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}