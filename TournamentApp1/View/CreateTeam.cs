using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentApp1.Model;
using TournamentApp1.ModelDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TournamentApp1
{
    public partial class CreateTeam : Form
    {
        Model.Team newTeam = new Team();
        DataTable newMembersTable = new DataTable();
        DataTable tablePeople = new DataTable();
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\alvil\source\repos\TournamentApp1\TournamentApp1\Model\Database1.mdf; Integrated Security = True; Connect Timeout = 30");

        public CreateTeam()
        {
            
            InitializeComponent();
        }

        private void CreateTeam_Load(object sender, EventArgs e)
        {
            //Create the datatable to be used as source for the listbox
            newMembersTable.Columns.Add("Id", typeof(Int32));
            newMembersTable.Columns.Add("FirstName", typeof(string));
            newMembersTable.Columns.Add("LastName", typeof(string));
            newMembersTable.Columns.Add("EmailAddress", typeof(string));
            newMembersTable.Columns.Add("PhoneNumber", typeof(string));
            newMembersTable.Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");
            lbMembers.DataSource = newMembersTable;

 
            //Retrieve the people from the db and populate the combobox with them
            var reader = connection.ExecuteReader("SELECT * FROM People;");
            tablePeople.Load(reader);
            cbTeamMembers.DataSource = tablePeople;
            tablePeople.Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");
            cbTeamMembers.DisplayMember = "FullName";

            //Filter from all the people the new created person to add it to the people in the team under creation
            // ("EmailAddress = ' dfg'")
            string expression = "dfg";
            DataRow[] rslt = tablePeople.Select($"[EmailAddress] = {expression}");           
            newMembersTable.ImportRow(rslt.First());
            lbMembers.DataSource = newMembersTable;
            lbMembers.DisplayMember = "FullName";
        }

        private void btAddMember_Click(object sender, EventArgs e)
        {

        }

        private void btCreateMember_Click(object sender, EventArgs e)
        {
            
            Model.Person person = new Person();
            person.FirstName = tbMemberFirstName.Text;
            person.LastName = tbMemberLastName.Text;
            person.EmailAddress = tbMemberEmail.Text;
            person.PhoneNumber = tbMemberPhone.Text;        
            using (connection)
            {
                string sqlPersonInsert = "INSERT INTO People (FirstName,LastName,EmailAddress,PhoneNumber) Values (@FirstName,@LastName,@EmailAddress,@PhoneNumber);";

                connection.Open();
                var affectedRows = connection.Execute(sqlPersonInsert, person);
                var reader = connection.ExecuteReader("SELECT * FROM People;");

                tablePeople.Load(reader);
                cbTeamMembers.DataSource = tablePeople;

            }

           /* string mailadd = "dfg";
            DataRow[] rslt = tablePeople.Select("EmailAddress = @EmailAddress" , mailadd);
            newMembersTable.Rows.Add(rslt);
            lbMembers.DataSource=newMembersTable;*/
            //  to ListBox
        }
        private void btCreateTeam_Click(object sender, EventArgs e)
        {
            newTeam.TeamName = tbTeamName.Text;
            //newTeam.TeamMembers = newMembers;

        }
    }
}
