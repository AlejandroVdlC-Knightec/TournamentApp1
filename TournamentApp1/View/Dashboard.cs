using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TournamentApp1
{
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            SqlCommand cmd = new SqlCommand();
            
            connetionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\alvil\source\repos\TournamentApp1\TournamentApp1\Model\Database1.mdf; Integrated Security = True; Connect Timeout = 30";
            con = new SqlConnection(connetionString);
            con.Open();
            Console.WriteLine("Connection Open  !");
            cmd.Connection = con;
            cmd.CommandText = ("SELECT * FROM Tournaments");
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["TournamentName"]);
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TournamentCreator tc = new TournamentCreator();
            tc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tournament t = new Tournament();
            t.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
