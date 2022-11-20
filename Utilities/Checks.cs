namespace ZBase.Classes
{
    internal static class Checks
    {


        public static bool IsAlive(this int health) => health >= 1
            && LocalPlayer.LifeState == (int)LifeState.Alive;

        public static bool IsMyTeam(this int team) => team == LocalPlayer.Team;

        public static bool HasTeam(this int team) => team == 2
            || team == 3;

        public static bool CanBunnyhop => LocalPlayer.MoveType != (int)MoveType_t.MOVETYPE_LADDER
            && LocalPlayer.MoveType != (int)MoveType_t.MOVETYPE_FLY
            && LocalPlayer.MoveType != (int)MoveType_t.MOVETYPE_NOCLIP
            && LocalPlayer.MoveType != (int)MoveType_t.MOVETYPE_OBSERVER
            && LocalPlayer.Flags != 262 && LocalPlayer.Flags != 256;

        public static bool IsC4(int id) => id == (int)ClassIDs.CC4
            || id == (int)ClassIDs.CPlantedC4;

        public static bool IsSniper(int id) => id == (int)ClassIDs.CWeaponAWP
            || id == (int)ClassIDs.CWeaponSSG08
            || id == (int)ClassIDs.CWeaponSCAR20
            || id == (int)ClassIDs.CWeaponG3SG1;

        public static bool IsRifle(int id) => id == (int)ClassIDs.CAK47
            || id == (int)ClassIDs.CWeaponM4A1
            || id == (int)ClassIDs.CWeaponM3
            || id == (int)ClassIDs.CWeaponSG550
            || id == (int)ClassIDs.CWeaponSG552
            || id == (int)ClassIDs.CWeaponSG556
            || id == (int)ClassIDs.CWeaponAug
            || id == (int)ClassIDs.CWeaponGalil
            || id == (int)ClassIDs.CWeaponGalilAR
            || id == (int)ClassIDs.CWeaponFamas;

        public static bool IsPistol(int id) => id == (int)ClassIDs.CDEagle
            || id == (int)ClassIDs.CWeaponCycler
            || id == (int)ClassIDs.CWeaponFiveSeven
            || id == (int)ClassIDs.CWeaponTec9
            || id == (int)ClassIDs.CWeaponUSP
            || id == (int)ClassIDs.CWeaponP250
            || id == (int)ClassIDs.CWeaponP228
            || id == (int)ClassIDs.CWeaponHKP2000
            || id == (int)ClassIDs.CWeaponGlock
            || id == (int)ClassIDs.CWeaponElite;

        public static bool IsHeavy(int id) => id == (int)ClassIDs.CWeaponXM1014
            || id == (int)ClassIDs.CWeaponNOVA
            || id == (int)ClassIDs.CWeaponMag7
            || id == (int)ClassIDs.CWeaponSawedoff
            || id == (int)ClassIDs.CWeaponNegev
            || id == (int)ClassIDs.CWeaponM249;

        public static bool IsMP(int id) => id == (int)ClassIDs.CWeaponUMP45
            || id == (int)ClassIDs.CWeaponP90
            || id == (int)ClassIDs.CWeaponMP9
            || id == (int)ClassIDs.CWeaponMP7
            || id == (int)ClassIDs.CWeaponMAC10
            || id == (int)ClassIDs.CWeaponBizon;

        public static bool IsGrenade(int id) => id == (int)ClassIDs.CBaseCSGrenade
            || id == (int)ClassIDs.CBaseCSGrenadeProjectile
            || id == (int)ClassIDs.CBaseGrenade
            || id == (int)ClassIDs.CDecoyGrenade
            || id == (int)ClassIDs.CDecoyProjectile
            || id == (int)ClassIDs.CHEGrenade
            || id == (int)ClassIDs.CIncendiaryGrenade
            || id == (int)ClassIDs.CMolotovProjectile
            || id == (int)ClassIDs.CMolotovGrenade
            || id == (int)ClassIDs.CSensorGrenade
            || id == (int)ClassIDs.CSensorGrenadeProjectile
            || id == (int)ClassIDs.CSmokeGrenade
            || id == (int)ClassIDs.CSmokeGrenadeProjectile;
    }
}