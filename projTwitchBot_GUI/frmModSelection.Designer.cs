namespace ProjTwitchBotVisual
{
    partial class frmModSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModSelection));
            this.lblModName = new System.Windows.Forms.Label();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.btnAddMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(12, 24);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(86, 20);
            this.lblModName.TabIndex = 0;
            this.lblModName.Text = "Mod Name";
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(110, 18);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(107, 26);
            this.txtModName.TabIndex = 1;
            // 
            // btnAddMod
            // 
            this.btnAddMod.Location = new System.Drawing.Point(52, 61);
            this.btnAddMod.Name = "btnAddMod";
            this.btnAddMod.Size = new System.Drawing.Size(104, 32);
            this.btnAddMod.TabIndex = 2;
            this.btnAddMod.Text = "Add Mod";
            this.btnAddMod.UseVisualStyleBackColor = true;
            this.btnAddMod.Click += new System.EventHandler(this.btnAddMod_Click);
            // 
            // frmModSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 105);
            this.Controls.Add(this.btnAddMod);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.lblModName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModSelection";
            this.Text = "Add Mod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Button btnAddMod;
    }
}