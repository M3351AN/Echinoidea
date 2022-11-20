using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ZBase.Classes;

namespace ZBase.Classes
{
    

    [StructLayout(LayoutKind.Explicit)]
    public struct GlowStruct
    {
        [FieldOffset(0x00)]
        public int EntityPointer;
        [FieldOffset(0x4)]
        public float r;
        [FieldOffset(0x8)]
        public float g;
        [FieldOffset(0xC)]
        public float b;
        [FieldOffset(0x10)]
        public float a;
        [FieldOffset(0x14)]
        public int jnk1;
        [FieldOffset(0x18)]
        public int jnk2;
        [FieldOffset(0x1C)]
        public float BloomAmount;
        [FieldOffset(0x20)]
        public int jnk3;

        [FieldOffset(0x24)]
        public bool m_bRenderWhenOccluded;
        [FieldOffset(0x25)]
        public bool m_bRenderWhenUnoccluded;
        [FieldOffset(0x2C)]
        public bool m_bFullBloom;
    };

    public struct RECT
    {
        public int left, top, right, bottom;
    }
    [StructLayout(LayoutKind.Explicit)]
    public struct Enemy_t
    {

        [FieldOffset(0x100)]//m_iHealth
        public int Health ;

        [FieldOffset(0xF4)]//m_iTeamNum
        public int Team;

        [FieldOffset(0x93D)]//m_bSpotted
        public bool Spotted;

        [FieldOffset(0x138)]//m_vecOrigin
        public System.Numerics.Vector3 Position;
    }
    public struct LocalPlayer
    {
        public static int Base { get; set; }
        public static int LifeState { get; set; }
        public static int Health { get; set; }
        public static bool Dormant { get; set; }
        public static int Flags { get; set; }
        public static int MoveType { get; set; }
        public static int Team { get; set; }
        public static int ShotsFired { get; set; }
        public static int CrosshairID { get; set; }
        public static System.Numerics.Vector3 Position { get; set; }
        public static System.Numerics.Vector3 AimPunch { get; set; }
        public static System.Numerics.Vector3 VecView { get; set; }
    }

    public struct Enemy
    {
        public int Base { get; set; }
        public int Health { get; set; }
        public int Team { get; set; }
        public bool Dormant { get; set; }
        public bool Spotted { get; set; }
        public System.Numerics.Vector3 Position { get; set; }
    }
    public enum WeaponID
    {
        DEAGLE = 1,
        BERETTAS = 2,
        FIVESEVEN = 3,
        GLOCK = 4,
        AK47 = 7,
        AUG = 8,
        AWP = 9,
        FAMAS = 10,
        G3SG1 = 11,
        GALILAR = 13,
        M249 = 14,
        M4A4 = 16,
        MAC10 = 17,
        P90 = 19,
        MP5SD = 23,
        UMP45 = 24,
        XM1014 = 25,
        BIZON = 26,
        MAG7 = 27,
        NEGEV = 28,
        SAWEDOFF = 29,
        TEC9 = 30,
        TASER = 31,
        P2000 = 32,
        MP7 = 33,
        MP9 = 34,
        NOVA = 35,
        P250 = 36,
        SCAR20 = 38,
        SG556 = 39,
        SSG08 = 40,
        KNIFE = 42,
        FLASHBANG = 43,
        HEGRENADE = 44,
        SMOKEGRENADE = 45,
        MOLOTOV = 46,
        DECOY = 47,
        INCGRENADE = 48,
        C4 = 49,
        M4A1S = 60,
        USPS = 61,
        CZ75A = 63,
        REVOLVER = 64,
    }
    public enum ClassIDs
    {
        CAI_BaseNPC,
        CAK47,
        CBaseAnimating,
        CBaseAnimatingOverlay,
        CBaseAttributableItem,
        CBaseButton,
        CBaseCombatCharacter,
        CBaseCombatWeapon,
        CBaseCSGrenade,
        CBaseCSGrenadeProjectile,
        CBaseDoor,
        CBaseEntity,
        CBaseFlex,
        CBaseGrenade,
        CBaseParticleEntity,
        CBasePlayer,
        CBasePropDoor,
        CBaseTeamObjectiveResource,
        CBaseTempEntity,
        CBaseToggle,
        CBaseTrigger,
        CBaseViewModel,
        CBaseVPhysicsTrigger,
        CBaseWeaponWorldModel,
        CBeam,
        CBeamSpotlight,
        CBoneFollower,
        CBRC4Target,
        CBreachCharge,
        CBreachChargeProjectile,
        CBreakableProp,
        CBreakableSurface,
        CC4,
        CCascadeLight,
        CChicken,
        CColorCorrection,
        CColorCorrectionVolume,
        CCSGameRulesProxy,
        CCSPlayer,
        CCSPlayerResource,
        CCSRagdoll,
        CCSTeam,
        CDangerZone,
        CDangerZoneController,
        CDEagle,
        CDecoyGrenade,
        CDecoyProjectile,
        CDrone,
        CDronegun,
        CDynamicLight,
        CDynamicProp,
        CEconEntity,
        CEconWearable,
        CEmbers,
        CEntityDissolve,
        CEntityFlame,
        CEntityFreezing,
        CEntityParticleTrail,
        CEnvAmbientLight,
        CEnvDetailController,
        CEnvDOFController,
        CEnvGasCanister,
        CEnvParticleScript,
        CEnvProjectedTexture,
        CEnvQuadraticBeam,
        CEnvScreenEffect,
        CEnvScreenOverlay,
        CEnvTonemapController,
        CEnvWind,
        CFEPlayerDecal,
        CFireCrackerBlast,
        CFireSmoke,
        CFireTrail,
        CFish,
        CFists,
        CFlashbang,
        CFogController,
        CFootstepControl,
        CFunc_Dust,
        CFunc_LOD,
        CFuncAreaPortalWindow,
        CFuncBrush,
        CFuncConveyor,
        CFuncLadder,
        CFuncMonitor,
        CFuncMoveLinear,
        CFuncOccluder,
        CFuncReflectiveGlass,
        CFuncRotating,
        CFuncSmokeVolume,
        CFuncTrackTrain,
        CGameRulesProxy,
        CGrassBurn,
        CHandleTest,
        CHEGrenade,
        CHostage,
        CHostageCarriableProp,
        CIncendiaryGrenade,
        CInferno,
        CInfoLadderDismount,
        CInfoMapRegion,
        CInfoOverlayAccessor,
        CItem_Healthshot,
        CItemCash,
        CItemDogtags,
        CKnife,
        CKnifeGG,
        CLightGlow,
        CMaterialModifyControl,
        CMelee,
        CMolotovGrenade,
        CMolotovProjectile,
        CMovieDisplay,
        CParadropChopper,
        CParticleFire,
        CParticlePerformanceMonitor,
        CParticleSystem,
        CPhysBox,
        CPhysBoxMultiplayer,
        CPhysicsProp,
        CPhysicsPropMultiplayer,
        CPhysMagnet,
        CPhysPropAmmoBox,
        CPhysPropLootCrate,
        CPhysPropRadarJammer,
        CPhysPropWeaponUpgrade,
        CPlantedC4,
        CPlasma,
        CPlayerResource,
        CPointCamera,
        CPointCommentaryNode,
        CPointWorldText,
        CPoseController,
        CPostProcessController,
        CPrecipitation,
        CPrecipitationBlocker,
        CPredictedViewModel,
        CProp_Hallucination,
        CPropCounter,
        CPropDoorRotating,
        CPropJeep,
        CPropVehicleDriveable,
        CRagdollManager,
        CRagdollProp,
        CRagdollPropAttached,
        CRopeKeyframe,
        CSCAR17,
        CSceneEntity,
        CSensorGrenade,
        CSensorGrenadeProjectile,
        CShadowControl,
        CSlideshowDisplay,
        CSmokeGrenade,
        CSmokeGrenadeProjectile,
        CSmokeStack,
        CSpatialEntity,
        CSpotlightEnd,
        CSprite,
        CSpriteOriented,
        CSpriteTrail,
        CStatueProp,
        CSteamJet,
        CSun,
        CSunlightShadowControl,
        CSurvivalSpawnChopper,
        CTablet,
        CTeam,
        CTeamplayRoundBasedRulesProxy,
        CTEArmorRicochet,
        CTEBaseBeam,
        CTEBeamEntPoint,
        CTEBeamEnts,
        CTEBeamFollow,
        CTEBeamLaser,
        CTEBeamPoints,
        CTEBeamRing,
        CTEBeamRingPoint,
        CTEBeamSpline,
        CTEBloodSprite,
        CTEBloodStream,
        CTEBreakModel,
        CTEBSPDecal,
        CTEBubbles,
        CTEBubbleTrail,
        CTEClientProjectile,
        CTEDecal,
        CTEDust,
        CTEDynamicLight,
        CTEEffectDispatch,
        CTEEnergySplash,
        CTEExplosion,
        CTEFireBullets,
        CTEFizz,
        CTEFootprintDecal,
        CTEFoundryHelpers,
        CTEGaussExplosion,
        CTEGlowSprite,
        CTEImpact,
        CTEKillPlayerAttachments,
        CTELargeFunnel,
        CTEMetalSparks,
        CTEMuzzleFlash,
        CTEParticleSystem,
        CTEPhysicsProp,
        CTEPlantBomb,
        CTEPlayerAnimEvent,
        CTEPlayerDecal,
        CTEProjectedDecal,
        CTERadioIcon,
        CTEShatterSurface,
        CTEShowLine,
        CTesla,
        CTESmoke,
        CTESparks,
        CTESprite,
        CTESpriteSpray,
        CTest_ProxyToggle_Networkable,
        CTestTraceline,
        CTEWorldDecal,
        CTriggerPlayerMovement,
        CTriggerSoundOperator,
        CVGuiScreen,
        CVoteController,
        CWaterBullet,
        CWaterLODControl,
        CWeaponAug,
        CWeaponAWP,
        CWeaponBaseItem,
        CWeaponBizon,
        CWeaponCSBase,
        CWeaponCSBaseGun,
        CWeaponCycler,
        CWeaponElite,
        CWeaponFamas,
        CWeaponFiveSeven,
        CWeaponG3SG1,
        CWeaponGalil,
        CWeaponGalilAR,
        CWeaponGlock,
        CWeaponHKP2000,
        CWeaponM249,
        CWeaponM3,
        CWeaponM4A1,
        CWeaponMAC10,
        CWeaponMag7,
        CWeaponMP5Navy,
        CWeaponMP7,
        CWeaponMP9,
        CWeaponNegev,
        CWeaponNOVA,
        CWeaponP228,
        CWeaponP250,
        CWeaponP90,
        CWeaponSawedoff,
        CWeaponSCAR20,
        CWeaponScout,
        CWeaponSG550,
        CWeaponSG552,
        CWeaponSG556,
        CWeaponSSG08,
        CWeaponTaser,
        CWeaponTec9,
        CWeaponTMP,
        CWeaponUMP45,
        CWeaponUSP,
        CWeaponXM1014,
        CWorld,
        CWorldVguiText,
        DustTrail,
        MovieExplosion,
        ParticleSmokeGrenade,
        RocketTrail,
        SmokeTrail,
        SporeExplosion,
        SporeTrail
    }

    public enum MoveType_t
    {
        MOVETYPE_NONE,
        MOVETYPE_ISOMETRIC,
        MOVETYPE_WALK,
        MOVETYPE_STEP,
        MOVETYPE_FLY,
        MOVETYPE_FLYGRAVITY,
        MOVETYPE_VPHYSICS,
        MOVETYPE_PUSH,
        MOVETYPE_NOCLIP,
        MOVETYPE_LADDER,
        MOVETYPE_OBSERVER,
        MOVETYPE_CUSTOM
    }

    public enum GameState
    {
        MENU = 0,
        GAME = 6
    }

    public enum Team
    {
        NONE,
        Spectator,
        Terrorist,
        Counter_Terrorist
    }

    public enum LifeState
    {
        Alive,
        Dead,
        Spectating
    }

}
