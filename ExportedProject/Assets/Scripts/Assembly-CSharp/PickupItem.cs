using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public abstract class PickupItem : MonoBehaviour
{
	[SerializeField]
	protected Transform muzzlePoint;

	[SerializeField]
	protected Transform holsterTransformOffset;

	[SerializeField]
	protected Transform firstPersonTransform;

	[SerializeField]
	protected Transform handTransform;

	[SerializeField]
	protected Transform center;

	[SerializeField]
	protected MeshRenderer[] meshRenderers;

	public MVPickupOwner owner;

	protected bool firedThisFrame;

	private Transform originalParent;

	private Vector3 originalPos;

	private Quaternion originalRot;

	private Vector3 originalScale;

	public virtual int Quantity => 0;

	public virtual Color CrossHairColor => default(Color);

	public virtual float ChargeState => 0f;

	public virtual bool FirstPerson => false;

	public virtual bool GunMode => false;

	public virtual bool IsHandEquippable => false;

	public virtual bool ThirdPersonGunMode => false;

	public virtual bool CanHolster => false;

	public virtual bool HasUnlimitedAmmo => false;

	public virtual bool CanUnequip => false;

	protected virtual bool IsAmmoDepleted => false;

	public bool IsHolstered { get; private set; }

	public Vector3 Origin => default(Vector3);

	public bool IsInFirstPersonMode => false;

	public bool IsAmmoEmpty => false;

	public abstract AvatarItemType Type { get; }

	public int VariantID { get; set; }

	public bool AbleToFire { get; set; }

	public static GameObject InstantiatePickupItem(AvatarItemType type, int variantId)
	{
		return null;
	}

	public void HolsterPickup(Transform targetHolsterTransform)
	{
	}

	public void UnholsterPickup()
	{
	}

	public void EnterFirstPersonView(MVCameraBase camera)
	{
	}

	public void EquipToHand(Transform hand)
	{
	}

	public void LeaveFirstPersonView()
	{
	}

	private void RevertToOriginalTransform()
	{
	}

	public virtual bool CanFire()
	{
		return false;
	}

	public virtual void TriggerBegin(int instigatorActorNr)
	{
	}

	public virtual void TriggerEnd()
	{
	}

	public virtual void OnStateChanged(Dictionary<object, object> newState)
	{
	}

	public virtual void OnEquip()
	{
	}

	public virtual void OnUnequip()
	{
	}

	public virtual void ResetAmmo()
	{
	}

	public virtual void OnLeaveVehicleWithWeapon()
	{
	}

	public virtual void OnEnterVehicleWithWeapon()
	{
	}

	protected virtual void OnHolstered()
	{
	}

	protected virtual void OnUnholstered()
	{
	}

	protected virtual int GetAmmoMultiplier(int defaultAmmo)
	{
		return 0;
	}

	public virtual void UpdateWithDirection(Vector3 dir)
	{
	}

	public bool GetAndResetFiredThisFrame()
	{
		return false;
	}

	public static GameObject CloneCubeModelInstance(MVCubeModelInstance cmb, bool forceVisible = false)
	{
		return null;
	}

	private static GameObject InstantiateMeleeWeapon(int variantId)
	{
		return null;
	}
}
