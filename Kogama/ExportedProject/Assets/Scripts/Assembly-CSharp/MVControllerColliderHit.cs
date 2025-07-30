using UnityEngine;

public struct MVControllerColliderHit
{
	public Vector3 positionTouchingHit;

	public Vector3 moveDirection;

	public Vector3 elipsoidNormal;

	public Vector3 slopeNormal;

	public Vector3 impactVelocity;

	public VoxelHit hit;

	public MVMaterial material;

	public bool testWithOutMoving;

	public MVControllerColliderHit(VoxelHit hit, Vector3 position, Vector3 elipsoidRadius, Vector3 R3Velocity, bool testWithOutMoving)
	{
		positionTouchingHit = default(Vector3);
		moveDirection = default(Vector3);
		elipsoidNormal = default(Vector3);
		slopeNormal = default(Vector3);
		impactVelocity = default(Vector3);
		this.hit = default(VoxelHit);
		material = null;
		this.testWithOutMoving = false;
	}
}
