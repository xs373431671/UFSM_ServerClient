using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace SCFSMSystem_ServerClient
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Image.FromFile(@"Picture/Logo1.jpg");
            pictureBox2.Image = Image.FromFile(@"Picture/SmartCityText.jpg");

            if (!File.Exists("Xml/UserInfo.xml")) //判断用户信息xml文件（用于存储帐号密码）是否存在，,存则调取信息，不存在则创建，然后调取信息
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);

                XmlElement userInfo = doc.CreateElement("UserInfo");
                doc.AppendChild(userInfo);

                XmlElement userAccount = doc.CreateElement("UserAccount");
                userAccount.InnerText = null;
                userInfo.AppendChild(userAccount);

                XmlElement userPassword = doc.CreateElement("UserPassword");
                userPassword.InnerText = null;
                userInfo.AppendChild(userPassword);

                XmlElement check = doc.CreateElement("CheckInfo");
                check.InnerText = "no";
                userInfo.AppendChild(check);

                doc.Save(@"Xml/UserInfo.xml");
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"Xml/UserInfo.xml");
                XmlElement userInfo = doc.DocumentElement;  //获取根节点
                XmlNode userAccount = userInfo["UserAccount"];  //获取根节点下的UserAccount节点
                this.accountNumberTbx.Text = userAccount.InnerText;
                XmlNode userPassword = userInfo["UserPassword"]; //获取根节点下的UserPassword节点
                this.passwordTbx.Text = userPassword.InnerText;
                XmlNode checkInfo = userInfo["CheckInfo"]; //获取根节点下的UserPassword节点
                if(checkInfo.InnerText=="yes")
                {
                    rememberPasswordcheckBox.Checked = true;
                }
                else
                {
                    rememberPasswordcheckBox.Checked = false;
                }
            }
           

            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(this.rememberPasswordcheckBox.Checked) //判断记住密码是否被选中
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Xml/UserInfo.xml");
                XmlElement userInfo = doc.DocumentElement;  //获取根节点
                XmlNode userAccount = userInfo["UserAccount"];  //获取根节点下的UserAccount节点
                userAccount.InnerText=this.accountNumberTbx.Text;
                XmlNode userPassword = userInfo["UserPassword"]; //获取根节点下的UserPassword节点
                userPassword.InnerText=this.passwordTbx.Text ;
                XmlNode checkInfo = userInfo["CheckInfo"]; //获取根节点下的checkInfo节点
                checkInfo.InnerText = "yes";
                doc.Save("Xml/UserInfo.xml");
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Xml/UserInfo.xml");
                XmlElement userInfo = doc.DocumentElement;  //获取根节点
                XmlNode userAccount = userInfo["UserAccount"];  //获取根节点下的UserAccount节点
                userAccount.InnerText = this.accountNumberTbx.Text;
                XmlNode userPassword = userInfo["UserPassword"]; //获取根节点下的UserPassword节点
                userPassword.InnerText =null;
                XmlNode checkInfo = userInfo["CheckInfo"]; //获取根节点下的checkInfo节点
                checkInfo.InnerText = "no";
                doc.Save("Xml/UserInfo.xml");
            }


            SqlHelper sh = new SqlHelper();
            if (sh.LoginJudge(accountNumberTbx.Text.Trim(),passwordTbx.Text.Trim()))//判断用户名密码是否正确
            {
                MessageBox.Show("登陆成功！");
                StaticStorage.UserName = accountNumberTbx.Text;
                this.DialogResult = DialogResult.OK;                             //向主界面返回值
                this.Close();
            }
            else
            {
                MessageBox.Show("密码或用户名错误");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;                      //向主界面返回值 
        }

        #region 点击任意位置移动窗体
        private Point offset;
        private void LoginFrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }
        private void LoginFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        #endregion
   
    }
}
