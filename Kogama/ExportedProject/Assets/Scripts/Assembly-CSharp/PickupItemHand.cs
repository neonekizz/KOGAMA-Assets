using MV.Common;

public class PickupItemHand : PickupItemWithDelay
{
	public float pushMagnitude;

	public float pushRadius;

	public override AvatarItemType Type => default(AvatarItemType);

	public override bool FirstPerson => false;

	public override bool GunMode => false;

	public override bool CanUnequip => false;

	public override bool CanHolster => false;

	public override int Quantity => 0;

	public override bool CanFire()
	{
		return false;
	}

	private void Awake()
	{
	}

	protected override void OnFire(bool isLocal)
	{
	}

	private void DoRemoveCubes()
	{
	}
}
