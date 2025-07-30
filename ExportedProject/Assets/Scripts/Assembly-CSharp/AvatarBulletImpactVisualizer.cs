using UnityEngine;

public class AvatarBulletImpactVisualizer : BulletImpactVisualizer
{
	[Range(0f, 10f)]
	[SerializeField]
	private float particlesPerPointOfDamage;

	public override void VisualizeBulletImpact(VoxelHit voxelHit, Ray lineOfFire, int shooterActorNumber, float damage = 100f)
	{
	}
}
