using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;
using Verse;
using Verse.AI;

namespace SYR_StoneRebalance
{
    /*public class StoneRebalanceCore : Mod
    {
        public static StoneRebalanceSettings settings;

        public StoneRebalanceCore(ModContentPack content) : base(content)
        {
            settings = GetSettings<StoneRebalanceSettings>();
            var harmony = new Harmony("Syrchalis.Rimworld.StoneRebalance");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        public override string SettingsCategory() => "SyrStoneRebalanceSettingsCategory".Translate();

        public override void DoSettingsWindowContents(Rect inRect)
        {
            checked
            {
                Listing_Standard listing_Standard = new Listing_Standard();
                listing_Standard.Begin(inRect);
                //listing_Standard.CheckboxLabeled("SyrThrumkin_useUnsupportedHair".Translate(), ref SyrNagaSettings.useUnsupportedHair, ("SyrThrumkin_useUnsupportedHairTooltip".Translate()));
                //listing_Standard.Gap(24f);
                if (listing_Standard.ButtonText("SyrStoneRebalance_defaultSettings".Translate(), "SyrStoneRebalance_defaultSettingsTooltip".Translate()))
                {
                    //SyrNagaSettings.useUnsupportedHair = false;
                }
                listing_Standard.End();
                settings.Write();
            }
        }
        public override void WriteSettings()
        {
            base.WriteSettings();
        }
    }*/
}
