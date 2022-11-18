using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.Windows.Forms;
using TournamentApp1.Model;

namespace TournamentApp1
{
    public partial class TournamentCreator: Form
    {
        //Object tournament that is going to be created/manipulated
        Model.Tournament tou = new Model.Tournament();
        DataTable newTeams = new DataTable();
        string connetionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\alvil\source\repos\TournamentApp1\TournamentApp1\Model\Database1.mdf; Integrated Security = True; Connect Timeout = 30";
        
        public TournamentCreator()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
            var connection = new SqlConnection(connetionString);
            var reader = connection.ExecuteReader("SELECT * FROM Teams;");

            DataTable tableTeams = new DataTable();
            tableTeams.Load(reader);
            cbTeams.DataSource = tableTeams;

            newTeams.Columns.Add("Id", typeof(int));
            newTeams.Columns.Add("TeamName", typeof(String));


        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Retrieve the new created team and add it to the list of teams directly
            CreateTeam ct = new CreateTeam();
            ct.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CreatePrize cp = new CreatePrize();
            cp.Show();
        }
        private void btCreateTournament_Click(object sender, EventArgs e)
        {
            /*Constrains to check: 
             - Tournament name doesnt exists
            - Fields are not empty
            */
            try
            {
                tou.TournamentName = tbTourName.Text;
                tou.EntryFee = System.Convert.ToDecimal(tbEntryFee.Text);
                //tou.EnteredTeams = newTeams; -> make a function which returns a list of people after using dapper to retrieve evry people from teambebmbers where id = newTeams teamId's
                Console.WriteLine(tou.TournamentName + " " + tou.EntryFee);
            }
            catch
            {

            }
                
            


        }
        private void btAddTeam_Click(object sender, EventArgs e){
            //Retrieves the selected datarow from the ComboBox, containing TeamId and teamName and
            //if the List<Team> of the new tournament doesn't contain that teamId, adds it.
            DataRowView drv = (DataRowView)cbTeams.SelectedItem;
            DataRow dr = drv.Row;
            
            try{
                //If List<Team> in the new tournament is empty, adds the team right away.
                if (! (dr.ItemArray[1] is string))
                    throw new ArgumentException();
                if (dr.ItemArray.Length==0)
                    throw new ArgumentNullException();
                if (newTeams.Rows.Count == 0)
                    newTeams.ImportRow(dr);
                else
                {
                    foreach (DataRow item in newTeams.Rows)
                    {
                        if (item.ItemArray[0].Equals(dr.ItemArray[0]))
                            throw new RowExistingException();     
                    }
                    newTeams.ImportRow(dr);
                }
                lbTeams.DataSource = newTeams;
                lbTeams.DisplayMember = "TeamName";
            }
            catch{
                return;
            }
        }
        private void btDeleteTeam_Click(object sender, EventArgs e)
        {
            //retrieves selected row in the listbox and removes it from the newTeams DataTable
            try
            {
                if (newTeams.Rows.Count == 0)
                    throw new InvalidOperationException();
                DataRowView drv = (DataRowView)lbTeams.SelectedItem;
                DataRow dr = drv.Row;
                if (!(dr.ItemArray[1] is string))
                    throw new ArgumentException();
                if (dr.ItemArray.Length == 0)
                    throw new ArgumentNullException();
                
                else
                {
                    
                    newTeams.Rows.Remove(newTeams.Rows[lbTeams.SelectedIndex]);
                }
            }
            catch
            {
                return;
            }
        }

        //Exceptions 
        [Serializable]
        private class RowExistingException : Exception
        {
            public RowExistingException()
            {
            }
            public RowExistingException(string message) : base(message)
            {
            }
            public RowExistingException(string message, Exception innerException) : base(message, innerException)
            {
            }
            protected RowExistingException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }


    }
}