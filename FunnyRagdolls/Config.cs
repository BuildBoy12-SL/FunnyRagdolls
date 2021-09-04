// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace FunnyRagdolls
{
    using System.ComponentModel;
    using Exiled.API.Interfaces;

    /// <inheritdoc cref="IConfig"/>
    public class Config : IConfig
    {
        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether debug messages should be shown.
        /// </summary>
        [Description("Whether debug messages should be shown.")]
        public bool ShowDebug { get; set; } = true;

        /// <summary>
        /// Gets or sets the base multiplier which is factored into by the direction the killer is looking.
        /// </summary>
        [Description("The base multiplier which is factored into by the direction the killer is looking.")]
        public float BaseDistanceLine { get; set; } = 10f;

        /// <summary>
        /// Gets or sets all of the configs related to <see cref="DamageTypes"/> and their respective knock-back multipliers.
        /// </summary>
        [Description("All of the configs related to damagetypes and their respective knock-back multipliers.")]
        public DamageTypeConfig Multipliers { get; set; } = new DamageTypeConfig();
    }
}