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
    public partial class Watchlsit : Form
    {
        int userz;
        string watchname;
        public Watchlsit(int userid , string watchlistname)
        {
            userz = userid;
            watchname = watchlistname;
            DBconnectioncs c = new DBconnectioncs();
            DataTable d = c.Select("select * from watchlist_has_part, watchlist_has_series where part.watchlist_idwatchlist = idwatchlist and series.watchlist_idwatchlist = idwatchlist");
            for (int i = 0; i < d.Rows.Count; i++)
            {
                if (d.Rows[i][0].ToString() == userz.ToString() && d.Rows[i][1].ToString() == watchname)
                {
                    listBox1.Items.Add(d.Rows[i][2].ToString());
                }
            }
                
          
            
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
            
        }

        private void Watchlsit_Load(object sender, EventArgs e)
        {

        }
    }
}
