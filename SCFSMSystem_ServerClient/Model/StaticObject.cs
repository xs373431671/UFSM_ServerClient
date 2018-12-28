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

        public static int[,] FirePossibility = new int[10, 9];
        public static int[,] FireDestructive = new int[10, 8];
        public static int[,] FireResistance = new int[10, 8];

        public static Dictionary<string, double> IndexWeight = new Dictionary<string, double>()
        { { "人口密度",0}, { "人口素质",0 }, { "建筑耐火等级分布",0 }, {"用电线路负荷",0 }, {"用电线路老化情况",0 }, {"重点防火单位防火巡查情况", 0},
            { "建筑建设年限及分布情况",0 }, {"消防安全宣传情况",0 }, {"时间因素",0 }, {"高层建筑数量及面积情况",0 }, {"地下人流密集空间面积",0 },
            { "易燃易爆仓储分布情况",0 }, {"火灾风险抵御能力",0 }, {"建筑密度",0 }, {"经济密度",0 }, {"重点防火单位数量",0 }, {"用地属性及面积",0 }
            , {"消防站能力覆盖情况",0 }, {"消防站装备配备情况",0 }, {"公共消防设施建设情况",0 }, {"灭火救援预案情况",0 }, {"同医疗与交通部门应急联动情况",0 },
            { "重点消防单位消防自建情况",0 }, {"消防安全管理情况",0 }, {"道路拥挤情况",0 } };
    }
}
