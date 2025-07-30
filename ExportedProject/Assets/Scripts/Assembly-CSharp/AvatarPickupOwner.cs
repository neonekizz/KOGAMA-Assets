using System.Collections.Generic;

public class AvatarPickupOwner : MVPickupOwner
{
	private MVAvatar mvAvatar;

	private bool hasUnlimitedAmmo;

	public override HashSet<int> IgnoreWOIDs => null;

	public HashSet<int> AdditionalIgnoreWOIDS { private get; set; }

	public void Init(MVRuntimeDataVariable currentItemRuntimeDataVariable, MVRuntimeDataVariable isFiringRuntimeDataVariable, MVAvatar mvAvatar, WorldObjectSkillDataManager skillsDataManager)
	{
	}

	private void InitSkills(WorldObjectSkillDataManager skillDataManager)
	{
	}

	protected override void SetupItemTransform()
	{
	}

	protected override void Unequip()
	{
	}

	public void HandlePointing(bool inputFire)
	{
	}

	public void HandlePointWeapon()
	{
	}

	public void HandlePointWeaponOnlyNetworked()
	{
	}

	public void HandleSetHandEquippableItem(bool value)
	{
	}
}
