﻿using System;
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
    public partial class HomeScreen : Form
    { int user;
        SqlConnection con;
        public HomeScreen(int userz) {
        
            user= userz;
           // MessageBox.Show(user.ToString());
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = " Data Source = AHSANPC; Initial Catalog = A8; Integrated Security = True";
            con.Open();

            DBconnectioncs c = new DBconnectioncs();
            DataTable d = c.Select("Select * from watchlist");

            for (int i = 0; i < d.Rows.Count; i++)
            {
                if (d.Rows[i][1].ToString() == user.ToString())
                {
                    Watchlistbox.Items.Add(d.Rows[i][2]);
                }
            }
            //make watchlistbox populate with all the watch list names from user having user id userz
            //conn = new SqlConnection();
            //conn.ConnectionString = " Data Source = AHSANPC; Initial Catalog = A7; Integrated Security = True";
            //conn.Open();
                    }
         
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            ViewDetails f = new ViewDetails(listBox2.SelectedItem.ToString());// needs arguments from result box to be able to run
            f.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Watchlsit f = new Watchlsit(user,Watchlistbox.SelectedItem.ToString());
            f.Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 f = new Form2(user);
            f.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you really want to delete this Watchlist?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) {
               
                string qry = "delete from watchlist  where User_2_idUser_2 = @id and watchlistname = @text ;";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@text", Watchlistbox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@id" ,user);
               

                cmd.ExecuteNonQuery();


                Watchlistbox.Items.Remove(Watchlistbox.SelectedItem);
                
            };
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            SqlCommand cmd = new SqlCommand();
            if ( typebox.SelectedItem != null && typebox.SelectedItem.ToString() == "Movie" )
            {
                if (catbox.SelectedItem == null)
                {
                    if (titletext.Text=="")
                    {
                        try
                        {
                            DBconnectioncs c = new DBconnectioncs();
                            listBox2.Items.Add("Title                   |                  genre                       || part");
                            DataTable d = c.Select("Select name,part.number,type_2 from part,MovieSeries,Genre where Genre_idgenre = idGenre and Movieseries_idmovies = idmovies");
                            for (int i = 0; i < d.Rows.Count; i++)
                            {

                                listBox2.Items.Add(d.Rows[i][0].ToString() + "," + d.Rows[i][2].ToString() + "," + d.Rows[i][1].ToString()+",Movie");

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                }
               
            }
            else if (typebox.SelectedItem != null && typebox.SelectedItem.ToString() == "Series")
            {

                if (catbox.SelectedItem == null)
                {
                    if (titletext.Text == "")
                    {
                        try
                        {
                            listBox2.Items.Add("Title                   |                  genre                       || Episodes");
                            DBconnectioncs c = new DBconnectioncs();
                            DataTable d = c.Select("Select name,numberofepisodes,type_2 from series,Genre where Genre_idgenre = idGenre");
                            for (int i = 0; i < d.Rows.Count; i++)
                            {

                                listBox2.Items.Add(d.Rows[i][0].ToString() + "," + d.Rows[i][2].ToString() + "," + d.Rows[i][1].ToString()+",Series");

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                }

            }
            
    
            else  
            {
                if (titletext.Text=="")
                {
                    if(catbox.SelectedItem==null)
                    {
                        try
                        {
                            DBconnectioncs c = new DBconnectioncs();
                            DataTable d = c.Select("Select name,numberofepisodes,type_2 from series,Genre where Genre_idgenre = idGenre");
                            listBox2.Items.Add("Title                   |                  genre                      | Episodes/Part");
                            for (int i = 0; i < d.Rows.Count; i++)
                            {

                                listBox2.Items.Add(d.Rows[i][0].ToString() + "," + d.Rows[i][2].ToString() + "," + d.Rows[i][1].ToString()+",Series");

                            }
                            DBconnectioncs f = new DBconnectioncs();
                            DataTable g = f.Select("Select name,number,type_2 from part,MovieSeries,Genre where Genre_idgenre = idGenre and Movieseries_idmovies = idmovies");
                            for (int i = 0; i < g.Rows.Count; i++)
                            {
                                listBox2.Items.Add(g.Rows[i][0].ToString() + "," + g.Rows[i][2].ToString() + "," + g.Rows[i][1].ToString()+",Movie");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                }
                
            }

            
                //else if (typebox.SelectedItem.ToString() == "Series") {
                //    cmd.CommandText = "select * from Series where name like "+titletext.Text+"% and Genre_Genreid =(select idGenre from genre where type_2 ="+catbox.SelectedItem.ToString()+")";
                //    cmd.Connection = conn;
                //}
                //else {
                //    cmd.CommandText = "select * from Series,MovieSeries where MovieSeries.name like " + titletext.Text + "% and Series.Name like " + titletext.Text + "% and Genre_idGenre =(select idGenre from Genre where type_2=" + catbox.SelectedItem.ToString() + ") and Series.Genre_Genreid =" + titletext.Text + "% and Movieseries.Genre_idGenre =(select idGenre from Genre where type_2=" + catbox.SelectedItem.ToString() + ");";
                //    cmd.Connection = conn;
                //}
                //cmd.ExecuteNonQuery();
                // add a querry to iterate over results and add them to result box
            }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // querry to add selected item from results into selected watchlist of user having userid = userz
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
