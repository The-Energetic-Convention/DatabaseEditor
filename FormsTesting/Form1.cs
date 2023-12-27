using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Windows.Forms;
using TECDataClasses;
using Newtonsoft.Json;
using System.Threading;

namespace FormsTesting
{
    public partial class Form1 : Form
    {
        NamedPipeClientStream pipeClient;
        string authKey = Environment.GetEnvironmentVariable("TECKEY");
        bool eventUnsavedChanges = false;
        bool userUnsavedChanges = false;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (eventUnsavedChanges||userUnsavedChanges) 
            { 
                var warning = new WarningWindow("Warning! You have unsaved changes! Would you still like to exit?", "exit", "return");
                var result = warning.ShowDialog();
                if (result == DialogResult.Yes) { e.Cancel = false; }
                else if (result == DialogResult.No) { e.Cancel = true; }
                else { throw new Exception("Incorrect dialog result returned!"); }
            }
            base.OnFormClosing(e);
        }

        private StreamString ConnectClient()
        {
            try
            {
                pipeClient = new NamedPipeClientStream(".", "TECDatabasePipe", PipeDirection.InOut, PipeOptions.None);
                pipeClient.Connect();
                var ss = new StreamString(pipeClient);
                Console.WriteLine("Authorizing");
                ss.WriteString(authKey);
                if (ss.ReadString() != authKey) { ss.WriteString("Unauthorized server!"); throw new Exception("Unauthorized server connection attemted!"); }

                return ss;
            }
            catch (Exception e) { Console.WriteLine(e.Message); return null; }
        }

        private void CheckResponse(StreamString ss)
        {
            if (ss.ReadString() != "READY") { throw new Exception("Server Error"); }
        }

        #region Event Buttons
        private void EventCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Interact with database app to create an event
                var ss = ConnectClient();

                // tell the server we are creating
                ss.WriteString("C");
                CheckResponse(ss);

                // tell the server it is an event
                ss.WriteString("E");
                CheckResponse(ss);

                // send the event info to create
                EventInfo _event = new EventInfo(
                    (int)EventNumber.Value,
                    EventName.Text,
                    EventDescription.Text,
                    (EventType)EventType.SelectedIndex,
                    QuestCompatable.Checked,
                    JsonConvert.SerializeObject(UserPings.Lines),
                    EventLink.Text,
                    (EventRating)EventRating.SelectedIndex, 
                    EventDate.Value);
                ss.WriteString(JsonConvert.SerializeObject(_event));
                if (ss.ReadString() != "SUCCESS") { throw new Exception("Server Error"); }

                pipeClient.Close();

                EventNumber.Value++;
                EventName.Text = "";
                EventDescription.Text = "";
                EventType.SelectedIndex = 0;
                QuestCompatable.Checked = true;
                UserPings.Text = "";
                EventLink.Text = "";
                EventRating.SelectedIndex = 0;

                EventRead_Click(sender, e);
                eventUnsavedChanges = false;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void EventRead_Click(object sender, EventArgs e)
        {
            // Interact with database app to read events
            // and display the events in the EventsList tree view
            var ss = ConnectClient();

            // tell the server we are reading
            ss.WriteString("R");
            CheckResponse(ss);

            // tell the server it is an event
            ss.WriteString("E");
            CheckResponse(ss);

            ss.WriteString("ALL");
            EventInfo[] events = JsonConvert.DeserializeObject<EventInfo[]>(ss.ReadString());
            if (ss.ReadString() != "SUCCESS") { throw new Exception("Server Error"); }

            // build the node tree
            TreeNode eventTree = new TreeNode("Events");
            foreach (EventInfo _event in events)
            {
                TreeNode number      = new TreeNode($"ID={_event.EventNumber}");
                TreeNode name        = new TreeNode(_event.EventName);
                TreeNode description = new TreeNode(_event.EventDescription);
                TreeNode type        = new TreeNode(JsonConvert.SerializeObject(_event.EventType));
                TreeNode quest       = new TreeNode(JsonConvert.SerializeObject(_event.QuestCompatable));
                TreeNode pings       = new TreeNode("UserPings");
                TreeNode link        = new TreeNode(_event.EventLink);
                TreeNode rating      = new TreeNode(JsonConvert.SerializeObject(_event.EventRating));
                TreeNode date        = new TreeNode(_event.EventDate.ToString("dd/MM/yyyy hh:mm tt"));

                foreach (string ping in JsonConvert.DeserializeObject<string[]>(_event.UserPings))
                {
                    pings.Nodes.Add(new TreeNode(ping));
                }
                

                number.Nodes.Add(new TreeNode("EventName",        new TreeNode[] { name         }));
                number.Nodes.Add(new TreeNode("EventDescription", new TreeNode[] { description  }));
                number.Nodes.Add(new TreeNode("EventType",        new TreeNode[] { type         }));
                number.Nodes.Add(new TreeNode("QuestCompatable",  new TreeNode[] { quest        }));
                number.Nodes.Add(                                                  pings          );
                number.Nodes.Add(new TreeNode("EventLink",        new TreeNode[] { link         }));
                number.Nodes.Add(new TreeNode("EventRating",      new TreeNode[] { rating       }));
                number.Nodes.Add(new TreeNode("EventDate",        new TreeNode[] { date         }));

                eventTree.Nodes.Add(number);
            }

            // clear the current tree and add the new one
            EventsList.Nodes.Clear();
            eventTree.Expand();
            EventsList.Nodes.Add(eventTree);


            pipeClient.Close();
            eventUnsavedChanges = false;
        }

        private void EventUpdate_Click(object sender, EventArgs e)
        {
            // Interact with database app to update an event
            var ss = ConnectClient();

            // tell the server we are creating
            ss.WriteString("U");
            CheckResponse(ss);

            // tell the server it is an event
            ss.WriteString("E");
            CheckResponse(ss);

            // send the event info to create
            EventInfo _event = new EventInfo(
                (int)EventNumber.Value,
                EventName.Text,
                EventDescription.Text,
                (EventType)EventType.SelectedIndex,
                QuestCompatable.Checked,
                JsonConvert.SerializeObject(UserPings.Lines),
                EventLink.Text,
                (EventRating)EventRating.SelectedIndex,
                EventDate.Value);
            ss.WriteString(JsonConvert.SerializeObject(_event));
            if (ss.ReadString() != "SUCCESS") { throw new Exception("Server Error"); }

            pipeClient.Close();

            EventNumber.Value = 0;
            EventName.Text = "";
            EventDescription.Text = "";
            EventType.SelectedIndex = 0;
            QuestCompatable.Checked = true;
            UserPings.Text = "";
            EventLink.Text = "";
            EventRating.SelectedIndex = 0;

            EventRead_Click(sender, e);
            eventUnsavedChanges = false;
        }

        private void EventDelete_Click(object sender, EventArgs e)
        {
            // Interact with database app to delete an event
            var ss = ConnectClient();

            // tell the server we are creating
            ss.WriteString("D");
            CheckResponse(ss);

            // tell the server it is an event
            ss.WriteString("E");
            CheckResponse(ss);

            // send the event info to create
            EventInfo _event = new EventInfo(
                (int)EventNumber.Value,
                EventName.Text,
                EventDescription.Text,
                (EventType)EventType.SelectedIndex,
                QuestCompatable.Checked,
                JsonConvert.SerializeObject(UserPings.Lines),
                EventLink.Text,
                (EventRating)EventRating.SelectedIndex,
                EventDate.Value);
            ss.WriteString(JsonConvert.SerializeObject(_event));
            if (ss.ReadString() != "SUCCESS") { throw new Exception("Server Error"); }

            pipeClient.Close();

            EventNumber.Value = 0;
            EventName.Text = "";
            EventDescription.Text = "";
            EventType.SelectedIndex = 0;
            QuestCompatable.Checked = true;
            UserPings.Text = "";
            EventLink.Text = "";
            EventRating.SelectedIndex = 0;

            EventRead_Click(sender, e);
            eventUnsavedChanges = false;
        }
        #endregion

        #region User Buttons
        private void UserCreate_Click(object sender, EventArgs e)
        {
            // Interact with database app to create a user
            var ss = ConnectClient();

            // tell the server we are creating
            ss.WriteString("C");
            CheckResponse(ss);

            // tell the server it is an event
            ss.WriteString("U");
            CheckResponse(ss);

            // send the event info to create
            UserData user = new UserData(
                Username.Text,
                DiscordUsername.Text,
                EncryptedPassword.Text,
                Email.Text,
                (UserRole)Role.SelectedIndex,
                EmailConfirmed.Checked,
                Pronouns.Text,
                Birthday.Value,
                (int)UserID.Value);
            ss.WriteString(JsonConvert.SerializeObject(user));
            if (ss.ReadString() != "SUCCESS") { throw new Exception("Server Error"); }

            pipeClient.Close();

            Username.Text = "";
            DiscordUsername.Text = "";
            EncryptedPassword.Text = "";
            Email.Text = "";
            Role.SelectedIndex = 0;
            EmailConfirmed.Checked = false;
            Pronouns.Text = "";
            UserID.Value++;

            UserRead_Click(sender, e);
            userUnsavedChanges = false;
        }

        private void UserRead_Click(object sender, EventArgs e)
        {
            // Interact with database app to read users
            // and display the users in the UsersList tree view
            Console.WriteLine("Connecting");
            var ss = ConnectClient();

            Console.WriteLine("read");
            // tell the server we are reading
            ss.WriteString("R");
            CheckResponse(ss);

            Console.WriteLine("user");
            // tell the server it is an user
            ss.WriteString("U");
            CheckResponse(ss);

            Console.WriteLine("all");
            ss.WriteString("ALL");
            LocalUserData[] users = new LocalUserData[1];

            Console.WriteLine("deserialize");
            users = JsonConvert.DeserializeObject<LocalUserData[]>(ss.ReadString());

            Console.WriteLine("success");
            if (ss.ReadString() != "SUCCESS") { throw new Exception("Server Error"); }

            Console.WriteLine("building tree");
            // build the node tree
            TreeNode userTree = new TreeNode("Users");
            foreach (LocalUserData user in users)
            {
                Console.WriteLine("next user nodes");
                TreeNode number   = new TreeNode($"ID={user.userID}");
                TreeNode username = new TreeNode(user.username);
                TreeNode discord  = new TreeNode(user.discordUsername);
                TreeNode pass     = new TreeNode(user.encryptedPassword);
                TreeNode email    = new TreeNode(user.email);
                TreeNode role     = new TreeNode(JsonConvert.SerializeObject(user.role));
                TreeNode econfirm = new TreeNode(JsonConvert.SerializeObject(user.emailConfirmed));
                TreeNode pronouns = new TreeNode(user.pronouns);
                TreeNode birthday = new TreeNode(user.birthday.ToString("dd/MM/yyyy"));

                Console.WriteLine("adding nodes");
                number.Nodes.Add(new TreeNode("Username",          new TreeNode[] { username }));
                number.Nodes.Add(new TreeNode("DiscordUsername",   new TreeNode[] { discord  }));
                number.Nodes.Add(new TreeNode("EncryptedPassword", new TreeNode[] { pass     }));
                number.Nodes.Add(new TreeNode("Email",             new TreeNode[] { email    }));
                number.Nodes.Add(new TreeNode("UserRole",          new TreeNode[] { role     }));
                number.Nodes.Add(new TreeNode("EmailConfirmed",    new TreeNode[] { econfirm }));
                number.Nodes.Add(new TreeNode("Pronouns",          new TreeNode[] { pronouns }));
                number.Nodes.Add(new TreeNode("Birthday",          new TreeNode[] { birthday }));

                Console.WriteLine("add to tree");
                userTree.Nodes.Add(number);
            }

            Console.WriteLine("clear and refresh");
            // clear the current tree and add the new one
            UsersList.Nodes.Clear();
            userTree.Expand();
            UsersList.Nodes.Add(userTree);

            Console.WriteLine("close and done");
            pipeClient.Close();
            userUnsavedChanges = false;
        }

        private void UserUpdate_Click(object sender, EventArgs e)
        {
            // Interact with database app to update a user
            var ss = ConnectClient();

            // tell the server we are creating
            ss.WriteString("U");
            CheckResponse(ss);

            // tell the server it is an event
            ss.WriteString("U");
            CheckResponse(ss);

            // send the event info to create
            UserData user = new UserData(
                Username.Text,
                DiscordUsername.Text,
                EncryptedPassword.Text,
                Email.Text,
                (UserRole)Role.SelectedIndex,
                EmailConfirmed.Checked,
                Pronouns.Text,
                Birthday.Value,
                (int)UserID.Value);
            ss.WriteString(JsonConvert.SerializeObject(user));
            if (ss.ReadString() != "SUCCESS") { throw new Exception("Server Error"); }

            pipeClient.Close();

            Username.Text = "";
            DiscordUsername.Text = "";
            EncryptedPassword.Text = "";
            Email.Text = "";
            Role.SelectedIndex = 0;
            EmailConfirmed.Checked = false;
            Pronouns.Text = "";
            UserID.Value = 0;

            UserRead_Click(sender, e);
            userUnsavedChanges = false;
        }

        private void UserDelete_Click(object sender, EventArgs e)
        {
            // Interact with database app to delete a user
            var ss = ConnectClient();

            // tell the server we are creating
            ss.WriteString("D");
            CheckResponse(ss);

            // tell the server it is an event
            ss.WriteString("U");
            CheckResponse(ss);

            // send the event info to create
            UserData user = new UserData(
                Username.Text,
                DiscordUsername.Text,
                EncryptedPassword.Text,
                Email.Text,
                (UserRole)Role.SelectedIndex,
                EmailConfirmed.Checked,
                Pronouns.Text,
                Birthday.Value,
                (int)UserID.Value);
            ss.WriteString(JsonConvert.SerializeObject(user));
            if (ss.ReadString() != "SUCCESS") { throw new Exception("Server Error"); }

            pipeClient.Close();

            Username.Text = "";
            DiscordUsername.Text = "";
            EncryptedPassword.Text = "";
            Email.Text = "";
            Role.SelectedIndex = 0;
            EmailConfirmed.Checked = false;
            Pronouns.Text = "";
            UserID.Value = 0;

            UserRead_Click(sender, e);
            userUnsavedChanges = false;
        }
        #endregion

        #region List Interactions
        private void EventsList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // make sure we are selecting a specific event
            // and put that events info into the fields
            if (eventUnsavedChanges)
            {
                var warning = new WarningWindow("Warning! You have unsaved changes! Would you still like to select this event?", "select", "return");
                var result = warning.ShowDialog();
                if (result == DialogResult.Yes) { /* no need to do anything, just continue */ }
                else if (result == DialogResult.No) { return; }
                else { throw new Exception("Incorrect dialog result returned!"); }
            }

            if (!e.Node.Text.StartsWith("ID=")) { return; }

            TreeNodeCollection nodes = e.Node.Nodes;
            TreeNode number = e.Node;
            TreeNode name        = nodes[0].Nodes[0];
            TreeNode description = nodes[1].Nodes[0];
            TreeNode type        = nodes[2].Nodes[0];
            TreeNode quest       = nodes[3].Nodes[0];
            TreeNode pings       = nodes[4];
            TreeNode link        = nodes[5].Nodes[0];
            TreeNode rating      = nodes[6].Nodes[0];
            TreeNode date        = nodes[7].Nodes[0];

            string[] pinglist = new string[pings.Nodes.Count];
            int i = 0;
            foreach (TreeNode ping in pings.Nodes)
            {
                pinglist[i] = ping.Text;
                i++;
            }

            EventNumber.Value = decimal.Parse( number.Text.Replace("ID=", ""));
            EventName.Text = name.Text;
            EventDescription.Text = description.Text;
            EventType.SelectedIndex = (int)JsonConvert.DeserializeObject<EventType>(type.Text);
            QuestCompatable.Checked = JsonConvert.DeserializeObject<bool>(quest.Text);
            UserPings.Lines = pinglist;
            EventLink.Text = link.Text;
            EventRating.SelectedIndex = (int)JsonConvert.DeserializeObject<EventRating>(rating.Text);
            EventDate.Value = DateTime.ParseExact(date.Text, "dd/MM/yyyy hh:mm tt", null);

            eventUnsavedChanges = false;
        }

        private void UsersList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // make sure we are selecting a specific user
            // and put that users info into the fields
            if (userUnsavedChanges)
            {
                var warning = new WarningWindow("Warning! You have unsaved changes! Would you still like to select this user?", "select", "return");
                var result = warning.ShowDialog();
                if (result == DialogResult.Yes) { /* no need to do anything, just continue */ }
                else if (result == DialogResult.No) { return; }
                else { throw new Exception("Incorrect dialog result returned!"); }
            }

            if (!e.Node.Text.StartsWith("ID=")) { return; }

            TreeNodeCollection nodes = e.Node.Nodes;
            TreeNode number = e.Node;
            TreeNode username = nodes[0].Nodes[0];
            TreeNode discord = nodes[1].Nodes[0];
            TreeNode pass = nodes[2].Nodes[0];
            TreeNode email = nodes[3].Nodes[0];
            TreeNode role = nodes[4].Nodes[0];
            TreeNode econfirm = nodes[5].Nodes[0];
            TreeNode pronouns = nodes[6].Nodes[0];
            TreeNode birthday = nodes[7].Nodes[0];

            Username.Text = username.Text;
            DiscordUsername.Text = discord.Text;
            EncryptedPassword.Text = pass.Text;
            Email.Text = email.Text;
            Role.SelectedIndex = (int)JsonConvert.DeserializeObject<UserRole>(role.Text);
            EmailConfirmed.Checked = JsonConvert.DeserializeObject<bool>(econfirm.Text);
            Pronouns.Text = pronouns.Text;
            Birthday.Value = DateTime.ParseExact(birthday.Text, "dd/MM/yyyy", null);
            UserID.Value = decimal.Parse(number.Text.Replace("ID=", ""));

            userUnsavedChanges = false;
        }
        #endregion

        #region Event Fields Changed
        private void EventNumber_ValueChanged(object sender, EventArgs e)
        {
            eventUnsavedChanges = true;
        }

        private void EventName_TextChanged(object sender, EventArgs e)
        {
            eventUnsavedChanges = true;
        }

        private void EventDescription_TextChanged(object sender, EventArgs e)
        {
            eventUnsavedChanges = true;
        }

        private void EventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventUnsavedChanges = true;
        }

        private void QuestCompatable_CheckedChanged(object sender, EventArgs e)
        {
            eventUnsavedChanges = true;
        }

        private void UserPings_TextChanged(object sender, EventArgs e)
        {
            eventUnsavedChanges = true;
        }

        private void EventLink_TextChanged(object sender, EventArgs e)
        {
            eventUnsavedChanges = true;
        }

        private void EventRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventUnsavedChanges = true;
        }

        private void EventDate_ValueChanged(object sender, EventArgs e)
        {
            userUnsavedChanges = true;
        }
        #endregion

        #region User Fields Changed
        private void Username_TextChanged(object sender, EventArgs e)
        {
            userUnsavedChanges = true;
        }

        private void DiscordUsername_TextChanged(object sender, EventArgs e)
        {
            userUnsavedChanges = true;
        }

        private void EncryptedPassword_TextChanged(object sender, EventArgs e)
        {
            userUnsavedChanges = true;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            userUnsavedChanges = true;
        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            userUnsavedChanges = true;
        }

        private void EmailConfirmed_CheckedChanged(object sender, EventArgs e)
        {
            userUnsavedChanges = true;
        }

        private void Pronouns_TextChanged(object sender, EventArgs e)
        {
            userUnsavedChanges = true;
        }

        private void Birthday_ValueChanged(object sender, EventArgs e)
        {
            userUnsavedChanges = true;
        }

        private void UserID_ValueChanged(object sender, EventArgs e)
        {
            userUnsavedChanges = true;
        }
        #endregion
    }

    public class StreamString
    {
        private Stream ioStream;
        private UnicodeEncoding streamEncoding;

        public StreamString(Stream ioStream)
        {
            this.ioStream = ioStream;
            streamEncoding = new UnicodeEncoding();
        }

        public string ReadString()
        {
            int i = 0;
            tryread:
            int len;
            len = ioStream.ReadByte() * 256;
            len += ioStream.ReadByte();
            Thread.Sleep(100);
            if (len<0 && i<10) { i++; goto tryread; }
            var inBuffer = new byte[len];
            ioStream.Read(inBuffer, 0, len);

            return streamEncoding.GetString(inBuffer);
        }

        public int WriteString(string outString)
        {
            byte[] outBuffer = streamEncoding.GetBytes(outString);
            int len = outBuffer.Length;
            if (len > UInt16.MaxValue)
            {
                len = (int)UInt16.MaxValue;
            }
            ioStream.WriteByte((byte)(len / 256));
            ioStream.WriteByte((byte)(len & 255));
            ioStream.Write(outBuffer, 0, len);
            ioStream.Flush();

            return outBuffer.Length + 2;
        }
    }

    public class LocalUserData
    {
        public string username { get; set; }

        public string discordUsername { get; set; }

        public string encryptedPassword { get; set; }

        public string email { get; set; }

        public UserRole role { get; set; }

        public bool emailConfirmed { get; set; }

        public string pronouns { get; set; }

        public DateTime birthday { get; set; }

        public int userID { get; set; }

        public LocalUserData(string username, string discordUsername, string encryptedPassword, string email, UserRole role, bool emailConfirmed, string pronouns, DateTime birthday, int userID)
        {
            this.username = username;
            this.discordUsername = discordUsername;
            this.encryptedPassword = encryptedPassword;
            this.email = email;
            this.role = role;
            this.emailConfirmed = emailConfirmed;
            this.pronouns = pronouns;
            this.birthday = birthday;
            this.userID = userID;
        }
    }
}
