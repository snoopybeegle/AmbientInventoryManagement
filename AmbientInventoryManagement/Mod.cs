﻿using Harmony;
using SMLHelper.V2.Handlers;
using QModManager.API.ModLoading;

namespace AmbientInventoryManagement
{
    [QModCore]
    public static class CraftData_SetItemSize
    {
        [QModPatch]
        public static void Patch()
        {
            setItemSizes();
        }

        private static void setItemSizes()
        {
            CraftDataHandler.SetItemSize(TechType.LEDLight, new Vector2int(1, 3));
            CraftDataHandler.SetItemSize(TechType.PowerCell, new Vector2int(1, 2));
        }
    }
}
