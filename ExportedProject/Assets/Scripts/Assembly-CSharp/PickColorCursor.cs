using UnityEngine;

public class PickColorCursor
{
	private readonly CellCursor paintCursor;

	private bool flashing;

	private float flashingTime;

	private bool currentMaterial;

	public PickColorCursor(Vector3[] cubeCorners)
	{
	}

	public void UpdateCursor(CubePickingInfo selectedCube, MVCubeModelBase targetCubeModel, bool allowedMaterial)
	{
	}

	public void Remove()
	{
	}

	public void UnlockMaterialToRemove()
	{
	}
}
