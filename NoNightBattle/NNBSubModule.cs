using HarmonyLib;
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
            TaleWorlds.MountAndBlade.MessageManager.DisplayMessage("NoNightBattle Started");
        }
    }
}
