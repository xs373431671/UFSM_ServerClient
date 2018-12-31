namespace SCFSMSystem_ServerClient
{
    partial class GisFrm_SelectFeatureFrm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("图层");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GisFrm_SelectFeatureFrm));
            this.treeViewLayers = new System.Windows.Forms.TreeView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelLayerSelectionCount = new System.Windows.Forms.Label();
            this.labelMapSelectionCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewLayers
            // 
            this.treeViewLayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewLayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeViewLayers.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewLayers.ForeColor = System.Drawing.Color.DodgerBlue;
            this.treeViewLayers.LineColor = System.Drawing.Color.DodgerBlue;
            this.treeViewLayers.Location = new System.Drawing.Point(0, 0);
            this.treeViewLayers.Name = "treeViewLayers";
            treeNode1.ForeColor = System.Drawing.Color.DodgerBlue;
            treeNode1.Name = "Layers";
            treeNode1.Text = "图层";
            this.treeViewLayers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewLayers.Size = new System.Drawing.Size(185, 440);
            this.treeViewLayers.TabIndex = 0;
            this.treeViewLayers.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView.Location = new System.Drawing.Point(185, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(525, 411);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // labelLayerSelectionCount
            // 
            this.labelLayerSelectionCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLayerSelectionCount.AutoSize = true;
            this.labelLayerSelectionCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelLayerSelectionCount.Location = new System.Drawing.Point(539, 417);
            this.labelLayerSelectionCount.Name = "labelLayerSelectionCount";
            this.labelLayerSelectionCount.Size = new System.Drawing.Size(155, 12);
            this.labelLayerSelectionCount.TabIndex = 2;
            this.labelLayerSelectionCount.Text = "当前图层选择了 0 个要素。";
            // 
            // labelMapSelectionCount
            // 
            this.labelMapSelectionCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMapSelectionCount.AutoSize = true;
            this.labelMapSelectionCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelMapSelectionCount.Location = new System.Drawing.Point(202, 417);
            this.labelMapSelectionCount.Name = "labelMapSelectionCount";
            this.labelMapSelectionCount.Size = new System.Drawing.Size(167, 12);
            this.labelMapSelectionCount.TabIndex = 3;
            this.labelMapSelectionCount.Text = "当前地图共选择了 0 个要素。";
            // 
            // GisFrm_SelectFeatureFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(711, 438);
            this.Controls.Add(this.labelMapSelectionCount);
            this.Controls.Add(this.labelLayerSelectionCount);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.treeViewLayers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GisFrm_SelectFeatureFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地图选择集";
            this.Load += new System.EventHandler(this.FormSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewLayers;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelLayerSelectionCount;
        private System.Windows.Forms.Label labelMapSelectionCount;
    }
}