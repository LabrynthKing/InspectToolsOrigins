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

namespace InspectToolsOrigins;

[Menu("Inspect Tools - Origins")]
public class Config : ConfigFile
{
    [Toggle(LabelLanguageId = "EnableRandom", TooltipLanguageId = "EnableRandom_ToolTip", Order = 1)]
    public bool EnableRandom;

    [Toggle(LabelLanguageId = "EnableRandomAirBladder", TooltipLanguageId = "EnableRandomAirBladder_ToolTip",
        Order = 25)]
    public bool EnableRandomAirBladder;

    [Toggle(LabelLanguageId = "EnableRandomFlare", TooltipLanguageId = "EnableRandomFlare_ToolTip", Order = 15)]
    public bool EnableRandomFlare;

    [Toggle(LabelLanguageId = "EnableRandomFlashLight", TooltipLanguageId = "EnableRandomFlashLight_ToolTip",
        Order = 7)]
    public bool EnableRandomFlashLight;

    [Toggle(LabelLanguageId = "EnableRandomHabitatBuilder", TooltipLanguageId = "EnableRandomHabitatBuilder_ToolTip",
        Order = 9)]
    public bool EnableRandomHabitatBuilder;

    [Toggle(LabelLanguageId = "EnableRandomKnife", TooltipLanguageId = "EnableRandomKnife_ToolTip", Order = 3)]
    public bool EnableRandomKnife;

    [Toggle(LabelLanguageId = "EnableRandomLaserCutter", TooltipLanguageId = "EnableRandomLaserCutter_ToolTip",
        Order = 27)]
    public bool EnableRandomLaserCutter;

    [Toggle(LabelLanguageId = "EnableRandomPathfinder", TooltipLanguageId = "EnableRandomPathfinder_ToolTip",
        Order = 23)]
    public bool EnableRandomPathfinder;

    [Toggle(LabelLanguageId = "EnableRandomPropulsionCannon",
        TooltipLanguageId = "EnableRandomPropulsionCannon_ToolTip", Order = 19)]
    public bool EnableRandomPropulsionCannon;

    [Toggle(LabelLanguageId = "EnableRandomRepairTool", TooltipLanguageId = "EnableRandomRepairTool_ToolTip",
        Order = 11)]
    public bool EnableRandomRepairTool;

    [Toggle(LabelLanguageId = "EnableRandomRepulsionCannon", TooltipLanguageId = "EnableRandomRepulsionCannon_ToolTip",
        Order = 21)]
    public bool EnableRandomRepulsionCannon;

    [Toggle(LabelLanguageId = "EnableRandomScanner", TooltipLanguageId = "EnableRandomScanner_ToolTip", Order = 5)]
    public bool EnableRandomScanner;

    [Toggle(LabelLanguageId = "EnableRandomSeaglide", TooltipLanguageId = "EnableRandomSeaglide_ToolTip", Order = 13)]
    public bool EnableRandomSeaglide;

    [Toggle(LabelLanguageId = "EnableRandomStasisRifle", TooltipLanguageId = "EnableRandomStasisRifle_ToolTip",
        Order = 17)]
    public bool EnableRandomStasisRifle;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 2)]
    public float RandomChance;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 26)]
    public float RandomChanceAirBladder;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 16)]
    public float RandomChanceFlare;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 8)]
    public float RandomChanceFlashLight;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 10)]
    public float RandomChanceHabitatBuilder;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 4)]
    public float RandomChanceKnife;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 28)]
    public float RandomChanceLaserCutter;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 24)]
    public float RandomChancePathfinder;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 20)]
    public float RandomChancePropulsionCannon;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 12)]
    public float RandomChanceRepairTool;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 22)]
    public float RandomChanceRepulsionCannon;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 6)]
    public float RandomChanceScanner;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 14)]
    public float RandomChanceSeaglide;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip2", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %", Order = 18)]
    public float RandomChanceStasisRifle;
}