﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkEase
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void About_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
