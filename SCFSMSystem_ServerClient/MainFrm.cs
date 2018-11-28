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

            //toolStripStatusLabel1.Text = FormObject.account + "，欢迎您登录智慧城市火灾风险评估系统！";
            myl.Close();            
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

        private void opGisFrmBtn_Click(object sender, EventArgs e)
        {
            if(StaticForm.GisForm==null)
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if(StaticForm.GisForm != null)
            {
                StaticForm.GisForm.Close();
            }

            this.Close();
        }

        
    }
}
