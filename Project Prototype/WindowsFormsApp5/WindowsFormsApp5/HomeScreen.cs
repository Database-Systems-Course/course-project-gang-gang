using System;
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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewDetails f = new ViewDetails();
            f.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Watchlsit f = new Watchlsit();
            f.Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you really want to delete this Watchlist?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) ;
        }
    }
}
