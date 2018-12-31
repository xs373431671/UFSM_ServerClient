namespace SCFSMSystem_ServerClient.GISAnalysis
{
    partial class GISAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GISAnalysis));
            this.exitBtn = new System.Windows.Forms.Button();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.label1 = new System.Windows.Forms.Label();
            this.maxMinBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.container1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TOCcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看属性表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.缩放到图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.eagleEyeMapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.mainMapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.tOCControl = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.TOCcontextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eagleEyeMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOCControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.exitBtn.Location = new System.Drawing.Point(1047, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(55, 30);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(827, 524);
            this.axLicenseControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "消防站有效覆盖面积地理分析";
            // 
            // maxMinBtn
            // 
            this.maxMinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxMinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxMinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxMinBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxMinBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.maxMinBtn.Location = new System.Drawing.Point(993, 0);
            this.maxMinBtn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.maxMinBtn.Name = "maxMinBtn";
            this.maxMinBtn.Size = new System.Drawing.Size(55, 30);
            this.maxMinBtn.TabIndex = 9;
            this.maxMinBtn.Text = "Max";
            this.maxMinBtn.UseVisualStyleBackColor = false;
            this.maxMinBtn.Click += new System.EventHandler(this.maxMinBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.container1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1102, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // container1
            // 
            this.container1.Name = "container1";
            this.container1.Size = new System.Drawing.Size(188, 17);
            this.container1.Text = "欢迎使用城市火灾安全管理软件！";
            // 
            // TOCcontextMenuStrip
            // 
            this.TOCcontextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TOCcontextMenuStrip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TOCcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看属性表ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.缩放到图层ToolStripMenuItem});
            this.TOCcontextMenuStrip.Name = "TOCcontextMenuStrip";
            this.TOCcontextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TOCcontextMenuStrip.Size = new System.Drawing.Size(137, 54);
            // 
            // 查看属性表ToolStripMenuItem
            // 
            this.查看属性表ToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.查看属性表ToolStripMenuItem.Name = "查看属性表ToolStripMenuItem";
            this.查看属性表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.查看属性表ToolStripMenuItem.Text = "查看属性表";
            this.查看属性表ToolStripMenuItem.Click += new System.EventHandler(this.查看属性表ToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 6);
            // 
            // 缩放到图层ToolStripMenuItem
            // 
            this.缩放到图层ToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.缩放到图层ToolStripMenuItem.Name = "缩放到图层ToolStripMenuItem";
            this.缩放到图层ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.缩放到图层ToolStripMenuItem.Text = "缩放到图层";
            this.缩放到图层ToolStripMenuItem.Click += new System.EventHandler(this.缩放到图层ToolStripMenuItem_Click_1);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 30);
            this.axToolbarControl1.Margin = new System.Windows.Forms.Padding(0);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(1436, 28);
            this.axToolbarControl1.TabIndex = 8;
            // 
            // eagleEyeMapControl
            // 
            this.eagleEyeMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eagleEyeMapControl.Location = new System.Drawing.Point(2, 328);
            this.eagleEyeMapControl.Margin = new System.Windows.Forms.Padding(0);
            this.eagleEyeMapControl.Name = "eagleEyeMapControl";
            this.eagleEyeMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("eagleEyeMapControl.OcxState")));
            this.eagleEyeMapControl.Size = new System.Drawing.Size(263, 233);
            this.eagleEyeMapControl.TabIndex = 5;
            this.eagleEyeMapControl.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.eagleEyeMapControl_OnMouseDown);
            this.eagleEyeMapControl.OnMouseUp += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseUpEventHandler(this.eagleEyeMapControl_OnMouseUp);
            this.eagleEyeMapControl.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.eagleEyeMapControl_OnMouseMove);
            // 
            // mainMapControl
            // 
            this.mainMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMapControl.Location = new System.Drawing.Point(265, 58);
            this.mainMapControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainMapControl.Name = "mainMapControl";
            this.mainMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainMapControl.OcxState")));
            this.mainMapControl.Size = new System.Drawing.Size(677, 503);
            this.mainMapControl.TabIndex = 4;
            this.mainMapControl.OnExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnExtentUpdatedEventHandler(this.mainMapControl_OnExtentUpdated);
            this.mainMapControl.OnFullExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnFullExtentUpdatedEventHandler(this.mainMapControl_OnFullExtentUpdated);
            this.mainMapControl.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.mainMapControl_OnMapReplaced);
            // 
            // tOCControl
            // 
            this.tOCControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tOCControl.Location = new System.Drawing.Point(0, 58);
            this.tOCControl.Margin = new System.Windows.Forms.Padding(0);
            this.tOCControl.Name = "tOCControl";
            this.tOCControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tOCControl.OcxState")));
            this.tOCControl.Size = new System.Drawing.Size(265, 270);
            this.tOCControl.TabIndex = 3;
            this.tOCControl.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.tOCControl_OnMouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(5, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "计算消防站有效覆盖面积";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.Location = new System.Drawing.Point(36, 376);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 23);
            this.textBox1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(945, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 503);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // GISAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1102, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.maxMinBtn);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eagleEyeMapControl);
            this.Controls.Add(this.mainMapControl);
            this.Controls.Add(this.tOCControl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.axLicenseControl1);
            this.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(602, 382);
            this.Name = "GISAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GISAnalysis";
            this.Load += new System.EventHandler(this.GISAnalysis_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GISAnalysis_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GISAnalysis_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TOCcontextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eagleEyeMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOCControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private ESRI.ArcGIS.Controls.AxTOCControl tOCControl;
        private ESRI.ArcGIS.Controls.AxMapControl mainMapControl;
        private ESRI.ArcGIS.Controls.AxMapControl eagleEyeMapControl;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.Label label1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.Button maxMinBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel container1;
        private System.Windows.Forms.ContextMenuStrip TOCcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 查看属性表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 缩放到图层ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}