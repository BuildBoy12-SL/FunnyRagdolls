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
    public class EventHandlers
    {
        private readonly Config config;

        public EventHandlers(Config config) => this.config = config;

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnSpawningRagdoll(SpawningRagdollEventArgs)"/>
        public void OnSpawningRagdoll(SpawningRagdollEventArgs ev)
        {
            Log.Debug($"{ev.Killer?.Nickname} killed {ev.PlayerNickname}, checking.", config.ShowDebug);
            float multiplier = DamageTypeParser.ParseMultiplier(ev.HitInformations.Tool);

            Log.Debug($"Original ragdoll velocity @ {ev.Velocity}.", config.ShowDebug);
            if (ev.Killer == null || ev.Killer?.Nickname == ev.PlayerNickname || ev.HitInformations.Tool.Equals(DamageTypes.Grenade))
            {
                Log.Debug("Self death or grenade, passing default velocity times multiplier.", config.ShowDebug);
                ev.Velocity *= multiplier;
                Log.Debug($"Adjusted ragdoll velocity @ {ev.Velocity}.", config.ShowDebug);
                return;
            }

            var point = ev.Killer.CameraTransform.forward * config.BaseDistanceLine;

            Log.Debug($"Direction: {point}", config.ShowDebug);
            Log.Debug($"Multiplier: {multiplier}", config.ShowDebug);
            ev.Velocity = (point * multiplier) + ev.Velocity;
            Log.Debug($"Adjusted ragdoll velocity @ {ev.Velocity}.", config.ShowDebug);
        }
    }
}