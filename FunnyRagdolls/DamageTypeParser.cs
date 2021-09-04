namespace FunnyRagdolls
{
    public static class DamageTypeParser
    {
        public static float ParseMultiplier(DamageTypes.DamageType damageTypes)
        {
            var multipliers = Plugin.Instance.Config.Multipliers;
            if (damageTypes.Equals(DamageTypes.Asphyxiation))
                return multipliers.Asphyxiation;
            if (damageTypes.Equals(DamageTypes.Bleeding))
                return multipliers.Bleeding;
            if (damageTypes.Equals(DamageTypes.Com15))
                return multipliers.Com15;
            if (damageTypes.Equals(DamageTypes.Com18))
                return multipliers.Com18;
            if (damageTypes.Equals(DamageTypes.Contain))
                return multipliers.Contain;
            if (damageTypes.Equals(DamageTypes.Decont))
                return multipliers.Decont;
            if (damageTypes.Equals(DamageTypes.Falldown))
                return multipliers.Falldown;
            if (damageTypes.Equals(DamageTypes.Flying))
                return multipliers.Flying;
            if (damageTypes.Equals(DamageTypes.Grenade))
                return multipliers.Grenade;
            if (damageTypes.Equals(DamageTypes.Logicer))
                return multipliers.Logicer;
            if (damageTypes.Equals(DamageTypes.Lure))
                return multipliers.Lure;
            if (damageTypes.Equals(DamageTypes.None))
                return multipliers.None;
            if (damageTypes.Equals(DamageTypes.Nuke))
                return multipliers.Nuke;
            if (damageTypes.Equals(DamageTypes.Pocket))
                return multipliers.Pocket;
            if (damageTypes.Equals(DamageTypes.Poison))
                return multipliers.Poison;
            if (damageTypes.Equals(DamageTypes.Recontainment))
                return multipliers.Recontainment;
            if (damageTypes.Equals(DamageTypes.Revolver))
                return multipliers.Revolver;
            if (damageTypes.Equals(DamageTypes.Scp018))
                return multipliers.Scp018;
            if (damageTypes.Equals(DamageTypes.Scp049))
                return multipliers.Scp049;
            if (damageTypes.Equals(DamageTypes.Scp096))
                return multipliers.Scp096;
            if (damageTypes.Equals(DamageTypes.Scp106))
                return multipliers.Scp106;
            if (damageTypes.Equals(DamageTypes.Scp173))
                return multipliers.Scp173;
            if (damageTypes.Equals(DamageTypes.Scp207))
                return multipliers.Scp207;
            if (damageTypes.Equals(DamageTypes.Scp0492))
                return multipliers.Scp0492;
            if (damageTypes.Equals(DamageTypes.Scp939))
                return multipliers.Scp939;
            if (damageTypes.Equals(DamageTypes.Shotgun))
                return multipliers.Shotgun;
            if (damageTypes.Equals(DamageTypes.Tesla))
                return multipliers.Tesla;
            if (damageTypes.Equals(DamageTypes.Wall))
                return multipliers.Wall;
            if (damageTypes.Equals(DamageTypes.AK))
                return multipliers.Ak;
            if (damageTypes.Equals(DamageTypes.CrossVec))
                return multipliers.CrossVec;
            if (damageTypes.Equals(DamageTypes.RagdollLess))
                return multipliers.RagdollLess;
            if (damageTypes.Equals(DamageTypes.E11SR))
                return multipliers.E11;
            if (damageTypes.Equals(DamageTypes.FriendlyFireDetector))
                return multipliers.FriendlyFireDetector;
            if (damageTypes.Equals(DamageTypes.FSP9))
                return multipliers.Fsp9;
            if (damageTypes.Equals(DamageTypes.MicroHID))
                return multipliers.Micro;

            return 1f;
        }
    }
}