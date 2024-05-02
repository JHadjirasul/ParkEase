namespace ParkEase
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pan1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelReserved = new System.Windows.Forms.Label();
            this.labelOccupied = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pan2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pan3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rdbOccupied = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdbReserved = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdbAvailable = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.dgvParking = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pan1.SuspendLayout();
            this.bar1.SuspendLayout();
            this.pan2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pan3.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParking)).BeginInit();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.BackColor = System.Drawing.Color.White;
            this.pan1.BorderRadius = 15;
            this.pan1.Controls.Add(this.bar1);
            this.pan1.Controls.Add(this.label8);
            this.pan1.Controls.Add(this.label7);
            this.pan1.Controls.Add(this.labelReserved);
            this.pan1.Controls.Add(this.labelOccupied);
            this.pan1.Controls.Add(this.labelAvailable);
            this.pan1.Controls.Add(this.guna2Panel2);
            this.pan1.Controls.Add(this.label4);
            this.pan1.Controls.Add(this.label3);
            this.pan1.Controls.Add(this.label2);
            this.pan1.Controls.Add(this.label1);
            this.pan1.Location = new System.Drawing.Point(22, 7);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(720, 723);
            this.pan1.TabIndex = 0;
            // 
            // bar1
            // 
            this.bar1.Controls.Add(this.label5);
            this.bar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.bar1.FillThickness = 50;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(36)))), ((int)(((byte)(245)))));
            this.bar1.Location = new System.Drawing.Point(19, 137);
            this.bar1.Minimum = 0;
            this.bar1.Name = "bar1";
            this.bar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(49)))), ((int)(((byte)(237)))));
            this.bar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(33)))), ((int)(((byte)(247)))));
            this.bar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.bar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.bar1.ProgressThickness = 50;
            this.bar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.bar1.ShowText = true;
            this.bar1.Size = new System.Drawing.Size(400, 400);
            this.bar1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(144)))), ((int)(((byte)(154)))));
            this.label5.Location = new System.Drawing.Point(129, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Occupancy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(634, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 39);
            this.label8.TabIndex = 11;
            this.label8.Text = "136";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(84)))));
            this.label7.Location = new System.Drawing.Point(442, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 39);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total";
            // 
            // labelReserved
            // 
            this.labelReserved.AutoSize = true;
            this.labelReserved.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReserved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(161)))), ((int)(((byte)(217)))));
            this.labelReserved.Location = new System.Drawing.Point(644, 336);
            this.labelReserved.Name = "labelReserved";
            this.labelReserved.Size = new System.Drawing.Size(33, 39);
            this.labelReserved.TabIndex = 9;
            this.labelReserved.Text = "0";
            // 
            // labelOccupied
            // 
            this.labelOccupied.AutoSize = true;
            this.labelOccupied.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccupied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOccupied.Location = new System.Drawing.Point(644, 288);
            this.labelOccupied.Name = "labelOccupied";
            this.labelOccupied.Size = new System.Drawing.Size(33, 39);
            this.labelOccupied.TabIndex = 8;
            this.labelOccupied.Text = "0";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(144)))), ((int)(((byte)(57)))));
            this.labelAvailable.Location = new System.Drawing.Point(644, 240);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(33, 39);
            this.labelAvailable.TabIndex = 7;
            this.labelAvailable.Text = "0";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(144)))), ((int)(((byte)(154)))));
            this.guna2Panel2.Location = new System.Drawing.Point(449, 378);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(260, 1);
            this.guna2Panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(144)))), ((int)(((byte)(154)))));
            this.label4.Location = new System.Drawing.Point(442, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reserved";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(144)))), ((int)(((byte)(154)))));
            this.label3.Location = new System.Drawing.Point(444, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Occupied";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(144)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(444, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Status";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.pan1;
            // 
            // pan2
            // 
            this.pan2.BackColor = System.Drawing.Color.White;
            this.pan2.BorderRadius = 15;
            this.pan2.Controls.Add(this.panel1);
            this.pan2.Location = new System.Drawing.Point(758, 308);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(592, 422);
            this.pan2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(16, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 401);
            this.panel1.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(22, 301);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(527, 69);
            this.label16.TabIndex = 21;
            this.label16.Text = "7.  Payment for parking fees can be made either onsite online through the parking" +
    " management system\'s secure payment portal. ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(22, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(323, 27);
            this.label15.TabIndex = 20;
            this.label15.Text = "8. Surrender the parking ticket at the exit.";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(22, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(524, 61);
            this.label14.TabIndex = 19;
            this.label14.Text = "6. The management is not liable for any damage, theft, or loss of vehicles or bel" +
    "ongings while parked on the premises.";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(19, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(530, 59);
            this.label13.TabIndex = 18;
            this.label13.Text = "4. The customer agrees to follow rules and regulations and observe traffic signs " +
    "in the car park.";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(22, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(524, 59);
            this.label12.TabIndex = 17;
            this.label12.Text = "5. Any designated reserved parking spaces are strictly for the designated users o" +
    "nly. ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(429, 27);
            this.label11.TabIndex = 16;
            this.label11.Text = "3. The parking fee is for the use of parking spaces only.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(530, 27);
            this.label10.TabIndex = 15;
            this.label10.Text = "2. Owners shall submit their vehicles for inspection upon  entrances.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sans Serif Collection", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(390, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "1. All vehicles must pay the stipulated parking fee.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sans Serif Collection", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(105, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(364, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Parking Terms and Conditions";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.pan2;
            // 
            // pan3
            // 
            this.pan3.BackColor = System.Drawing.Color.White;
            this.pan3.BorderRadius = 15;
            this.pan3.Controls.Add(this.guna2GroupBox1);
            this.pan3.Controls.Add(this.btnAll);
            this.pan3.Controls.Add(this.dgvParking);
            this.pan3.Location = new System.Drawing.Point(758, 8);
            this.pan3.Name = "pan3";
            this.pan3.Size = new System.Drawing.Size(592, 289);
            this.pan3.TabIndex = 2;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Controls.Add(this.label19);
            this.guna2GroupBox1.Controls.Add(this.label18);
            this.guna2GroupBox1.Controls.Add(this.label17);
            this.guna2GroupBox1.Controls.Add(this.rdbOccupied);
            this.guna2GroupBox1.Controls.Add(this.rdbReserved);
            this.guna2GroupBox1.Controls.Add(this.rdbAvailable);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(398, 78);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(182, 162);
            this.guna2GroupBox1.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(186)))));
            this.label19.Location = new System.Drawing.Point(67, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 22);
            this.label19.TabIndex = 5;
            this.label19.Text = "OCCUPIED";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(186)))));
            this.label18.Location = new System.Drawing.Point(67, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 22);
            this.label18.TabIndex = 4;
            this.label18.Text = "RESERVED";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(186)))));
            this.label17.Location = new System.Drawing.Point(67, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 22);
            this.label17.TabIndex = 3;
            this.label17.Text = "AVAILABLE";
            // 
            // rdbOccupied
            // 
            this.rdbOccupied.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(186)))));
            this.rdbOccupied.CheckedState.BorderThickness = 0;
            this.rdbOccupied.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(186)))));
            this.rdbOccupied.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbOccupied.Location = new System.Drawing.Point(16, 113);
            this.rdbOccupied.Name = "rdbOccupied";
            this.rdbOccupied.Size = new System.Drawing.Size(25, 28);
            this.rdbOccupied.TabIndex = 2;
            this.rdbOccupied.Text = "guna2CustomRadioButton3";
            this.rdbOccupied.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbOccupied.UncheckedState.BorderThickness = 2;
            this.rdbOccupied.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbOccupied.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbOccupied.CheckedChanged += new System.EventHandler(this.rdbOccupied_CheckedChanged);
            // 
            // rdbReserved
            // 
            this.rdbReserved.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(186)))));
            this.rdbReserved.CheckedState.BorderThickness = 0;
            this.rdbReserved.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(186)))));
            this.rdbReserved.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbReserved.Location = new System.Drawing.Point(16, 69);
            this.rdbReserved.Name = "rdbReserved";
            this.rdbReserved.Size = new System.Drawing.Size(25, 28);
            this.rdbReserved.TabIndex = 1;
            this.rdbReserved.Text = "guna2CustomRadioButton2";
            this.rdbReserved.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbReserved.UncheckedState.BorderThickness = 2;
            this.rdbReserved.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbReserved.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbReserved.CheckedChanged += new System.EventHandler(this.rdbReserved_CheckedChanged);
            // 
            // rdbAvailable
            // 
            this.rdbAvailable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(186)))));
            this.rdbAvailable.CheckedState.BorderThickness = 0;
            this.rdbAvailable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(186)))));
            this.rdbAvailable.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbAvailable.Location = new System.Drawing.Point(16, 28);
            this.rdbAvailable.Name = "rdbAvailable";
            this.rdbAvailable.Size = new System.Drawing.Size(25, 28);
            this.rdbAvailable.TabIndex = 0;
            this.rdbAvailable.Text = "guna2CustomRadioButton1";
            this.rdbAvailable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbAvailable.UncheckedState.BorderThickness = 2;
            this.rdbAvailable.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbAvailable.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbAvailable.CheckedChanged += new System.EventHandler(this.rdbAvailable_CheckedChanged);
            // 
            // btnAll
            // 
            this.btnAll.BorderRadius = 15;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(153)))), ((int)(((byte)(186)))));
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(433, 22);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(124, 50);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "ALL SLOTS";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // dgvParking
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvParking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvParking.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvParking.ColumnHeadersHeight = 4;
            this.dgvParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParking.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvParking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvParking.Location = new System.Drawing.Point(16, 13);
            this.dgvParking.Name = "dgvParking";
            this.dgvParking.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParking.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvParking.Size = new System.Drawing.Size(372, 266);
            this.dgvParking.TabIndex = 0;
            this.dgvParking.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Cyan;
            this.dgvParking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvParking.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvParking.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvParking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvParking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvParking.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvParking.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvParking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.dgvParking.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvParking.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParking.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvParking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvParking.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvParking.ThemeStyle.ReadOnly = false;
            this.dgvParking.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.dgvParking.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParking.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvParking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvParking.ThemeStyle.RowsStyle.Height = 22;
            this.dgvParking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.dgvParking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.pan3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(237)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1368, 782);
            this.Controls.Add(this.pan3);
            this.Controls.Add(this.pan2);
            this.Controls.Add(this.pan1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.bar1.ResumeLayout(false);
            this.bar1.PerformLayout();
            this.pan2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pan3.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pan1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pan2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel pan3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelReserved;
        private System.Windows.Forms.Label labelOccupied;
        private Guna.UI2.WinForms.Guna2DataGridView dgvParking;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2CircleProgressBar bar1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbOccupied;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbReserved;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbAvailable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
    }
}