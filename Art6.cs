﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewBT
{
    public partial class Art6 : Form
    {
        public Art6()
        {
            InitializeComponent();
        }

        private void Art6_Load(object sender, EventArgs e)
        {

        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            this.Text = "Article for Button";
            this.Size = new System.Drawing.Size(500, 500);
        }
    }
}
