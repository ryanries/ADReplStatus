namespace ADReplStatus
{
    partial class SetForestNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetForestNameForm));
            this.EnterForestNameLabel = new System.Windows.Forms.Label();
            this.SetForestNameTextBox = new System.Windows.Forms.TextBox();
            this.SetForestNameButton = new System.Windows.Forms.Button();
            this.SaveForestCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EnterForestNameLabel
            // 
            this.EnterForestNameLabel.AutoSize = true;
            this.EnterForestNameLabel.Location = new System.Drawing.Point(12, 9);
            this.EnterForestNameLabel.Name = "EnterForestNameLabel";
            this.EnterForestNameLabel.Size = new System.Drawing.Size(303, 13);
            this.EnterForestNameLabel.TabIndex = 0;
            this.EnterForestNameLabel.Text = "Enter the name of the Active Directory forest you want to scan:";
            // 
            // SetForestNameTextBox
            // 
            this.SetForestNameTextBox.Location = new System.Drawing.Point(13, 29);
            this.SetForestNameTextBox.Name = "SetForestNameTextBox";
            this.SetForestNameTextBox.Size = new System.Drawing.Size(240, 20);
            this.SetForestNameTextBox.TabIndex = 1;
            // 
            // SetForestNameButton
            // 
            this.SetForestNameButton.Location = new System.Drawing.Point(322, 29);
            this.SetForestNameButton.Name = "SetForestNameButton";
            this.SetForestNameButton.Size = new System.Drawing.Size(75, 23);
            this.SetForestNameButton.TabIndex = 2;
            this.SetForestNameButton.Text = "OK";
            this.SetForestNameButton.UseVisualStyleBackColor = true;
            this.SetForestNameButton.Click += new System.EventHandler(this.SetForestNameButton_Click);
            // 
            // SaveForestCheckBox
            // 
            this.SaveForestCheckBox.AutoSize = true;
            this.SaveForestCheckBox.Location = new System.Drawing.Point(15, 56);
            this.SaveForestCheckBox.Name = "SaveForestCheckBox";
            this.SaveForestCheckBox.Size = new System.Drawing.Size(51, 17);
            this.SaveForestCheckBox.TabIndex = 3;
            this.SaveForestCheckBox.Text = "Save";
            this.SaveForestCheckBox.UseVisualStyleBackColor = true;
            // 
            // SetForestNameForm
            // 
            this.AcceptButton = this.SetForestNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 83);
            this.Controls.Add(this.SaveForestCheckBox);
            this.Controls.Add(this.SetForestNameButton);
            this.Controls.Add(this.SetForestNameTextBox);
            this.Controls.Add(this.EnterForestNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetForestNameForm";
            this.ShowInTaskbar = false;
            this.Text = "Enter AD Forest Name";
            this.Load += new System.EventHandler(this.SetForestNameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterForestNameLabel;
        private System.Windows.Forms.TextBox SetForestNameTextBox;
        private System.Windows.Forms.Button SetForestNameButton;
        private System.Windows.Forms.CheckBox SaveForestCheckBox;
    }
}