using MV.WorldObject;
using UnityEngine;

public struct MVTerrainLOD
{
	public IntVector localPos;

	public Vector3 worldPos;

	public MVTerrainLOD(IntVector localPos, Vector3 worldPos)
	{
		this.localPos = default(IntVector);
		this.worldPos = default(Vector3);
	}
}
