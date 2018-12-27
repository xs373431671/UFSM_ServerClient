using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCFSMSystem_ServerClient.BLL;
using SCFSMSystem_ServerClient.Model;

namespace SCFSMSystem_ServerClient.StaffManagementForm
{
    public partial class StaffManagementForm : Form
    {
        private UFSM_UserInfo user;
        public StaffManagementForm()
        {
            InitializeComponent();
        }
        private void UpdateDGV()
        {
            string outMessage;
            dataGridView1.DataSource = new UserInfoService().GetUserList(out outMessage);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowHeadersVisible = false;
            foreach (DataGridViewColumn item in this.dataGridView1.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void StaffManagementForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            //设置dataGridView绑定数据源
            UpdateDGV();

            //设置comboBox的状态
            this.comboBox1.SelectedItem = this.comboBox1.Items[0];
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            label14.Text = "NULL";
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


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            user = (UFSM_UserInfo)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            textBox3.Text = user.Name;
            textBox4.Text = user.Account;
            textBox5.Text = user.Password;
            textBox6.Text = user.Department;
            textBox7.Text = user.Email;
            textBox8.Text = user.Telephone;
            numericUpDown2.Value = user.AreaNum;
            comboBox2.SelectedIndex = user.Authority == "normal" ? 0 : 1;
            label14.Text = user.ID.ToString();
        }


        /// <summary>
        /// 添加新用户，初始密码默认123456
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UFSM_UserInfo user = new UFSM_UserInfo();
                user.Name = textBox1.Text.Trim();
                user.Account = textBox2.Text.Trim();
                user.Authority = comboBox1.SelectedIndex == 0 ? "normal" : "admin";
                if(user.Authority=="admin")
                {
                    user.AreaNum = 0;
                }
                else
                {
                    user.AreaNum = (int)numericUpDown1.Value;
                }              
                user.Password = "123456";
                if(new UserInfoService().AddUserInfo(user))
                {
                    MessageBox.Show("添加成功!");
                    UpdateDGV();
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
                
            }
            catch
            {
                MessageBox.Show("添加失败,请检查注册内容合法性后重试！");
            }
            
        }


        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                user = new UFSM_UserInfo();
                user.Name = textBox3.Text;
                user.Account = textBox4.Text;
                user.Password = textBox5.Text;
                user.Department = textBox6.Text;
                user.Email = textBox7.Text;
                user.Telephone = textBox8.Text;
                user.Authority = comboBox2.SelectedIndex == 0 ? "normal" : "admin";
                if (user.Authority == "admin")
                {
                    user.AreaNum = 0;
                }
                else
                {
                    user.AreaNum = (int)numericUpDown2.Value;
                }
                user.ID = Convert.ToInt32(label14.Text.Trim());

                DialogResult result = MessageBox.Show("确定要进行修改吗？", "敏感操作提示", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (new UserInfoService().ChangeUserInfo(user))
                    {
                        UpdateDGV();
                        MessageBox.Show("修改成功");
                    }
                    else
                    {
                        MessageBox.Show("修改失败!");
                    }
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("执行异常，请稍后再试！");
            }
                                                 
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string id = label14.Text.Trim();          
            try
            {
                user.ID = int.Parse(id);
                DialogResult result = MessageBox.Show("确定要删除吗？","敏感操作提示",MessageBoxButtons.YesNo);
                if(result== DialogResult.Yes)
                {
                    if(new UserInfoService().DeleteUserInfo(user))
                    {
                        UpdateDGV();
                        MessageBox.Show("删除成功！");
                    }
                    else
                    {
                        MessageBox.Show("删除失败!");
                    }
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("删除失败，请先选择要删除的对象!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaticForm.MainForm.Show();
        }
    }
}
