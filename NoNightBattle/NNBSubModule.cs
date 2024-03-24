using HarmonyLib;
using System;
using System.Windows.Forms;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace NoNightBattle
{
    public class NNBSubModule : MBSubModuleBase
    {
        private static readonly string Namespace = typeof(NNBSubModule).Namespace;

        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            new Harmony(Namespace).PatchAll();
        }
    }
}
