namespace SCFSMSystem_ServerClient
{
    partial class GisFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GisFrm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.加载数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载mxd地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载文件地理数据库数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选评估区属性查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.同步火灾风险评估结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新评估区显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.TOCcontextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eagleEyeMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOCControl)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载数据ToolStripMenuItem,
            this.查询SToolStripMenuItem,
            this.编辑EToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(953, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 加载数据ToolStripMenuItem
            // 
            this.加载数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载mxd地图ToolStripMenuItem,
            this.加载文件地理数据库数据ToolStripMenuItem});
            this.加载数据ToolStripMenuItem.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.加载数据ToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.加载数据ToolStripMenuItem.Name = "加载数据ToolStripMenuItem";
            this.加载数据ToolStripMenuItem.ShortcutKeyDisplayString = "F";
            this.加载数据ToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.加载数据ToolStripMenuItem.Text = "文件（F）";
            // 
            // 加载mxd地图ToolStripMenuItem
            // 
            this.加载mxd地图ToolStripMenuItem.Name = "加载mxd地图ToolStripMenuItem";
            this.加载mxd地图ToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.加载mxd地图ToolStripMenuItem.Text = "加载mxd地图";
            this.加载mxd地图ToolStripMenuItem.Click += new System.EventHandler(this.加载mxd地图ToolStripMenuItem_Click);
            // 
            // 加载文件地理数据库数据ToolStripMenuItem
            // 
            this.加载文件地理数据库数据ToolStripMenuItem.Name = "加载文件地理数据库数据ToolStripMenuItem";
            this.加载文件地理数据库数据ToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.加载文件地理数据库数据ToolStripMenuItem.Text = "加载文件地理数据库数据";
            this.加载文件地理数据库数据ToolStripMenuItem.Click += new System.EventHandler(this.加载文件地理数据库数据ToolStripMenuItem_Click);
            // 
            // 查询SToolStripMenuItem
            // 
            this.查询SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选评估区属性查询ToolStripMenuItem});
            this.查询SToolStripMenuItem.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询SToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.查询SToolStripMenuItem.Name = "查询SToolStripMenuItem";
            this.查询SToolStripMenuItem.ShortcutKeyDisplayString = "S";
            this.查询SToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.查询SToolStripMenuItem.Text = "查询（S）";
            // 
            // 选评估区属性查询ToolStripMenuItem
            // 
            this.选评估区属性查询ToolStripMenuItem.Name = "选评估区属性查询ToolStripMenuItem";
            this.选评估区属性查询ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.选评估区属性查询ToolStripMenuItem.Text = "选评估区属性查询";
            this.选评估区属性查询ToolStripMenuItem.Click += new System.EventHandler(this.选评估区属性查询ToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.同步火灾风险评估结果ToolStripMenuItem,
            this.刷新评估区显示ToolStripMenuItem});
            this.编辑EToolStripMenuItem.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.编辑EToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.ShortcutKeyDisplayString = "e";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.编辑EToolStripMenuItem.Text = "编辑(E)";
            // 
            // 同步火灾风险评估结果ToolStripMenuItem
            // 
            this.同步火灾风险评估结果ToolStripMenuItem.Name = "同步火灾风险评估结果ToolStripMenuItem";
            this.同步火灾风险评估结果ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.同步火灾风险评估结果ToolStripMenuItem.Text = "同步火灾风险评估结果";
            this.同步火灾风险评估结果ToolStripMenuItem.Click += new System.EventHandler(this.同步火灾风险评估结果ToolStripMenuItem_Click);
            // 
            // 刷新评估区显示ToolStripMenuItem
            // 
            this.刷新评估区显示ToolStripMenuItem.Name = "刷新评估区显示ToolStripMenuItem";
            this.刷新评估区显示ToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.刷新评估区显示ToolStripMenuItem.Text = "刷新评估区显示";
            this.刷新评估区显示ToolStripMenuItem.Click += new System.EventHandler(this.刷新评估区显示ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.menuStrip);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 23);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(735, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "同步时间较长，请耐心等待......";
            this.label2.Visible = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.exitBtn.Location = new System.Drawing.Point(897, 1);
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
            this.axLicenseControl1.Location = new System.Drawing.Point(827, 543);
            this.axLicenseControl1.Margin = new System.Windows.Forms.Padding(2);
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
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "城市区域火灾风险评估结果GIS可视化";
            // 
            // maxMinBtn
            // 
            this.maxMinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxMinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxMinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxMinBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxMinBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.maxMinBtn.Location = new System.Drawing.Point(843, 1);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(953, 22);
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
            this.查看属性表ToolStripMenuItem.Click += new System.EventHandler(this.查看属性表ToolStripMenuItem_Click);
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
            this.缩放到图层ToolStripMenuItem.Click += new System.EventHandler(this.缩放到图层ToolStripMenuItem_Click);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 53);
            this.axToolbarControl1.Margin = new System.Windows.Forms.Padding(0);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(953, 28);
            this.axToolbarControl1.TabIndex = 8;
            // 
            // eagleEyeMapControl
            // 
            this.eagleEyeMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eagleEyeMapControl.Location = new System.Drawing.Point(0, 319);
            this.eagleEyeMapControl.Margin = new System.Windows.Forms.Padding(0);
            this.eagleEyeMapControl.Name = "eagleEyeMapControl";
            this.eagleEyeMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("eagleEyeMapControl.OcxState")));
            this.eagleEyeMapControl.Size = new System.Drawing.Size(238, 223);
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
            this.mainMapControl.Location = new System.Drawing.Point(238, 81);
            this.mainMapControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainMapControl.Name = "mainMapControl";
            this.mainMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainMapControl.OcxState")));
            this.mainMapControl.Size = new System.Drawing.Size(715, 460);
            this.mainMapControl.TabIndex = 4;
            this.mainMapControl.OnExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnExtentUpdatedEventHandler(this.mainMapControl_OnExtentUpdated);
            this.mainMapControl.OnFullExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnFullExtentUpdatedEventHandler(this.mainMapControl_OnFullExtentUpdated);
            this.mainMapControl.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.mainMapControl_OnMapReplaced);
            // 
            // tOCControl
            // 
            this.tOCControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tOCControl.Location = new System.Drawing.Point(0, 81);
            this.tOCControl.Margin = new System.Windows.Forms.Padding(0);
            this.tOCControl.Name = "tOCControl";
            this.tOCControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tOCControl.OcxState")));
            this.tOCControl.Size = new System.Drawing.Size(238, 237);
            this.tOCControl.TabIndex = 3;
            this.tOCControl.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.tOCControl_OnMouseDown);
            // 
            // GisFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(953, 564);
            this.Controls.Add(this.mainMapControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.maxMinBtn);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.tOCControl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eagleEyeMapControl);
            this.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(602, 382);
            this.Name = "GisFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GisFrm";
            this.Load += new System.EventHandler(this.GisFrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GisFrm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GisFrm_MouseMove);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TOCcontextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eagleEyeMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOCControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 加载数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载mxd地图ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private ESRI.ArcGIS.Controls.AxTOCControl tOCControl;
        private ESRI.ArcGIS.Controls.AxMapControl mainMapControl;
        private ESRI.ArcGIS.Controls.AxMapControl eagleEyeMapControl;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 加载文件地理数据库数据ToolStripMenuItem;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.Button maxMinBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel container1;
        private System.Windows.Forms.ContextMenuStrip TOCcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 查看属性表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 缩放到图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选评估区属性查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 同步火灾风险评估结果ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 刷新评估区显示ToolStripMenuItem;
    }
}