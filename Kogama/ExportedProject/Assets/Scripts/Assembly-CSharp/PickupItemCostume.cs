using System.Collections.Generic;
using MV.Common;
using UnityEngine;

public class PickupItemCostume : PickupItemEditable
{
	protected class CostumeConfiguration : EditableItemConfiguration
	{
		public float health;

		public float movementSpeed;

		public float trailLength;

		public bool isPlayerInvisible;

		public bool playersCanCollide;

		public bool isTrailEnabled;

		public Color trailColor;
	}

	[SerializeField]
	private TrailRenderer trailRenderer;

	private BoxCollider costumeTriggerCollider;

	public override AvatarItemType Type => default(AvatarItemType);

	public override bool FirstPerson => false;

	public override bool GunMode => false;

	public override bool CanHolster => false;

	public Color TrailColor => default(Color);

	protected new CostumeConfiguration Configuration
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void Initialize()
	{
	}

	protected override EditableItemConfiguration GetDefaultConfiguration()
	{
		return null;
	}

	protected override void SetConfiguration(Dictionary<object, object> itemData)
	{
	}

	protected override void OnPickupNewEditableItem()
	{
	}

	public override void OnStateChanged(Dictionary<object, object> newState)
	{
	}

	private void OnHealthStateChanged()
	{
	}

	private void OnSpeedStateChanged()
	{
	}

	private void OnArcTrailStateChanged()
	{
	}

	private void OnCollisionStateChanged()
	{
	}

	private void OnAvatarInvisibleStateChanged()
	{
	}

	private void SetAvatarInvisibility(bool isInvisible, MVAvatar avatar)
	{
	}

	private void OnLocalPlayerTeamChanged()
	{
	}

	private void CalculateRemoteAvatarUIVisibility(bool isInvisible, MVAvatarRemote avatar)
	{
	}

	protected override void OnFire(bool isLocal)
	{
	}

	public override void UpdateWithDirection(Vector3 dir)
	{
	}

	public override bool IsSameItemData(Dictionary<object, object> itemData)
	{
		return false;
	}

	protected override void InterruptFire()
	{
	}

	public override void OnEnterVehicleWithWeapon()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void InitializeAudioPlayers()
	{
	}
}
