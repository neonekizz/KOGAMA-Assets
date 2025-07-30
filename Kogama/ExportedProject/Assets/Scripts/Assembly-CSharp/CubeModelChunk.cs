using System;
using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class CubeModelChunk
{
	public const bool UseAOShadows = true;

	private readonly IntVector chunkPos;

	private readonly Dictionary<Guid, ChunkInstances.ChunkInstanceVariables> instances;

	private SharedMeshData sharedMeshData;

	private Bounds meshBounds;

	private readonly string name;

	private int cubeCount;

	private int triangleCount;

	private int activeInstances;

	private readonly Dictionary<IntVector, Cell> cells;

	private static FaceData[] faceData;

	public int TriangleCount => 0;

	public int ActiveInstances
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int CubeCount => 0;

	public CubeModelChunk(IntVector iVector)
	{
	}

	public CubeModelChunk CloneGeometry(float scale)
	{
		return null;
	}

	public bool CompareGeometry(CubeModelChunk chunk)
	{
		return false;
	}

	public bool CompareGeometry(CubeModelChunk chunk, ref int matchingCubeCount, ref int investigatedCubeCount, bool visibleCubesOnly)
	{
		return false;
	}

	public Cube GetCube(IntVector iVector)
	{
		return null;
	}

	public bool ContainsCube(IntVector iVector)
	{
		return false;
	}

	public void AddToChunk(IntVector iVector, Cube cube, bool setVisibility = true)
	{
	}

	public IntVector GetFirstSolidCubePos()
	{
		return default(IntVector);
	}

	public void RemoveFromChunk(IntVector iVector)
	{
	}

	public void Destroy()
	{
	}

	public string Guids()
	{
		return null;
	}

	public void RebuildChunk(float scale)
	{
	}

	public SharedMeshData GetMeshData()
	{
		return default(SharedMeshData);
	}

	private void EvaluateReferenceCount(int oldReferenceCount, int newReferenceCount)
	{
	}

	private void RevokeSharedMeshOnInstances()
	{
	}

	private void RestoreSharedMeshOnInstances()
	{
	}

	private void UpdateInstances()
	{
	}

	public void SetInstanceDataRef(IntVector chunkPos, MVCubeModelBase cubeInstance)
	{
	}

	private void ChunkInstancesChanged(object sender, ChunkInstancesChanged e)
	{
	}

	private void SetCubeVisibilityWithNeighbors(IntVector pos)
	{
	}

	private void SetCubeVisibility(IntVector iVector)
	{
	}

	public void SetCubeVisibility()
	{
	}

	private static void SetCubeVisibility(Dictionary<IntVector, Cell> cells)
	{
	}

	private static void SetCubeVisibility(Dictionary<IntVector, Cell> cells, IntVector pos, Cube cube)
	{
	}

	private static void SimpleFaceVisibilityTest(FaceFlags faceFlagCube, FaceFlags faceFlagOpposite, ref Cube cube, ref Cube neighborCube)
	{
	}

	private static bool AllFaceCornersIsTouchingCubeBorder(Face face, ref Vector3[] faceIndices)
	{
		return false;
	}

	private static void AdvancedFaceVisibilityTest(FaceFlags faceFlagCube, FaceFlags faceFlagOpposite, ref Cube cube, ref Cube neighborCube)
	{
	}

	private static void GetMeshBounds(ref Bounds bounds, Dictionary<IntVector, Cell> cells)
	{
	}

	private static int RebuildMesh(Dictionary<IntVector, Cell> cells, float scale)
	{
		return 0;
	}

	private static Vector2[] GetFaceUvs(Vector3[] faceVertices, Face face, float scale)
	{
		return null;
	}
}
