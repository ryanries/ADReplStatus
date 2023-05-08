namespace ADReplStatus
{
    partial class SetUserDomainControllerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUserDomainControllerForm));
            this.SetUserDomainControllerButton = new System.Windows.Forms.Button();
            this.SetUserDomainControllerTextBox = new System.Windows.Forms.TextBox();
            this.SetUserDomainControllerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetUserDomainControllerButton
            // 
            this.SetUserDomainControllerButton.Location = new System.Drawing.Point(226, 25);
            this.SetUserDomainControllerButton.Name = "SetUserDomainControllerButton";
            this.SetUserDomainControllerButton.Size = new System.Drawing.Size(75, 20);
            this.SetUserDomainControllerButton.TabIndex = 3;
            this.SetUserDomainControllerButton.Text = "Set";
            this.SetUserDomainControllerButton.UseVisualStyleBackColor = true;
            this.SetUserDomainControllerButton.Click += new System.EventHandler(this.SetForestNameButton_Click);
            // 
            // SetUserDomainControllerTextBox
            // 
            this.SetUserDomainControllerTextBox.Location = new System.Drawing.Point(15, 25);
            this.SetUserDomainControllerTextBox.Name = "SetUserDomainControllerTextBox";
            this.SetUserDomainControllerTextBox.Size = new System.Drawing.Size(205, 20);
            this.SetUserDomainControllerTextBox.TabIndex = 4;
            this.SetUserDomainControllerTextBox.Text = "DC1.contoso.com";
            this.SetUserDomainControllerTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetUserDomainControllerTextBox_KeyDown);

            // 
            // SetUserDomainControllerLabel
            // 
            this.SetUserDomainControllerLabel.AutoSize = true;
            this.SetUserDomainControllerLabel.Location = new System.Drawing.Point(12, 9);
            this.SetUserDomainControllerLabel.Name = "SetUserDomainControllerLabel";
            this.SetUserDomainControllerLabel.Size = new System.Drawing.Size(137, 13);
            this.SetUserDomainControllerLabel.TabIndex = 5;
            this.SetUserDomainControllerLabel.Text = "Specify a domain controller:";
            // 
            // SetUserDomainControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 50);
            this.Controls.Add(this.SetUserDomainControllerLabel);
            this.Controls.Add(this.SetUserDomainControllerTextBox);
            this.Controls.Add(this.SetUserDomainControllerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetUserDomainControllerForm";
            this.Text = "Set Domain Controller";
            this.Load += new System.EventHandler(this.SetUserDomainControllerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetUserDomainControllerButton;
        private System.Windows.Forms.TextBox SetUserDomainControllerTextBox;
        private System.Windows.Forms.Label SetUserDomainControllerLabel;
    }
}