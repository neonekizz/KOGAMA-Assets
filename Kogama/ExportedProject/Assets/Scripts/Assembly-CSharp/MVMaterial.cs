using MV.WorldObject;
using UnityEngine;

public class MVMaterial
{
	public int unlockPriceGold;

	public bool isUnlocked;

	public Mesh Mesh { get; private set; }

	public string Name { get; private set; }

	public string Description { get; private set; }

	public PhysicalProperties PhysicalProperties { get; private set; }

	public AvatarModifierPackageType ModifierPackageType { get; private set; }

	public Texture2D ButtonTexture { get; private set; }

	public bool IsAvailable => false;

	public bool IsDestructible => false;

	public MVMaterial()
	{
	}

	public MVMaterial(PhysicalProperties physicalProperties, MaterialSound materialSound, AvatarModifierPackageType modifierPackageType)
	{
	}

	public MVMaterial(string name, string description, PhysicalProperties physicalProperties, MaterialSound materialSound, AvatarModifierPackageType modifierPackageType, int unlockPriceGold, bool isUnlocked)
	{
	}

	public MVMaterial(int materialId, string name, string description, PhysicalProperties physicalProperties, MaterialSound materialSound, AvatarModifierPackageType modifierPackageType, int unlockPriceGold, bool isUnlocked, MaterialButtonTextureGenerator materialButtonTextureGenerator = null)
	{
	}

	public void RegenerateButtonTexture(MaterialButtonTextureGenerator materialButtonTextureGenerator)
	{
	}

	private void GenerateCube(int materialID)
	{
	}

	private void AddVertices(int direction)
	{
	}
}
