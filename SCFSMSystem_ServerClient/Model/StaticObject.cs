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

        public static string[] efficiencyFactor_3Percent = {"乙醛","丙酮","丙烯腈","乙酸戊酯","戊醇","苯","丁二烯","丁烷","丁烯","乙酸丁酯","一氧化碳氰","甲基异丙基苯","癸烷","二氯苯","二氯乙烷","二甲醚","乙烷","乙醇","乙醇乙酯","乙胺","乙苯","氯乙烷","甲酸乙酯","丙酸乙酯","糠醇","庚烷","已烷","氢氰酸","氢","硫化氢","异丁醇","异丁烯","异丙醇","甲烷","甲醇","乙酸甲酯","甲胺","甲基丁基酮","氯甲烷","甲基乙基酮","甲酸甲酯","甲硫醇","甲基丙基酮","萘","异辛烷","戊烷","石油醚","邻苯二甲酸酐","丙烷","丙醇","乙酸","丙烯","二氯丙烷","苯乙烯","四氟乙烯","甲苯","乙酸乙烯酯","氯乙烯","偏氯乙烯","水煤气","二甲苯"};
    
        public static string[] efficiencyFactor_6Percent = { "丙烯醛","二硫化碳","环己烷","乙醚","亚硝酸乙酯","甲基乙烯酯","环氧丙烷" };
        public static string[] efficiencyFactor_19Percent = { "乙炔","亚乙基氧","硝酸乙酯","联氯","硝酸异丙酯","丙炔","硝基甲烷","乙烯基乙炔" };

    }
}
