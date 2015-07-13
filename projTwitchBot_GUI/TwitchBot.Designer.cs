namespace projTwitchBotVisual
{
    partial class frmTwitchBot
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
            this.btnServerConnection = new System.Windows.Forms.Button();
            this.lblBotName = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtChan = new System.Windows.Forms.TextBox();
            this.btnSaveConData = new System.Windows.Forms.Button();
            this.comboConnection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOuthKey = new System.Windows.Forms.Label();
            this.txtOuth = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnServerConnection
            // 
            this.btnServerConnection.Location = new System.Drawing.Point(103, 181);
            this.btnServerConnection.Name = "btnServerConnection";
            this.btnServerConnection.Size = new System.Drawing.Size(147, 23);
            this.btnServerConnection.TabIndex = 0;
            this.btnServerConnection.Text = "Connect to server";
            this.btnServerConnection.UseVisualStyleBackColor = true;
            this.btnServerConnection.Click += new System.EventHandler(this.btnServerConnection_Click);
            // 
            // lblBotName
            // 
            this.lblBotName.AutoSize = true;
            this.lblBotName.Location = new System.Drawing.Point(14, 72);
            this.lblBotName.Name = "lblBotName";
            this.lblBotName.Size = new System.Drawing.Size(74, 17);
            this.lblBotName.TabIndex = 1;
            this.lblBotName.Text = "Bot Name:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(33, 97);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(54, 17);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server:";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(33, 158);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(64, 17);
            this.lblChannel.TabIndex = 4;
            this.lblChannel.Text = "Channel:";
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.AutoSize = true;
            this.lblPortNumber.Location = new System.Drawing.Point(45, 125);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(38, 17);
            this.lblPortNumber.TabIndex = 3;
            this.lblPortNumber.Text = "Port:";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(103, 69);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(147, 22);
            this.txtNick.TabIndex = 5;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(103, 97);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(147, 22);
            this.txtServer.TabIndex = 6;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(103, 125);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(147, 22);
            this.txtPort.TabIndex = 7;
            // 
            // txtChan
            // 
            this.txtChan.Location = new System.Drawing.Point(103, 153);
            this.txtChan.Name = "txtChan";
            this.txtChan.Size = new System.Drawing.Size(147, 22);
            this.txtChan.TabIndex = 8;
            // 
            // btnSaveConData
            // 
            this.btnSaveConData.Location = new System.Drawing.Point(40, 181);
            this.btnSaveConData.Name = "btnSaveConData";
            this.btnSaveConData.Size = new System.Drawing.Size(57, 23);
            this.btnSaveConData.TabIndex = 9;
            this.btnSaveConData.Text = "Save";
            this.btnSaveConData.UseVisualStyleBackColor = true;
            // 
            // comboConnection
            // 
            this.comboConnection.Items.AddRange(new object[] {
            "Twitch ",
            "Other"});
            this.comboConnection.Location = new System.Drawing.Point(103, 39);
            this.comboConnection.Name = "comboConnection";
            this.comboConnection.Size = new System.Drawing.Size(147, 24);
            this.comboConnection.TabIndex = 10;
            this.comboConnection.SelectedIndexChanged += new System.EventHandler(this.comboConnection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Connection:";
            // 
            // lblOuthKey
            // 
            this.lblOuthKey.AutoSize = true;
            this.lblOuthKey.Location = new System.Drawing.Point(40, 125);
            this.lblOuthKey.Name = "lblOuthKey";
            this.lblOuthKey.Size = new System.Drawing.Size(43, 17);
            this.lblOuthKey.TabIndex = 12;
            this.lblOuthKey.Text = "Outh:";
            this.lblOuthKey.Visible = false;
            // 
            // txtOuth
            // 
            this.txtOuth.Location = new System.Drawing.Point(103, 125);
            this.txtOuth.Name = "txtOuth";
            this.txtOuth.Size = new System.Drawing.Size(147, 22);
            this.txtOuth.TabIndex = 13;
            this.txtOuth.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCommandsToolStripMenuItem,
            this.addCommandsToolStripMenuItem});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // viewCommandsToolStripMenuItem
            // 
            this.viewCommandsToolStripMenuItem.Name = "viewCommandsToolStripMenuItem";
            this.viewCommandsToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.viewCommandsToolStripMenuItem.Text = "View Commands";
            this.viewCommandsToolStripMenuItem.Click += new System.EventHandler(this.viewCommandsToolStripMenuItem_Click);
            // 
            // addCommandsToolStripMenuItem
            // 
            this.addCommandsToolStripMenuItem.Name = "addCommandsToolStripMenuItem";
            this.addCommandsToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.addCommandsToolStripMenuItem.Text = "Add Commands";
            this.addCommandsToolStripMenuItem.Click += new System.EventHandler(this.addCommandsToolStripMenuItem_Click);
            // 
            // frmTwitchBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboConnection);
            this.Controls.Add(this.btnSaveConData);
            this.Controls.Add(this.txtChan);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.lblPortNumber);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblBotName);
            this.Controls.Add(this.btnServerConnection);
            this.Controls.Add(this.txtOuth);
            this.Controls.Add(this.lblOuthKey);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTwitchBot";
            this.Text = "TwitchBot";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServerConnection;
        private System.Windows.Forms.Label lblBotName;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblPortNumber;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtChan;
        private System.Windows.Forms.Button btnSaveConData;
        private System.Windows.Forms.ComboBox comboConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOuthKey;
        private System.Windows.Forms.TextBox txtOuth;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCommandsToolStripMenuItem;
    }
}

