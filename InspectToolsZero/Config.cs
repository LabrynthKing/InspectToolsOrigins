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

using Nautilus.Json;
using Nautilus.Options.Attributes;
using UnityEngine;

namespace InspectToolsZero;

[Menu("Inspect Tools: Zero")]
public class Config : ConfigFile
{
    [Toggle(LabelLanguageId = "EnableRandom", TooltipLanguageId = "EnableRandom_ToolTip", Order = 2)]
    public bool EnableRandom;

    [Toggle(LabelLanguageId = "EnableRandomAirBladder", TooltipLanguageId = "EnableRandomAirBladder_ToolTip",
        Order = 22)]
    public bool EnableRandomAirBladder;

    [Toggle(LabelLanguageId = "EnableRandomFlare", TooltipLanguageId = "EnableRandomFlare_ToolTip", Order = 16)]
    public bool EnableRandomFlare;

    [Toggle(LabelLanguageId = "EnableRandomFlashLight", TooltipLanguageId = "EnableRandomFlashLight_ToolTip",
        Order = 8)]
    public bool EnableRandomFlashLight;

    [Toggle(LabelLanguageId = "EnableRandomHabitatBuilder", TooltipLanguageId = "EnableRandomHabitatBuilder_ToolTip",
        Order = 10)]
    public bool EnableRandomHabitatBuilder;

    [Toggle(LabelLanguageId = "EnableRandomKnife", TooltipLanguageId = "EnableRandomKnife_ToolTip", Order = 4)]
    public bool EnableRandomKnife;

    [Toggle(LabelLanguageId = "EnableRandomLaserCutter", TooltipLanguageId = "EnableRandomLaserCutter_ToolTip",
        Order = 24)]
    public bool EnableRandomLaserCutter;

    [Toggle(LabelLanguageId = "EnableRandomPathfinder", TooltipLanguageId = "EnableRandomPathfinder_ToolTip",
        Order = 20)]
    public bool EnableRandomPathfinder;

    [Toggle(LabelLanguageId = "EnableRandomPropulsionCannon",
        TooltipLanguageId = "EnableRandomPropulsionCannon_ToolTip", Order = 18)]
    public bool EnableRandomPropulsionCannon;

    [Toggle(LabelLanguageId = "EnableRandomRepairTool", TooltipLanguageId = "EnableRandomRepairTool_ToolTip",
        Order = 12)]
    public bool EnableRandomRepairTool;

    [Toggle(LabelLanguageId = "EnableRandomScanner", TooltipLanguageId = "EnableRandomScanner_ToolTip", Order = 6)]
    public bool EnableRandomScanner;

    [Toggle(LabelLanguageId = "EnableRandomSeaglide", TooltipLanguageId = "EnableRandomSeaglide_ToolTip", Order = 14)]
    public bool EnableRandomSeaglide;
    
    [Toggle(LabelLanguageId = "EnableRandomSpyPengling", TooltipLanguageId = "EnableRandomSpyPengling_ToolTip", Order = 26)]
    public bool EnableRandomSpyPengling;

    [Keybind(LabelLanguageId = "OptionInspectButton_Bind", TooltipLanguageId = "OptionDesc_InspectButton_Bind",
        Order = 1)]
    public KeyCode InspectKeyBind;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 3)]
    public float RandomChance;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 23)]
    public float RandomChanceAirBladder;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 17)]
    public float RandomChanceFlare;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 9)]
    public float RandomChanceFlashLight;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 11)]
    public float RandomChanceHabitatBuilder;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 5)]
    public float RandomChanceKnife;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 25)]
    public float RandomChanceLaserCutter;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 21)]
    public float RandomChancePathfinder;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 19)]
    public float RandomChancePropulsionCannon;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 13)]
    public float RandomChanceRepairTool;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 7)]
    public float RandomChanceScanner;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 15)]
    public float RandomChanceSeaglide;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 27)]
    public float RandomChanceSpyPengling;
}