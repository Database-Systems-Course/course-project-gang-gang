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
    public partial class Watchlsit : Form
    {
        int userz;
        string watchname;
        public Watchlsit(int userid,string watchlistname)
        {
            userz = userid;
            watchname = watchlistname;
            InitializeComponent();
            // run querry to show watchlist of user having userid = userz and the watchlist name as userz
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewDetails f = new ViewDetails();
            f.Show();
        }

        private void Watchlsit_Load(object sender, EventArgs e)
        {

        }
    }
}
