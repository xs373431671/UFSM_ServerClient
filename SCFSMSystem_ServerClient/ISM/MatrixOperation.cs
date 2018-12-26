using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCFSMSystem_ServerClient.ISM
{
    class MatrixOperation
    {
        /// <summary>
        /// 两矩阵相加
        /// </summary>
        /// <param name="a">第一个矩阵</param>
        /// <param name="b">第二个矩阵</param>
        /// <returns></returns>
        public int[,] MatrixAdd(int[,] a, int[,] b)
        {

            int aLength = a.GetLength(0); //获取维度（行数）
            int aHeight = a.GetLength(1); //获取元素个数（列数）
            int bLength = b.GetLength(0);
            int bHeight = b.GetLength(1);
            if (aLength != bLength || aHeight != bHeight)
            {
                System.Windows.Forms.MessageBox.Show("相加的两个矩阵不符合相加要求，请重新检查！");
                return null;
            }
            int[,] c = new int[aLength, aHeight]; //声明一个新数组，与传入的数组同维度
            for (int i = 0; i < aLength; i++)
            {
                for (int j = 0; j < aHeight; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            return c;
        }



        /// <summary>
        /// 两矩阵乘法
        /// </summary>
        /// <param name="a">第一个矩阵</param>
        /// <param name="b">第二个矩阵</param>
        /// <returns></returns>
        public int[,] MatrixMultiply(int[,] a, int[,] b)
        {

            int aLength = a.GetLength(0); //获取维度（行数）
            int aHeight = a.GetLength(1); //获取元素个数（列数）
            int bLength = b.GetLength(0);
            int bHeight = b.GetLength(1);
            if (aHeight != bLength)
            {
                System.Windows.Forms.MessageBox.Show("相加的两个矩阵不符合相乘要求，请重新检查！");
                return null;
            }
            int[,] c = new int[aLength, bHeight]; //声明一个新数组，与传入的数组同维度
            for (int i = 0; i < aLength; i++)      //两矩阵相乘
            {
                for (int j = 0; j < bHeight; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < aHeight; k++)
                    {
                        sum = sum + a[i, k] * b[k, j];
                    }
                    c[i, j] = sum;
                }
            }
            return c;
        }



        /// <summary>
        /// 声明单位矩阵
        /// </summary>
        /// <param name="a">矩阵的维度</param>
        /// <returns>单位矩阵</returns>
        public int[,] UnitMatrix(int a)
        {
            int[,] c = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i == j)
                    {
                        c[i, j] = 1;
                    }
                }
            }
            return c;
        }



        /// <summary>
        /// 向文本框中输出矩阵
        /// </summary>
        /// <param name="a">输出的矩阵</param>
        /// <param name="rbb">文本框对象</param>
        public void Output(int[,] a, TextBoxBase rbb)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (i == 0)
                {
                    rbb.Text = rbb.Text + "--------------------------------------------------------------------------------------" + "\r\n";
                }
                else
                {
                    rbb.Text = rbb.Text + "\r\n";
                }
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    //if(a[i,j]<10)
                    //{
                    rbb.Text = rbb.Text + a[i, j] + "  ";
                    //}
                    //else if(a[i,j]>=10&&a[i,j]<100)
                    //{
                    //    rbb.Text = rbb.Text + a[i, j] + "";
                    //}
                    //else
                    //{
                    //    rbb.Text = rbb.Text + a[i, j] + " ";
                    //}
                }
            }
            rbb.Text = rbb.Text + "\r\n" + "--------------------------------------------------------------------------------------" + "\r\n";
        }



        /// <summary>
        /// 将（A+I）矩阵大于1的元素全改为1
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int[,] ChangehMatrix(int[,] a)
        {
            int[,] c = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == 0)
                    { c[i, j] = 0; }
                    else
                    { c[i, j] = 1; }
                }
            }
            return c;
        }




        /// <summary>
        /// 用于在textbox中输出MyMatrix对象的可达集、先行、并集。
        /// </summary>
        /// <param name="m"></param>
        /// <param name="rbb"></param>
        public void OutputMyMatrix(MyMatrix m, TextBoxBase rbb)
        {
            rbb.Text = rbb.Text + "\r\n" + "------------------------------------要素" + m.XB + ":----------------------------------\r\n可达集为： ";

            foreach (int item in m.KD)
            {
                rbb.Text = rbb.Text + item + " ";
            }
            rbb.Text = rbb.Text + "\r\n先行集为：";
            foreach (int item in m.XX)
            {
                rbb.Text = rbb.Text + item + " ";
            }
            rbb.Text = rbb.Text + "\r\n可达集与先行集的并集为：";
            foreach (int item in m.KDnXX)
            {
                rbb.Text = rbb.Text + item + " ";
            }
        }




        /// <summary>
        /// 判断两List集合是否相等
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool JudgeListAndList(List<int> a, List<int> b)
        {
            if (a.Count != b.Count)
            { return false; }
            int judge = 0;//存放两集合相同元素的个数
            foreach (var itemA in a)
            {
                foreach (var itemB in b)
                {
                    if (itemA == itemB)
                    {
                        judge = judge + 1;
                    }
                }
            }
            if (judge == a.Count)
            { return true; }
            else
            { return false; }
        }






        /// <summary>
        /// 对相应的字符串替换相应的颜色
        /// </summary>
        /// <param name="key"></param>
        /// <param name="color"></param>
        /// <param name="a"></param>
        public void ChangeKeyColor(string key, Color color, RichTextBox a)
        {
            Regex regex = new Regex(key);
            //找出内容中所有的要替换的关键字
            MatchCollection collection = regex.Matches(a.Text);
            //对所有的要替换颜色的关键字逐个替换颜色    
            foreach (Match match in collection)
            {
                //开始位置、长度、颜色缺一不可
                a.SelectionStart = match.Index;
                a.SelectionLength = key.Length;
                a.SelectionColor = color;
            }
        }






        /// <summary>
        /// 对相应的字符串替换相应的加粗
        /// </summary>
        /// <param name="key"></param>
        /// <param name="color"></param>
        /// <param name="a"></param>
        public void ChangeKeyBold(string key, FontStyle aa, RichTextBox a, Color c)
        {
            Regex regex = new Regex(key);
            //找出内容中所有的要替换的关键字
            MatchCollection collection = regex.Matches(a.Text);
            //对所有的要替换颜色的关键字逐个替换颜色    
            foreach (Match match in collection)
            {
                //开始位置、长度、颜色缺一不可
                a.SelectionStart = match.Index;
                a.SelectionLength = key.Length;
                a.SelectionFont = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold); ;
                a.SelectionColor = c;
            }
        }
    }
}
