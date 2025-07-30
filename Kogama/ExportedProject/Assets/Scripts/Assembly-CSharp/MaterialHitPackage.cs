using UnityEngine;

public struct MaterialHitPackage
{
	public AvatarModifierPackageType PackageType;

	public ParticleSystem ParticlePrefab;

	public MaterialHitPackage(AvatarModifierPackageType type, ParticleSystem prefab)
	{
		PackageType = default(AvatarModifierPackageType);
		ParticlePrefab = null;
	}
}
