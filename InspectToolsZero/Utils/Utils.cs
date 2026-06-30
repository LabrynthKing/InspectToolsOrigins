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

namespace InspectToolsZero.Utils;

internal static class Utils
{
    public static float? GetChance(TechType techType)
    {
        float? chance = Plugin.ModConfig.EnableRandom ? Plugin.ModConfig.RandomChance : null;

        switch (techType)
        {
            case TechType.Knife:
            {
                if (Plugin.ModConfig.EnableRandomKnife) chance = Plugin.ModConfig.RandomChanceKnife;
                break;
            }
            case TechType.Scanner:
            {
                if (Plugin.ModConfig.EnableRandomScanner) chance = Plugin.ModConfig.RandomChanceScanner;
                break;
            }
            case TechType.Flashlight:
            {
                if (Plugin.ModConfig.EnableRandomFlashLight) chance = Plugin.ModConfig.RandomChanceFlashLight;
                break;
            }
            case TechType.Builder:
            {
                if (Plugin.ModConfig.EnableRandomHabitatBuilder) chance = Plugin.ModConfig.RandomChanceHabitatBuilder;
                break;
            }
            case TechType.Welder:
            {
                if (Plugin.ModConfig.EnableRandomRepairTool) chance = Plugin.ModConfig.RandomChanceRepairTool;
                break;
            }
            case TechType.Seaglide:
            {
                if (Plugin.ModConfig.EnableRandomSeaglide) chance = Plugin.ModConfig.RandomChanceSeaglide;
                break;
            }
            case TechType.Flare:
            {
                if (Plugin.ModConfig.EnableRandomFlare) chance = Plugin.ModConfig.RandomChanceFlare;
                break;
            }
            case TechType.PropulsionCannon:
            {
                if (Plugin.ModConfig.EnableRandomPropulsionCannon)
                    chance = Plugin.ModConfig.RandomChancePropulsionCannon;
                break;
            }
            case TechType.DiveReel: // Dive Reel LMAO
            {
                if (Plugin.ModConfig.EnableRandomPathfinder) chance = Plugin.ModConfig.RandomChancePathfinder;
                break;
            }
            case TechType.AirBladder:
            {
                if (Plugin.ModConfig.EnableRandomAirBladder) chance = Plugin.ModConfig.RandomChanceAirBladder;
                break;
            }
            case TechType.LaserCutter:
            {
                if (Plugin.ModConfig.EnableRandomLaserCutter) chance = Plugin.ModConfig.RandomChanceLaserCutter;
                break;
            }
            case TechType.SpyPenguin:
            {
                if (Plugin.ModConfig.EnableRandomSpyPengling) chance = Plugin.ModConfig.RandomChanceSpyPengling;
                break;
            }
        }

        return chance;
    }
}