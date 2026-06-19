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

using System.Collections;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Nautilus.Handlers;
using UnityEngine;

namespace InspectToolsZero;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
[BepInDependency("com.snmodding.nautilus")]
public class Plugin : BaseUnityPlugin
{
    private bool _isInspecting;

    private static Config ModConfig { get; set; }

    public new static ManualLogSource Logger { get; private set; }

    private static Assembly Assembly { get; } = Assembly.GetExecutingAssembly();

    private void Awake()
    {
        Logger = base.Logger;

        // Register Localization
        LanguageHandler.RegisterLocalizationFolder();

        ModConfig = OptionsPanelHandler.RegisterModOptions<Config>();

        Harmony.CreateAndPatchAll(Assembly, $"{PluginInfo.PLUGIN_GUID}");
        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
    }

    private void Update()
    {
        if (Player.main is null || Inventory.main is null || uGUI_PDA.main?.tabOpen != PDATab.None ||
            (DevConsole.instance?.state ?? true)) return;

        if (_isInspecting) return;

        if (!Input.GetKeyDown(KeyCode.I)) return;

        var heldTool = Inventory.main.GetHeldTool();
        if (heldTool is null || !heldTool.hasFirstUseAnimation) return;

        var techy = heldTool.pickupable.GetTechType();
        if (techy is TechType.None) return;

        var quickSlots = Inventory.main.quickSlots;

        var item = heldTool.pickupable.inventoryItem;
        var slot = quickSlots.GetSlotByItem(item);
        if (slot == -1) return;

        StartCoroutine(InspectRoutine(quickSlots, slot, techy, heldTool.holsterTime));
    }

    private IEnumerator InspectRoutine(QuickSlots quickSlots, int slot, TechType techy, float holsterTime)
    {
        _isInspecting = true;
        Logger.LogInfo($"Inspecting tool: {techy}");

        if (Player.main.usedTools.Contains(techy))
            Player.main.usedTools.Remove(techy);

        quickSlots.DeselectImmediate();

        yield return new WaitForSeconds(holsterTime + 0.01f);

        quickSlots.SelectImmediate(slot);

        _isInspecting = false;
    }
}