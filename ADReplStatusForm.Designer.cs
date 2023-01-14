namespace ADReplStatus
{
    partial class ADReplStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADReplStatusForm));
            this.RefreshButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EnableLoggingButton = new System.Windows.Forms.Button();
            this.SetForestButton = new System.Windows.Forms.Button();
            this.ProgressPictureBox = new System.Windows.Forms.PictureBox();
            this.AlternateCredsButton = new System.Windows.Forms.Button();
            this.ProgressPercentLabel = new System.Windows.Forms.Label();
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.DCNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DomainNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SiteColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DiscoveryIssuesColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.IsGCColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.IsRODCColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SourceServerColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PartitionNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ConsecutiveFailureCountColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.LastSuccessfulSyncColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.LastSyncResultColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.LastSyncMessageColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ErrorsOnlyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.Location = new System.Drawing.Point(12, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(50, 50);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // EnableLoggingButton
            // 
            this.EnableLoggingButton.Image = ((System.Drawing.Image)(resources.GetObject("EnableLoggingButton.Image")));
            this.EnableLoggingButton.Location = new System.Drawing.Point(292, 12);
            this.EnableLoggingButton.Name = "EnableLoggingButton";
            this.EnableLoggingButton.Size = new System.Drawing.Size(50, 50);
            this.EnableLoggingButton.TabIndex = 3;
            this.EnableLoggingButton.UseVisualStyleBackColor = true;
            this.EnableLoggingButton.Click += new System.EventHandler(this.EnableLoggingButton_Click);
            // 
            // SetForestButton
            // 
            this.SetForestButton.Image = ((System.Drawing.Image)(resources.GetObject("SetForestButton.Image")));
            this.SetForestButton.Location = new System.Drawing.Point(124, 12);
            this.SetForestButton.Name = "SetForestButton";
            this.SetForestButton.Size = new System.Drawing.Size(50, 50);
            this.SetForestButton.TabIndex = 4;
            this.SetForestButton.UseVisualStyleBackColor = true;
            this.SetForestButton.Click += new System.EventHandler(this.SetForestButton_Click);
            // 
            // ProgressPictureBox
            // 
            this.ProgressPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ProgressPictureBox.Image")));
            this.ProgressPictureBox.Location = new System.Drawing.Point(72, 22);
            this.ProgressPictureBox.Name = "ProgressPictureBox";
            this.ProgressPictureBox.Size = new System.Drawing.Size(40, 40);
            this.ProgressPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProgressPictureBox.TabIndex = 5;
            this.ProgressPictureBox.TabStop = false;
            this.ProgressPictureBox.Visible = false;
            // 
            // AlternateCredsButton
            // 
            this.AlternateCredsButton.Image = ((System.Drawing.Image)(resources.GetObject("AlternateCredsButton.Image")));
            this.AlternateCredsButton.Location = new System.Drawing.Point(180, 12);
            this.AlternateCredsButton.Name = "AlternateCredsButton";
            this.AlternateCredsButton.Size = new System.Drawing.Size(50, 50);
            this.AlternateCredsButton.TabIndex = 6;
            this.AlternateCredsButton.UseVisualStyleBackColor = true;
            this.AlternateCredsButton.Click += new System.EventHandler(this.AlternateCredsButton_Click);
            // 
            // ProgressPercentLabel
            // 
            this.ProgressPercentLabel.Location = new System.Drawing.Point(71, 9);
            this.ProgressPercentLabel.Name = "ProgressPercentLabel";
            this.ProgressPercentLabel.Size = new System.Drawing.Size(42, 12);
            this.ProgressPercentLabel.TabIndex = 8;
            this.ProgressPercentLabel.Text = "0%";
            this.ProgressPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressPercentLabel.Visible = false;
            // 
            // treeListView1
            // 
            this.treeListView1.AllColumns.Add(this.DCNameColumn);
            this.treeListView1.AllColumns.Add(this.DomainNameColumn);
            this.treeListView1.AllColumns.Add(this.SiteColumn);
            this.treeListView1.AllColumns.Add(this.DiscoveryIssuesColumn);
            this.treeListView1.AllColumns.Add(this.IsGCColumn);
            this.treeListView1.AllColumns.Add(this.IsRODCColumn);
            this.treeListView1.AllColumns.Add(this.SourceServerColumn);
            this.treeListView1.AllColumns.Add(this.PartitionNameColumn);
            this.treeListView1.AllColumns.Add(this.ConsecutiveFailureCountColumn);
            this.treeListView1.AllColumns.Add(this.LastSuccessfulSyncColumn);
            this.treeListView1.AllColumns.Add(this.LastSyncResultColumn);
            this.treeListView1.AllColumns.Add(this.LastSyncMessageColumn);
            this.treeListView1.CellEditUseWholeCell = false;
            this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DCNameColumn,
            this.DomainNameColumn,
            this.SiteColumn,
            this.DiscoveryIssuesColumn,
            this.IsGCColumn,
            this.IsRODCColumn,
            this.SourceServerColumn,
            this.PartitionNameColumn,
            this.ConsecutiveFailureCountColumn,
            this.LastSuccessfulSyncColumn,
            this.LastSyncResultColumn,
            this.LastSyncMessageColumn});
            this.treeListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListView1.HideSelection = false;
            this.treeListView1.Location = new System.Drawing.Point(12, 68);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.ShowGroups = false;
            this.treeListView1.Size = new System.Drawing.Size(760, 381);
            this.treeListView1.TabIndex = 9;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.UseFiltering = true;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            this.treeListView1.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.treeListView1_FormatRow);
            // 
            // DCNameColumn
            // 
            this.DCNameColumn.AspectName = "Name";
            this.DCNameColumn.Groupable = false;
            this.DCNameColumn.Text = "DC Name";
            // 
            // DomainNameColumn
            // 
            this.DomainNameColumn.AspectName = "DomainName";
            this.DomainNameColumn.Text = "Domain";
            // 
            // SiteColumn
            // 
            this.SiteColumn.AspectName = "Site";
            this.SiteColumn.Text = "Site";
            // 
            // DiscoveryIssuesColumn
            // 
            this.DiscoveryIssuesColumn.AspectName = "DiscoveryIssues";
            this.DiscoveryIssuesColumn.Text = "Discovery Issues";
            // 
            // IsGCColumn
            // 
            this.IsGCColumn.AspectName = "IsGC";
            this.IsGCColumn.Text = "Is GC";
            // 
            // IsRODCColumn
            // 
            this.IsRODCColumn.AspectName = "IsRODC";
            this.IsRODCColumn.Text = "Is RODC";
            // 
            // SourceServerColumn
            // 
            this.SourceServerColumn.AspectName = "SourceServer";
            this.SourceServerColumn.Text = "Source DC";
            // 
            // PartitionNameColumn
            // 
            this.PartitionNameColumn.AspectName = "PartitionName";
            this.PartitionNameColumn.Text = "Partition";
            // 
            // ConsecutiveFailureCountColumn
            // 
            this.ConsecutiveFailureCountColumn.AspectName = "ConsecutiveFailureCount";
            this.ConsecutiveFailureCountColumn.Text = "Consecutive Failures";
            // 
            // LastSuccessfulSyncColumn
            // 
            this.LastSuccessfulSyncColumn.AspectName = "LastSuccessfulSync";
            this.LastSuccessfulSyncColumn.Text = "Last Successful Sync";
            // 
            // LastSyncResultColumn
            // 
            this.LastSyncResultColumn.AspectName = "LastSyncResult";
            this.LastSyncResultColumn.Text = "Last Sync Result";
            // 
            // LastSyncMessageColumn
            // 
            this.LastSyncMessageColumn.AspectName = "LastSyncMessage";
            this.LastSyncMessageColumn.Text = "Last Sync Message";
            // 
            // ErrorsOnlyButton
            // 
            this.ErrorsOnlyButton.Image = ((System.Drawing.Image)(resources.GetObject("ErrorsOnlyButton.Image")));
            this.ErrorsOnlyButton.Location = new System.Drawing.Point(236, 12);
            this.ErrorsOnlyButton.Name = "ErrorsOnlyButton";
            this.ErrorsOnlyButton.Size = new System.Drawing.Size(50, 50);
            this.ErrorsOnlyButton.TabIndex = 10;
            this.ErrorsOnlyButton.UseVisualStyleBackColor = true;
            this.ErrorsOnlyButton.Click += new System.EventHandler(this.ErrorsOnlyButton_Click);
            // 
            // ADReplStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.ErrorsOnlyButton);
            this.Controls.Add(this.treeListView1);
            this.Controls.Add(this.ProgressPercentLabel);
            this.Controls.Add(this.AlternateCredsButton);
            this.Controls.Add(this.ProgressPictureBox);
            this.Controls.Add(this.SetForestButton);
            this.Controls.Add(this.EnableLoggingButton);
            this.Controls.Add(this.RefreshButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ADReplStatusForm";
            this.Text = "AD Replication Status Tool";
            this.Load += new System.EventHandler(this.ADReplStatusForm_Load);
            this.Resize += new System.EventHandler(this.ADReplStatusForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RefreshButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button EnableLoggingButton;
        private System.Windows.Forms.Button SetForestButton;
        private System.Windows.Forms.PictureBox ProgressPictureBox;
        private System.Windows.Forms.Button AlternateCredsButton;
        private System.Windows.Forms.Label ProgressPercentLabel;
        private BrightIdeasSoftware.TreeListView treeListView1;
        private BrightIdeasSoftware.OLVColumn DCNameColumn;
        private BrightIdeasSoftware.OLVColumn SiteColumn;
        private BrightIdeasSoftware.OLVColumn DiscoveryIssuesColumn;
        private BrightIdeasSoftware.OLVColumn IsGCColumn;
        private BrightIdeasSoftware.OLVColumn IsRODCColumn;
        private BrightIdeasSoftware.OLVColumn DomainNameColumn;
        private BrightIdeasSoftware.OLVColumn SourceServerColumn;
        private BrightIdeasSoftware.OLVColumn PartitionNameColumn;
        private BrightIdeasSoftware.OLVColumn ConsecutiveFailureCountColumn;
        private BrightIdeasSoftware.OLVColumn LastSuccessfulSyncColumn;
        private BrightIdeasSoftware.OLVColumn LastSyncResultColumn;
        private BrightIdeasSoftware.OLVColumn LastSyncMessageColumn;
        private System.Windows.Forms.Button ErrorsOnlyButton;
    }
}

