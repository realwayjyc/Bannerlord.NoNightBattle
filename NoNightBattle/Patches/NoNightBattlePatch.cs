using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;

namespace NoNightBattle.Patches
{
    [HarmonyPatch(typeof(DefaultMapWeatherModel), "GetHourOfDay")]
    internal class NoNightBattlePatch
    {
        [HarmonyPrefix]
        public static bool GetHourOfDay(ref float __result)
        {
            __result =(float) CampaignTime.Now.ToHours;
            if (__result <= 9.0f)
            {
                __result = 9f;
            }
            else if (__result >=15.0f)
            {
                __result = 15.0f;
            }
            
            return false;
        }
    }
}
