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
using System.Data.Common;

namespace WindowsFormsApp5
{
    public partial class Addnew : Form 
    {
        SqlConnection conn;
        public Addnew(int text)
        {
            InitializeComponent();
            conn = new SqlConnection();
            conn.ConnectionString = " Data Source = AHSANPC; Initial Catalog = A7; Integrated Security = True";
            conn.Open();      
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
            if (type_box.SelectedItem.ToString() == "Movies")
            {
                try
                {
                    DBconnectioncs c = new DBconnectioncs();
                    DataTable d = c.Select("Select * from Genre");
                   
                        MessageBox.Show(d.Rows.ToString());
                       
                        //dataGridView1.DataSource = d;
                        //DbConnection c = new DBconnectioncs();
                        //DataTable dt = c.Select("SELECT COUNT(*) FROM operator WHERE username = '" + UName.Text + "' AND pass = '" + PWord.Text + "'");




                        // SqlCommand cmd = new SqlCommand();
                        //cmd.CommandText = "Insert into MovieSeries(Genre_idGenre,Name,Plot,Dubbed) values((select idGenre from Genre where type_2=" + cat_box.SelectedItem + " )," + Title_box.Text + "," + plot_text.Text + " , " + dubbed_check.Checked + ");";
                        //cmd.Connection = conn;
                        //cmd.ExecuteNonQuery();
                        //SqlCommand cmd2 = new SqlCommand();



                        //MessageBox.Show("Record has been Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (type_box.SelectedItem.ToString() == "Series")
            {
                try
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Insert Series values((select idStudio from Studio where Name=" + studio_box.SelectedItem + " ),(select idCategory from SeasonTime where Tpe_2=" + season_box.SelectedItem + " )," + Title_box.Text + "," + plot_text.Text + " , " + dubbed_check.Checked + ");";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record has been Added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void type_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_box.SelectedItem.ToString() == "Movies")
            {
                studio_box.Text = "";
                Episode_text.Text = "";
                season_box.Text = "";
                Numberofseasons_text.Text = "";

                ongoing_check.Enabled = false;
                Part_text.Enabled = true;
               Time.Enabled = true;

                studio_box.Enabled = false;
                Episode_text.Enabled = false;
                season_box.Enabled = false;
                Numberofseasons_text.Enabled = false;

                Episode_text.Text = "";
                season_box.Text = "";
                Numberofseasons_text.Text = "";

            }
            if (type_box.SelectedItem.ToString() == "Series")
            {
                studio_box.Enabled = true;
                Episode_text.Enabled = true;
                season_box.Enabled = true;
                Numberofseasons_text.Enabled = true;

                ongoing_check.Enabled = true;

                Part_text.Text = "";
                


                Part_text.Enabled = false;
                Time.Enabled = false;
                

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
