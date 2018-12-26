using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCFSMSystem_ServerClient.ISM
{
    class MyMatrix
    {
        public static int[,] ljMatrix;  //邻接矩阵全局变量

        public static int[,] kdMatrix;  //可达矩阵全局变量

        public int XB  //用于存放对象的下标
        {
            get;
            set;
        }

        public List<int> KD = new List<int>();   //实例化对象，存放对象的可达集
        public List<int> XX = new List<int>();     //实例化对象，存放对象的先行集
        public List<int> KDnXX = new List<int>();    //用于存放对象的可达与先行的并集
    }
}
