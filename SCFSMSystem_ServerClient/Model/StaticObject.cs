using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SCFSMSystem_ServerClient.Model
{
    
    public static class StaticObject
    {
        public static UFSM_UserInfo user = null;
        public static List<UFSM_AreaInfo> areaList = null;

        //用于存储德尔菲专家打分矩阵，从而对各指标权重进行计算
        public static int[,] FirePossibility = new int[10, 9];
        public static int[,] FireDestructive = new int[10, 8];
        public static int[,] FireResistance = new int[10, 8];

        public static Dictionary<string, double> IndexWeight = new Dictionary<string, double>()
        { { "人口密度",0.11}, { "人口素质",0.11 }, { "建筑耐火等级分布",0.11}, {"用电线路负荷",0.11}, {"用电线路老化情况",0.11 }, {"重点防火单位防火巡查情况", 0.11},
            { "建筑建设年限及分布情况",0.11}, {"消防安全宣传情况",0.11 }, {"时间因素",0.11 }, {"高层建筑数量及面积情况",0.125 }, {"地下人流密集空间面积",0.125 },
            { "易燃易爆仓储分布情况",0.125 }, {"火灾风险抵御能力",0.125 }, {"建筑密度",0.125 }, {"经济密度",0.125 }, {"重点防火单位数量",0.125 }, {"用地属性及面积",0.125 }
            , {"消防站能力覆盖情况",0.125 }, {"消防站装备配备情况",0.125 }, {"公共消防设施建设情况",0.125 }, {"灭火救援预案情况",0.125 }, {"同医疗与交通部门应急联动情况",0.125 },
            { "重点消防单位消防自建情况",0.125 }, {"消防安全管理情况",0.125 }, {"道路拥挤情况",0.125 } };

        public static int FirePossibilityGrade = 0;
        public static int FireDestructiveGrade = 0;
        public static int FireResistanceGrade = 0;
    }
}
