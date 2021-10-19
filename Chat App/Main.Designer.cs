
namespace Chat_App
{
    partial class ChatApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatApp));
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_DebugFrom = new System.Windows.Forms.ListBox();
            this.listBox_DebugText = new System.Windows.Forms.ListBox();
            this.listBox_DebugTimestamp = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_Messages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listBox_DebugUID = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_Profile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Username = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClearChats = new System.Windows.Forms.Button();
            this.label_Other_Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messagesPanel = new System.Windows.Forms.Panel();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label_Debug = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Panel_Debug = new System.Windows.Forms.Panel();
            this.label_Debug_Active = new System.Windows.Forms.Label();
            this.label_DebugActiveIndex = new System.Windows.Forms.Label();
            this.contextMenuStrip_Messages.SuspendLayout();
            this.chatPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.contextMenuStrip_Profile.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.messagesPanel.SuspendLayout();
            this.Panel_Debug.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxUsers.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUsers.ForeColor = System.Drawing.Color.Black;
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.ItemHeight = 21;
            this.listBoxUsers.Items.AddRange(new object[] {
            "All"});
            this.listBoxUsers.Location = new System.Drawing.Point(9, 10);
            this.listBoxUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(167, 231);
            this.listBoxUsers.TabIndex = 6;
            this.listBoxUsers.SelectedValueChanged += new System.EventHandler(this.listBoxUsers_SelectedItemChange);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registered Users";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(16, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 5);
            this.panel1.TabIndex = 10;
            // 
            // listBox_DebugFrom
            // 
            this.listBox_DebugFrom.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_DebugFrom.FormattingEnabled = true;
            this.listBox_DebugFrom.ItemHeight = 16;
            this.listBox_DebugFrom.Location = new System.Drawing.Point(146, 29);
            this.listBox_DebugFrom.Name = "listBox_DebugFrom";
            this.listBox_DebugFrom.Size = new System.Drawing.Size(125, 100);
            this.listBox_DebugFrom.TabIndex = 14;
            // 
            // listBox_DebugText
            // 
            this.listBox_DebugText.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_DebugText.FormattingEnabled = true;
            this.listBox_DebugText.ItemHeight = 16;
            this.listBox_DebugText.Location = new System.Drawing.Point(283, 29);
            this.listBox_DebugText.Name = "listBox_DebugText";
            this.listBox_DebugText.Size = new System.Drawing.Size(125, 100);
            this.listBox_DebugText.TabIndex = 15;
            // 
            // listBox_DebugTimestamp
            // 
            this.listBox_DebugTimestamp.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_DebugTimestamp.FormattingEnabled = true;
            this.listBox_DebugTimestamp.ItemHeight = 16;
            this.listBox_DebugTimestamp.Location = new System.Drawing.Point(420, 29);
            this.listBox_DebugTimestamp.Name = "listBox_DebugTimestamp";
            this.listBox_DebugTimestamp.Size = new System.Drawing.Size(125, 100);
            this.listBox_DebugTimestamp.TabIndex = 16;
            // 
            // contextMenuStrip_Messages
            // 
            this.contextMenuStrip_Messages.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip_Messages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contextMenuStrip_Messages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailsToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip_Messages.Name = "contextMenuStrip_Messages";
            this.contextMenuStrip_Messages.Size = new System.Drawing.Size(138, 48);
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Chat_App.Properties.Resources.i_trash_open_1;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // chatPanel
            // 
            this.chatPanel.BackColor = System.Drawing.Color.Transparent;
            this.chatPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chatPanel.Controls.Add(this.button1);
            this.chatPanel.Controls.Add(this.buttonSend);
            this.chatPanel.Controls.Add(this.textMessage);
            this.chatPanel.Controls.Add(this.button5);
            this.chatPanel.Controls.Add(this.button4);
            this.chatPanel.Controls.Add(this.button2);
            this.chatPanel.Controls.Add(this.button6);
            this.chatPanel.Controls.Add(this.button7);
            this.chatPanel.Controls.Add(this.button8);
            this.chatPanel.ForeColor = System.Drawing.Color.DimGray;
            this.chatPanel.Location = new System.Drawing.Point(-1, 405);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(556, 45);
            this.chatPanel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImage = global::Chat_App.Properties.Resources.i_chat_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(23, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSend.BackgroundImage = global::Chat_App.Properties.Resources.i_send;
            this.buttonSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Location = new System.Drawing.Point(495, 8);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(30, 30);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            this.buttonSend.MouseHover += new System.EventHandler(this.buttonSend_MouseHover);
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.Color.DodgerBlue;
            this.textMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMessage.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.ForeColor = System.Drawing.Color.White;
            this.textMessage.Location = new System.Drawing.Point(72, 12);
            this.textMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(405, 22);
            this.textMessage.TabIndex = 1;
            this.textMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMessage_KeyDown_Enter);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.BackgroundImage = global::Chat_App.Properties.Resources.i_input_dodgerblue_bg;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(193, 7);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 32);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.BackgroundImage = global::Chat_App.Properties.Resources.i_input_dodgerblue_bg;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(317, 7);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 32);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.BackgroundImage = global::Chat_App.Properties.Resources.i_input_dodgerblue_bg;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(60, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 32);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::Chat_App.Properties.Resources.i_input_whitesmoke_bg;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(14, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 45);
            this.button6.TabIndex = 15;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::Chat_App.Properties.Resources.i_input_whitesmoke_bg;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(321, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(219, 45);
            this.button7.TabIndex = 16;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::Chat_App.Properties.Resources.i_input_whitesmoke_bg;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(168, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(219, 45);
            this.button8.TabIndex = 17;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.ForeColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(16, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 5);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.listBoxUsers);
            this.panel5.ForeColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(16, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 250);
            this.panel5.TabIndex = 12;
            // 
            // listBox_DebugUID
            // 
            this.listBox_DebugUID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_DebugUID.FormattingEnabled = true;
            this.listBox_DebugUID.ItemHeight = 16;
            this.listBox_DebugUID.Location = new System.Drawing.Point(9, 29);
            this.listBox_DebugUID.Name = "listBox_DebugUID";
            this.listBox_DebugUID.Size = new System.Drawing.Size(125, 100);
            this.listBox_DebugUID.TabIndex = 16;
            // 
            // contextMenuStrip_Profile
            // 
            this.contextMenuStrip_Profile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.contextMenuStrip_Profile.Name = "contextMenuStrip_Profile";
            this.contextMenuStrip_Profile.Size = new System.Drawing.Size(113, 48);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = global::Chat_App.Properties.Resources.i_user;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Chat_App.Properties.Resources.i_input_whitesmoke_bg;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label_Username);
            this.panel3.ForeColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(16, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 31);
            this.panel3.TabIndex = 11;
            // 
            // label_Username
            // 
            this.label_Username.BackColor = System.Drawing.Color.Transparent;
            this.label_Username.ContextMenuStrip = this.contextMenuStrip_Profile;
            this.label_Username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Username.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.Color.DimGray;
            this.label_Username.Location = new System.Drawing.Point(1, 6);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(182, 19);
            this.label_Username.TabIndex = 19;
            this.label_Username.Text = "Profile";
            this.label_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Chat_App.Properties.Resources.i_input_whitesmoke_bg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.buttonClearChats);
            this.panel2.Controls.Add(this.label_Other_Username);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(225, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 42);
            this.panel2.TabIndex = 19;
            // 
            // buttonClearChats
            // 
            this.buttonClearChats.BackColor = System.Drawing.Color.Transparent;
            this.buttonClearChats.BackgroundImage = global::Chat_App.Properties.Resources.i_trash_open_1;
            this.buttonClearChats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClearChats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearChats.FlatAppearance.BorderSize = 0;
            this.buttonClearChats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClearChats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClearChats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearChats.Location = new System.Drawing.Point(274, 9);
            this.buttonClearChats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClearChats.Name = "buttonClearChats";
            this.buttonClearChats.Size = new System.Drawing.Size(25, 25);
            this.buttonClearChats.TabIndex = 18;
            this.buttonClearChats.UseVisualStyleBackColor = false;
            this.buttonClearChats.Click += new System.EventHandler(this.buttonClearChats_Click);
            this.buttonClearChats.MouseHover += new System.EventHandler(this.buttonClearChats_MouseHover);
            // 
            // label_Other_Username
            // 
            this.label_Other_Username.BackColor = System.Drawing.Color.Transparent;
            this.label_Other_Username.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Other_Username.ForeColor = System.Drawing.Color.DimGray;
            this.label_Other_Username.Location = new System.Drawing.Point(28, 11);
            this.label_Other_Username.Name = "label_Other_Username";
            this.label_Other_Username.Size = new System.Drawing.Size(244, 20);
            this.label_Other_Username.TabIndex = 3;
            this.label_Other_Username.Text = "other_usernname";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "@";
            // 
            // messagesPanel
            // 
            this.messagesPanel.BackColor = System.Drawing.Color.Transparent;
            this.messagesPanel.BackgroundImage = global::Chat_App.Properties.Resources.square_dark_gray_corners;
            this.messagesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.messagesPanel.Controls.Add(this.listBoxMessages);
            this.messagesPanel.Location = new System.Drawing.Point(224, 67);
            this.messagesPanel.Name = "messagesPanel";
            this.messagesPanel.Size = new System.Drawing.Size(314, 325);
            this.messagesPanel.TabIndex = 9;
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMessages.ContextMenuStrip = this.contextMenuStrip_Messages;
            this.listBoxMessages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxMessages.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMessages.ForeColor = System.Drawing.Color.Black;
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.HorizontalExtent = 500;
            this.listBoxMessages.ItemHeight = 21;
            this.listBoxMessages.Location = new System.Drawing.Point(11, 16);
            this.listBoxMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(292, 294);
            this.listBoxMessages.TabIndex = 0;
            this.listBoxMessages.SelectedIndexChanged += new System.EventHandler(this.listBoxMessages_SelectedIndexChanged);
            this.listBoxMessages.DoubleClick += new System.EventHandler(this.listBoxMessage_EventSetMessage);
            this.listBoxMessages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxMessages_KeyDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Chat_App.Properties.Resources.i_user;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.ContextMenuStrip = this.contextMenuStrip_Profile;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(83, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label_Debug
            // 
            this.label_Debug.BackColor = System.Drawing.Color.Transparent;
            this.label_Debug.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Debug.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Debug.Location = new System.Drawing.Point(208, 2);
            this.label_Debug.Name = "label_Debug";
            this.label_Debug.Size = new System.Drawing.Size(149, 18);
            this.label_Debug.TabIndex = 20;
            this.label_Debug.Text = "Live Debug Data";
            this.label_Debug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(186, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "From";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(327, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Text";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(451, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Timestamp";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(53, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "UID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Debug
            // 
            this.Panel_Debug.Controls.Add(this.label_DebugActiveIndex);
            this.Panel_Debug.Controls.Add(this.label_Debug_Active);
            this.Panel_Debug.Controls.Add(this.listBox_DebugUID);
            this.Panel_Debug.Controls.Add(this.label6);
            this.Panel_Debug.Controls.Add(this.listBox_DebugFrom);
            this.Panel_Debug.Controls.Add(this.label5);
            this.Panel_Debug.Controls.Add(this.listBox_DebugText);
            this.Panel_Debug.Controls.Add(this.label4);
            this.Panel_Debug.Controls.Add(this.listBox_DebugTimestamp);
            this.Panel_Debug.Controls.Add(this.label3);
            this.Panel_Debug.Controls.Add(this.label_Debug);
            this.Panel_Debug.Location = new System.Drawing.Point(-1, 465);
            this.Panel_Debug.Name = "Panel_Debug";
            this.Panel_Debug.Size = new System.Drawing.Size(556, 150);
            this.Panel_Debug.TabIndex = 25;
            this.Panel_Debug.Visible = false;
            // 
            // label_Debug_Active
            // 
            this.label_Debug_Active.AutoSize = true;
            this.label_Debug_Active.BackColor = System.Drawing.Color.Transparent;
            this.label_Debug_Active.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Debug_Active.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Debug_Active.Location = new System.Drawing.Point(12, 10);
            this.label_Debug_Active.Name = "label_Debug_Active";
            this.label_Debug_Active.Size = new System.Drawing.Size(63, 16);
            this.label_Debug_Active.TabIndex = 25;
            this.label_Debug_Active.Text = "Active Index:";
            this.label_Debug_Active.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_DebugActiveIndex
            // 
            this.label_DebugActiveIndex.BackColor = System.Drawing.Color.Transparent;
            this.label_DebugActiveIndex.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DebugActiveIndex.ForeColor = System.Drawing.Color.DarkGray;
            this.label_DebugActiveIndex.Location = new System.Drawing.Point(72, 7);
            this.label_DebugActiveIndex.Name = "label_DebugActiveIndex";
            this.label_DebugActiveIndex.Size = new System.Drawing.Size(62, 18);
            this.label_DebugActiveIndex.TabIndex = 26;
            this.label_DebugActiveIndex.Text = "0";
            this.label_DebugActiveIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChatApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 466);
            this.Controls.Add(this.Panel_Debug);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chatPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.messagesPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Closing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Disposed += new System.EventHandler(this.Main_Dispose);
            this.contextMenuStrip_Messages.ResumeLayout(false);
            this.chatPanel.ResumeLayout(false);
            this.chatPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.contextMenuStrip_Profile.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.messagesPanel.ResumeLayout(false);
            this.Panel_Debug.ResumeLayout(false);
            this.Panel_Debug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Label label_Other_Username;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel messagesPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_DebugFrom;
        private System.Windows.Forms.ListBox listBox_DebugText;
        private System.Windows.Forms.ListBox listBox_DebugTimestamp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Messages;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button buttonClearChats;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox listBox_DebugUID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Profile;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Debug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Panel_Debug;
        private System.Windows.Forms.Label label_DebugActiveIndex;
        private System.Windows.Forms.Label label_Debug_Active;
        public System.Windows.Forms.ListBox listBoxMessages;
        public System.Windows.Forms.Label label_Username;
    }
}