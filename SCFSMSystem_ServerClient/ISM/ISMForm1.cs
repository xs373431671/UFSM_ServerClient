using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCFSMSystem_ServerClient.Model;

namespace SCFSMSystem_ServerClient.ISM
{
    public partial class ISMForm1 : Form
    {
        public ISMForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] firstArray = richTextBox1.Text.Split('\n'); //获取richbox中每行，形成一个字符串数组，每行为一个元素
                int row = 1;
                for (int i = 0; i < firstArray.Length; i++) //判断用户输入矩阵的维度,并声明同维度二维数组secondArray
                {
                    if (firstArray[i][0] == '0' || firstArray[i][0] == '1')
                    {
                        row = i + 1;
                    }
                }
                int[,] secondArray = new int[row, row];

                for (int i = 0; i < row; i++) //将firstArray中的每个元素（行），分割放入sencondArray中
                {
                    string[] a = firstArray[i].Split(new char[] { ' ', 'x' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < row; j++)
                    {
                        secondArray[i, j] = Convert.ToInt32(a[j]);
                    }
                }
                //将secondArray邻接矩阵赋值给全局变量
                MyMatrix.ljMatrix = secondArray;
                ISMForm2 frm2 = new ISMForm2();
                frm2.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("请检测输入矩阵合法性！");
            }
            
        }

        private void ISMForm1_Load(object sender, EventArgs e)
        {
            StaticForm.ISMForm = this;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaticForm.MainForm.Show();
        }
    }
}
