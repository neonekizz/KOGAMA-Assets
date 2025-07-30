using MV.Common;
using UnityEngine;

public class PickupItemSlapGun : PickupItemWithDelay
{
	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private AudioClip[] slapSounds;

	public ParticleSystem hitParticles;

	public float maxRange;

	public float slapStrength;

	public ImpulseRay impulseRayPrefab;

	public Color slapColor;

	private int layerMask;

	private static readonly float damage;

	public override AvatarItemType Type => default(AvatarItemType);

	public override bool CanUnequip => false;

	public override bool FirstPerson => false;

	public override bool GunMode => false;

	public override int Quantity => 0;

	public override bool CanHolster => false;

	private void Awake()
	{
	}

	protected override void OnFire(bool isLocal)
	{
	}

	private Vector3 FindRayTarget(Ray lineOfFire)
	{
		return default(Vector3);
	}

	private Vector3 ComputeImpulseDirection(Ray lineOfFire)
	{
		return default(Vector3);
	}
}
