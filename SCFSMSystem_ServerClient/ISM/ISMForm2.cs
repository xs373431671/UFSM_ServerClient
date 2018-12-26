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
    public partial class ISMForm2 : Form
    {
        public ISMForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\r\n邻接矩阵为：" + "\r\n";
            MatrixOperation mo = new MatrixOperation();
            mo.Output(MyMatrix.ljMatrix, richTextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "可达矩阵经计算为：" + "\r\n";
            MatrixOperation mo = new MatrixOperation();
            int[,] dwMatrix = mo.UnitMatrix(MyMatrix.ljMatrix.GetLength(0));//声明一个与全局邻接矩阵相同维度的单位矩阵
            int[,] middleMatrix = mo.MatrixAdd(MyMatrix.ljMatrix, dwMatrix); //(A+I)
            //richTextBox1.Text = richTextBox1.Text + "\r\n" + "（A+I）矩阵为：" + "\r\n";

            //mo.Output(middleMatrix, richTextBox1);
            int[,] middleMatrix2 = middleMatrix;//中间变量
            int judge = 1; //记录循环次数
            bool b = true;
            while (b)
            {
                int p = 0; //用于判断与中间矩阵是否相等，不相等为1，相等为0
                for (int i = 0; i < middleMatrix2.GetLength(0); i++)//对中间变量与处理后的变化进行遍历，看是否相等,若不相等，那么p=1，全部相等则p=0；
                {
                    for (int j = 0; j < middleMatrix2.GetLength(1); j++)
                    {
                        if (middleMatrix2[i, j] != mo.ChangehMatrix(mo.MatrixMultiply(middleMatrix2, middleMatrix))[i, j])
                        {
                            p = 1;
                        }
                    }
                }
                if (p == 0)                 //例：若p=0说明A+I=（A+I）的平方
                {
                    MyMatrix.kdMatrix = middleMatrix2;
                    mo.Output(middleMatrix2, richTextBox1);
                    b = false;
                }
                else
                {
                    middleMatrix2 = mo.MatrixMultiply(middleMatrix2, middleMatrix);
                    middleMatrix2 = mo.ChangehMatrix(middleMatrix2);
                    judge = judge + 1;
                    //richTextBox1.Text = richTextBox1.Text + "\r\n" + "(A+I)的：" + judge + "次方为：" + "\r\n";
                    //mo.Output(middleMatrix2, richTextBox1);
                }
                if (judge == 30)
                {
                    MessageBox.Show("邻接矩阵不标准，请重新核对！");
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MyMatrix.kdMatrix == null) //先判断是否计算出了可达矩阵
            {
                MessageBox.Show("请先计算可达矩阵！");
                return;
            }

            List<MyMatrix> mm = new List<MyMatrix>(); //创建MyMatrix类对象集合，存放级间划分对象（27个）
            MatrixOperation mo = new MatrixOperation();

            richTextBox1.Text = richTextBox1.Text + "\r\n<<<<<<<<<<第1级间划分计算>>>>>>>>>>\r\n";
            for (int i = 0; i < MyMatrix.kdMatrix.GetLength(0); i++)  //遍历可达矩阵，对各对象的可达集、先行集、并集赋值；
            {
                MyMatrix m = new MyMatrix();  //每循环一次创建一个MyMatrix对象
                m.XB = i + 1;//存放下标

                for (int j = 0; j < MyMatrix.kdMatrix.GetLength(1); j++)
                {
                    if (MyMatrix.kdMatrix[i, j] == 1)//对象可达集赋值
                    {
                        m.KD.Add(j + 1);
                    }
                    if (MyMatrix.kdMatrix[j, i] == 1)//对象先行集赋值
                    {
                        m.XX.Add(j + 1);
                    }
                }
                m.KDnXX = m.KD.Intersect(m.XX).ToList();//取kd与xx的交集
                mo.OutputMyMatrix(m, richTextBox1);
                mm.Add(m);

            }
            //------------------------------------------------------------第二轮-------------------------------------------------
            int cs = 1;   //记录处理的次数（第几级级间划分）
            int judge = 0;//用于存放每一轮剔除元素的个数
            int judge2 = mm.Count; //存放集合中元素的个数

            while (judge != judge2)
            {

                judge = 0;
                cs = cs + 1;
                List<MyMatrix> removeMyMatrix = new List<MyMatrix>();//存放剔除出的元素
                judge2 = mm.Count;

                List<MyMatrix> lsmm = new List<MyMatrix>();
                for (int i = 0; i < mm.Count; i++)//为临时的mymatrix集合赋值，不能直接=，因为此为引用类型
                {
                    lsmm.Add(mm[i]);
                }
                for (int i = 0; i < lsmm.Count; i++)//剔除集合中的要素（其他要素中的可达集等先未剔除）
                {
                    if (mo.JudgeListAndList(lsmm[i].KD, lsmm[i].KDnXX))//判断两个list集合是否相等
                    {
                        mm.Remove(lsmm[i]);
                        removeMyMatrix.Add(lsmm[i]);
                        judge = judge + 1;
                    }
                }

                foreach (MyMatrix m in mm) //剔除集合中可达集中的被踢出要素
                {
                    for (int i = 0; i < removeMyMatrix.Count; i++)
                    {
                        m.KD.Remove(removeMyMatrix[i].XB);
                        m.XX.Remove(removeMyMatrix[i].XB);
                        m.KDnXX.Remove(removeMyMatrix[i].XB);
                    }
                }

                richTextBox1.Text = richTextBox1.Text + "\r\n" + "\r\n" + "第" + (cs - 1) + "层元素为：";
                for (int i = 0; i < removeMyMatrix.Count; i++)//循环输出剔除元素（层）
                {
                    richTextBox1.Text = richTextBox1.Text + removeMyMatrix[i].XB + " ";
                }

                richTextBox1.Text = richTextBox1.Text + "\r\n" + "\r\n<<<<<<<<<<第" + cs + "级间划分计算>>>>>>>>>>\r\n";
                foreach (MyMatrix m in mm)
                {
                    mo.OutputMyMatrix(m, richTextBox1);
                }
            }

            //--------------------------对richtextbox中的字体进行设置
            mo.ChangeKeyBold("第1层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第2层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第3层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第4层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第5层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第6层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第7层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第8层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第9层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第10层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第11层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第12层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第13层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第14层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("第15层元素为：", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第1级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第2级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第3级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第4级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第5级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第6级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第7级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第8级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第9级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第10级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第11级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第12级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第13级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第14级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第15级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
            mo.ChangeKeyBold("<<<<<<<<<<第16级间划分计算>>>>>>>>>>", FontStyle.Bold, richTextBox1, Color.Red);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            StaticForm.ISMForm.Show();
        }

        private void ISMForm2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private int frmSize = 2; //用于存放窗体放大缩小的值
        private void maxMinBtn_Click(object sender, EventArgs e)
        {
            if (frmSize % 2 == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                maxMinBtn.Text = "Min";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maxMinBtn.Text = "Max";
            }
            frmSize++;
        }
    }
}
