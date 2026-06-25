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
    [Toggle(LabelLanguageId = "EnableRandom", TooltipLanguageId = "EnableRandom_ToolTip")]
    public bool EnableRandom;

    [Slider(LabelLanguageId = "RandomChance", TooltipLanguageId = "RandomChance_ToolTip", DefaultValue = 10,
        Min = 0, Max = 100, Step = 1, Format = "{0:F0} %")]
    public float RandomChance;
}