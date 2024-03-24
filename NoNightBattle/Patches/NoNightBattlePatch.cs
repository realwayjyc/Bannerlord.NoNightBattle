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
        [HarmonyPostfix]
        public static void GetHourOfDay(DefaultMapWeatherModel __instance,ref float __result)
        {
            if (__result <= 6.0f)
            {
                __result = 6f;
            }
            else if (__result >=18.0f)
            {
                __result = 18.0f;
            }
        }
    }
}
