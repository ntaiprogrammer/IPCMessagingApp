
namespace IPC_Client
{
    partial class ClientForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.messageTB = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.listBoxMessageLog = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hostName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(173, 155);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(167, 30);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // messageTB
            // 
            this.messageTB.Location = new System.Drawing.Point(11, 155);
            this.messageTB.Multiline = true;
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(156, 30);
            this.messageTB.TabIndex = 23;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(165, 18);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 29);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Username";
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Location = new System.Drawing.Point(185, 9);
            this.Host.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(32, 13);
            this.Host.TabIndex = 19;
            this.Host.Text = "Host:";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(5, 82);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTB.Multiline = true;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(156, 29);
            this.passwordTB.TabIndex = 18;
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(5, 29);
            this.userNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTB.Multiline = true;
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(156, 29);
            this.userNameTB.TabIndex = 17;
            // 
            // listBoxMessageLog
            // 
            this.listBoxMessageLog.FormattingEnabled = true;
            this.listBoxMessageLog.Location = new System.Drawing.Point(11, 26);
            this.listBoxMessageLog.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMessageLog.Name = "listBoxMessageLog";
            this.listBoxMessageLog.Size = new System.Drawing.Size(329, 121);
            this.listBoxMessageLog.TabIndex = 13;
            this.toolTip1.SetToolTip(this.listBoxMessageLog, "Double click to clear messages");
            this.listBoxMessageLog.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMessageLog_MouseDoubleClick);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConnect.Location = new System.Drawing.Point(165, 82);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(156, 29);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect to Server";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(165, 52);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(75, 23);
            this.btnShowUsers.TabIndex = 26;
            this.btnShowUsers.Text = "Show Users";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(246, 52);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userNameTB);
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.passwordTB);
            this.groupBox1.Controls.Add(this.btnShowUsers);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(6, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 120);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Message Log";
            // 
            // hostName
            // 
            this.hostName.AutoSize = true;
            this.hostName.Location = new System.Drawing.Point(222, 9);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(118, 13);
            this.hostName.TabIndex = 30;
            this.hostName.Text = "\\\\.\\pipe\\myNamedPipe";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 320);
            this.Controls.Add(this.hostName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.listBoxMessageLog);
            this.Controls.Add(this.messageTB);
            this.Controls.Add(this.btnSend);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox messageTB;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.ListBox listBoxMessageLog;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hostName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

