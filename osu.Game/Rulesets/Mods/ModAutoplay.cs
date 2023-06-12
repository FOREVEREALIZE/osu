// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Localisation;
using osu.Game.Beatmaps;
using osu.Game.Graphics;
using osu.Game.Replays;

namespace osu.Game.Rulesets.Mods
{
    public abstract class ModAutoplay : Mod, IApplicableFailOverride
    {
        public override string Name => "Autoplay";
        public override string Acronym => "AT";
        public override IconUsage? Icon => OsuIcon.ModAuto;
        public override ModType Type => ModType.Automation;
        public override LocalisableString Description => "Watch a perfect automated play through the song.";
        public override double ScoreMultiplier => 1;

        public bool PerformFail() => false;

        public bool RestartOnFail => false;

        public override bool UserPlayable => true;
        public override bool ValidForMultiplayer => true;
        public override bool ValidForMultiplayerAsFreeMod => true;

        public override Type[] IncompatibleMods => new[] { typeof(ModCinema), typeof(ModRelax), typeof(ModFailCondition), typeof(ModNoFail), typeof(ModAdaptiveSpeed) };

        public override bool HasImplementation => GetType().GenericTypeArguments.Length == 0;
    }
}
