using UnityEngine;

public class VehiclePickupOwner : MVPickupOwner
{
	private Transform mountTransform;

	public void Init(MVRuntimeDataVariable currentItemRuntimeVariable, MVRuntimeDataVariable isFiringRuntimeVariable, Transform mountTransform)
	{
	}

	public void OnLocalObjectsDestroyed()
	{
	}

	protected override void SetupItemTransform()
	{
	}

	protected override void Unequip()
	{
	}
}
