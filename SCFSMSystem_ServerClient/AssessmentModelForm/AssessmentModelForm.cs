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

namespace SCFSMSystem_ServerClient.AssessmentModelForm
{
    public partial class AssessmentModelForm : Form
    {
        public AssessmentModelForm()
        {
            InitializeComponent();
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

        private static int witchButtonClick = 0;   //记录是哪个按钮进行了点击
        
        
        //刷新各指标权重
        private void UpdateIndexWeight()
        {
            label21.Text = "人口密度:"+ StaticObject.IndexWeight["人口密度"];
            label22.Text = "人口素质:" + StaticObject.IndexWeight["人口素质"];
            label23.Text = "建筑耐火等级分布:" + StaticObject.IndexWeight["建筑耐火等级分布"];
            label24.Text = "用电线路负荷:" + StaticObject.IndexWeight["用电线路负荷"];
            label25.Text = "用电线路老化情况:" + StaticObject.IndexWeight["用电线路老化情况"];
            label26.Text = "重点防火单位防火巡查情况:" + StaticObject.IndexWeight["重点防火单位防火巡查情况"];
            label27.Text = "建筑建设年限及分布情况:" + StaticObject.IndexWeight["建筑建设年限及分布情况"];
            label28.Text = "消防安全宣传情况:" + StaticObject.IndexWeight["消防安全宣传情况"];
            label29.Text = "时间因素:" + StaticObject.IndexWeight["时间因素"];

            label31.Text = "高层建筑数量及面积情况:" + StaticObject.IndexWeight["高层建筑数量及面积情况"];
            label32.Text = "地下人流密集空间面积:" + StaticObject.IndexWeight["地下人流密集空间面积"];
            label33.Text = "易燃易爆仓储分布情况:" + StaticObject.IndexWeight["易燃易爆仓储分布情况"];
            label34.Text = "火灾风险抵御能力:" + StaticObject.IndexWeight["火灾风险抵御能力"];
            label35.Text = "建筑密度:" + StaticObject.IndexWeight["建筑密度"];
            label36.Text = "经济密度:" + StaticObject.IndexWeight["经济密度"];
            label37.Text = "重点防火单位数量:" + StaticObject.IndexWeight["重点防火单位数量"];
            label38.Text = "用地属性及面积:" + StaticObject.IndexWeight["用地属性及面积"];

            label41.Text = "消防站能力覆盖情况:" + StaticObject.IndexWeight["消防站能力覆盖情况"];
            label42.Text = "消防站装备配备情况:" + StaticObject.IndexWeight["消防站装备配备情况"];
            label43.Text = "公共消防设施建设情况:" + StaticObject.IndexWeight["公共消防设施建设情况"];
            label44.Text = "灭火救援预案情况:" + StaticObject.IndexWeight["灭火救援预案情况"];
            label45.Text = "同医疗与交通部门应急联动情况:" + StaticObject.IndexWeight["同医疗与交通部门应急联动情况"];
            label46.Text = "重点消防单位消防自建情况:" + StaticObject.IndexWeight["重点消防单位消防自建情况"];
            label47.Text = "消防安全管理情况:" + StaticObject.IndexWeight["消防安全管理情况"];
            label48.Text = "道路拥挤情况:" + StaticObject.IndexWeight["道路拥挤情况"];
        }
        
        
        //为全局变量（专家调查表赋值）
        private void UpdateExpertTable()
        {
            if(witchButtonClick==1)
            {
                int row = 0;
                for (int i=0;i<10;i++)
                {
                    foreach(Control c in groupBox4.Controls)
                    {
                        if(c is TextBox)
                        {
                            if(c.Name==string.Format("textBox{0}",i*10+1))
                            {
                                if(c.Text=="0")
                                {
                                    row = i ;
                                    break;
                                }
                            }
                        }
                    }
                    if(row >0)
                    { break; }
                }
                if(row==0)
                { row = 9; }
                
                for(int i=0;i<row+1;i++)
                {
                    for(int j=0;j<9;j++)
                    {
                        foreach(Control c in groupBox4.Controls)
                        {
                            if(c is TextBox)
                            {
                                if(i==0)
                                {
                                    if (c.Name == string.Format("textBox{0}",j+1))
                                    {
                                        StaticObject.FirePossibility[i, j] = int.Parse(c.Text);
                                    }
                                }
                                else
                                {
                                    if(c.Name==string.Format("textBox{0}{1}",i,j+1))
                                    {
                                        StaticObject.FirePossibility[i, j] = int.Parse(c.Text);
                                    }
                                }
                                
                            }
                        }
                        
                    }
                }
            }
            else if(witchButtonClick==2)
            {
                int row = 0;
                for (int i = 0; i < 10; i++)
                {
                    foreach (Control c in groupBox4.Controls)
                    {
                        if (c is TextBox)
                        {
                            if (c.Name == string.Format("textBox{0}", i * 10 + 1))
                            {
                                if (c.Text == "0")
                                {
                                    row = i;
                                    break;
                                }
                            }
                        }
                    }
                    if (row > 0)
                    { break; }
                }
                if (row == 0)
                { row = 10; }

                for (int i = 0; i < row+1; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        foreach (Control c in groupBox4.Controls)
                        {
                            if (c is TextBox)
                            {
                                if (i == 0)
                                {
                                    if (c.Name == string.Format("textBox{0}", j + 1))
                                    {
                                        StaticObject.FireDestructive[i, j] = int.Parse(c.Text);
                                    }
                                }
                                else
                                {
                                    if (c.Name == string.Format("textBox{0}{1}", i, j + 1))
                                    {
                                        StaticObject.FireDestructive[i, j] = int.Parse(c.Text);
                                    }
                                }

                            }
                        }
                    }
                }
            }
            else if(witchButtonClick==3)
            {
                int row = 0;
                for (int i = 0; i < 10; i++)
                {
                    foreach (Control c in groupBox4.Controls)
                    {
                        if (c is TextBox)
                        {
                            if (c.Name == string.Format("textBox{0}", i * 10 + 1))
                            {
                                if (c.Text == "0")
                                {
                                    row = i;
                                    break;
                                }
                            }
                        }
                    }
                    if (row > 0)
                    { break; }
                }
                if (row == 0)
                { row = 10; }

                for (int i = 0; i < row+1; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        foreach (Control c in groupBox4.Controls)
                        {
                            if (c is TextBox)
                            {
                                if (i == 0)
                                {
                                    if (c.Name == string.Format("textBox{0}", j + 1))
                                    {
                                        StaticObject.FireResistance[i, j] = int.Parse(c.Text);
                                    }
                                }
                                else
                                {
                                    if (c.Name == string.Format("textBox{0}{1}", i, j + 1))
                                    {
                                        StaticObject.FireResistance[i, j] = int.Parse(c.Text);
                                    }
                                }

                            }
                        }

                    }
                }
            }
            else
            {
                return;
            }
        }


        private void AssessmentModelForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            StaticForm.AssessmentModelForm = this;
            numericUpDown1.Value = 10;
            foreach(Control c in groupBox4.Controls)
            {
                if(c is TextBox)
                {
                    (c as TextBox).TextAlign = HorizontalAlignment.Center;
                    c.Text = "0";
                }
                
                c.Visible = false;             
            }
            this.UpdateIndexWeight();                     
        }


        /// <summary>
        /// 控制gropBox中控件的显示于隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int a =(int)numericUpDown1.Value;
            //若a=10，则全部显示并退出方法
            if (a==10)
            {
                foreach (Control c in groupBox4.Controls)
                {
                    c.Visible = true;
                }
                if (witchButtonClick > 1)
                {
                    richTextBox9.Visible = false;                  
                    textBox9.Text = "0";
                    textBox19.Text = "0";
                    textBox29.Text = "0";
                    textBox39.Text = "0";
                    textBox49.Text = "0";
                    textBox59.Text = "0";
                    textBox69.Text = "0";
                    textBox79.Text = "0";
                    textBox89.Text = "0";
                    textBox99.Text = "0";
                    textBox9.Visible = false;
                    textBox19.Visible = false;
                    textBox29.Visible = false;
                    textBox39.Visible = false;
                    textBox49.Visible = false;
                    textBox59.Visible = false;
                    textBox69.Visible = false;
                    textBox79.Visible = false;
                    textBox89.Visible = false;
                    textBox99.Visible = false;

                }
                return;
            }
            //显示所有控件
            foreach (Control c in groupBox4.Controls)
            {
                c.Visible = true;
            }
            //计算要隐藏的TextBox
            for (int i = a*10+1; i < 100; i++)
            {
                foreach (Control c in groupBox4.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Name == string.Format("textBox{0}", i))
                        {
                            c.Text = "0";
                            c.Visible = false;
                        }
                    }
                }
            }
            //计算要隐藏的label
            for(int i=a+10;i<21;i++)
            {
                foreach (Control c in groupBox4.Controls)
                {
                    if (c is Label)
                    {
                        if (c.Name == string.Format("label{0}", i+1))
                        {
                            c.Visible = false;
                        }
                    }
                }
            }
            if(witchButtonClick>1)
            {
                richTextBox9.Visible = false;
                textBox9.Text = "0";
                textBox19.Text = "0";
                textBox29.Text = "0";
                textBox39.Text = "0";
                textBox49.Text = "0";
                textBox59.Text = "0";
                textBox69.Text = "0";
                textBox79.Text = "0";
                textBox89.Text = "0";
                textBox99.Text = "0";
                textBox9.Visible = false;
                textBox19.Visible = false;
                textBox29.Visible = false;
                textBox39.Visible = false;
                textBox49.Visible = false;
                textBox59.Visible = false;
                textBox69.Visible = false;
                textBox79.Visible = false;
                textBox89.Visible = false;
                textBox99.Visible = false;
            }           
        }


        /// <summary>
        /// 火灾可能性专家调查表设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control c in groupBox4.Controls)
            {
                c.Visible = true;
            }
            numericUpDown1.Value = 10;
            witchButtonClick = 1;
            richTextBox9.Visible = true;
            textBox9.Visible = true;
            textBox19.Visible = true;
            textBox29.Visible = true;
            textBox39.Visible = true;
            textBox49.Visible = true;
            textBox59.Visible = true;
            textBox69.Visible = true;
            textBox79.Visible = true;
            textBox89.Visible = true;
            textBox99.Visible = true;
            richTextBox1.Text = "人口密度";
            richTextBox2.Text = "人口素质";
            richTextBox3.Text = "建筑耐火等级分布";
            richTextBox4.Text = "用电线路负荷";
            richTextBox5.Text = "用电线路老化情况";
            richTextBox6.Text = "重点防火单位防火巡查情况";
            richTextBox7.Text = "建筑建设年限及分布情况";
            richTextBox8.Text = "消防安全宣传情况";
            richTextBox9.Text = "时间因素";
            //richTextBox内容居中显示
            foreach(Control c in groupBox4.Controls)
            {
                if (c is RichTextBox)
                {
                    (c as RichTextBox).SelectAll();
                    (c as RichTextBox).SelectionAlignment = HorizontalAlignment.Center;
                }
            }

            //初始化gropBox4中的TextBox
            for(int i=0;i<10;i++)
            {
                for(int j=0;j<9;j++)
                {
                    foreach(Control c in groupBox4.Controls)
                    {
                        if(c is TextBox)
                        {
                            if(c.Name==string.Format("textBox{0}",i*10+j+1))
                            {
                                c.Text = StaticObject.FirePossibility[i, j].ToString();
                            }
                        }
                    }
                }
            }
            





            //正常运行后要注释
            textBox1.Text = "1";
            textBox2.Text = "2";
            textBox3.Text = "4";
            textBox4.Text = "3";
            textBox5.Text = "5";
            textBox6.Text = "7";
            textBox7.Text = "6";
            textBox8.Text = "8";
            textBox9.Text = "9";

            textBox11.Text = "8";
            textBox12.Text = "1";
            textBox13.Text = "9";
            textBox14.Text = "6";
            textBox15.Text = "3";
            textBox16.Text = "4";
            textBox17.Text = "5";
            textBox18.Text = "2";
            textBox19.Text = "7";

            textBox21.Text = "2";
            textBox22.Text = "4";
            textBox23.Text = "9";
            textBox24.Text = "6";
            textBox25.Text = "5";
            textBox26.Text = "8";
            textBox27.Text = "1";
            textBox28.Text = "3";
            textBox29.Text = "7";

            textBox31.Text = "6";
            textBox32.Text = "3";
            textBox33.Text = "8";
            textBox34.Text = "2";
            textBox35.Text = "1";
            textBox36.Text = "5";
            textBox37.Text = "9";
            textBox38.Text = "4";
            textBox39.Text = "7";

            textBox41.Text = "4";
            textBox42.Text = "2";
            textBox43.Text = "7";
            textBox44.Text = "3";
            textBox45.Text = "1";
            textBox46.Text = "6";
            textBox47.Text = "9";
            textBox48.Text = "8";
            textBox49.Text = "5";





        }


        /// <summary>
        /// 火灾危害性专家调查表设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox4.Controls)
            {
                c.Visible = true;
            }
            numericUpDown1.Value = 10;
            witchButtonClick = 2;

            richTextBox1.Text = "高层建筑数量及面积情况";
            richTextBox2.Text = "地下人流密集空间面积";
            richTextBox3.Text = "易燃易爆仓储分布情况";
            richTextBox4.Text = "火灾风险抵御能力";
            richTextBox5.Text = "建筑密度";
            richTextBox6.Text = "经济密度";
            richTextBox7.Text = "重点防火单位数量";
            richTextBox8.Text = "用地属性及面积";
            richTextBox9.Visible = false;

            textBox9.Visible = false;
            textBox19.Visible = false;
            textBox29.Visible = false;
            textBox39.Visible = false;
            textBox49.Visible = false;
            textBox59.Visible = false;
            textBox69.Visible = false;
            textBox79.Visible = false;
            textBox89.Visible = false;
            textBox99.Visible = false;
            //richTextBox内容居中显示
            foreach (Control c in groupBox4.Controls)
            {
                if (c is RichTextBox)
                {
                    (c as RichTextBox).SelectAll();
                    (c as RichTextBox).SelectionAlignment = HorizontalAlignment.Center;
                }
            }

            //初始化gropBox4中的TextBox
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    foreach (Control c in groupBox4.Controls)
                    {
                        if (c is TextBox)
                        {
                            if (c.Name == string.Format("textBox{0}", i * 10 + j + 1))
                            {
                                c.Text = StaticObject.FireDestructive[i, j].ToString();
                            }
                        }
                    }
                }
            }

        }


        /// <summary>
        /// 火灾抵御性专家调查表设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox4.Controls)
            {
                c.Visible = true;
            }
            numericUpDown1.Value = 10;
            witchButtonClick = 3;

            richTextBox1.Text = "消防站能力覆盖情况";
            richTextBox2.Text = "消防站装备配备情况";
            richTextBox3.Text = "公共消防设施建设情况";
            richTextBox4.Text = "灭火救援预案情况";
            richTextBox5.Text = "同医疗与交通部门应急联动情况";
            richTextBox6.Text = "重点消防单位消防自建情况";
            richTextBox7.Text = "消防安全管理情况";
            richTextBox8.Text = "道路拥挤情况";
            richTextBox9.Visible = false;

            textBox9.Visible = false;
            textBox19.Visible = false;
            textBox29.Visible = false;
            textBox39.Visible = false;
            textBox49.Visible = false;
            textBox59.Visible = false;
            textBox69.Visible = false;
            textBox79.Visible = false;
            textBox89.Visible = false;
            textBox99.Visible = false;
            //richTextBox内容居中显示
            foreach (Control c in groupBox4.Controls)
            {
                if (c is RichTextBox)
                {
                    (c as RichTextBox).SelectAll();
                    (c as RichTextBox).SelectionAlignment = HorizontalAlignment.Center;
                }
            }

            //初始化gropBox4中的TextBox
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    foreach (Control c in groupBox4.Controls)
                    {
                        if (c is TextBox)
                        {
                            if (c.Name == string.Format("textBox{0}", i * 10 + j + 1))
                            {
                                c.Text = StaticObject.FireResistance[i, j].ToString();
                            }
                        }
                    }
                }
            }
        }


        /// <summary>
        /// groupBox4中的textBox恢复默认值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if(witchButtonClick==1)
            {
                numericUpDown1.Value = 10;
                foreach(Control c in groupBox4.Controls)
                {
                    if(c is TextBox)
                    {
                        c.Visible = true;
                        c.Text = "0";
                    }
                }
                

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        foreach (Control c in groupBox4.Controls)
                        {
                            if (c is TextBox)
                            {
                                if (c.Name == string.Format("textBox{0}", i * 10 + j + 1))
                                {
                                    c.Text = StaticObject.FirePossibility[i, j].ToString();
                                }
                            }
                        }
                    }
                }
            }
            else if(witchButtonClick==2)
            {
                numericUpDown1.Value = 10;
                foreach (Control c in groupBox4.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Visible = true;
                        c.Text = "0";
                    }
                }
                textBox9.Visible = false;
                textBox19.Visible = false;
                textBox29.Visible = false;
                textBox39.Visible = false;
                textBox49.Visible = false;
                textBox59.Visible = false;
                textBox69.Visible = false;
                textBox79.Visible = false;
                textBox89.Visible = false;
                textBox99.Visible = false;


                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        foreach (Control c in groupBox4.Controls)
                        {
                            if (c is TextBox)
                            {
                                if (c.Name == string.Format("textBox{0}", i * 10 + j + 1))
                                {
                                    c.Text = StaticObject.FireDestructive[i, j].ToString();
                                }
                            }
                        }
                    }
                }
            }
            else if(witchButtonClick==3)
            {
                numericUpDown1.Value = 10;
                foreach (Control c in groupBox4.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Visible = true;
                        c.Text = "0";
                    }
                }
                textBox9.Visible = false;
                textBox19.Visible = false;
                textBox29.Visible = false;
                textBox39.Visible = false;
                textBox49.Visible = false;
                textBox59.Visible = false;
                textBox69.Visible = false;
                textBox79.Visible = false;
                textBox89.Visible = false;
                textBox99.Visible = false;

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        foreach (Control c in groupBox4.Controls)
                        {
                            if (c is TextBox)
                            {
                                if (c.Name == string.Format("textBox{0}", i * 10 + j + 1))
                                {
                                    c.Text = StaticObject.FireResistance[i, j].ToString();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }



        /// <summary>
        /// 外部方法：求“典型排序”矩阵的隶属度矩阵，a的i为指标，j为专家
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double[,] LiShuDuJuZhen(int[,] a)
        {
            int m = a.GetLength(1) + 2; //获取“典型排序”矩阵列数,m=9+2
            double[,] b = new double[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[i, j] = (Math.Log(m - a[i, j]) / Math.Log(m - 1));
                }
            }
            return b;
        }


        /// <summary>
        /// 计算出权重
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定执行权重计算吗？","敏感操作提醒",MessageBoxButtons.YesNo);
            if(result!=DialogResult.Yes)
            {
                return;
            }

            if (witchButtonClick==1)
            {
                //对FirePossibility进行赋值
                UpdateExpertTable();
                
                //对FirePossibility矩阵进行预处理，提取实际有值的矩阵GoodFirePossibility
                int column = StaticObject.FirePossibility.GetLength(1);
                int row=0;
                for(int i=0;i<StaticObject.FirePossibility.GetLength(0);i++)
                {
                    for(int j=0;j<StaticObject.FirePossibility.GetLength(1);j++)
                    {
                        if(StaticObject.FirePossibility[i,j]==0)
                        {
                            row = i;
                            break;
                        }                       
                    }
                    if(row>0)
                    { break; }
                }
                int[,] GoodFirePossibility = new int[row, column];
                for(int i=0;i<row;i++)
                {
                    for(int j=0;j<column;j++)
                    {
                        GoodFirePossibility[i, j] = StaticObject.FirePossibility[i, j];                       
                    }
                }
                //得到隶属矩阵
                double[,] b = LiShuDuJuZhen(GoodFirePossibility);

                //计算平均认识度p
                double[] p = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    double z = 0;
                    for (int j = 0; j < b.GetLength(0); j++)
                    {
                        z = z + b[j, i];
                    }
                    p[i] = z / b.GetLength(0);
                }

                //计算认识盲度
                double[] r = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    double z = 0;
                    double maxb = 0;
                    double minb = 99;
                    for (int j = 0; j < b.GetLength(0); j++)
                    {
                        if (maxb < b[j, i])
                        {
                            maxb = b[j, i];
                        }
                        if (minb > b[j, i])
                        {
                            minb = b[j, i];
                        }
                    }                  
                    z = Math.Abs((maxb - p[i]) + (minb - p[i])) / 2;
                    r[i] = z;
                }

                //计算总体认识度
                double[] zt = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    zt[i] = p[i] * (1 - r[i]);
            
                }

                //归一化处理
                double[] g = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    double a = 0;
                    foreach (double j in zt)
                    {
                        a = a + j;
                    }
                    g[i] = zt[i] / a;                    
                }

                //提取权重值
                StaticObject.IndexWeight["人口密度"]=double.Parse(g[0].ToString("f3"));
                StaticObject.IndexWeight["人口素质"]= double.Parse(g[1].ToString("f3"));
                StaticObject.IndexWeight["建筑耐火等级分布"]= double.Parse(g[2].ToString("f3"));
                StaticObject.IndexWeight["用电线路负荷"]= double.Parse(g[3].ToString("f3"));
                StaticObject.IndexWeight["用电线路老化情况"]= double.Parse(g[4].ToString("f3"));
                StaticObject.IndexWeight["重点防火单位防火巡查情况"]= double.Parse(g[5].ToString("f3"));
                StaticObject.IndexWeight["建筑建设年限及分布情况"]= double.Parse(g[6].ToString("f3"));
                StaticObject.IndexWeight["消防安全宣传情况"]= double.Parse(g[7].ToString("f3"));
                StaticObject.IndexWeight["时间因素"]= double.Parse(g[8].ToString("f3"));
            }
            else if(witchButtonClick==2)
            {
                //对FirePossibility进行赋值
                UpdateExpertTable();
                //对FireDestructive矩阵进行预处理，提取实际有值的矩阵GoodFirePossibility
                int column = StaticObject.FireDestructive.GetLength(1);
                int row = 0;
                for (int i = 0; i < StaticObject.FireDestructive.GetLength(0); i++)
                {
                    for (int j = 0; j < StaticObject.FireDestructive.GetLength(1); j++)
                    {
                        if (StaticObject.FireDestructive[i, j] == 0)
                        {
                            row = i;
                            break;
                        }
                    }
                    if (row > 0)
                    { break; }
                }
                int[,] GoodFireDestructive = new int[row, column];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        GoodFireDestructive[i, j] = StaticObject.FireDestructive[i, j];
                    }
                }
                //得到隶属矩阵
                double[,] b = LiShuDuJuZhen(GoodFireDestructive);

                //计算平均认识度p
                double[] p = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    double z = 0;
                    for (int j = 0; j < b.GetLength(0); j++)
                    {
                        z = z + b[j, i];
                    }
                    p[i] = z / b.GetLength(0);
                }

                //计算认识盲度
                double[] r = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    double z = 0;
                    double maxb = 0;
                    double minb = 99;
                    for (int j = 0; j < b.GetLength(0); j++)
                    {
                        if (maxb < b[j, i])
                        {
                            maxb = b[j, i];
                        }
                        if (minb > b[j, i])
                        {
                            minb = b[j, i];
                        }
                    }
                    z = Math.Abs((maxb - p[i]) + (minb - p[i])) / 2;
                    r[i] = z;
                }

                //计算总体认识度
                double[] zt = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    zt[i] = p[i] * (1 - r[i]);
                 
                }

                //归一化处理
                double[] g = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    double a = 0;
                    foreach (double j in zt)
                    {
                        a = a + j;
                    }
                    g[i] = zt[i] / a;
                }

                //提取权重值
                StaticObject.IndexWeight["高层建筑数量及面积情况"] = double.Parse(g[0].ToString("f3"));
                StaticObject.IndexWeight["地下人流密集空间面积"] = double.Parse(g[1].ToString("f3"));
                StaticObject.IndexWeight["易燃易爆仓储分布情况"] = double.Parse(g[2].ToString("f3"));
                StaticObject.IndexWeight["火灾风险抵御能力"] = double.Parse(g[3].ToString("f3"));
                StaticObject.IndexWeight["建筑密度"] = double.Parse(g[4].ToString("f3"));
                StaticObject.IndexWeight["经济密度"] = double.Parse(g[5].ToString("f3"));
                StaticObject.IndexWeight["重点防火单位数量"] = double.Parse(g[6].ToString("f3"));
                StaticObject.IndexWeight["用地属性及面积"] = double.Parse(g[7].ToString("f3"));
            }
            else if(witchButtonClick==3)
            {
                //对FirePossibility进行赋值
                UpdateExpertTable();
                //对FirePossibility矩阵进行预处理，提取实际有值的矩阵GoodFirePossibility
                int column = StaticObject.FireResistance.GetLength(1);
                int row = 0;
                for (int i = 0; i < StaticObject.FireResistance.GetLength(0); i++)
                {
                    for (int j = 0; j < StaticObject.FireResistance.GetLength(1); j++)
                    {
                        if (StaticObject.FireResistance[i, j] == 0)
                        {
                            row = i;
                            break;
                        }
                    }
                    if (row > 0)
                    { break; }
                }
                int[,] GoodFireResistance = new int[row, column];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        GoodFireResistance[i, j] = StaticObject.FireResistance[i, j];
                    }
                }
                //得到隶属矩阵
                double[,] b = LiShuDuJuZhen(GoodFireResistance);

                //计算平均认识度p
                double[] p = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    double z = 0;
                    for (int j = 0; j < b.GetLength(0); j++)
                    {
                        z = z + b[j, i];
                    }
                    p[i] = z / b.GetLength(0);
                }

                //计算认识盲度
                double[] r = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    double z = 0;
                    double maxb = 0;
                    double minb = 99;
                    for (int j = 0; j < b.GetLength(0); j++)
                    {
                        if (maxb < b[j, i])
                        {
                            maxb = b[j, i];
                        }
                        if (minb > b[j, i])
                        {
                            minb = b[j, i];
                        }
                    }
                    z = Math.Abs((maxb - p[i]) + (minb - p[i])) / 2;
                    r[i] = z;
                }

                //计算总体认识度
                double[] zt = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    zt[i] = p[i] * (1 - r[i]);                
                }

                //归一化处理
                double[] g = new double[b.GetLength(1)];
                for (int i = 0; i < b.GetLength(1); i++)
                {
                    double a = 0;
                    foreach (double j in zt)
                    {
                        a = a + j;
                    }
                    g[i] = zt[i] / a;
                }

                //提取权重值               
                StaticObject.IndexWeight["消防站能力覆盖情况"] = double.Parse(g[0].ToString("f3"));
                StaticObject.IndexWeight["消防站装备配备情况"] = double.Parse(g[1].ToString("f3"));
                StaticObject.IndexWeight["公共消防设施建设情况"] = double.Parse(g[2].ToString("f3"));
                StaticObject.IndexWeight["灭火救援预案情况"] = double.Parse(g[3].ToString("f3"));
                StaticObject.IndexWeight["同医疗与交通部门应急联动情况"] = double.Parse(g[4].ToString("f3"));
                StaticObject.IndexWeight["重点消防单位消防自建情况"] = double.Parse(g[5].ToString("f3"));
                StaticObject.IndexWeight["消防安全管理情况"] = double.Parse(g[6].ToString("f3"));
                StaticObject.IndexWeight["道路拥挤情况"] = double.Parse(g[7].ToString("f3"));
            }
            else
            {
                return;
            }
            this.UpdateIndexWeight();
            foreach(Control c in groupBox4.Controls)
            {
                c.Visible = false;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaticForm.MainForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaticForm.MainForm.Show();
        }
    }
}
