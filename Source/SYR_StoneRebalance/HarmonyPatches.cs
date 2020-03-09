using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using RimWorld;
using Verse;
using UnityEngine;
using Verse.AI;

namespace SYR_StoneRebalance
{
    [HarmonyPatch(typeof(RecipeDef), nameof(RecipeDef.WorkAmountTotal))]
    public class WorkAmountTotalPatch
    {
        [HarmonyPostfix]
        public static void WorkAmountTotal_Postfix(ref float __result, RecipeDef __instance, ThingDef stuffDef)
        {
            if (__instance == StoneRebalanceDefOf.Make_StoneBlocksAny)
            {
                __result = 1500;
            }
        }
    }

    [DefOf]
    public static class StoneRebalanceDefOf
    {
        static StoneRebalanceDefOf()
        {
        }
        public static RecipeDef Make_StoneBlocksAny;
    }
}
