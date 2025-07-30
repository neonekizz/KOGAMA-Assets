using MV.Common;
using MV.WorldObject;

public class PickupItemGrowthGun : SizeGunBase
{
	public override AvatarItemType Type => default(AvatarItemType);

	protected override InteractionData GetPackageData()
	{
		return default(InteractionData);
	}
}
