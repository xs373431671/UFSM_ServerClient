using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCFSMSystem_ServerClient
{
    public partial class GisFrm_AttributeFrm : Form
    {
        public GisFrm_AttributeFrm()
        {
            InitializeComponent();
        }

        //要查询的属性图层
        private IFeatureLayer _curFeatureLayer; //由toc右键菜单代码赋予，获取右键点击图层的要素图层
        public IFeatureLayer CurFeatureLayer
        {
            get { return _curFeatureLayer; }
            set { _curFeatureLayer = value; }
        }


        public void InitUI()
        {
            if (_curFeatureLayer == null) return;

            IFeature pFeature = null;
            DataTable pFeatDT = new DataTable(); //创建数据表
            DataRow pDataRow = null; //数据表行变量
            DataColumn pDataCol = null; //数据表列变量
            IField pField = null;
            for (int i = 0; i < _curFeatureLayer.FeatureClass.Fields.FieldCount; i++)  //获取要素字段，并添加字段信息（初始化每一列的表头，为表添加列）
            {
                pDataCol = new DataColumn();
                pField = _curFeatureLayer.FeatureClass.Fields.get_Field(i);
                pDataCol.ColumnName = pField.AliasName; //获取字段名作为列标题
                pDataCol.DataType = Type.GetType("System.Object");//定义列字段类型
                pFeatDT.Columns.Add(pDataCol); //在数据表中添加字段信息
            }

            IFeatureCursor pFeatureCursor = _curFeatureLayer.Search(null, true);
            pFeature = pFeatureCursor.NextFeature();//此处是一个指针，第一次运行指向表头，每运行一次指向下一行（类似于sqlDataReader）
            while (pFeature != null)
            {
                pDataRow = pFeatDT.NewRow();
                //获取字段属性
                for (int k = 0; k < pFeatDT.Columns.Count; k++)
                {
                    pDataRow[k] = pFeature.get_Value(k);
                }

                pFeatDT.Rows.Add(pDataRow); //在数据表中添加字段属性信息
                pFeature = pFeatureCursor.NextFeature();
            }
            //释放指针
            System.Runtime.InteropServices.Marshal.ReleaseComObject(pFeatureCursor);

            //dataGridAttribute.BeginInit();
            dataGridView1.DataSource = pFeatDT;
            //dataGridAttribute.EndInit();
        }
    }
}
