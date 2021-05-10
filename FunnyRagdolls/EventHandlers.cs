// -----------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace FunnyRagdolls
{
    using Exiled.API.Features;
    using Exiled.Events.EventArgs;

    /// <summary>
    /// Methods which subscribe to events in <see cref="Exiled.Events.Handlers"/>.
    /// </summary>
    public static class EventHandlers
    {
        private static Config Config => Plugin.Instance.Config;

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnSpawningRagdoll(SpawningRagdollEventArgs)"/>
        public static void OnSpawningRagdoll(SpawningRagdollEventArgs ev)
        {
            Log.Debug($"{ev.Killer?.Nickname} killed {ev.PlayerNickname}, checking.");
            var dmgConfig = Config.Multipliers;
            float multiplier = ev.HitInformations.GetDamageName() switch
            {
                "NONE" => dmgConfig.None,
                "LURE" => dmgConfig.Lure,
                "NUKE" => dmgConfig.Nuke,
                "WALL" => dmgConfig.Wall,
                "DECONT" => dmgConfig.Decont,
                "TESLA" => dmgConfig.Tesla,
                "FALLDOWN" => dmgConfig.Falldown,
                "Flying detection" => dmgConfig.Flying,
                "Friendly fire detector" => dmgConfig.FriendlyFireDetector,
                "RECONTAINMENT" => dmgConfig.Recontainment,
                "BLEEDING" => dmgConfig.Bleeding,
                "POISONED" => dmgConfig.Poison,
                "ASPHYXIATION" => dmgConfig.Asphyxiation,
                "CONTAIN" => dmgConfig.Contain,
                "POCKET" => dmgConfig.Pocket,
                "RAGDOLL-LESS" => dmgConfig.RagdollLess,
                "Com15" => dmgConfig.Com15,
                "P90" => dmgConfig.P90,
                "E11 Standard Rifle" => dmgConfig.E11,
                "MP7" => dmgConfig.Mp7,
                "USP" => dmgConfig.Usp,
                "MicroHID" => dmgConfig.Micro,
                "GRENADE" => dmgConfig.Grenade,
                "SCP-049" => dmgConfig.Scp049,
                "SCP-049-2" => dmgConfig.Scp0492,
                "SCP-096" => dmgConfig.Scp096,
                "SCP-106" => dmgConfig.Scp106,
                "SCP-173" => dmgConfig.Scp173,
                "SCP-939" => dmgConfig.Scp939,
                "SCP-207" => dmgConfig.Scp207,
                "Logicier" => dmgConfig.Logicer,
                _ => 1
            };

            Log.Debug($"Original ragdoll velocity @ {ev.Velocity}.", Config.ShowDebug);
            if (ev.Killer == null || ev.Killer?.Nickname == ev.PlayerNickname || ev.HitInformations.GetDamageType() == DamageTypes.Grenade)
            {
                Log.Debug("Self death or grenade, passing default velocity times multiplier.", Config.ShowDebug);
                ev.Velocity *= multiplier;
                Log.Debug($"Adjusted ragdoll velocity @ {ev.Velocity}.", Config.ShowDebug);
                return;
            }

            var point = ev.Killer.CameraTransform.forward * Config.BaseDistanceLine;

            Log.Debug($"Direction: {point}", Config.ShowDebug);
            Log.Debug($"Multiplier: {multiplier}", Config.ShowDebug);
            ev.Velocity = (point * multiplier) + ev.Velocity;
            Log.Debug($"Adjusted ragdoll velocity @ {ev.Velocity}.", Config.ShowDebug);
        }
    }
}