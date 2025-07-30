using System.Collections.Generic;

namespace Assets.Scripts.WorldObjectTypes.EditablePickupItem
{
	public static class EditablePickupItemData
	{
		public abstract class Keys
		{
			public const string CubeModelId = "CubeModelId";

			public const string Name = "Name";

			public const string Damage = "Damage";

			public const string MaxAmmo = "MaxAmmo";

			public const string ImpulseStrength = "ImpulseStrength";

			public const string RecoilStrength = "RecoilStrength";

			public const string AttackAnimationTime = "AttackAnimationTime";

			public const string AttackCooldown = "AttackCooldown";

			public const string Range = "Range";

			public const string Radius = "Radius";

			public const string FireSoundEffect = "FireSoundEffect";

			public const string FireSoundEffectVolume = "FireSoundEffectVolume";

			public const string HitSoundEffect = "HitSoundEffect";

			public const string HitSoundEffectVolume = "HitSoundEffectVolume";

			public static List<string> GetKeys()
			{
				return null;
			}
		}
	}
}
