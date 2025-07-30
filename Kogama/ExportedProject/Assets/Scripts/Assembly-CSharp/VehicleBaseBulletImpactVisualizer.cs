using UnityEngine;

public class VehicleBaseBulletImpactVisualizer : BulletImpactVisualizer
{
	[SerializeField]
	[Range(0f, 10f)]
	private float particlesPerPointOfDamage;

	public override void VisualizeBulletImpact(VoxelHit voxelHit, Ray lineOfFire, int shooterActorNumber, float damage = 100f)
	{
	}
}
