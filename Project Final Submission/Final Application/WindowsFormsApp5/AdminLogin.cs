﻿using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class AdminLogin : Form
    {
        int user;
        public AdminLogin(int a)
        {
            InitializeComponent();
            user = a;
            try
            {
                //DBconnectioncs c = new DBconnectioncs();
                //DataTable d = c.Select("Select * from Genre");
                //for (int i = 0; i < 10; i++)
                //{
                //    MessageBox.Show(d.Rows[i][1].ToString());
                //}


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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool logged = false;
            //if (textBox1.Text == "1" && textBox2.Text == "123")
            //{
            //    Addnew f = new Addnew(Int32.Parse(textBox1.Text));
            //    f.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    HomeScreen f = new HomeScreen(Int32.Parse(textBox1.Text));
            //    f.Show();
            //    this.Hide();
            //}
            DBconnectioncs c = new DBconnectioncs();
            DataTable d = c.Select("Select * from User_2");
            
            for (int i = 0; i < d.Rows.Count; i++)
            {
              // MessageBox.Show(d.Rows[i][1].ToString());
               
                if (d.Rows[i][1].ToString() == textBox1.Text.ToString())
                {
                    if (d.Rows[i][2].ToString() == textBox2.Text.ToString())
                    {
                        if (user == 1)
                        {
                            HomeScreen f = new HomeScreen(user);
                            f.Show();
                            this.Hide();
                            logged = true;
                            return;
                        }
                        //For user
                        else if (user == 0)
                        {
                            Addnew f = new Addnew();
                            f.Show();
                            this.Hide();
                            logged = true;
                            return;
                            
                        }
                    }
                                
                }
               

            }
            if (logged != true)
            {
                MessageBox.Show("Incorrect Login Credentials");

            }


            // MessageBox.Show(d.Rows[i][1].ToString());



        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
