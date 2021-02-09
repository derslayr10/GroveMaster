using BepInEx;
using RoR2;
using GroveMaster.Helpers;
using System;
using System.Collections.Generic;
using R2API;
using R2API.Utils;

namespace GroveMaster
{
    [BepInDependency("com.bepis.r2api")]
    //Change these
    [BepInPlugin("com.Derslayr.Grovemaster", "The Grovemaster", "1.0.0")]
    [R2APISubmoduleDependency(nameof(PrefabAPI), nameof(LanguageAPI))]
    public class GroveMaster : BaseUnityPlugin
    {

        public void Awake()
        {

        }
    }
}
