﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        int userz;
        public Form2(int userid)
        {
            userz = userid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            HomeScreen f = new HomeScreen(userz);
            // add watchlist to user having userid=userz and watchlist name as textbox
            f.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
