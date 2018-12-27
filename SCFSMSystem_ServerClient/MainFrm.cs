using SCFSMSystem_ServerClient.MainFormPanel;
using SCFSMSystem_ServerClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SCFSMSystem_ServerClient
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            StaticForm.MainForm = this;    //将主窗体对象静态存储

            LoginFrm myl = new LoginFrm();            //Main窗口加载前先加载登录窗口对象
            if (myl.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            myl.Close();
                      
            pictureBox1.Image = Image.FromFile(@"Picture/mainLogo.png");
            pictureBox2.Image = Image.FromFile(@"Picture/cursor.png");
            pictureBox3.Image = Image.FromFile(@"Picture/cursor.png");
            pictureBox4.Image = Image.FromFile(@"Picture/cursor.png");
            pictureBox5.Image = Image.FromFile(@"Picture/cursor.png");
            pictureBox6.Image = Image.FromFile(@"Picture/cursor.png");
            pictureBox7.Image = Image.FromFile(@"Picture/cursor.png");
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;

            try
            {
                ISMPanel ismPanel = new ISMPanel();
                ismPanel.TopLevel = false;
                this.panel1.Controls.Add(ismPanel);           
                ismPanel.WindowState = FormWindowState.Maximized;
                ismPanel.FormBorderStyle = FormBorderStyle.None;
                ismPanel.BringToFront();
                ismPanel.Show();
                //toolStripStatusLabel1.Text = FormObject.account + "，欢迎您登录智慧城市火灾风险评估系统！";
                toolStripStatusLabel2.Text = DateTime.Now.ToString();          
            }
            catch
            {
                this.Close();
            }
            
        }

        #region 点击窗体任意位置移动窗体
        private Point offset;
        private void MainFrm_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void MainFrm_MouseMove(object sender, MouseEventArgs e)
        {           
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }

        #endregion

        #region 关闭panel内所有的窗体
        public void CloseAllPanelForm()
        {
            foreach (var v in panel1.Controls)
            {
                if (v is Form)
                {
                    (v as Form).Close();
                }
            }
        }

        #endregion


        private void opGisFrmBtn_Click(object sender, EventArgs e)
        {
            if (StaticForm.GisForm==null)
            {
                StaticForm.GisForm = new GisFrm();
                StaticForm.GisForm.Show();
            }
            else
            {
                StaticForm.GisForm.Show();
            }
            this.Hide();
        }


        #region 主界面按钮设置
        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            CloseAllPanelForm();
            ISMPanel ismPanel = new ISMPanel();
            ismPanel.TopLevel = false;
            this.panel1.Controls.Add(ismPanel);
            ismPanel.WindowState = FormWindowState.Maximized;
            ismPanel.FormBorderStyle = FormBorderStyle.None;
            ismPanel.BringToFront();
            ismPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            CloseAllPanelForm();
            AssessmentModelPanel assessmentMode = new AssessmentModelPanel();
            assessmentMode.TopLevel = false;
            this.panel1.Controls.Add(assessmentMode);
            assessmentMode.WindowState = FormWindowState.Maximized;
            assessmentMode.FormBorderStyle = FormBorderStyle.None;
            assessmentMode.BringToFront();
            assessmentMode.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            CloseAllPanelForm();
            GISAnalysisPanel gisAnalysisPanel = new GISAnalysisPanel();
            gisAnalysisPanel.TopLevel = false;
            this.panel1.Controls.Add(gisAnalysisPanel);
            gisAnalysisPanel.WindowState = FormWindowState.Maximized;
            gisAnalysisPanel.FormBorderStyle = FormBorderStyle.None;
            gisAnalysisPanel.BringToFront();
            gisAnalysisPanel.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            CloseAllPanelForm();
            FireRiskAssessmentPanel fireRiskAssessmentPanel = new FireRiskAssessmentPanel();
            fireRiskAssessmentPanel.TopLevel = false;
            this.panel1.Controls.Add(fireRiskAssessmentPanel);
            fireRiskAssessmentPanel.WindowState = FormWindowState.Maximized;
            fireRiskAssessmentPanel.FormBorderStyle = FormBorderStyle.None;
            fireRiskAssessmentPanel.BringToFront();
            fireRiskAssessmentPanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            CloseAllPanelForm();
            StaffManagementPanel staffManagementPanel = new StaffManagementPanel();
            staffManagementPanel.TopLevel = false;
            this.panel1.Controls.Add(staffManagementPanel);
            staffManagementPanel.WindowState = FormWindowState.Maximized;
            staffManagementPanel.FormBorderStyle = FormBorderStyle.None;
            staffManagementPanel.BringToFront();
            staffManagementPanel.Show();
        }
        #endregion


        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            if(StaticForm.GisForm != null)
            {
                StaticForm.GisForm.Close();
            }

            this.Close();
        }


        /// <summary>
        /// Timer组件设置主界面左下角时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }


        /// <summary>
        /// 改变窗体大小时，panel内的窗体随之改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_SizeChanged(object sender, EventArgs e)
        {
            foreach (var v in panel1.Controls)
            {
                //如果是新窗体
                if (v is Form)
                {
                    //新窗体先变为正常大小
                    (v as Form).WindowState = FormWindowState.Normal;
                    //新窗体再变为最大化以适应新的Size
                    (v as Form).WindowState = FormWindowState.Maximized;
                }
            }
        }
    }
}
