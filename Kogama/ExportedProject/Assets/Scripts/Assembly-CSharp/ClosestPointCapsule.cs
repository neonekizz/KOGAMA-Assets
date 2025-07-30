using UnityEngine;

public class ClosestPointCapsule : ClosestPointBase
{
	[SerializeField]
	private CapsuleCollider capsule;

	private Transform Transform => null;

	private Vector3 Position => default(Vector3);

	private Vector3 Scale => default(Vector3);

	public ClosestPointCapsule(CapsuleCollider c)
	{
	}

	public override Vector3 GetClosestPoint(Vector3 from)
	{
		return default(Vector3);
	}

	private void OnValidate()
	{
	}
}
