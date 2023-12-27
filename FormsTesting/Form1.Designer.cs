namespace FormsTesting
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Events");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Users");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EventPage = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.EventDate = new System.Windows.Forms.DateTimePicker();
            this.EventDelete = new System.Windows.Forms.Button();
            this.EventsList = new System.Windows.Forms.TreeView();
            this.EventUpdate = new System.Windows.Forms.Button();
            this.EventRead = new System.Windows.Forms.Button();
            this.EventCreate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EventLink = new System.Windows.Forms.TextBox();
            this.UserPings = new System.Windows.Forms.RichTextBox();
            this.QuestCompatable = new System.Windows.Forms.CheckBox();
            this.EventDescription = new System.Windows.Forms.RichTextBox();
            this.EventName = new System.Windows.Forms.TextBox();
            this.EventNumber = new System.Windows.Forms.NumericUpDown();
            this.EventRating = new System.Windows.Forms.ComboBox();
            this.EventType = new System.Windows.Forms.ComboBox();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.UsersList = new System.Windows.Forms.TreeView();
            this.UserDelete = new System.Windows.Forms.Button();
            this.UserUpdate = new System.Windows.Forms.Button();
            this.UserRead = new System.Windows.Forms.Button();
            this.UserCreate = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.NumericUpDown();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.Pronouns = new System.Windows.Forms.TextBox();
            this.EmailConfirmed = new System.Windows.Forms.CheckBox();
            this.Role = new System.Windows.Forms.ComboBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.EncryptedPassword = new System.Windows.Forms.TextBox();
            this.DiscordUsername = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.EventPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventNumber)).BeginInit();
            this.UsersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserID)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.EventPage);
            this.tabControl1.Controls.Add(this.UsersPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 669);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // EventPage
            // 
            this.EventPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.EventPage.Controls.Add(this.label18);
            this.EventPage.Controls.Add(this.EventDate);
            this.EventPage.Controls.Add(this.EventDelete);
            this.EventPage.Controls.Add(this.EventsList);
            this.EventPage.Controls.Add(this.EventUpdate);
            this.EventPage.Controls.Add(this.EventRead);
            this.EventPage.Controls.Add(this.EventCreate);
            this.EventPage.Controls.Add(this.label8);
            this.EventPage.Controls.Add(this.label7);
            this.EventPage.Controls.Add(this.label6);
            this.EventPage.Controls.Add(this.label5);
            this.EventPage.Controls.Add(this.label4);
            this.EventPage.Controls.Add(this.label3);
            this.EventPage.Controls.Add(this.label2);
            this.EventPage.Controls.Add(this.label1);
            this.EventPage.Controls.Add(this.EventLink);
            this.EventPage.Controls.Add(this.UserPings);
            this.EventPage.Controls.Add(this.QuestCompatable);
            this.EventPage.Controls.Add(this.EventDescription);
            this.EventPage.Controls.Add(this.EventName);
            this.EventPage.Controls.Add(this.EventNumber);
            this.EventPage.Controls.Add(this.EventRating);
            this.EventPage.Controls.Add(this.EventType);
            this.EventPage.Cursor = System.Windows.Forms.Cursors.Default;
            this.EventPage.Location = new System.Drawing.Point(4, 22);
            this.EventPage.Name = "EventPage";
            this.EventPage.Padding = new System.Windows.Forms.Padding(3);
            this.EventPage.Size = new System.Drawing.Size(829, 643);
            this.EventPage.TabIndex = 0;
            this.EventPage.Text = "Events";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Silver;
            this.label18.Location = new System.Drawing.Point(7, 580);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "EventDate";
            // 
            // EventDate
            // 
            this.EventDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventDate.CalendarForeColor = System.Drawing.Color.Silver;
            this.EventDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventDate.CalendarTitleForeColor = System.Drawing.Color.Silver;
            this.EventDate.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.EventDate.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.EventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EventDate.Location = new System.Drawing.Point(108, 580);
            this.EventDate.Name = "EventDate";
            this.EventDate.Size = new System.Drawing.Size(313, 20);
            this.EventDate.TabIndex = 21;
            this.EventDate.ValueChanged += new System.EventHandler(this.EventDate_ValueChanged);
            // 
            // EventDelete
            // 
            this.EventDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EventDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventDelete.FlatAppearance.BorderSize = 0;
            this.EventDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventDelete.ForeColor = System.Drawing.Color.Silver;
            this.EventDelete.Location = new System.Drawing.Point(304, 612);
            this.EventDelete.Name = "EventDelete";
            this.EventDelete.Size = new System.Drawing.Size(75, 23);
            this.EventDelete.TabIndex = 20;
            this.EventDelete.Text = "Delete";
            this.EventDelete.UseVisualStyleBackColor = false;
            this.EventDelete.Click += new System.EventHandler(this.EventDelete_Click);
            // 
            // EventsList
            // 
            this.EventsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventsList.ForeColor = System.Drawing.Color.Silver;
            this.EventsList.Location = new System.Drawing.Point(436, 5);
            this.EventsList.Name = "EventsList";
            treeNode3.Name = "Events";
            treeNode3.Text = "Events";
            this.EventsList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.EventsList.Size = new System.Drawing.Size(387, 628);
            this.EventsList.TabIndex = 3;
            this.EventsList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.EventsList_AfterSelect);
            // 
            // EventUpdate
            // 
            this.EventUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EventUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventUpdate.FlatAppearance.BorderSize = 0;
            this.EventUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventUpdate.ForeColor = System.Drawing.Color.Silver;
            this.EventUpdate.Location = new System.Drawing.Point(205, 612);
            this.EventUpdate.Name = "EventUpdate";
            this.EventUpdate.Size = new System.Drawing.Size(75, 23);
            this.EventUpdate.TabIndex = 19;
            this.EventUpdate.Text = "Update";
            this.EventUpdate.UseVisualStyleBackColor = false;
            this.EventUpdate.Click += new System.EventHandler(this.EventUpdate_Click);
            // 
            // EventRead
            // 
            this.EventRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EventRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventRead.FlatAppearance.BorderSize = 0;
            this.EventRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventRead.ForeColor = System.Drawing.Color.Silver;
            this.EventRead.Location = new System.Drawing.Point(105, 612);
            this.EventRead.Name = "EventRead";
            this.EventRead.Size = new System.Drawing.Size(75, 23);
            this.EventRead.TabIndex = 18;
            this.EventRead.Text = "Read";
            this.EventRead.UseVisualStyleBackColor = false;
            this.EventRead.Click += new System.EventHandler(this.EventRead_Click);
            // 
            // EventCreate
            // 
            this.EventCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EventCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventCreate.FlatAppearance.BorderSize = 0;
            this.EventCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventCreate.ForeColor = System.Drawing.Color.Silver;
            this.EventCreate.Location = new System.Drawing.Point(6, 611);
            this.EventCreate.Name = "EventCreate";
            this.EventCreate.Size = new System.Drawing.Size(75, 23);
            this.EventCreate.TabIndex = 17;
            this.EventCreate.Text = "Create";
            this.EventCreate.UseVisualStyleBackColor = false;
            this.EventCreate.Click += new System.EventHandler(this.EventCreate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(7, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Event Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(7, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Event Link";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(7, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "User Pings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(7, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quest Compatable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(7, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Event Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Event Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Event Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Event Number";
            // 
            // EventLink
            // 
            this.EventLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventLink.ForeColor = System.Drawing.Color.Silver;
            this.EventLink.Location = new System.Drawing.Point(108, 526);
            this.EventLink.Name = "EventLink";
            this.EventLink.Size = new System.Drawing.Size(313, 13);
            this.EventLink.TabIndex = 8;
            this.EventLink.TextChanged += new System.EventHandler(this.EventLink_TextChanged);
            // 
            // UserPings
            // 
            this.UserPings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserPings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPings.ForeColor = System.Drawing.Color.Silver;
            this.UserPings.Location = new System.Drawing.Point(108, 350);
            this.UserPings.Name = "UserPings";
            this.UserPings.Size = new System.Drawing.Size(313, 161);
            this.UserPings.TabIndex = 7;
            this.UserPings.Text = "";
            this.UserPings.TextChanged += new System.EventHandler(this.UserPings_TextChanged);
            // 
            // QuestCompatable
            // 
            this.QuestCompatable.AutoSize = true;
            this.QuestCompatable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuestCompatable.Checked = true;
            this.QuestCompatable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.QuestCompatable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestCompatable.ForeColor = System.Drawing.Color.Black;
            this.QuestCompatable.Location = new System.Drawing.Point(108, 327);
            this.QuestCompatable.Name = "QuestCompatable";
            this.QuestCompatable.Size = new System.Drawing.Size(12, 11);
            this.QuestCompatable.TabIndex = 6;
            this.QuestCompatable.UseVisualStyleBackColor = false;
            this.QuestCompatable.CheckedChanged += new System.EventHandler(this.QuestCompatable_CheckedChanged);
            // 
            // EventDescription
            // 
            this.EventDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventDescription.ForeColor = System.Drawing.Color.Silver;
            this.EventDescription.Location = new System.Drawing.Point(108, 57);
            this.EventDescription.Name = "EventDescription";
            this.EventDescription.Size = new System.Drawing.Size(313, 236);
            this.EventDescription.TabIndex = 5;
            this.EventDescription.Text = "";
            this.EventDescription.TextChanged += new System.EventHandler(this.EventDescription_TextChanged);
            // 
            // EventName
            // 
            this.EventName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventName.ForeColor = System.Drawing.Color.Silver;
            this.EventName.Location = new System.Drawing.Point(108, 31);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(313, 13);
            this.EventName.TabIndex = 4;
            this.EventName.TextChanged += new System.EventHandler(this.EventName_TextChanged);
            // 
            // EventNumber
            // 
            this.EventNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventNumber.ForeColor = System.Drawing.Color.Silver;
            this.EventNumber.Location = new System.Drawing.Point(108, 5);
            this.EventNumber.Name = "EventNumber";
            this.EventNumber.Size = new System.Drawing.Size(313, 16);
            this.EventNumber.TabIndex = 3;
            this.EventNumber.ValueChanged += new System.EventHandler(this.EventNumber_ValueChanged);
            // 
            // EventRating
            // 
            this.EventRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventRating.ForeColor = System.Drawing.Color.Silver;
            this.EventRating.FormattingEnabled = true;
            this.EventRating.Items.AddRange(new object[] {
            "Everyone",
            "PG13",
            "Adult"});
            this.EventRating.Location = new System.Drawing.Point(108, 549);
            this.EventRating.Name = "EventRating";
            this.EventRating.Size = new System.Drawing.Size(313, 21);
            this.EventRating.TabIndex = 2;
            this.EventRating.SelectedIndexChanged += new System.EventHandler(this.EventRating_SelectedIndexChanged);
            // 
            // EventType
            // 
            this.EventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EventType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventType.ForeColor = System.Drawing.Color.Silver;
            this.EventType.FormattingEnabled = true;
            this.EventType.Items.AddRange(new object[] {
            "Game",
            "Panel",
            "Special",
            "GuestPanel",
            "GuestGame",
            "Video",
            "Shop"});
            this.EventType.Location = new System.Drawing.Point(108, 299);
            this.EventType.Name = "EventType";
            this.EventType.Size = new System.Drawing.Size(313, 21);
            this.EventType.TabIndex = 1;
            this.EventType.SelectedIndexChanged += new System.EventHandler(this.EventType_SelectedIndexChanged);
            // 
            // UsersPage
            // 
            this.UsersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.UsersPage.Controls.Add(this.UsersList);
            this.UsersPage.Controls.Add(this.UserDelete);
            this.UsersPage.Controls.Add(this.UserUpdate);
            this.UsersPage.Controls.Add(this.UserRead);
            this.UsersPage.Controls.Add(this.UserCreate);
            this.UsersPage.Controls.Add(this.label17);
            this.UsersPage.Controls.Add(this.label16);
            this.UsersPage.Controls.Add(this.label15);
            this.UsersPage.Controls.Add(this.label14);
            this.UsersPage.Controls.Add(this.label13);
            this.UsersPage.Controls.Add(this.label12);
            this.UsersPage.Controls.Add(this.label11);
            this.UsersPage.Controls.Add(this.label10);
            this.UsersPage.Controls.Add(this.label9);
            this.UsersPage.Controls.Add(this.UserID);
            this.UsersPage.Controls.Add(this.Birthday);
            this.UsersPage.Controls.Add(this.Pronouns);
            this.UsersPage.Controls.Add(this.EmailConfirmed);
            this.UsersPage.Controls.Add(this.Role);
            this.UsersPage.Controls.Add(this.Email);
            this.UsersPage.Controls.Add(this.EncryptedPassword);
            this.UsersPage.Controls.Add(this.DiscordUsername);
            this.UsersPage.Controls.Add(this.Username);
            this.UsersPage.Location = new System.Drawing.Point(4, 22);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersPage.Size = new System.Drawing.Size(829, 643);
            this.UsersPage.TabIndex = 1;
            this.UsersPage.Text = "Users";
            // 
            // UsersList
            // 
            this.UsersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersList.ForeColor = System.Drawing.Color.Silver;
            this.UsersList.Location = new System.Drawing.Point(434, 6);
            this.UsersList.Name = "UsersList";
            treeNode4.Name = "Users";
            treeNode4.Text = "Users";
            this.UsersList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.UsersList.Size = new System.Drawing.Size(389, 631);
            this.UsersList.TabIndex = 4;
            this.UsersList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.UsersList_AfterSelect);
            // 
            // UserDelete
            // 
            this.UserDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserDelete.FlatAppearance.BorderSize = 0;
            this.UserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDelete.ForeColor = System.Drawing.Color.Silver;
            this.UserDelete.Location = new System.Drawing.Point(300, 615);
            this.UserDelete.Name = "UserDelete";
            this.UserDelete.Size = new System.Drawing.Size(75, 23);
            this.UserDelete.TabIndex = 24;
            this.UserDelete.Text = "Delete";
            this.UserDelete.UseVisualStyleBackColor = false;
            this.UserDelete.Click += new System.EventHandler(this.UserDelete_Click);
            // 
            // UserUpdate
            // 
            this.UserUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserUpdate.FlatAppearance.BorderSize = 0;
            this.UserUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserUpdate.ForeColor = System.Drawing.Color.Silver;
            this.UserUpdate.Location = new System.Drawing.Point(201, 615);
            this.UserUpdate.Name = "UserUpdate";
            this.UserUpdate.Size = new System.Drawing.Size(75, 23);
            this.UserUpdate.TabIndex = 23;
            this.UserUpdate.Text = "Update";
            this.UserUpdate.UseVisualStyleBackColor = false;
            this.UserUpdate.Click += new System.EventHandler(this.UserUpdate_Click);
            // 
            // UserRead
            // 
            this.UserRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserRead.FlatAppearance.BorderSize = 0;
            this.UserRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserRead.ForeColor = System.Drawing.Color.Silver;
            this.UserRead.Location = new System.Drawing.Point(105, 615);
            this.UserRead.Name = "UserRead";
            this.UserRead.Size = new System.Drawing.Size(75, 23);
            this.UserRead.TabIndex = 22;
            this.UserRead.Text = "Read";
            this.UserRead.UseVisualStyleBackColor = false;
            this.UserRead.Click += new System.EventHandler(this.UserRead_Click);
            // 
            // UserCreate
            // 
            this.UserCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserCreate.FlatAppearance.BorderSize = 0;
            this.UserCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserCreate.ForeColor = System.Drawing.Color.Silver;
            this.UserCreate.Location = new System.Drawing.Point(6, 614);
            this.UserCreate.Name = "UserCreate";
            this.UserCreate.Size = new System.Drawing.Size(75, 23);
            this.UserCreate.TabIndex = 21;
            this.UserCreate.Text = "Create";
            this.UserCreate.UseVisualStyleBackColor = false;
            this.UserCreate.Click += new System.EventHandler(this.UserCreate_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(7, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "User ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(7, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Birthday";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(7, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Pronouns";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(7, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Email Confirmed";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(7, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Role";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(7, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(7, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Encrypted Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(7, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Discord Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(7, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Username";
            // 
            // UserID
            // 
            this.UserID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserID.ForeColor = System.Drawing.Color.Silver;
            this.UserID.Location = new System.Drawing.Point(116, 216);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(300, 16);
            this.UserID.TabIndex = 8;
            this.UserID.ValueChanged += new System.EventHandler(this.UserID_ValueChanged);
            // 
            // Birthday
            // 
            this.Birthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Birthday.CalendarForeColor = System.Drawing.Color.Silver;
            this.Birthday.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Birthday.CalendarTitleForeColor = System.Drawing.Color.Silver;
            this.Birthday.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.Birthday.Location = new System.Drawing.Point(116, 189);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(300, 20);
            this.Birthday.TabIndex = 7;
            this.Birthday.Value = new System.DateTime(2023, 11, 24, 17, 7, 18, 0);
            this.Birthday.ValueChanged += new System.EventHandler(this.Birthday_ValueChanged);
            // 
            // Pronouns
            // 
            this.Pronouns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pronouns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pronouns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pronouns.ForeColor = System.Drawing.Color.Silver;
            this.Pronouns.Location = new System.Drawing.Point(116, 163);
            this.Pronouns.Name = "Pronouns";
            this.Pronouns.Size = new System.Drawing.Size(300, 13);
            this.Pronouns.TabIndex = 6;
            this.Pronouns.TextChanged += new System.EventHandler(this.Pronouns_TextChanged);
            // 
            // EmailConfirmed
            // 
            this.EmailConfirmed.AutoSize = true;
            this.EmailConfirmed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailConfirmed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmailConfirmed.ForeColor = System.Drawing.Color.Black;
            this.EmailConfirmed.Location = new System.Drawing.Point(116, 141);
            this.EmailConfirmed.Name = "EmailConfirmed";
            this.EmailConfirmed.Size = new System.Drawing.Size(12, 11);
            this.EmailConfirmed.TabIndex = 5;
            this.EmailConfirmed.UseVisualStyleBackColor = false;
            this.EmailConfirmed.CheckedChanged += new System.EventHandler(this.EmailConfirmed_CheckedChanged);
            // 
            // Role
            // 
            this.Role.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Role.ForeColor = System.Drawing.Color.Silver;
            this.Role.FormattingEnabled = true;
            this.Role.Items.AddRange(new object[] {
            "user",
            "moderator",
            "admin",
            "staff",
            "owner"});
            this.Role.Location = new System.Drawing.Point(116, 114);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(300, 21);
            this.Role.TabIndex = 4;
            this.Role.SelectedIndexChanged += new System.EventHandler(this.Role_SelectedIndexChanged);
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Email.ForeColor = System.Drawing.Color.Silver;
            this.Email.Location = new System.Drawing.Point(116, 87);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(300, 13);
            this.Email.TabIndex = 3;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // EncryptedPassword
            // 
            this.EncryptedPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptedPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EncryptedPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EncryptedPassword.ForeColor = System.Drawing.Color.Silver;
            this.EncryptedPassword.Location = new System.Drawing.Point(116, 60);
            this.EncryptedPassword.Name = "EncryptedPassword";
            this.EncryptedPassword.Size = new System.Drawing.Size(300, 13);
            this.EncryptedPassword.TabIndex = 2;
            this.EncryptedPassword.TextChanged += new System.EventHandler(this.EncryptedPassword_TextChanged);
            // 
            // DiscordUsername
            // 
            this.DiscordUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscordUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DiscordUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscordUsername.ForeColor = System.Drawing.Color.Silver;
            this.DiscordUsername.Location = new System.Drawing.Point(116, 33);
            this.DiscordUsername.Name = "DiscordUsername";
            this.DiscordUsername.Size = new System.Drawing.Size(300, 13);
            this.DiscordUsername.TabIndex = 1;
            this.DiscordUsername.TextChanged += new System.EventHandler(this.DiscordUsername_TextChanged);
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.ForeColor = System.Drawing.Color.Silver;
            this.Username.Location = new System.Drawing.Point(116, 6);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(300, 13);
            this.Username.TabIndex = 0;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(858, 693);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(874, 732);
            this.Name = "Form1";
            this.Text = "TEC Database Editor";
            this.tabControl1.ResumeLayout(false);
            this.EventPage.ResumeLayout(false);
            this.EventPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventNumber)).EndInit();
            this.UsersPage.ResumeLayout(false);
            this.UsersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EventPage;
        private System.Windows.Forms.TabPage UsersPage;
        private System.Windows.Forms.ComboBox EventType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EventLink;
        private System.Windows.Forms.RichTextBox UserPings;
        private System.Windows.Forms.CheckBox QuestCompatable;
        private System.Windows.Forms.RichTextBox EventDescription;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.NumericUpDown EventNumber;
        private System.Windows.Forms.ComboBox EventRating;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown UserID;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.TextBox Pronouns;
        private System.Windows.Forms.CheckBox EmailConfirmed;
        private System.Windows.Forms.ComboBox Role;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox EncryptedPassword;
        private System.Windows.Forms.TextBox DiscordUsername;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button EventRead;
        private System.Windows.Forms.Button EventCreate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button EventDelete;
        private System.Windows.Forms.TreeView EventsList;
        private System.Windows.Forms.Button EventUpdate;
        private System.Windows.Forms.TreeView UsersList;
        private System.Windows.Forms.Button UserDelete;
        private System.Windows.Forms.Button UserUpdate;
        private System.Windows.Forms.Button UserRead;
        private System.Windows.Forms.Button UserCreate;
        private System.Windows.Forms.DateTimePicker EventDate;
        private System.Windows.Forms.Label label18;
    }
}

