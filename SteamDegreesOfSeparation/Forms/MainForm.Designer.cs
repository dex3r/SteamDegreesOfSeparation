namespace SteamDegreesOfSeparation
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.lbSteamAPIKeys = new System.Windows.Forms.ListBox();
			this.tbSteamAPIKeyInput = new System.Windows.Forms.TextBox();
			this.bAddSteamAPIKey = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bSteamAPIKeysRemove = new System.Windows.Forms.Button();
			this.bSteamAPIKeysClear = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tbSeedUserSteamID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpSettings = new System.Windows.Forms.TabPage();
			this.pQuarrySettings = new System.Windows.Forms.Panel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.nupQuarryThreadsToUse = new System.Windows.Forms.NumericUpDown();
			this.tpFriendsQuarry = new System.Windows.Forms.TabPage();
			this.lSeenUsers = new System.Windows.Forms.Label();
			this.lPrivateProfilesFound = new System.Windows.Forms.Label();
			this.lProcessedUsersPerSecond = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lProcessedUsers = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.bQuarryStop = new System.Windows.Forms.Button();
			this.bQuarryPause = new System.Windows.Forms.Button();
			this.bQuarryStart = new System.Windows.Forms.Button();
			this.lQuarryState = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tUpdateFriendsQuarryStats = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tpSettings.SuspendLayout();
			this.pQuarrySettings.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupQuarryThreadsToUse)).BeginInit();
			this.tpFriendsQuarry.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbSteamAPIKeys
			// 
			this.lbSteamAPIKeys.FormattingEnabled = true;
			this.lbSteamAPIKeys.Location = new System.Drawing.Point(9, 87);
			this.lbSteamAPIKeys.Name = "lbSteamAPIKeys";
			this.lbSteamAPIKeys.Size = new System.Drawing.Size(263, 160);
			this.lbSteamAPIKeys.TabIndex = 1;
			// 
			// tbSteamAPIKeyInput
			// 
			this.tbSteamAPIKeyInput.Location = new System.Drawing.Point(9, 32);
			this.tbSteamAPIKeyInput.Name = "tbSteamAPIKeyInput";
			this.tbSteamAPIKeyInput.Size = new System.Drawing.Size(263, 20);
			this.tbSteamAPIKeyInput.TabIndex = 2;
			// 
			// bAddSteamAPIKey
			// 
			this.bAddSteamAPIKey.Location = new System.Drawing.Point(197, 53);
			this.bAddSteamAPIKey.Name = "bAddSteamAPIKey";
			this.bAddSteamAPIKey.Size = new System.Drawing.Size(75, 23);
			this.bAddSteamAPIKey.TabIndex = 3;
			this.bAddSteamAPIKey.Text = "Add";
			this.bAddSteamAPIKey.UseVisualStyleBackColor = true;
			this.bAddSteamAPIKey.Click += new System.EventHandler(this.bAddSteamAPIKey_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.bSteamAPIKeysRemove);
			this.groupBox1.Controls.Add(this.bSteamAPIKeysClear);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lbSteamAPIKeys);
			this.groupBox1.Controls.Add(this.bAddSteamAPIKey);
			this.groupBox1.Controls.Add(this.tbSteamAPIKeyInput);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(278, 288);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Steam Web API keys";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Keys in use:";
			// 
			// bSteamAPIKeysRemove
			// 
			this.bSteamAPIKeysRemove.Location = new System.Drawing.Point(116, 253);
			this.bSteamAPIKeysRemove.Name = "bSteamAPIKeysRemove";
			this.bSteamAPIKeysRemove.Size = new System.Drawing.Size(75, 23);
			this.bSteamAPIKeysRemove.TabIndex = 5;
			this.bSteamAPIKeysRemove.Text = "Clear";
			this.bSteamAPIKeysRemove.UseVisualStyleBackColor = true;
			this.bSteamAPIKeysRemove.Click += new System.EventHandler(this.bSteamAPIKeysRemove_Click);
			// 
			// bSteamAPIKeysClear
			// 
			this.bSteamAPIKeysClear.Location = new System.Drawing.Point(197, 253);
			this.bSteamAPIKeysClear.Name = "bSteamAPIKeysClear";
			this.bSteamAPIKeysClear.Size = new System.Drawing.Size(75, 23);
			this.bSteamAPIKeysClear.TabIndex = 4;
			this.bSteamAPIKeysClear.Text = "Remove";
			this.bSteamAPIKeysClear.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "New key:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbSeedUserSteamID);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(287, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 89);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Seed user SteamID";
			// 
			// tbSeedUserSteamID
			// 
			this.tbSeedUserSteamID.Location = new System.Drawing.Point(9, 58);
			this.tbSeedUserSteamID.Name = "tbSeedUserSteamID";
			this.tbSeedUserSteamID.Size = new System.Drawing.Size(185, 20);
			this.tbSeedUserSteamID.TabIndex = 1;
			this.tbSeedUserSteamID.Leave += new System.EventHandler(this.tbSeedUserSteamID_Leave);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(188, 39);
			this.label3.TabIndex = 0;
			this.label3.Text = "Steam ID to use as a seed for the quarry. Must be a public profile with some frie" +
    "nds.";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpSettings);
			this.tabControl1.Controls.Add(this.tpFriendsQuarry);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(560, 392);
			this.tabControl1.TabIndex = 6;
			// 
			// tpSettings
			// 
			this.tpSettings.Controls.Add(this.pQuarrySettings);
			this.tpSettings.Location = new System.Drawing.Point(4, 22);
			this.tpSettings.Name = "tpSettings";
			this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tpSettings.Size = new System.Drawing.Size(552, 366);
			this.tpSettings.TabIndex = 0;
			this.tpSettings.Text = "Friends quarry settings";
			this.tpSettings.UseVisualStyleBackColor = true;
			// 
			// pQuarrySettings
			// 
			this.pQuarrySettings.Controls.Add(this.groupBox1);
			this.pQuarrySettings.Controls.Add(this.groupBox3);
			this.pQuarrySettings.Controls.Add(this.groupBox2);
			this.pQuarrySettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pQuarrySettings.Location = new System.Drawing.Point(3, 3);
			this.pQuarrySettings.Name = "pQuarrySettings";
			this.pQuarrySettings.Size = new System.Drawing.Size(546, 360);
			this.pQuarrySettings.TabIndex = 7;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.nupQuarryThreadsToUse);
			this.groupBox3.Location = new System.Drawing.Point(287, 98);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 100);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Quarry settings";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 15);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Threads to use:";
			// 
			// nupQuarryThreadsToUse
			// 
			this.nupQuarryThreadsToUse.Location = new System.Drawing.Point(9, 31);
			this.nupQuarryThreadsToUse.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.nupQuarryThreadsToUse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nupQuarryThreadsToUse.Name = "nupQuarryThreadsToUse";
			this.nupQuarryThreadsToUse.Size = new System.Drawing.Size(120, 20);
			this.nupQuarryThreadsToUse.TabIndex = 0;
			this.nupQuarryThreadsToUse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nupQuarryThreadsToUse.ValueChanged += new System.EventHandler(this.nupQuarryThreadsToUse_ValueChanged);
			// 
			// tpFriendsQuarry
			// 
			this.tpFriendsQuarry.Controls.Add(this.lSeenUsers);
			this.tpFriendsQuarry.Controls.Add(this.lPrivateProfilesFound);
			this.tpFriendsQuarry.Controls.Add(this.lProcessedUsersPerSecond);
			this.tpFriendsQuarry.Controls.Add(this.label8);
			this.tpFriendsQuarry.Controls.Add(this.label7);
			this.tpFriendsQuarry.Controls.Add(this.label6);
			this.tpFriendsQuarry.Controls.Add(this.lProcessedUsers);
			this.tpFriendsQuarry.Controls.Add(this.label30);
			this.tpFriendsQuarry.Controls.Add(this.bQuarryStop);
			this.tpFriendsQuarry.Controls.Add(this.bQuarryPause);
			this.tpFriendsQuarry.Controls.Add(this.bQuarryStart);
			this.tpFriendsQuarry.Controls.Add(this.lQuarryState);
			this.tpFriendsQuarry.Controls.Add(this.label4);
			this.tpFriendsQuarry.Location = new System.Drawing.Point(4, 22);
			this.tpFriendsQuarry.Name = "tpFriendsQuarry";
			this.tpFriendsQuarry.Padding = new System.Windows.Forms.Padding(3);
			this.tpFriendsQuarry.Size = new System.Drawing.Size(552, 366);
			this.tpFriendsQuarry.TabIndex = 1;
			this.tpFriendsQuarry.Text = "Friends Quarry";
			this.tpFriendsQuarry.UseVisualStyleBackColor = true;
			// 
			// lSeenUsers
			// 
			this.lSeenUsers.AutoSize = true;
			this.lSeenUsers.Location = new System.Drawing.Point(237, 103);
			this.lSeenUsers.Name = "lSeenUsers";
			this.lSeenUsers.Size = new System.Drawing.Size(13, 13);
			this.lSeenUsers.TabIndex = 12;
			this.lSeenUsers.Text = "0";
			// 
			// lPrivateProfilesFound
			// 
			this.lPrivateProfilesFound.AutoSize = true;
			this.lPrivateProfilesFound.Location = new System.Drawing.Point(237, 116);
			this.lPrivateProfilesFound.Name = "lPrivateProfilesFound";
			this.lPrivateProfilesFound.Size = new System.Drawing.Size(13, 13);
			this.lPrivateProfilesFound.TabIndex = 11;
			this.lPrivateProfilesFound.Text = "0";
			// 
			// lProcessedUsersPerSecond
			// 
			this.lProcessedUsersPerSecond.AutoSize = true;
			this.lProcessedUsersPerSecond.Location = new System.Drawing.Point(237, 90);
			this.lProcessedUsersPerSecond.Name = "lProcessedUsersPerSecond";
			this.lProcessedUsersPerSecond.Size = new System.Drawing.Size(13, 13);
			this.lProcessedUsersPerSecond.TabIndex = 10;
			this.lProcessedUsersPerSecond.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(87, 90);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 13);
			this.label8.TabIndex = 9;
			this.label8.Text = "Processed users per second:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(157, 103);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Profiles found:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(122, 116);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Private profiles found:";
			// 
			// lProcessedUsers
			// 
			this.lProcessedUsers.AutoSize = true;
			this.lProcessedUsers.Location = new System.Drawing.Point(237, 77);
			this.lProcessedUsers.Name = "lProcessedUsers";
			this.lProcessedUsers.Size = new System.Drawing.Size(13, 13);
			this.lProcessedUsers.TabIndex = 6;
			this.lProcessedUsers.Text = "0";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(144, 77);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(88, 13);
			this.label30.TabIndex = 5;
			this.label30.Text = "Processed users:";
			// 
			// bQuarryStop
			// 
			this.bQuarryStop.Location = new System.Drawing.Point(309, 31);
			this.bQuarryStop.Name = "bQuarryStop";
			this.bQuarryStop.Size = new System.Drawing.Size(75, 23);
			this.bQuarryStop.TabIndex = 4;
			this.bQuarryStop.Text = "Stop";
			this.bQuarryStop.UseVisualStyleBackColor = true;
			this.bQuarryStop.Click += new System.EventHandler(this.bQuarryStop_Click);
			// 
			// bQuarryPause
			// 
			this.bQuarryPause.Location = new System.Drawing.Point(228, 31);
			this.bQuarryPause.Name = "bQuarryPause";
			this.bQuarryPause.Size = new System.Drawing.Size(75, 23);
			this.bQuarryPause.TabIndex = 3;
			this.bQuarryPause.Text = "Pause";
			this.bQuarryPause.UseVisualStyleBackColor = true;
			this.bQuarryPause.Click += new System.EventHandler(this.bQuarryPause_Click);
			// 
			// bQuarryStart
			// 
			this.bQuarryStart.Location = new System.Drawing.Point(147, 31);
			this.bQuarryStart.Name = "bQuarryStart";
			this.bQuarryStart.Size = new System.Drawing.Size(75, 23);
			this.bQuarryStart.TabIndex = 2;
			this.bQuarryStart.Text = "Start";
			this.bQuarryStart.UseVisualStyleBackColor = true;
			this.bQuarryStart.Click += new System.EventHandler(this.bQuarryStart_Click);
			// 
			// lQuarryState
			// 
			this.lQuarryState.AutoSize = true;
			this.lQuarryState.Location = new System.Drawing.Point(301, 15);
			this.lQuarryState.Name = "lQuarryState";
			this.lQuarryState.Size = new System.Drawing.Size(10, 13);
			this.lQuarryState.TabIndex = 1;
			this.lQuarryState.Text = "-";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(225, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Current state:";
			// 
			// tUpdateFriendsQuarryStats
			// 
			this.tUpdateFriendsQuarryStats.Interval = 500;
			this.tUpdateFriendsQuarryStats.Tick += new System.EventHandler(this.tUpdateFriendsQuarryStats_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 413);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Steam Degrees of Separation";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tpSettings.ResumeLayout(false);
			this.pQuarrySettings.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nupQuarryThreadsToUse)).EndInit();
			this.tpFriendsQuarry.ResumeLayout(false);
			this.tpFriendsQuarry.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox lbSteamAPIKeys;
		private System.Windows.Forms.TextBox tbSteamAPIKeyInput;
		private System.Windows.Forms.Button bAddSteamAPIKey;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bSteamAPIKeysRemove;
		private System.Windows.Forms.Button bSteamAPIKeysClear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox tbSeedUserSteamID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpSettings;
		private System.Windows.Forms.TabPage tpFriendsQuarry;
		private System.Windows.Forms.Label lQuarryState;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bQuarryStop;
		private System.Windows.Forms.Button bQuarryPause;
		private System.Windows.Forms.Button bQuarryStart;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lProcessedUsers;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lSeenUsers;
		private System.Windows.Forms.Label lPrivateProfilesFound;
		private System.Windows.Forms.Label lProcessedUsersPerSecond;
		private System.Windows.Forms.Timer tUpdateFriendsQuarryStats;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown nupQuarryThreadsToUse;
		private System.Windows.Forms.Panel pQuarrySettings;
	}
}

