using System;
using System.Collections;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

/* 
 * Nathan Tai
 * P148535
 * 15/04/2021
 * Programming III, Activity 4
 * Inter-process Communication: Server Side
 * 
 * Requirements:
 * "JMC wishes to have a standard login functionality 
 * for all their terminals around the ship, this should 
 * be accomplished via logging into a central server to 
 * test user and password combinations (you must have at 
 * least one administrator password setup). You must create 
 * a Server Client program it must use IPC to communicate. 
 * Your program must have a login that uses standard hashing 
 * techniques."
 */

namespace IPC_Server
{
    public partial class ServerForm : Form
    {
        #region Globals

        //Encoder for sending messages
        ASCIIEncoding encoder = new ASCIIEncoding();

        //Instantiate Server
        private Server server = new Server();

        //Arraylist for logins
        ArrayList loginList = new ArrayList();

        //Add some existing users
        public void listPreFill()
        {
            loginList.Add("user:password");
            loginList.Add("admin:admin");
        }

        #endregion Globals

        #region Pipe

        //Form initialises
        public ServerForm()
        {
            InitializeComponent();
            server.MessageReceived += pipeServer_MessageReceived;
            server.ClientDisconnected += pipeServer_ClientDisconnected;

            //prefill some users
            listPreFill();

            //fill listbox with existing users, hash passwords before displaying
            foreach (string login in loginList)
            {
                string[] logins = login.Split(':');
                string display = logins[0] + ":" + hashPassword(logins[1]);
                listBoxUsers.Items.Add(display);
            }
        }

        //Executes ClientDisconnected method
        void pipeServer_ClientDisconnected()
        {
            Invoke(new Server.ClientDisconnectedHandler(ClientDisconnected));
        }

        //Server notified when a client disconnects, display number of connected clients
        void ClientDisconnected()
        {
            listBoxMessageLog.Items.Add(server.TotalConnectedClients + " clients connected.");
        }

        //Receives messages from client
        void pipeServer_MessageReceived(byte[] message)
        {
            Invoke(new Server.MessageReceivedHandler(DisplayMessageReceived),
                new object[] { message });
        }

        //Display client messages in listBoxMessageLog
        void DisplayMessageReceived(byte[] message)
        {
            string messageReceived = encoder.GetString(message, 0, message.Length);

            //If request from admin account to display users
            if (messageReceived.Equals("show users"))
            {
                byte[] mBuff2 = encoder.GetBytes("Displaying users");
                server.SendMessage(mBuff2);

                foreach (string login in loginList)
                {
                    string[] splitInfo = login.Split(':');

                    //login details into strings
                    string userNameReceived = splitInfo[0];
                    string passwordReceived = splitInfo[1];

                    //strings for display
                    string userPrint = "Username: " + userNameReceived;
                    string passwordPrint = "Password: " + (hashPassword(passwordReceived));

                    byte[] sendUser = encoder.GetBytes(userPrint);
                    server.SendMessage(sendUser);

                    byte[] sendPassword = encoder.GetBytes(passwordPrint);
                    server.SendMessage(sendPassword);
                }
            }
            //User request to logout
            else if (messageReceived.Equals("logout"))
            {
                //send string to trigger user logout process
                byte[] mBuff = encoder.GetBytes("logout");
                server.SendMessage(mBuff);
                listBoxMessageLog.Items.Add("user logged out.");
            }
            //User login attempt
            else if (messageReceived.Contains(":")) //colon indicates concatenated user/password string
            {
                //Split concatenated login string (user:password)
                string[] splitInfo = messageReceived.Split(':');

                //login details into strings
                string userNameReceived = splitInfo[0];
                string passwordReceived = splitInfo[1];

                //strings for display
                string userPrint = "Username: " + userNameReceived;
                string passwordPrint = "Password: " + (hashPassword(passwordReceived));

                //add to listbox
                listBoxMessageLog.Items.Add(userPrint);
                listBoxMessageLog.Items.Add(passwordPrint);

                //Check users array for matching user
                foreach (string login in loginList)
                {
                    if (messageReceived.Equals(login))
                    {
                        byte[] mBuff = encoder.GetBytes(userNameReceived + " logged in.");
                        server.SendMessage(mBuff);
                        if (messageReceived.Equals("admin:admin"))
                        {
                            byte[] mBuff2 = encoder.GetBytes("Admin privileges enabled.");
                            server.SendMessage(mBuff2);
                        }
                        return;
                    }
                }
                //If not found or wrong details
                byte[] mBuff1 = encoder.GetBytes("Login details incorrect");
                server.SendMessage(mBuff1);
            }
            //Recieving a normal message
            else
            {
                listBoxMessageLog.Items.Add(messageReceived);
            }
        }

        #endregion Pipe

        #region Buttons

        //Starts server
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            //Get host name from label on form
            string login = hostLabel.Text;

            //Start server
            if (!server.Running)
            {
                server.Start(login);

                btnStartServer.Enabled = false;
            }
            //If already running
            else
            {
                MessageBox.Show("Server already running.");
            }
        }

        //Send message to client
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            byte[] mBuff1 = encoder.GetBytes(messageTB.Text);
            server.SendMessage(mBuff1);
            messageTB.Clear();
        }

        //Add users to the user arraylist
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //Checks for empty fields
            if (!string.IsNullOrEmpty(userNameTB.Text) && !string.IsNullOrEmpty(passwordTB.Text))
            {
                //name and password into strings
                string user = userNameTB.Text;
                string password = passwordTB.Text;

                //Concatenate, add to arraylist
                loginList.Add(user + ":" + password);

                //Hash password and format display string for message log
                string confirmation = "User added. \n Username: " + user + "\n Password: " + hashPassword(password);
                listBoxMessageLog.Items.Add(confirmation);

                //Clear users listbox
                listBoxUsers.Items.Clear();

                //Add each item from arraylist to users listbox, display all users with passwords hashed
                foreach (string login in loginList)
                {
                    string[] logins = login.Split(':');
                    string display = logins[0] + ":" + hashPassword(logins[1]);
                    listBoxUsers.Items.Add(display);
                }
                //Clear username and password fields
                userNameTB.Clear();
                passwordTB.Clear();
            }
            //If fields empty
            else
            {
                MessageBox.Show("Username or password blank.");
            }
        }

        //Double click to clear messages
        void listBoxMessageLog_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Clear messages?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                listBoxMessageLog.Items.Clear();
            }
        }

        #endregion Buttons

        #region Hashing

        //Generates salt
        public string GenerateSalt()
        {
            var bytes = new byte[128 / 8];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        //Compute hash using generated salt
        public string ComputeHash(byte[] bytesToHash, byte[] salt)
        {
            var byteResult = new Rfc2898DeriveBytes(bytesToHash, salt, 10000);
            return Convert.ToBase64String(byteResult.GetBytes(24));
        }

        //Method for hashing passwords
        public string hashPassword(string password)
        {
            var newSalt = GenerateSalt();
            var hashedPassword = ComputeHash(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(newSalt));
            return hashedPassword;
        }

        #endregion Hashing
    }
}
