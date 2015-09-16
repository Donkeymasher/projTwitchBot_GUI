namespace ProjTwitchBotVisual
{
    partial class frmAddCommand
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
            this.lblCommandName = new System.Windows.Forms.Label();
            this.lblCanPlayMusic = new System.Windows.Forms.Label();
            this.lblCanRespondToChat = new System.Windows.Forms.Label();
            this.txtCommandName = new System.Windows.Forms.TextBox();
            this.ComboBoxMusic = new System.Windows.Forms.ComboBox();
            this.comboBoxChat = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCommandName
            // 
            this.lblCommandName.AutoSize = true;
            this.lblCommandName.Location = new System.Drawing.Point(12, 12);
            this.lblCommandName.Name = "lblCommandName";
            this.lblCommandName.Size = new System.Drawing.Size(128, 20);
            this.lblCommandName.TabIndex = 0;
            this.lblCommandName.Text = "Command Name";
            // 
            // lblCanPlayMusic
            // 
            this.lblCanPlayMusic.AutoSize = true;
            this.lblCanPlayMusic.Location = new System.Drawing.Point(12, 47);
            this.lblCanPlayMusic.Name = "lblCanPlayMusic";
            this.lblCanPlayMusic.Size = new System.Drawing.Size(83, 20);
            this.lblCanPlayMusic.TabIndex = 1;
            this.lblCanPlayMusic.Text = "Play Music";
            // 
            // lblCanRespondToChat
            // 
            this.lblCanRespondToChat.AutoSize = true;
            this.lblCanRespondToChat.Location = new System.Drawing.Point(10, 83);
            this.lblCanRespondToChat.Name = "lblCanRespondToChat";
            this.lblCanRespondToChat.Size = new System.Drawing.Size(130, 20);
            this.lblCanRespondToChat.TabIndex = 2;
            this.lblCanRespondToChat.Text = "Respond to Chat";
            // 
            // txtCommandName
            // 
            this.txtCommandName.Location = new System.Drawing.Point(146, 9);
            this.txtCommandName.Name = "txtCommandName";
            this.txtCommandName.Size = new System.Drawing.Size(100, 26);
            this.txtCommandName.TabIndex = 3;
            // 
            // ComboBoxMusic
            // 
            this.ComboBoxMusic.Items.AddRange(new object[] {
            "True",
            "False"});
            this.ComboBoxMusic.Location = new System.Drawing.Point(146, 44);
            this.ComboBoxMusic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxMusic.Name = "ComboBoxMusic";
            this.ComboBoxMusic.Size = new System.Drawing.Size(100, 28);
            this.ComboBoxMusic.TabIndex = 6;
            // 
            // comboBoxChat
            // 
            this.comboBoxChat.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxChat.Location = new System.Drawing.Point(146, 80);
            this.comboBoxChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxChat.Name = "comboBoxChat";
            this.comboBoxChat.Size = new System.Drawing.Size(100, 28);
            this.comboBoxChat.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(31, 115);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(161, 28);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm Command";
            // 
            // frmAddCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 156);
            this.Controls.Add(this.comboBoxChat);
            this.Controls.Add(this.ComboBoxMusic);
            this.Controls.Add(this.txtCommandName);
            this.Controls.Add(this.lblCommandName);
            this.Controls.Add(this.lblCanPlayMusic);
            this.Controls.Add(this.lblCanRespondToChat);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmAddCommand";
            this.Text = "Add Command";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommandName;
        private System.Windows.Forms.Label lblCanPlayMusic;
        private System.Windows.Forms.Label lblCanRespondToChat;
        private System.Windows.Forms.TextBox txtCommandName;
        private System.Windows.Forms.ComboBox ComboBoxMusic;
        private System.Windows.Forms.ComboBox comboBoxChat;
        private System.Windows.Forms.Button btnConfirm;
    }
}