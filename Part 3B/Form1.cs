﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3B
{
    public partial class MainForm : Form
    {   
        public MainForm()
        {
            InitializeComponent();
        }   string name;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            name = txtInput.Text;
            lblMeassage.Text = "Nice to meet you " + name;
        }
    }
}
