// -----------------------------------------------------------------------
// <copyright file="Plugin.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace FunnyRagdolls
{
    using System;
    using Exiled.API.Features;

    /// <summary>
    /// The main plugin class.
    /// </summary>
    public class Plugin : Plugin<Config>
    {
        private static readonly Plugin InstanceValue = new Plugin();

        private Plugin()
        {
        }

        /// <summary>
        /// Gets a static instance of the <see cref="Plugin"/> class.
        /// </summary>
        public static Plugin Instance { get; } = InstanceValue;

        /// <inheritdoc />
        public override Version RequiredExiledVersion { get; } = new Version(2, 10, 0);

        /// <inheritdoc />
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.SpawningRagdoll += EventHandlers.OnSpawningRagdoll;
            base.OnEnabled();
        }

        /// <inheritdoc />
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.SpawningRagdoll -= EventHandlers.OnSpawningRagdoll;
            base.OnDisabled();
        }
    }
}