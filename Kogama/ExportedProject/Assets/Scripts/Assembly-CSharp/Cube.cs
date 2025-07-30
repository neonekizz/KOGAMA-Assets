using System;
using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class Cube : CubeBase
{
	private static Vector3[] cornersBookkeeping;

	private byte hiddenSides;

	public byte HiddenSides
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Cube(byte[] byteCorners, byte[] faceMaterials)
		: base(null, null)
	{
	}

	public Cube(BytePacker bp, byte byteFlags)
		: base(null, null)
	{
	}

	public Cube Clone()
	{
		return null;
	}

	private bool IsSideVisible(FaceFlags face)
	{
		return false;
	}

	public static Cube Clone(Cube original)
	{
		return null;
	}

	public static byte[] CreateMaterialArray(byte material)
	{
		return null;
	}

	public static Vector3[] GetCorners(Cube cube, Face face)
	{
		return null;
	}

	public static void SetMaterial(Cube cube, Face face, byte materialId)
	{
	}

	public static Vector3[] GetVertices(Cube cube)
	{
		return null;
	}

	public static IntVector GetCubePosAboveFace(IntVector localPos, Face face)
	{
		return default(IntVector);
	}

	public static Face GetFaceIdentityFromLocalDir(Vector3 localDir)
	{
		return default(Face);
	}

	public static Vector3 GetFaceAxis(Face face)
	{
		return default(Vector3);
	}

	public static List<Vector3> GetCorners(List<Vector2> clockwiseCorners, Face direction)
	{
		return null;
	}

	public static void SetFace(Cube cube, Face face, Vector3[] faceVertices)
	{
	}

	public static bool IsFaceBoxSideAligened(Cube cube, Face face)
	{
		return false;
	}

	public static void UnIndentFace(Cube cube, Face face)
	{
	}

	public static Vector3[] GetVerticesWorldAxisAligned(Cube cube, IntVector iVector)
	{
		return null;
	}

	private static float CalculateAOLightCheap(Face face, int faceCornerIndex, Dictionary<IntVector, Cell> cells, IntVector cubePos, bool inside)
	{
		return 0f;
	}

	private static float CalculateAOLightExpensive(Face face, int faceCornerIndex, Dictionary<IntVector, Cell> cells, IntVector cubePos, int[] cornerIndexToVertex, Vector3 normal)
	{
		return 0f;
	}

	public static FaceData[] GenerateCubeFaces(Cube cube, IntVector cubePos, Dictionary<IntVector, Cell> cells)
	{
		return null;
	}

	private static FaceData[] GenerateCubeFacesExpensive(Cube cube, IntVector cubePos, Dictionary<IntVector, Cell> cells)
	{
		return null;
	}

	private static FaceData[] GenerateCubeFacesCheap(Cube cube, IntVector cubePos, Dictionary<IntVector, Cell> cells)
	{
		return null;
	}

	private static FaceData GenerateFaceDataExpensive(Face face, IntVector cubePos, Dictionary<IntVector, Cell> cells)
	{
		return null;
	}

	private static FaceData GenerateFaceDataCheap(Face face, IntVector cubePos, Dictionary<IntVector, Cell> cells, Func<int, bool> insideCheck)
	{
		return null;
	}

	private static float CalculateAOBleed(FaceData faceData, int index)
	{
		return 0f;
	}

	public static Face GetFace(Vector3[] corners, Vector3[] triangleVertices)
	{
		return default(Face);
	}

	public static Vector3[] GetFace(Vector3[] corners, Face face)
	{
		return null;
	}

	public static Vector3[] GetFaceVerticesWorld(GameObject gameObject, Cube cube, Face face, IntVector iVector)
	{
		return null;
	}

	public static Vector3[] GetEdge(Cube cube, Face face, Edge edge)
	{
		return null;
	}

	public static void SetEdge(Cube cube, Face face, Edge edge, Vector3[] edgeVertices)
	{
	}

	public static Edge GetEdge(GameObject gameObject, Cube cube, Face face, Vector3 pos, IntVector iVector)
	{
		return default(Edge);
	}

	public static Vector3[] GetEdgeVerticesWorld(GameObject gameObject, Cube cube, Face face, Edge edge, IntVector iVector)
	{
		return null;
	}

	private static bool IsOutOfBound(Vector3[] corners)
	{
		return false;
	}

	public static void MoveVertex(CubePickingInfo info, float value, Vector3 axis, bool edgeIndex0, bool edgeIndex1, ref CubeOutOfBoundState coob)
	{
	}

	public static void MoveEdge(CubePickingInfo info, float value, Vector3 axis, ref CubeOutOfBoundState coob)
	{
	}

	private static bool FaceIsOutOfCubeBoundery(Vector3[] faceVertices)
	{
		return false;
	}

	private static void AddDeltaToFace(ref Vector3[] faceVertices, float delta, Vector3 axis)
	{
	}

	private static void ClampFace(ref Vector3[] faceVertices)
	{
	}

	public static void MoveFace(CubePickingInfo info, float delta, Vector3 axis, ref CubeOutOfBoundState outOfBoundState)
	{
	}

	private static List<Vector3> GetCorners(Vector3[] counterClockwiseFace, Face direction)
	{
		return null;
	}

	public static Vector3[] GetNormals(Vector3[] corners, Face face)
	{
		return null;
	}

	private static Vector3 GetDefaultNormal(Face face)
	{
		return default(Vector3);
	}

	private static Vector3[] GetVertices(Vector3[] corners)
	{
		return null;
	}

	private static void SetFace(ref Vector3[] corners, Face face, Vector3[] faceVertices)
	{
	}

	private static List<Vector3> SquareCornersToCubeCorners(List<Vector2> corners, Face direction)
	{
		return null;
	}

	private static List<Vector3> CreateCubeCornersFromTopFace(List<Vector3> cubeCorners, Face direction)
	{
		return null;
	}

	private static Quaternion GetFromTopRotation(Face direction)
	{
		return default(Quaternion);
	}

	private static Vector3[] RotateFaceToTop(Cube cube, Face direction)
	{
		return null;
	}

	private static Quaternion GetToTopRotation(Face direction)
	{
		return default(Quaternion);
	}

	private static void SetEdge(ref Vector3[] corners, Face face, Edge edge, Vector3[] edgeVertices)
	{
	}

	private static bool IsFaceCollapsed(Vector3[] faceIndices)
	{
		return false;
	}

	private static bool IsFaceValid(Vector3[] faceIndices, Face face)
	{
		return false;
	}

	public static bool IsCollapsed(Vector3[] corners)
	{
		return false;
	}

	public static bool GetPlaneVertices(Vector3[] corners, ref Vector3[] planeVertices)
	{
		return false;
	}

	public static bool IsLegal(Vector3[] corners)
	{
		return false;
	}

	private static bool IsCornersValid(Vector3[] corners)
	{
		return false;
	}

	private static void GetTriangle(int triangleNr, Vector3[] triangleVertices, Vector3[] corners)
	{
	}
}
