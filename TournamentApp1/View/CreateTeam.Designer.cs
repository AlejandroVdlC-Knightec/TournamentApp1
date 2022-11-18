using System.Windows.Forms;

namespace TournamentApp1
{
    partial class CreateTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAddMember = new System.Windows.Forms.Button();
            this.btCreateTeam = new System.Windows.Forms.Button();
            this.btCreateMember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMemberLastName = new System.Windows.Forms.TextBox();
            this.tbMemberPhone = new System.Windows.Forms.TextBox();
            this.tbMemberEmail = new System.Windows.Forms.TextBox();
            this.tbMemberFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.cbTeamMembers = new System.Windows.Forms.ComboBox();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddMember
            // 
            this.btAddMember.Location = new System.Drawing.Point(47, 282);
            this.btAddMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddMember.Name = "btAddMember";
            this.btAddMember.Size = new System.Drawing.Size(199, 31);
            this.btAddMember.TabIndex = 0;
            this.btAddMember.Text = "Add Member";
            this.btAddMember.UseVisualStyleBackColor = true;
            this.btAddMember.Click += new System.EventHandler(this.btAddMember_Click);
            // 
            // btCreateTeam
            // 
            this.btCreateTeam.Location = new System.Drawing.Point(250, 702);
            this.btCreateTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCreateTeam.Name = "btCreateTeam";
            this.btCreateTeam.Size = new System.Drawing.Size(199, 31);
            this.btCreateTeam.TabIndex = 1;
            this.btCreateTeam.Text = "Create Team";
            this.btCreateTeam.UseVisualStyleBackColor = true;
            this.btCreateTeam.Click += new System.EventHandler(this.btCreateTeam_Click);
            // 
            // btCreateMember
            // 
            this.btCreateMember.Location = new System.Drawing.Point(36, 278);
            this.btCreateMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCreateMember.Name = "btCreateMember";
            this.btCreateMember.Size = new System.Drawing.Size(199, 31);
            this.btCreateMember.TabIndex = 2;
            this.btCreateMember.Text = "Create Member";
            this.btCreateMember.UseVisualStyleBackColor = true;
            this.btCreateMember.Click += new System.EventHandler(this.btCreateMember_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMemberLastName);
            this.groupBox1.Controls.Add(this.tbMemberPhone);
            this.groupBox1.Controls.Add(this.tbMemberEmail);
            this.groupBox1.Controls.Add(this.tbMemberFirstName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btCreateMember);
            this.groupBox1.Location = new System.Drawing.Point(11, 352);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(294, 322);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // tbMemberLastName
            // 
            this.tbMemberLastName.Location = new System.Drawing.Point(139, 99);
            this.tbMemberLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemberLastName.Name = "tbMemberLastName";
            this.tbMemberLastName.Size = new System.Drawing.Size(151, 26);
            this.tbMemberLastName.TabIndex = 10;
            // 
            // tbMemberPhone
            // 
            this.tbMemberPhone.Location = new System.Drawing.Point(139, 218);
            this.tbMemberPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemberPhone.Name = "tbMemberPhone";
            this.tbMemberPhone.Size = new System.Drawing.Size(151, 26);
            this.tbMemberPhone.TabIndex = 9;
            // 
            // tbMemberEmail
            // 
            this.tbMemberEmail.Location = new System.Drawing.Point(139, 157);
            this.tbMemberEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemberEmail.Name = "tbMemberEmail";
            this.tbMemberEmail.Size = new System.Drawing.Size(151, 26);
            this.tbMemberEmail.TabIndex = 8;
            // 
            // tbMemberFirstName
            // 
            this.tbMemberFirstName.Location = new System.Drawing.Point(139, 44);
            this.tbMemberFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMemberFirstName.Name = "tbMemberFirstName";
            this.tbMemberFirstName.Size = new System.Drawing.Size(151, 26);
            this.tbMemberFirstName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cellphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(18, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Team Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Team Member";
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.ItemHeight = 20;
            this.lbMembers.Location = new System.Drawing.Point(387, 110);
            this.lbMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(378, 564);
            this.lbMembers.TabIndex = 7;
            // 
            // cbTeamMembers
            // 
            this.cbTeamMembers.FormattingEnabled = true;
            this.cbTeamMembers.Location = new System.Drawing.Point(29, 216);
            this.cbTeamMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTeamMembers.Name = "cbTeamMembers";
            this.cbTeamMembers.Size = new System.Drawing.Size(277, 28);
            this.cbTeamMembers.TabIndex = 8;
            // 
            // tbTeamName
            // 
            this.tbTeamName.Location = new System.Drawing.Point(29, 118);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(277, 26);
            this.tbTeamName.TabIndex = 10;
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 762);
            this.Controls.Add(this.tbTeamName);
            this.Controls.Add(this.cbTeamMembers);
            this.Controls.Add(this.lbMembers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCreateTeam);
            this.Controls.Add(this.btAddMember);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateTeam";
            this.Text = "CreateTeam";
            this.Load += new System.EventHandler(this.CreateTeam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btAddMember;
        private Button btCreateTeam;
        private Button btCreateMember;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbMemberLastName;
        private TextBox tbMemberPhone;
        private TextBox tbMemberEmail;
        private TextBox tbMemberFirstName;
        private ListBox lbMembers;
        private ComboBox cbTeamMembers;
        private TextBox tbTeamName;
    }
}