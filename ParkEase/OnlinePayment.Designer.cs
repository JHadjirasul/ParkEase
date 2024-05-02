namespace ParkEase
{
    partial class OnlinePayment
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
            this.tbxTicket = new Guna.UI2.WinForms.Guna2TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdbGcash = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdbPaymaya = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdbPaypal = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.pbxPaypal = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbxPaymaya = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbxAN = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.pbxGcash = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPaypal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPaymaya)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGcash)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxTicket
            // 
            this.tbxTicket.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTicket.DefaultText = "";
            this.tbxTicket.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxTicket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxTicket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTicket.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTicket.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTicket.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTicket.Location = new System.Drawing.Point(109, 82);
            this.tbxTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTicket.Name = "tbxTicket";
            this.tbxTicket.PasswordChar = '\0';
            this.tbxTicket.PlaceholderText = "Ticket Number";
            this.tbxTicket.SelectedText = "";
            this.tbxTicket.Size = new System.Drawing.Size(267, 46);
            this.tbxTicket.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(162)))), ((int)(((byte)(229)))));
            this.panel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(162)))), ((int)(((byte)(229)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 48);
            this.panel1.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Image = global::ParkEase.Properties.Resources.icons8_close_window_261;
            this.btnClose.Location = new System.Drawing.Point(441, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.pbxGcash);
            this.guna2GroupBox1.Controls.Add(this.rdbGcash);
            this.guna2GroupBox1.Controls.Add(this.rdbPaymaya);
            this.guna2GroupBox1.Controls.Add(this.rdbPaypal);
            this.guna2GroupBox1.Controls.Add(this.pbxPaypal);
            this.guna2GroupBox1.Controls.Add(this.pbxPaymaya);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Lavender;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 49);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(479, 146);
            this.guna2GroupBox1.TabIndex = 13;
            this.guna2GroupBox1.Text = "Payment Method";
            // 
            // rdbGcash
            // 
            this.rdbGcash.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.rdbGcash.CheckedState.BorderThickness = 0;
            this.rdbGcash.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.rdbGcash.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbGcash.Location = new System.Drawing.Point(15, 82);
            this.rdbGcash.Name = "rdbGcash";
            this.rdbGcash.Size = new System.Drawing.Size(20, 20);
            this.rdbGcash.TabIndex = 11;
            this.rdbGcash.Text = "guna2CustomRadioButton1";
            this.rdbGcash.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbGcash.UncheckedState.BorderThickness = 2;
            this.rdbGcash.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbGcash.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbPaymaya
            // 
            this.rdbPaymaya.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.rdbPaymaya.CheckedState.BorderThickness = 0;
            this.rdbPaymaya.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.rdbPaymaya.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbPaymaya.Location = new System.Drawing.Point(299, 82);
            this.rdbPaymaya.Name = "rdbPaymaya";
            this.rdbPaymaya.Size = new System.Drawing.Size(20, 20);
            this.rdbPaymaya.TabIndex = 10;
            this.rdbPaymaya.Text = "guna2CustomRadioButton3";
            this.rdbPaymaya.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbPaymaya.UncheckedState.BorderThickness = 2;
            this.rdbPaymaya.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbPaymaya.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbPaypal
            // 
            this.rdbPaypal.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.rdbPaypal.CheckedState.BorderThickness = 0;
            this.rdbPaypal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.rdbPaypal.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbPaypal.Location = new System.Drawing.Point(160, 82);
            this.rdbPaypal.Name = "rdbPaypal";
            this.rdbPaypal.Size = new System.Drawing.Size(20, 20);
            this.rdbPaypal.TabIndex = 9;
            this.rdbPaypal.Text = "guna2CustomRadioButton2";
            this.rdbPaypal.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbPaypal.UncheckedState.BorderThickness = 2;
            this.rdbPaypal.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbPaypal.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // pbxPaypal
            // 
            this.pbxPaypal.FillColor = System.Drawing.Color.Transparent;
            this.pbxPaypal.Image = global::ParkEase.Properties.Resources.paypal80_removebg_preview;
            this.pbxPaypal.ImageRotate = 0F;
            this.pbxPaypal.Location = new System.Drawing.Point(186, 53);
            this.pbxPaypal.Name = "pbxPaypal";
            this.pbxPaypal.Size = new System.Drawing.Size(80, 80);
            this.pbxPaypal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPaypal.TabIndex = 6;
            this.pbxPaypal.TabStop = false;
            this.pbxPaypal.Click += new System.EventHandler(this.pbxPaypal_Click);
            // 
            // pbxPaymaya
            // 
            this.pbxPaymaya.Image = global::ParkEase.Properties.Resources.paymaya100;
            this.pbxPaymaya.ImageRotate = 0F;
            this.pbxPaymaya.Location = new System.Drawing.Point(326, 53);
            this.pbxPaymaya.Name = "pbxPaymaya";
            this.pbxPaymaya.Size = new System.Drawing.Size(150, 80);
            this.pbxPaymaya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPaymaya.TabIndex = 7;
            this.pbxPaymaya.TabStop = false;
            this.pbxPaymaya.Click += new System.EventHandler(this.pbxPaymaya_Click);
            // 
            // tbxAN
            // 
            this.tbxAN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxAN.DefaultText = "";
            this.tbxAN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxAN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxAN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxAN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxAN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxAN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxAN.Location = new System.Drawing.Point(109, 28);
            this.tbxAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxAN.Name = "tbxAN";
            this.tbxAN.PasswordChar = '\0';
            this.tbxAN.PlaceholderText = "Account Number";
            this.tbxAN.SelectedText = "";
            this.tbxAN.Size = new System.Drawing.Size(267, 46);
            this.tbxAN.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbxAN);
            this.panel2.Controls.Add(this.tbxTicket);
            this.panel2.Location = new System.Drawing.Point(0, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 167);
            this.panel2.TabIndex = 15;
            // 
            // btnPay
            // 
            this.btnPay.BorderRadius = 5;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(5)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = global::ParkEase.Properties.Resources.basket30;
            this.btnPay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPay.Location = new System.Drawing.Point(330, 367);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(141, 42);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "     CHECK OUT";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pbxGcash
            // 
            this.pbxGcash.Image = global::ParkEase.Properties.Resources.gcash3;
            this.pbxGcash.ImageRotate = 0F;
            this.pbxGcash.Location = new System.Drawing.Point(41, 53);
            this.pbxGcash.Name = "pbxGcash";
            this.pbxGcash.Size = new System.Drawing.Size(80, 80);
            this.pbxGcash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxGcash.TabIndex = 12;
            this.pbxGcash.TabStop = false;
            this.pbxGcash.Click += new System.EventHandler(this.pbxGcash_Click);
            // 
            // OnlinePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(479, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OnlinePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnlinePayment";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPaypal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPaymaya)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGcash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tbxTicket;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2PictureBox pbxPaypal;
        private Guna.UI2.WinForms.Guna2PictureBox pbxPaymaya;
        private Guna.UI2.WinForms.Guna2GradientPanel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbPaymaya;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbPaypal;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbGcash;
        private Guna.UI2.WinForms.Guna2TextBox tbxAN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2PictureBox pbxGcash;
    }
}