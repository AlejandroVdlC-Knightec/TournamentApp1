using System.Windows.Forms;

namespace TournamentApp1
{
    partial class TournamentCreator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.tbEntryFee = new System.Windows.Forms.TextBox();
            this.tbTourName = new System.Windows.Forms.TextBox();
            this.btAddTeam = new System.Windows.Forms.Button();
            this.btCreatePrize = new System.Windows.Forms.Button();
            this.btCreateTournament = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btDeleteTeam = new System.Windows.Forms.Button();
            this.btDeletePrize = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Tournament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(84, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tournament Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(513, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teams / Players";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(84, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Entry Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(84, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(513, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prizes";
            // 
            // cbTeams
            // 
            this.cbTeams.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbTeams.DisplayMember = "TeamName";
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(84, 370);
            this.cbTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(326, 28);
            this.cbTeams.TabIndex = 8;
            // 
            // tbEntryFee
            // 
            this.tbEntryFee.Location = new System.Drawing.Point(219, 231);
            this.tbEntryFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEntryFee.Name = "tbEntryFee";
            this.tbEntryFee.Size = new System.Drawing.Size(191, 26);
            this.tbEntryFee.TabIndex = 9;
            // 
            // tbTourName
            // 
            this.tbTourName.Location = new System.Drawing.Point(84, 159);
            this.tbTourName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTourName.Name = "tbTourName";
            this.tbTourName.Size = new System.Drawing.Size(326, 26);
            this.tbTourName.TabIndex = 10;
            // 
            // btAddTeam
            // 
            this.btAddTeam.Location = new System.Drawing.Point(161, 418);
            this.btAddTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddTeam.Name = "btAddTeam";
            this.btAddTeam.Size = new System.Drawing.Size(147, 35);
            this.btAddTeam.TabIndex = 11;
            this.btAddTeam.Text = "Add Team";
            this.btAddTeam.UseVisualStyleBackColor = true;
            this.btAddTeam.Click += new System.EventHandler(this.btAddTeam_Click);
            // 
            // btCreatePrize
            // 
            this.btCreatePrize.Location = new System.Drawing.Point(161, 482);
            this.btCreatePrize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCreatePrize.Name = "btCreatePrize";
            this.btCreatePrize.Size = new System.Drawing.Size(147, 29);
            this.btCreatePrize.TabIndex = 12;
            this.btCreatePrize.Text = "Create Prize";
            this.btCreatePrize.UseVisualStyleBackColor = true;
            this.btCreatePrize.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCreateTournament
            // 
            this.btCreateTournament.Location = new System.Drawing.Point(269, 630);
            this.btCreateTournament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCreateTournament.Name = "btCreateTournament";
            this.btCreateTournament.Size = new System.Drawing.Size(348, 44);
            this.btCreateTournament.TabIndex = 13;
            this.btCreateTournament.Text = "Create Tournament";
            this.btCreateTournament.UseVisualStyleBackColor = true;
            this.btCreateTournament.Click += new System.EventHandler(this.btCreateTournament_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(284, 337);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 20);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "create new";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btDeleteTeam
            // 
            this.btDeleteTeam.Location = new System.Drawing.Point(680, 156);
            this.btDeleteTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteTeam.Name = "btDeleteTeam";
            this.btDeleteTeam.Size = new System.Drawing.Size(108, 70);
            this.btDeleteTeam.TabIndex = 15;
            this.btDeleteTeam.Text = "Delete Selected";
            this.btDeleteTeam.UseVisualStyleBackColor = true;
            this.btDeleteTeam.Click += new System.EventHandler(this.btDeleteTeam_Click);
            // 
            // btDeletePrize
            // 
            this.btDeletePrize.Location = new System.Drawing.Point(680, 439);
            this.btDeletePrize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeletePrize.Name = "btDeletePrize";
            this.btDeletePrize.Size = new System.Drawing.Size(108, 70);
            this.btDeletePrize.TabIndex = 16;
            this.btDeletePrize.Text = "Delete Selected";
            this.btDeletePrize.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(512, 439);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(162, 104);
            this.listBox2.TabIndex = 7;
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.ItemHeight = 20;
            this.lbTeams.Location = new System.Drawing.Point(513, 156);
            this.lbTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(162, 104);
            this.lbTeams.TabIndex = 6;
            // 
            // TournamentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 736);
            this.Controls.Add(this.btDeletePrize);
            this.Controls.Add(this.btDeleteTeam);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btCreateTournament);
            this.Controls.Add(this.btCreatePrize);
            this.Controls.Add(this.btAddTeam);
            this.Controls.Add(this.tbTourName);
            this.Controls.Add(this.tbEntryFee);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lbTeams);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TournamentCreator";
            this.Text = "Tournament Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbTeams;
        private TextBox tbEntryFee;
        private TextBox tbTourName;
        private Button btAddTeam;
        private Button btCreatePrize;
        private Button btCreateTournament;
        private LinkLabel linkLabel1;
        private Button btDeleteTeam;
        private Button btDeletePrize;
        private ListBox listBox2;
        private ListBox lbTeams;

    }
}