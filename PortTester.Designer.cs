namespace ADReplStatus
{
    partial class PortTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortTester));
            this.results_label = new System.Windows.Forms.Label();
            this.results_txtbox = new System.Windows.Forms.TextBox();
            this.Target_label = new System.Windows.Forms.Label();
            this.target_txtbox = new System.Windows.Forms.TextBox();
            this.portOverride_btn = new System.Windows.Forms.CheckBox();
            this.port_label = new System.Windows.Forms.Label();
            this.port_txtbox = new System.Windows.Forms.TextBox();
            this.manualTest_btn = new System.Windows.Forms.Button();
            this.protocolTesterListBox = new System.Windows.Forms.CheckedListBox();
            this.runTest_btn = new System.Windows.Forms.Button();
            this.selectAll_rbtn = new System.Windows.Forms.RadioButton();
            this.exportResults_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // results_label
            // 
            resources.ApplyResources(this.results_label, "results_label");
            this.results_label.Name = "results_label";
            // 
            // results_txtbox
            // 
            resources.ApplyResources(this.results_txtbox, "results_txtbox");
            this.results_txtbox.Name = "results_txtbox";
            // 
            // Target_label
            // 
            resources.ApplyResources(this.Target_label, "Target_label");
            this.Target_label.Name = "Target_label";
            // 
            // target_txtbox
            // 
            resources.ApplyResources(this.target_txtbox, "target_txtbox");
            this.target_txtbox.Name = "target_txtbox";
            // 
            // portOverride_btn
            // 
            resources.ApplyResources(this.portOverride_btn, "portOverride_btn");
            this.portOverride_btn.Name = "portOverride_btn";
            this.portOverride_btn.UseVisualStyleBackColor = true;
            this.portOverride_btn.CheckedChanged += new System.EventHandler(this.portOverride_btn_CheckedChanged);
            // 
            // port_label
            // 
            resources.ApplyResources(this.port_label, "port_label");
            this.port_label.Name = "port_label";
            // 
            // port_txtbox
            // 
            resources.ApplyResources(this.port_txtbox, "port_txtbox");
            this.port_txtbox.Name = "port_txtbox";
            // 
            // manualTest_btn
            // 
            resources.ApplyResources(this.manualTest_btn, "manualTest_btn");
            this.manualTest_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manualTest_btn.Name = "manualTest_btn";
            this.manualTest_btn.UseVisualStyleBackColor = true;
            this.manualTest_btn.Click += new System.EventHandler(this.manualTest_btn_Click);
            // 
            // protocolTesterListBox
            // 
            this.protocolTesterListBox.FormattingEnabled = true;
            resources.ApplyResources(this.protocolTesterListBox, "protocolTesterListBox");
            this.protocolTesterListBox.Name = "protocolTesterListBox";
            this.protocolTesterListBox.ThreeDCheckBoxes = true;
            // 
            // runTest_btn
            // 
            resources.ApplyResources(this.runTest_btn, "runTest_btn");
            this.runTest_btn.Name = "runTest_btn";
            this.runTest_btn.UseVisualStyleBackColor = true;
            this.runTest_btn.Click += new System.EventHandler(this.runTest_btn_Click);
            // 
            // selectAll_rbtn
            // 
            resources.ApplyResources(this.selectAll_rbtn, "selectAll_rbtn");
            this.selectAll_rbtn.Name = "selectAll_rbtn";
            this.selectAll_rbtn.TabStop = true;
            this.selectAll_rbtn.UseVisualStyleBackColor = true;
            this.selectAll_rbtn.CheckedChanged += new System.EventHandler(this.selectAll_rbtn_CheckedChanged);
            this.selectAll_rbtn.Click += new System.EventHandler(this.selectAll_rbtn_Click);
            // 
            // exportResults_btn
            // 
            resources.ApplyResources(this.exportResults_btn, "exportResults_btn");
            this.exportResults_btn.Name = "exportResults_btn";
            this.exportResults_btn.UseVisualStyleBackColor = true;
            this.exportResults_btn.Click += new System.EventHandler(this.exportResults_btn_Click);
            // 
            // PortTester
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exportResults_btn);
            this.Controls.Add(this.selectAll_rbtn);
            this.Controls.Add(this.runTest_btn);
            this.Controls.Add(this.protocolTesterListBox);
            this.Controls.Add(this.manualTest_btn);
            this.Controls.Add(this.port_txtbox);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.portOverride_btn);
            this.Controls.Add(this.target_txtbox);
            this.Controls.Add(this.Target_label);
            this.Controls.Add(this.results_txtbox);
            this.Controls.Add(this.results_label);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "PortTester";
            this.Load += new System.EventHandler(this.PortTester_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label results_label;
        private System.Windows.Forms.TextBox results_txtbox;
        private System.Windows.Forms.Label Target_label;
        private System.Windows.Forms.TextBox target_txtbox;
        private System.Windows.Forms.CheckBox portOverride_btn;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.TextBox port_txtbox;
        private System.Windows.Forms.Button manualTest_btn;
        private System.Windows.Forms.CheckedListBox protocolTesterListBox;
        private System.Windows.Forms.Button runTest_btn;
        private System.Windows.Forms.RadioButton selectAll_rbtn;
        private System.Windows.Forms.Button exportResults_btn;
    }
}