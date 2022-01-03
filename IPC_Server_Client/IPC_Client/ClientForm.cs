using System;
using System.Text;
using System.Windows.Forms;

/* 
 * Nathan Tai
 * P148535
 * 15/04/2021
 * Programming III, Activity 4
 * Inter-process Communication: Client Side
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

namespace IPC_Client
{
    public partial class ClientForm : Form
    {
        #region Globals

        //Encoder for sending messages
        ASCIIEncoding encoder = new ASCIIEncoding();

        //Instantiate Client
        private Client pipeClient;

        public ClientForm()
        {
            InitializeComponent();
            CreateNewPipeClient();
            disableButtons();
        }

        //Disable buttons to avoid errors
        void disableButtons()
        {
            btnLogin.Enabled = false;
            btnLogout.Enabled = false;
            btnSend.Enabled = false;
            btnShowUsers.Enabled = false;
        }

        #endregion Globals

        #region Pipe

        //New pipe for server connection
        void CreateNewPipeClient()
        {
            if (pipeClient != null)
            {
                pipeClient.MessageReceived -= pipeClient_MessageReceived;
                pipeClient.ServerDisconnected -= pipeClient_ServerDisconnected;
            }

            pipeClient = new Client();
            pipeClient.MessageReceived += pipeClient_MessageReceived;
            pipeClient.ServerDisconnected += pipeClient_ServerDisconnected;
        }

        //Execute EnableStartButton method when connection lost
        void pipeClient_ServerDisconnected()
        {
            Invoke(new Client.ServerDisconnectedHandler(EnableStartButton));
        }

        //Enable buttons
        void EnableStartButton()
        {
            btnConnect.Enabled = true;
            btnLogin.Enabled = true;
        }

        //Receives server messages
        void pipeClient_MessageReceived(byte[] message)
        {
            Invoke(new Client.MessageReceivedHandler(DisplayReceivedMessage),
                new object[] { message });
        }

        //Display server messages in listBoxMessageLog
        void DisplayReceivedMessage(byte[] message)
        {
            string str = encoder.GetString(message, 0, message.Length);
            string login = hostName.Text + ":" + userNameTB.Text + ":" + passwordTB.Text;

            if (str.Contains("logged in"))
            {
                btnLogin.Enabled = false;
                btnSend.Enabled = true;
                btnLogout.Enabled = true;
            }
            if (str == "admin logged in.")
            {
                btnShowUsers.Enabled = true;
                btnLogout.Enabled = true;
            }
            if (str == "logout")
            {
                disableButtons();
                listBoxMessageLog.Items.Clear();
                messageTB.Clear();
                str = "You have been logged out.";
                btnLogin.Enabled = true;
            }

            listBoxMessageLog.Items.Add(str);
        }

        #endregion Pipe

        #region Buttons

        //Attempts server connection using host name in label shown on the form
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string login = hostName.Text;

            pipeClient.Connect(login);

            if (pipeClient.Connected)
            {
                btnLogin.Enabled = true;
                MessageBox.Show("Connection Successful.");
                btnConnect.Enabled = false;
                btnLogin.Enabled = true;
            }
            else
            {
                MessageBox.Show("Connection Failed.");
            }
        }

        //Attempts login with user entered details
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (userNameTB.Text != "")
            {
                string check = userNameTB.Text + ":" + passwordTB.Text;
                pipeClient.SendMessage(encoder.GetBytes(check));
                userNameTB.Clear();
                passwordTB.Clear();
            }
            else
            {
                MessageBox.Show("Please input Username and Password.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pipeClient.SendMessage(encoder.GetBytes("logout"));
            btnLogout.Enabled = false;
            btnShowUsers.Enabled = false;
            listBoxMessageLog.Items.Clear();
            userNameTB.Clear();
            passwordTB.Clear();
        }

        //Send message to server
        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = messageTB.Text;
            pipeClient.SendMessage(encoder.GetBytes(message));
            messageTB.Clear();
        }

        //Show users if logged in as admin
        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            pipeClient.SendMessage(encoder.GetBytes("show users"));
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
    }
}
