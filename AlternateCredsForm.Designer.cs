namespace ADReplStatus
{
    partial class AlternateCredsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlternateCredsForm));
            this.AlternateCredsButton = new System.Windows.Forms.Button();
            this.AlternateCredsLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PwdLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlternateCredsButton
            // 
            this.AlternateCredsButton.Location = new System.Drawing.Point(384, 57);
            this.AlternateCredsButton.Name = "AlternateCredsButton";
            this.AlternateCredsButton.Size = new System.Drawing.Size(75, 23);
            this.AlternateCredsButton.TabIndex = 0;
            this.AlternateCredsButton.Text = "OK";
            this.AlternateCredsButton.UseVisualStyleBackColor = true;
            this.AlternateCredsButton.Click += new System.EventHandler(this.AlternateCredsButton_Click);
            // 
            // AlternateCredsLabel
            // 
            this.AlternateCredsLabel.AutoSize = true;
            this.AlternateCredsLabel.Location = new System.Drawing.Point(12, 9);
            this.AlternateCredsLabel.Name = "AlternateCredsLabel";
            this.AlternateCredsLabel.Size = new System.Drawing.Size(359, 39);
            this.AlternateCredsLabel.TabIndex = 1;
            this.AlternateCredsLabel.Text = resources.GetString("AlternateCredsLabel.Text");
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(74, 57);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(120, 20);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(240, 57);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(138, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PwdLabel
            // 
            this.PwdLabel.AutoSize = true;
            this.PwdLabel.Location = new System.Drawing.Point(206, 60);
            this.PwdLabel.Name = "PwdLabel";
            this.PwdLabel.Size = new System.Drawing.Size(31, 13);
            this.PwdLabel.TabIndex = 4;
            this.PwdLabel.Text = "Pwd:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(13, 60);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Username:";
            // 
            // AlternateCredsForm
            // 
            this.AcceptButton = this.AlternateCredsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 87);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PwdLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.AlternateCredsLabel);
            this.Controls.Add(this.AlternateCredsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlternateCredsForm";
            this.ShowInTaskbar = false;
            this.Text = "Provide Alternate Credentials";
            this.Load += new System.EventHandler(this.AlternateCredsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AlternateCredsButton;
        private System.Windows.Forms.Label AlternateCredsLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PwdLabel;
        private System.Windows.Forms.Label UsernameLabel;
    }
}