// Inspect Tools: Origins => A First Equip Animation Replay Mod For Subnautica & Subnautica: Below Zero
// Copyright (C)  2026  LabrynthKing
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published
// by the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

using System;
using HarmonyLib;

namespace InspectToolsZero.Patches;

[HarmonyPatch(typeof(QuickSlots), nameof(QuickSlots.SelectInternal))]
internal class QuickSlotsPatches
{
    private static readonly Random Random = new();

    [HarmonyPrefix]
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once UnusedMember.Local
    private static void Prefix(QuickSlots __instance, int slotID)
    {
        if (!Plugin.ModConfig.EnableRandom || uGUI_PDA.main?.tabOpen != PDATab.None ||
            (DevConsole.instance?.state ?? true)) return;

        if (slotID < 0 || slotID >= __instance.binding.Length) return;

        var targetItem = __instance.binding[slotID];
        if (targetItem?.item is null) return;

        var techy = targetItem.item.GetTechType();
        if (techy is TechType.None) return;

        if (!targetItem.item.gameObject.TryGetComponent(out PlayerTool tool) || !tool.hasFirstUseAnimation) return;

        // Plugin.Logger.LogDebug($"Checking Chance... {Plugin.ModConfig.RandomChance}");

        // It's A Tool With First Equip Anim, Now I Do Chance Shi
        if (Random.NextDouble() * 100 > Plugin.ModConfig.RandomChance)
            // Plugin.Logger.LogDebug("No Chance Bro");
            return;

        // Remove The Item So Its Forces The First Thingy
        if (Player.main.usedTools.Contains(techy))
            Player.main.usedTools.Remove(techy);

        Plugin.Logger.LogDebug($"Playing Random Inspection For {techy}...");
    }
}