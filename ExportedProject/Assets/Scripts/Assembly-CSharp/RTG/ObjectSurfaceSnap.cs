using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class ObjectSurfaceSnap
	{
		public enum Type
		{
			UnityTerrain = 0,
			Mesh = 1,
			TerrainMesh = 2,
			SphericalMesh = 3,
			SceneGrid = 4
		}

		public struct SnapConfig
		{
			public bool AlignAxis;

			public TransformAxis AlignmentAxis;

			public Type SurfaceType;

			public float OffsetFromSurface;

			public Vector3 SurfaceHitPoint;

			public Vector3 SurfaceHitNormal;

			public Plane SurfaceHitPlane;

			public GameObject SurfaceObject;

			public bool IsSurfaceMesh()
			{
				return false;
			}
		}

		public struct SnapResult
		{
			public bool Success;

			public Plane SittingPlane;

			public Vector3 SittingPoint;

			public SnapResult(Plane sittingPlane, Vector3 sittingPoint)
			{
				Success = false;
				SittingPlane = default(Plane);
				SittingPoint = default(Vector3);
			}
		}

		private abstract class SurfaceRaycaster
		{
			protected GameObject _surfaceObject;

			protected bool _raycastReverse;

			public SurfaceRaycaster(GameObject surfaceObject, bool raycastReverse)
			{
			}

			public abstract GameObjectRayHit Raycast(Ray ray);
		}

		private class MeshSurfaceRaycaster : SurfaceRaycaster
		{
			public MeshSurfaceRaycaster(GameObject surfaceObject, bool raycastReverse)
				: base(null, raycastReverse: false)
			{
			}

			public override GameObjectRayHit Raycast(Ray ray)
			{
				return null;
			}
		}

		private class TerrainSurfaceRaycaster : SurfaceRaycaster
		{
			private TerrainCollider _terrainCollider;

			public TerrainSurfaceRaycaster(GameObject surfaceObject, bool raycastReverse)
				: base(null, raycastReverse: false)
			{
			}

			public override GameObjectRayHit Raycast(Ray ray)
			{
				return null;
			}
		}

		public static SnapResult SnapHierarchy(GameObject root, SnapConfig snapConfig)
		{
			return default(SnapResult);
		}

		public static Vector3 CalculateSitOnSurfaceOffset(OBB obb, Plane surfacePlane, float offsetFromSurface)
		{
			return default(Vector3);
		}

		public static Vector3 CalculateSitOnSurfaceOffset(AABB aabb, Plane surfacePlane, float offsetFromSurface)
		{
			return default(Vector3);
		}

		public static Vector3 CalculateEmbedVector(List<Vector3> embedPoints, GameObject embedSurface, Vector3 embedDirection, Type surfaceType)
		{
			return default(Vector3);
		}

		private static SurfaceRaycaster CreateSurfaceRaycaster(Type surfaceType, GameObject surfaceObject, bool raycastReverse)
		{
			return null;
		}
	}
}
