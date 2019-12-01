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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text=="123")
            {
                Addnew f = new Addnew(Int32.Parse(textBox1.Text));
                f.Show();
                this.Hide();
            }
            else {
                HomeScreen f = new HomeScreen(Int32.Parse(textBox1.Text));
                f.Show();
                this.Hide();
            }

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
