
namespace IPC_Server
{
    partial class ServerForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.listBoxMessageLog = new System.Windows.Forms.ListBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.gbAddUser = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.messageTB = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(238, 7);
            this.hostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(118, 13);
            this.hostLabel.TabIndex = 17;
            this.hostLabel.Text = "\\\\.\\pipe\\myNamedPipe";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(6, 88);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTB.Multiline = true;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(157, 29);
            this.passwordTB.TabIndex = 16;
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(6, 36);
            this.userNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTB.Multiline = true;
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(157, 29);
            this.userNameTB.TabIndex = 15;
            // 
            // listBoxMessageLog
            // 
            this.listBoxMessageLog.FormattingEnabled = true;
            this.listBoxMessageLog.Location = new System.Drawing.Point(11, 25);
            this.listBoxMessageLog.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMessageLog.Name = "listBoxMessageLog";
            this.listBoxMessageLog.Size = new System.Drawing.Size(432, 108);
            this.listBoxMessageLog.TabIndex = 12;
            this.toolTip1.SetToolTip(this.listBoxMessageLog, "Double click to clear messages");
            this.listBoxMessageLog.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMessageLog_MouseDoubleClick);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(11, 137);
            this.btnStartServer.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(432, 26);
            this.btnStartServer.TabIndex = 11;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // gbAddUser
            // 
            this.gbAddUser.Controls.Add(this.label5);
            this.gbAddUser.Controls.Add(this.listBoxUsers);
            this.gbAddUser.Controls.Add(this.btnAddUser);
            this.gbAddUser.Controls.Add(this.userNameTB);
            this.gbAddUser.Controls.Add(this.passwordTB);
            this.gbAddUser.Controls.Add(this.label3);
            this.gbAddUser.Controls.Add(this.label2);
            this.gbAddUser.Location = new System.Drawing.Point(11, 169);
            this.gbAddUser.Name = "gbAddUser";
            this.gbAddUser.Size = new System.Drawing.Size(432, 168);
            this.gbAddUser.TabIndex = 22;
            this.gbAddUser.TabStop = false;
            this.gbAddUser.Text = "Users";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Users displayed as: username:password";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(168, 36);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(253, 121);
            this.listBoxUsers.TabIndex = 23;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(6, 128);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(157, 29);
            this.btnAddUser.TabIndex = 20;
            this.btnAddUser.Text = "AddUser";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Message Log";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Host:";
            // 
            // messageTB
            // 
            this.messageTB.Location = new System.Drawing.Point(11, 343);
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(297, 20);
            this.messageTB.TabIndex = 26;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(314, 341);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(129, 23);
            this.btnSendMessage.TabIndex = 27;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 372);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.messageTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbAddUser);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.listBoxMessageLog);
            this.Controls.Add(this.btnStartServer);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.gbAddUser.ResumeLayout(false);
            this.gbAddUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.ListBox listBoxMessageLog;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.GroupBox gbAddUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox messageTB;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

