using System.Collections.Generic;
using Assets.Scripts.WorldObjectTypes.EditablePickupItem;
using MV.WorldObject;
using UnityEngine;

namespace Assets.Scripts.WorldObjectTypes.CustomGun
{
	public static class CustomGunData
	{
		public enum FireMode
		{
			Semi = 0,
			Auto = 1,
			Burst = 2
		}

		public abstract class Keys : EditablePickupItemData.Keys
		{
			public const string MovementSpeedWhileHeld = "MovementSpeedWhileHeld";

			public const string FireMode = "FireMode";

			public const string MuzzlePosition = "MuzzlePosition";

			public const string MuzzleDirection = "MuzzleDirection";

			public const string MuzzleFlareOnFire = "MuzzleFlareOnFire";

			public const string MuzzleFlareSize = "MuzzleFlareSize";

			public const string MuzzleFlareColor = "MuzzleFlareColor";

			public const string ThirdPersonCamera = "ThirdPersonCamera";

			public const string SmokeOnFire = "SmokeOnFire";

			public const string ShotsPerBurst = "ShotsPerBurst";

			public const string BurstCooldownBetweenShots = "BurstCooldownBetweenShots";

			public const string ProjectilesPerShot = "ProjectilesPerShot";

			public const string ChargeEnabled = "ChargeEnabled";

			public const string ChargeTime = "ChargeTime";

			public const string ChargeSoundEffect = "ChargeSoundEffect";

			public const string ChargeSoundEffectVolume = "ChargeSoundEffectVolume";

			public const string ChargeParticlesEnabled = "ChargeParticlesEnabled";

			public const string ChargeParticlesSize = "ChargeParticlesSize";

			public const string ChargeParticlesColor = "ChargeParticlesColor";

			public const string ChargeZoomEnabled = "ChargeZoomEnabled";

			public const string ChargeZoomAmmount = "ChargeZoomAmmount";

			public const string ChargeZoomTime = "ChargeZoomTime";

			public const string ProjectileSpeed = "ProjectileSpeed";

			public const string ProjectileSize = "ProjectileSize";

			public const string ProjectileColor = "ProjectileColor";

			public const string ProjectileTrailColor = "ProjectileTrailColor";

			public const string SparksOnHit = "SparksOnHit";

			public const string SparksSize = "SparksSize";

			public const string SparksColor = "SparksColor";

			public new static List<string> GetKeys()
			{
				return null;
			}
		}

		private static readonly Dictionary<object, object> defaultItemValues;

		private static readonly Dictionary<object, object> minValues;

		private static readonly Dictionary<object, object> maxValues;

		public static readonly string[] fireModes;

		public static readonly string[] fireSoundEffects;

		public static readonly string[] hitSoundEffects;

		public static readonly string[] chargeSoundEffects;

		public static Dictionary<object, object> DefaultData()
		{
			return null;
		}

		public static Dictionary<object, object> DefaultItemData()
		{
			return null;
		}

		public static object DefaultValue(string key)
		{
			return null;
		}

		public static Color DefaultColor(string colorKey)
		{
			return default(Color);
		}

		public static Vector3 DefaultVector3(string vectorKey)
		{
			return default(Vector3);
		}

		public static float MinValue(string key)
		{
			return 0f;
		}

		public static float MaxValue(string key)
		{
			return 0f;
		}

		public static (float, float) MinMaxValue(string key)
		{
			return default((float, float));
		}

		public static (IntVector, IntVector) GetEditPoints()
		{
			return default((IntVector, IntVector));
		}
	}
}
