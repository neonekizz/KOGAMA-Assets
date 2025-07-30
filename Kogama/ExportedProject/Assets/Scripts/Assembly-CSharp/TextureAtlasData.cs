using System.Collections.Generic;
using UnityEngine;

public static class TextureAtlasData
{
	private class MaterialData
	{
		public Color colorData;

		public Vector4 emissiveData;

		public Vector4 animationData;

		public MaterialData(Color colorData, Vector4 emissiveData, Vector4 animationData)
		{
		}
	}

	public const int NrOfTiles = 69;

	public const int DefaultNrOfColumns = 16;

	public const int TileMarginSizeInTiles = 3;

	private const int AnimationScrollVertical = 0;

	private const int AnimationScrollHorizontal = 1;

	private const int AnimationExpandAndContract = 2;

	private const int AnimationLiquid = 3;

	private const int EmissionSolid = 0;

	private const int EmissionWave = 1;

	private const int EmissionOscillate = 2;

	private const int EmissionNoise = 3;

	public static readonly Vector2[] MeshUVs;

	public static readonly Vector2[] CubeUVs;

	private static Dictionary<Tile, MaterialData> materialDataDictionary;

	public static void Initialize()
	{
	}

	private static void InitializeEmissiveData()
	{
	}

	private static void InitializeAnimationData()
	{
	}

	public static Color GetMaterialColorData(int materialID)
	{
		return default(Color);
	}

	public static Vector4[] GetTileEmissionArray()
	{
		return null;
	}

	public static Vector4[] GetTileAnimationArray()
	{
		return null;
	}

	private static (int, int) TileSizeAndMargin(int atlasWidth)
	{
		return default((int, int));
	}

	public static int AtlasColumns(int atlasWidth)
	{
		return 0;
	}

	public static Vector4 TileUVData(int atlasWidth, int atlasHeight)
	{
		return default(Vector4);
	}

	public static void StreamAtlasDataToMaterial(in Material material, bool usingSM3)
	{
	}

	public static void StreamAtlasUVsToMaterial(in Material material)
	{
	}
}
