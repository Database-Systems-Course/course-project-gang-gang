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
    public partial class HomeScreen : Form
    { int userz;
        SqlConnection conn;
        public HomeScreen(int userid) {
        
            userz= userid;
            InitializeComponent();
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
            ViewDetails f = new ViewDetails();// needs arguments from result box to be able to run
            f.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Watchlsit f = new Watchlsit(userz,Watchlistbox.SelectedItem.ToString());
            f.Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2(userz);
            f.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you really want to delete this Watchlist?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) {
                Watchlistbox.Items.Remove(Watchlistbox.SelectedItem);
                // run querry to delete watchlist using userz as userid arguement
            };
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            if (typebox.SelectedItem.ToString() == "Movies")
            {
                cmd.CommandText = "select * from MovieSeries";
                cmd.Connection = conn;
            }
            else if (typebox.SelectedItem.ToString() == "Series") {
                cmd.CommandText = "select * from Series where name like "+titletext.Text+"% and Genre_Genreid =(select idGenre from genre where type_2 ="+catbox.SelectedItem.ToString()+")";
                cmd.Connection = conn;
            }
            else {
                cmd.CommandText = "select * from Series,MovieSeries where MovieSeries.name like " + titletext.Text + "% and Series.Name like " + titletext.Text + "% and Genre_idGenre =(select idGenre from Genre where type_2=" + catbox.SelectedItem.ToString() + ") and Series.Genre_Genreid =" + titletext.Text + "% and Movieseries.Genre_idGenre =(select idGenre from Genre where type_2=" + catbox.SelectedItem.ToString() + ");";
                cmd.Connection = conn;
            }
            cmd.ExecuteNonQuery();
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
