﻿using BepInEx;
using Common;

namespace IllusionFixes
{
    [BepInPlugin(GUID, PluginName, Constants.PluginsVersion)]
    public partial class ResourceUnloadOptimizations : BaseUnityPlugin
    {
        public const string GUID = "HS_Fix_ResourceUnloadOptimizations";
    }
}
