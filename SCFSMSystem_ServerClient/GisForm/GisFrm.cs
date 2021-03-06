﻿using ESRI.ArcGIS.Carto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;
using SCFSMSystem_ServerClient.Model;
using SCFSMSystem_ServerClient.BLL;

namespace SCFSMSystem_ServerClient
{
    public partial class GisFrm : Form
    {
        public GisFrm()
        {
            InitializeComponent();
            tOCControl.SetBuddyControl(mainMapControl);

            eagleEyeMapControl.Extent = mainMapControl.FullExtent;
            pEnv = eagleEyeMapControl.Extent;
            DrawRectangle(pEnv);
        }
        private void GisFrm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            if (StaticObject.user==null)
            {
                this.container1.Text = "测试用户，欢迎您使用城市火灾安全管理软件！";
            }
            else
            {
                this.container1.Text = StaticObject.user.Name + "用户，欢迎您使用城市火灾安全管理软件！";
            }
            ClearAllData();
            mainMapControl.LoadMxFile(@"太原GIS模型构建（test）\TaiYuan（new）.mxd");   //将地图文件赋予MainMapControl中的地图对象

        }

        #region 点击窗体任意处移动窗体
        private System.Drawing.Point offset;
        private void GisFrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            System.Drawing.Point cur = this.PointToScreen(e.Location);
            offset = new System.Drawing.Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void GisFrm_MouseMove(object sender, MouseEventArgs e)
        {

            if (MouseButtons.Left != e.Button) return;
            System.Drawing.Point cur = MousePosition;
            this.Location = new System.Drawing.Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        #endregion

        #region 控制窗体放大缩小
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaticForm.MainForm.Show();
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
        #endregion

        #region 定义变量

        //长度、面积量算
        //private FormMeasureResult frmMeasureResult = null;   //量算结果窗体
        //private INewLineFeedback pNewLineFeedback;           //追踪线对象
        //private INewPolygonFeedback pNewPolygonFeedback;     //追踪面对象
        //private IPoint pPointPt = null;                      //鼠标点击点
        //private IPoint pMovePt = null;                       //鼠标移动时的当前点
        //private double dToltalLength = 0;                    //量测总长度
        //private double dSegmentLength = 0;                   //片段距离
        //private IPointCollection pAreaPointCol = new MultipointClass();  //面积量算时画的点进行存储；  

        private string sMapUnits = "未知单位";             //地图单位变量
        private object missing = Type.Missing;

        ////TOC菜单
        //IFeatureLayer pTocFeatureLayer = null;            //点击的要素图层
        //private FormAtrribute frmAttribute = null;        //图层属性窗体
        //private ILayer pMoveLayer;                        //需要调整显示顺序的图层
        //private int toIndex;                              //存放拖动图层移动到的索引号     

        //鹰眼同步
        private bool bCanDrag;              //鹰眼地图上的矩形框可移动的标志
        private IPoint pMoveRectPoint;      //记录在移动鹰眼地图上的矩形框时鼠标的位置
        private IEnvelope pEnv;             //记录数据视图的Extent

        private IMap currentMap;//用于属性查询时，存放mapControl的地图;
        public IMap CurrentMap  //用于属性查询时，存放mapControl的地图;
        {
            set { this.currentMap = value; }
        }
        #endregion

        #region 封装的方法
        /// <summary>
        /// 加载工作空间里面的要素和栅格数据
        /// </summary>
        /// <param name="pWorkspace"></param>
        private void AddAllDataset(IWorkspace pWorkspace, AxMapControl mapControl)
        {
            IEnumDataset pEnumDataset = pWorkspace.get_Datasets(ESRI.ArcGIS.Geodatabase.esriDatasetType.esriDTAny);
            pEnumDataset.Reset();
            //将Enum数据集中的数据一个个读到DataSet中
            IDataset pDataset = pEnumDataset.Next();
            //判断数据集是否有数据
            while (pDataset != null)
            {
                if (pDataset is IFeatureDataset)  //要素数据集
                {
                    IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkspace;
                    IFeatureDataset pFeatureDataset = pFeatureWorkspace.OpenFeatureDataset(pDataset.Name);
                    IEnumDataset pEnumDataset1 = pFeatureDataset.Subsets;
                    pEnumDataset1.Reset();
                    IGroupLayer pGroupLayer = new GroupLayerClass();
                    pGroupLayer.Name = pFeatureDataset.Name;
                    IDataset pDataset1 = pEnumDataset1.Next();
                    while (pDataset1 != null)
                    {
                        if (pDataset1 is IFeatureClass)  //要素类
                        {
                            IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                            pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset1.Name);
                            if (pFeatureLayer.FeatureClass != null)
                            {
                                pFeatureLayer.Name = pFeatureLayer.FeatureClass.AliasName;
                                pGroupLayer.Add(pFeatureLayer);
                                mapControl.Map.AddLayer(pFeatureLayer);
                            }
                        }
                        pDataset1 = pEnumDataset1.Next();
                    }
                }
                else if (pDataset is IFeatureClass) //要素类
                {
                    IFeatureWorkspace pFeatureWorkspace = (IFeatureWorkspace)pWorkspace;
                    IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                    pFeatureLayer.FeatureClass = pFeatureWorkspace.OpenFeatureClass(pDataset.Name);

                    pFeatureLayer.Name = pFeatureLayer.FeatureClass.AliasName;
                    mapControl.Map.AddLayer(pFeatureLayer);
                }
                else if (pDataset is IRasterDataset) //栅格数据集
                {
                    IRasterWorkspaceEx pRasterWorkspace = (IRasterWorkspaceEx)pWorkspace;
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(pDataset.Name);
                    //影像金字塔判断与创建
                    IRasterPyramid3 pRasPyrmid;
                    pRasPyrmid = pRasterDataset as IRasterPyramid3;
                    if (pRasPyrmid != null)
                    {
                        if (!(pRasPyrmid.Present))
                        {
                            pRasPyrmid.Create(); //创建金字塔
                        }
                    }
                    IRasterLayer pRasterLayer = new RasterLayerClass();
                    pRasterLayer.CreateFromDataset(pRasterDataset);
                    ILayer pLayer = pRasterLayer as ILayer;
                    mapControl.AddLayer(pLayer, 0);
                }
                pDataset = pEnumDataset.Next();
            }

            mapControl.ActiveView.Refresh();
            //同步鹰眼
            SynchronizeEagleEye();
        }

        private void ClearAllData()
        {
            if (mainMapControl.Map != null && mainMapControl.Map.LayerCount > 0)
            {
                //新建mainMapControl中Map
                IMap dataMap = new MapClass();
                dataMap.Name = "Map";
                mainMapControl.DocumentFilename = string.Empty;
                mainMapControl.Map = dataMap;

                //新建EagleEyeMapControl中Map
                IMap eagleEyeMap = new MapClass();
                eagleEyeMap.Name = "eagleEyeMap";
                eagleEyeMapControl.DocumentFilename = string.Empty;
                eagleEyeMapControl.Map = eagleEyeMap;
            }
        }

        /// <summary>
        /// 获取RGB颜色
        /// </summary>
        /// <param name="intR">红</param>
        /// <param name="intG">绿</param>
        /// <param name="intB">蓝</param>
        /// <returns></returns>
        private IRgbColor GetRgbColor(int intR, int intG, int intB)
        {
            IRgbColor pRgbColor = null;
            if (intR < 0 || intR > 255 || intG < 0 || intG > 255 || intB < 0 || intB > 255)
            {
                return pRgbColor;
            }
            pRgbColor = new RgbColorClass();
            pRgbColor.Red = intR;
            pRgbColor.Green = intG;
            pRgbColor.Blue = intB;
            return pRgbColor;
        }


        #endregion

        #region 鹰眼的实现及同步
        private void mainMapControl_OnMapReplaced(object sender, IMapControlEvents2_OnMapReplacedEvent e)
        {
            SynchronizeEagleEye();
        }

        private void SynchronizeEagleEye()
        {
            if (eagleEyeMapControl.LayerCount > 0)
            {
                eagleEyeMapControl.ClearLayers();
            }
            //设置鹰眼和主地图的坐标系统一致
            eagleEyeMapControl.SpatialReference = mainMapControl.SpatialReference;
            for (int i = mainMapControl.LayerCount - 1; i >= 0; i--)
            {
                //使鹰眼视图与数据视图的图层上下顺序保持一致
                ILayer pLayer = mainMapControl.get_Layer(i);
                if (pLayer is IGroupLayer || pLayer is ICompositeLayer)
                {
                    ICompositeLayer pCompositeLayer = (ICompositeLayer)pLayer;
                    for (int j = pCompositeLayer.Count - 1; j >= 0; j--)
                    {
                        ILayer pSubLayer = pCompositeLayer.get_Layer(j);
                        IFeatureLayer pFeatureLayer = pSubLayer as IFeatureLayer;
                        if (pFeatureLayer != null)
                        {
                            try
                            {
                                //由于鹰眼地图较小，所以过滤点图层不添加
                                if (pFeatureLayer.FeatureClass.ShapeType != esriGeometryType.esriGeometryPoint
                                    && pFeatureLayer.FeatureClass.ShapeType != esriGeometryType.esriGeometryMultipoint)
                                {
                                    eagleEyeMapControl.AddLayer(pLayer);
                                }
                            }
                            catch
                            {

                            }                          
                        }
                    }
                }
                else
                {
                    IFeatureLayer pFeatureLayer = pLayer as IFeatureLayer;
                    if (pFeatureLayer != null)
                    {
                        try
                        {
                            if (pFeatureLayer.FeatureClass.ShapeType != esriGeometryType.esriGeometryPoint
                            && pFeatureLayer.FeatureClass.ShapeType != esriGeometryType.esriGeometryMultipoint)
                            {
                                eagleEyeMapControl.AddLayer(pLayer);
                            }
                        }
                        catch
                        {

                        }
                        
                    }
                }
                //设置鹰眼地图全图显示  
                eagleEyeMapControl.Extent = mainMapControl.FullExtent;
                pEnv = mainMapControl.Extent as IEnvelope;
                DrawRectangle(pEnv);
                eagleEyeMapControl.ActiveView.Refresh();
            }
        }

        private void eagleEyeMapControl_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            if (eagleEyeMapControl.Map.LayerCount > 0)
            {
                //按下鼠标左键移动矩形框
                if (e.button == 1)
                {
                    //如果指针落在鹰眼的矩形框中，标记可移动
                    if (e.mapX > pEnv.XMin && e.mapY > pEnv.YMin && e.mapX < pEnv.XMax && e.mapY < pEnv.YMax)
                    {
                        bCanDrag = true;
                    }
                    pMoveRectPoint = new PointClass();
                    pMoveRectPoint.PutCoords(e.mapX, e.mapY);  //记录点击的第一个点的坐标
                }
                //按下鼠标右键绘制矩形框
                //else if (e.button == 2)
                //{
                //    IEnvelope pEnvelope = eagleEyeMapControl.TrackRectangle();

                //    IPoint pTempPoint = new PointClass();
                //    pTempPoint.PutCoords(pEnvelope.XMin + pEnvelope.Width / 2, pEnvelope.YMin + pEnvelope.Height / 2);
                //    mainMapControl.Extent = pEnvelope;
                //    //矩形框的高宽和数据试图的高宽不一定成正比，这里做一个中心调整
                //    mainMapControl.CenterAt(pTempPoint);
                //}
            }
        }

        //移动矩形框
        private void eagleEyeMapControl_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            if (e.mapX > pEnv.XMin && e.mapY > pEnv.YMin && e.mapX < pEnv.XMax && e.mapY < pEnv.YMax)
            {
                //如果鼠标移动到矩形框中，鼠标换成小手，表示可以拖动
                eagleEyeMapControl.MousePointer = esriControlsMousePointer.esriPointerHand;
                if (e.button == 2)  //如果在内部按下鼠标右键，将鼠标演示设置为默认样式
                {
                    eagleEyeMapControl.MousePointer = esriControlsMousePointer.esriPointerDefault;
                }
            }
            else
            {
                //在其他位置将鼠标设为默认的样式
                eagleEyeMapControl.MousePointer = esriControlsMousePointer.esriPointerDefault;
            }

            if (bCanDrag)
            {
                double Dx, Dy;  //记录鼠标移动的距离
                Dx = e.mapX - pMoveRectPoint.X;
                Dy = e.mapY - pMoveRectPoint.Y;
                pEnv.Offset(Dx, Dy); //根据偏移量更改 pEnv 位置
                pMoveRectPoint.PutCoords(e.mapX, e.mapY);
                DrawRectangle(pEnv);
                mainMapControl.Extent = pEnv;
            }
        }

        private void eagleEyeMapControl_OnMouseUp(object sender, IMapControlEvents2_OnMouseUpEvent e)
        {
            if (e.button == 1 && pMoveRectPoint != null)
            {
                if (e.mapX == pMoveRectPoint.X && e.mapY == pMoveRectPoint.Y)
                {
                    mainMapControl.CenterAt(pMoveRectPoint);
                }
                bCanDrag = false;
            }
        }

        //绘制矩形框
        private void mainMapControl_OnExtentUpdated(object sender, IMapControlEvents2_OnExtentUpdatedEvent e)
        {
            //得到当前视图范围
            pEnv = (IEnvelope)e.newEnvelope;
            DrawRectangle(pEnv);
        }

        //在鹰眼地图上面画矩形框
        private void DrawRectangle(IEnvelope pEnvelope)
        {
            //在绘制前，清除鹰眼中之前绘制的矩形框
            IGraphicsContainer pGraphicsContainer = eagleEyeMapControl.Map as IGraphicsContainer;
            IActiveView pActiveView = pGraphicsContainer as IActiveView;
            pGraphicsContainer.DeleteAllElements();
            //得到当前视图范围
            IRectangleElement pRectangleElement = new RectangleElementClass();
            IElement pElement = pRectangleElement as IElement;
            pElement.Geometry = pEnvelope;
            //设置矩形框（实质为中间透明度面）
            IRgbColor pColor = new RgbColorClass();
            pColor = GetRgbColor(30, 144, 255);
            pColor.Transparency = 255;
            ILineSymbol pOutLine = new SimpleLineSymbolClass();
            pOutLine.Width = 2;
            pOutLine.Color = pColor;

            IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
            pColor = new RgbColorClass();
            pColor.Transparency = 0;
            pFillSymbol.Color = pColor;
            pFillSymbol.Outline = pOutLine;
            //向鹰眼中添加矩形框
            IFillShapeElement pFillShapeElement = pElement as IFillShapeElement;
            pFillShapeElement.Symbol = pFillSymbol;
            pGraphicsContainer.AddElement((IElement)pFillShapeElement, 0);
            //刷新
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }

        private void mainMapControl_OnFullExtentUpdated(object sender, IMapControlEvents2_OnFullExtentUpdatedEvent e)
        {
            //得到当前视图范围
            pEnv = (IEnvelope)e.newEnvelope;
            DrawRectangle(pEnv);
        }
        #endregion

        #region 菜单栏功能代码
        private void 加载mxd地图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Title = "打开地图文件";
            ofd.Filter = "ArcMap文档(*.mxd)|*.mxd;|ArcMap模版(*.mxt)|*.mxt|发布地图文件(*.pmf)|*.pmf|所有地图格式(*.mxd;*.mxt;*.pmf)|*.mxd;*.mxt;*.pmf";
            ofd.Multiselect = false;      //是否可进行多选
            ofd.RestoreDirectory = true;  //存储要打开的路径

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string mapFileName = ofd.FileName;
                if (mapFileName == "")
                {
                    return;
                }

                if (mainMapControl.CheckMxFile(mapFileName))
                {
                    ClearAllData();
                    mainMapControl.LoadMxFile(mapFileName);   //将地图文件赋予MainMapControl中的地图对象
                }
                else
                {
                    MessageBox.Show(mapFileName + "是无效的地图文档", "信息提示");
                    return;
                }

            }

        }

        private void 加载文件地理数据库数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IWorkspaceFactory pFileGDBWorkspaceFactory;

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;
            string pFullPath = dlg.SelectedPath;

            if (pFullPath == "")
            {
                return;
            }
            pFileGDBWorkspaceFactory = new FileGDBWorkspaceFactoryClass(); //using ESRI.ArcGIS.DataSourcesGDB;

            ClearAllData();    //新增删除数据

            //获取工作空间
            IWorkspace pWorkspace = pFileGDBWorkspaceFactory.OpenFromFile(pFullPath, 0);
            AddAllDataset(pWorkspace, mainMapControl);
        }

        private void 选评估区属性查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //新创建地图选择集窗体
            GisFrm_SelectFeatureFrm formSelection = new GisFrm_SelectFeatureFrm();
            //将当前主窗体中MapControl控件中的Map对象赋值给FormSelection窗体的CurrentMap属性
            formSelection.CurrentMap = mainMapControl.Map;
            //显示地图选择集窗体
            formSelection.Show();
        }
        #endregion

        #region TOC控件右键功能处

        IFeatureLayer clickLayer = null;//用来存放点击的要素图层
        private GisFrm_AttributeFrm attributeFrm = null;//存放图层属性窗体      
        private void tOCControl_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {
            if (e.button == 2)  //如果是右键点击
            {
                esriTOCControlItem tOCItem = esriTOCControlItem.esriTOCControlItemNone; //用来存储点击的对象
                IBasicMap basicMap = null;
                ILayer Layer = null;
                object unk = null;
                object data = null;
                tOCControl.HitTest(e.x, e.y, ref tOCItem, ref basicMap, ref Layer, ref unk, ref data); //内置方法，用来判断点击的对象，赋值给tocItem，并将图层信息赋值给layer
                clickLayer = Layer as IFeatureLayer;  //将图层信息交给clickLayer，以便给查看属性表的click时间调用
                if (tOCItem == esriTOCControlItem.esriTOCControlItemLayer && clickLayer != null) //如果点击的是图层对象
                {
                    TOCcontextMenuStrip.Show(Control.MousePosition); //打开右键菜单
                }

            }
        }

        private void 查看属性表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (attributeFrm == null || attributeFrm.IsDisposed)
            {
                attributeFrm = new GisFrm_AttributeFrm();
            }
            attributeFrm.CurFeatureLayer = clickLayer;
            attributeFrm.InitUI();
            attributeFrm.ShowDialog();
        }

        private void 缩放到图层ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clickLayer == null) return;
            (mainMapControl.Map as IActiveView).Extent = clickLayer.AreaOfInterest;
            (mainMapControl.Map as IActiveView).PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
        }



        #endregion


        private void 同步火灾风险评估结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            DialogResult result = MessageBox.Show("确定同步吗，同步数据将上传至数据库覆盖原数据，请谨慎操作！","敏感操作提示",MessageBoxButtons.YesNo);
            if(result== DialogResult.No)
            {
                label2.Visible = false;
                return;
            }
            //从数据库将areaList加载到内存中的areaList集合
            this.Cursor = Cursors.WaitCursor;
            string returnMessage = string.Empty;
            StaticObject.areaList = new AreaInfoService().GetAreaList(out returnMessage);
            if (returnMessage != "获取成功")
            {
                label2.Visible = false;
                Console.WriteLine("数据获取失败，请检查网络稍后再试！");
                return;
            }

            //根据权重结果对各区域风险分数进行计算并返回给数据库
            foreach (UFSM_AreaInfo memoryArea in StaticObject.areaList)
            {
                double? resistanceGrade = memoryArea.FireStationCapacityCoverage * StaticObject.IndexWeight["消防站能力覆盖情况"]
                                        + memoryArea.FireStationEquipment * StaticObject.IndexWeight["消防站装备配备情况"]
                                        + memoryArea.PublicFireFacilities * StaticObject.IndexWeight["公共消防设施建设情况"]
                                        + memoryArea.FireAndRescuePlan * StaticObject.IndexWeight["灭火救援预案情况"]
                                        + memoryArea.DepartmentalEmergencyResponse * StaticObject.IndexWeight["同医疗与交通部门应急联动情况"]
                                        + memoryArea.KeyBuildingsFirePreventBuilt * StaticObject.IndexWeight["重点消防单位消防自建情况"]
                                        + memoryArea.FireSafetyManagement * StaticObject.IndexWeight["消防安全管理情况"]
                                        + memoryArea.RoadCongestion * StaticObject.IndexWeight["道路拥挤情况"];

                double? destructiveGrade = memoryArea.HighBuildingsNum * StaticObject.IndexWeight["高层建筑数量及面积情况"]
                                          + memoryArea.UndergroundCrowdedSpace * StaticObject.IndexWeight["地下人流密集空间面积"]
                                          + memoryArea.DistributionOfInflammableStorage * StaticObject.IndexWeight["易燃易爆仓储分布情况"]
                                          + resistanceGrade * StaticObject.IndexWeight["火灾风险抵御能力"]
                                          + memoryArea.BuildingDensity * StaticObject.IndexWeight["建筑密度"]
                                          + memoryArea.EconomicDensity * StaticObject.IndexWeight["经济密度"]
                                          + memoryArea.DensityOfKeyBuildings * StaticObject.IndexWeight["重点防火单位数量"]
                                          + memoryArea.Attribute * StaticObject.IndexWeight["用地属性及面积"];

                double? posibilityGrade = memoryArea.PopDensity * StaticObject.IndexWeight["人口密度"]
                                         + memoryArea.PopQuality * StaticObject.IndexWeight["人口素质"]
                                         + memoryArea.BuildingFireResistanceRating * StaticObject.IndexWeight["建筑耐火等级分布"]
                                         + memoryArea.PowerLineLoad * StaticObject.IndexWeight["用电线路负荷"]
                                         + memoryArea.AgingOfPowerLines * StaticObject.IndexWeight["用电线路老化情况"]
                                         + memoryArea.FireInspectionOfKeyBuildings * StaticObject.IndexWeight["重点防火单位防火巡查情况"]
                                         + memoryArea.BuildingYears * StaticObject.IndexWeight["建筑建设年限及分布情况"]
                                         + memoryArea.FireSafetyPropaganda * StaticObject.IndexWeight["消防安全宣传情况"]
                                         + memoryArea.TimeFactor * StaticObject.IndexWeight["时间因素"];

                //StaticObject.FireResistanceGrade = (int?)resistanceGrade==null?0: (int)resistanceGrade;
                //StaticObject.FireDestructiveGrade = (int?)destructiveGrade == null?0:(int)destructiveGrade;
                //StaticObject.FirePossibilityGrade = (int?)posibilityGrade == null?0:(int)posibilityGrade;
                memoryArea.AreaRiskGrade = (byte?)(posibilityGrade * 0.5 + destructiveGrade * 0.5)==null?0:(byte?)(posibilityGrade * 0.5 + destructiveGrade * 0.5);
            }
            if (!new AreaInfoService().UpdateAreaRiskGrade(StaticObject.areaList))
            {
                MessageBox.Show(" 数据在返回数据库时更新失败，请稍后重试！");
            }

            //开始对gis界面进行可视化评估结果处理
            this.mainMapControl.Map.ClearSelection();         
            IFeatureLayer assessmentLayer = (IFeatureLayer)mainMapControl.Map.Layer[3];//获取第4层矢量图层（评估区）
            IQueryFilter queryString = new QueryFilter();
            queryString.WhereClause = "\"AreaNum\">0";
            IFeatureCursor featureCursor = assessmentLayer.Search(queryString, true);

            IFeature feature = featureCursor.NextFeature();
            while (feature != null)
            {
                //将各网格firerisk属性初始化为0
                feature.set_Value(feature.Fields.FindField("FireRisk"), 0);
                feature.Store();
                //根据内存表areaList,对网格的firerisk属性赋值
                foreach (UFSM_AreaInfo area in StaticObject.areaList)
                {
                    if (area.AreaRiskGrade == null)
                    {
                        continue;
                    }
                    if (area.AreaNum == Convert.ToInt32(feature.Value[2]))
                    {
                        feature.set_Value(feature.Fields.FindField("FireRisk"), area.AreaRiskGrade);
                        feature.Store();
                        break;
                    }
                }
                feature = featureCursor.NextFeature();
            }
            mainMapControl.ActiveView.Refresh();
            this.Cursor = Cursors.Default;           
            label2.Visible = false;
            MessageBox.Show("同步成功！");
        }

        private void 刷新评估区显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //从数据库将areaList加载到内存中的areaList集合
            this.Cursor = Cursors.WaitCursor;
            string returnMessage = string.Empty;
            StaticObject.areaList = new AreaInfoService().GetAreaList(out returnMessage);
            if (returnMessage != "获取成功")
            {
                Console.WriteLine("数据获取失败，请检查网络稍后再试！");
                return;
            }

            //开始对gis界面进行可视化评估结果处理
            this.mainMapControl.Map.ClearSelection();
            IFeatureLayer assessmentLayer = (IFeatureLayer)mainMapControl.Map.Layer[3];//获取第4层矢量图层（评估区）
            IQueryFilter queryString = new QueryFilter();
            queryString.WhereClause = "\"AreaNum\">0";
            IFeatureCursor featureCursor = assessmentLayer.Search(queryString, true);

            IFeature feature = featureCursor.NextFeature();
            while (feature != null)
            {
                //将各网格firerisk属性初始化为0
                feature.set_Value(feature.Fields.FindField("FireRisk"), 0);
                feature.Store();
                //根据内存表areaList,对网格的firerisk属性赋值
                foreach (UFSM_AreaInfo area in StaticObject.areaList)
                {
                    if (area.AreaRiskGrade == null)
                    {
                        continue;
                    }
                    if (area.AreaNum == Convert.ToInt32(feature.Value[2]))
                    {
                        feature.set_Value(feature.Fields.FindField("FireRisk"), area.AreaRiskGrade);
                        feature.Store();
                        break;
                    }
                }
                feature = featureCursor.NextFeature();
            }
            mainMapControl.ActiveView.Refresh();
            this.Cursor = Cursors.Default;
            MessageBox.Show("刷新成功！");
        }
    }
}
