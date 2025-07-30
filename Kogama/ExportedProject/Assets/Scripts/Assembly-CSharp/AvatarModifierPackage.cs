using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public struct AvatarModifierPackage
{
	public struct AvatarModifier
	{
		public AvatarModifierType avatarModifierType;

		public AvatarModifierEffect avatarModifierEffect;

		public Func<float> value;

		public AvatarModifier(AvatarModifierType avatarModifierType, AvatarModifierEffect avatarModifierEffect, Func<float> value)
		{
			this.avatarModifierType = default(AvatarModifierType);
			this.avatarModifierEffect = default(AvatarModifierEffect);
			this.value = null;
		}
	}

	public int id;

	public ObscuredFloat duration;

	public AvatarModifier[] avatarModifiers;

	public Dictionary<AvatarModifierPackageType, ModifierActions> actionsToTakeVsTypes;

	private ObscuredFloat timeStamp;

	public bool persistant;

	private float lastTimeStamp;

	private AvatarModifierPackageType avatarModifierPackageType;

	private AvatarModifierPackageAdditionPolicy avatarModifierPackageAdditionPolicy;

	public static string[] AvatarModifierPackageTypeLookupTable;

	public AvatarModifierPackageType AvatarModifierPackageType => default(AvatarModifierPackageType);

	public AvatarModifierPackageAdditionPolicy AvatarModifierPackageAdditionPolicy => default(AvatarModifierPackageAdditionPolicy);

	public bool IsExpired
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsEqualTo(AvatarModifierPackage other)
	{
		return false;
	}

	public AvatarModifierPackage(AvatarModifierPackageType avatarModifierPackageType, AvatarModifierPackageAdditionPolicy avatarModifierPackageAdditionPolicy, float duration, AvatarModifier[] avatarModifiers, Dictionary<AvatarModifierPackageType, ModifierActions> actionsToTakeVsTypes = null, bool persist = false)
	{
		id = 0;
		this.duration = default(ObscuredFloat);
		this.avatarModifiers = null;
		this.actionsToTakeVsTypes = null;
		timeStamp = default(ObscuredFloat);
		persistant = false;
		lastTimeStamp = 0f;
		this.avatarModifierPackageType = default(AvatarModifierPackageType);
		this.avatarModifierPackageAdditionPolicy = default(AvatarModifierPackageAdditionPolicy);
	}

	public void InPause()
	{
	}

	public void Renew()
	{
	}
}
