using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace WindowsFormsApp5
{
    public partial class Addnew : Form
    {
        SqlConnection conn;
        public Addnew()
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = " Data Source = AHSANPC; Initial Catalog = A5; Integrated Security = True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from studio";
            cmd.Connection = conn;

            SqlDataReader Reader;
            Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                plot_text.Items.Add(Reader[1].ToString() + Reader[2].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }


        private void type_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_box.SelectedItem == "Movies")
            {
                studio_box.Text = "";
                Episode_text.Text = "";
                season_box.Text = "";
                Numberofseasons_text.Text = "";

                studio_box.Enabled = false;
                Episode_text.Enabled = false;
                season_box.Enabled = false;
                Numberofseasons_text.Enabled = false;

                Episode_text.Text = "";
                season_box.Text = "";
                Numberofseasons_text.Text = "";

            }
            if (type_box.SelectedItem == "Series")
            {
                studio_box.Text = "";
                Episode_text.Text = "";
                season_box.Text = "";
                Numberofseasons_text.Text = "";

                studio_box.Enabled = false;
                Episode_text.Enabled = false;
                season_box.Enabled = false;
                Numberofseasons_text.Enabled = false;


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void season_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Numberofseasons_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
