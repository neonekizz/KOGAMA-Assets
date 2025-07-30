using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class CameraViewVolume
	{
		public enum VPoint
		{
			NearTopLeft = 0,
			NearTopRight = 1,
			NearBottomRight = 2,
			NearBottomLeft = 3,
			FarTopLeft = 4,
			FarTopRight = 5,
			FarBottomRight = 6,
			FarBottomLeft = 7
		}

		public enum VPlane
		{
			Left = 0,
			Right = 1,
			Bottom = 2,
			Top = 3,
			Near = 4,
			Far = 5
		}

		private const int _numWorldPoints = 8;

		private const int _numWorldPlanes = 6;

		private Vector3[] _worldPoints;

		private Plane[] _worldPlanes;

		private Vector2 _farPlaneSize;

		private Vector2 _nearPlaneSize;

		private AABB _worldAABB;

		private OBB _worldOBB;

		public Plane LeftPlane => default(Plane);

		public Plane RightPlane => default(Plane);

		public Plane BottomPlane => default(Plane);

		public Plane TopPlane => default(Plane);

		public Plane NearPlane => default(Plane);

		public Plane FarPlane => default(Plane);

		public Vector3 NearTopLeft => default(Vector3);

		public Vector3 NearTopRight => default(Vector3);

		public Vector3 NearBottomRight => default(Vector3);

		public Vector3 NearBottomLeft => default(Vector3);

		public Vector3 FarTopLeft => default(Vector3);

		public Vector3 FarTopRight => default(Vector3);

		public Vector3 FarBottomRight => default(Vector3);

		public Vector3 FarBottomLeft => default(Vector3);

		public Vector2 FarPlaneSize => default(Vector2);

		public Vector2 NearPlaneSize => default(Vector2);

		public AABB WorldAABB => default(AABB);

		public OBB WorldOBB => default(OBB);

		public CameraViewVolume()
		{
		}

		public CameraViewVolume(Camera camera)
		{
		}

		public void FromCamera(Camera camera)
		{
		}

		public List<Vector3> GetNearPlanePoints()
		{
			return null;
		}

		public static Plane[] GetCameraWorldPlanes(Camera camera)
		{
			return null;
		}

		public bool CheckAABB(AABB aabb)
		{
			return false;
		}

		public static bool CheckAABB(Camera camera, AABB aabb)
		{
			return false;
		}

		public static bool CheckAABB(Camera camera, AABB aabb, Plane[] cameraWorldPlanes)
		{
			return false;
		}

		private void CalculateWorldPoints(Camera camera)
		{
		}
	}
}
