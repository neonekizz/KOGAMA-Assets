using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class CameraEx
	{
		private static List<GameObject> _objectBuffer;

		public static bool IsCurrent(this Camera camera)
		{
			return false;
		}

		public static float GetFrustumDistanceFromHeight(this Camera camera, float frustumHeight)
		{
			return 0f;
		}

		public static float GetFOVFromDistanceAndHeight(this Camera camera, float frustumHeight, float distance)
		{
			return 0f;
		}

		public static float GetFrustumWidthFromDistance(this Camera camera, float distance)
		{
			return 0f;
		}

		public static float GetFrustumHeightFromDistance(this Camera camera, float distance)
		{
			return 0f;
		}

		public static AABB CalculateVolumeAABB(this Camera camera)
		{
			return default(AABB);
		}

		public static AABB CalculateFrustumAABB(this Camera camera)
		{
			return default(AABB);
		}

		public static AABB CalculateOrthoAABB(this Camera camera)
		{
			return default(AABB);
		}

		public static bool IsPointInFrontNearPlane(this Camera camera, Vector3 position)
		{
			return false;
		}

		public static Plane GetNearPlaneForward(this Camera camera)
		{
			return default(Plane);
		}

		public static Vector3 GetFarMidPoint(this Camera camera)
		{
			return default(Vector3);
		}

		public static Vector3 GetFarMidOrthoTop(this Camera camera)
		{
			return default(Vector3);
		}

		public static float GetOrthoFOV(this Camera camera)
		{
			return 0f;
		}

		public static bool IsPointFacingCamera(this Camera camera, Vector3 point, Vector3 pointNormal)
		{
			return false;
		}

		public static float GetPointZDistance(this Camera camera, Vector3 point)
		{
			return 0f;
		}

		public static List<Vector3> GetVisibleSphereExtents(this Camera camera, Sphere sphere)
		{
			return null;
		}

		public static List<Vector2> ConvertWorldToScreenPoints(this Camera camera, List<Vector3> worldPoints)
		{
			return null;
		}

		public static float ScreenToEstimatedWorldSize(this Camera camera, Vector3 worldPos, float screenSize)
		{
			return 0f;
		}

		public static float EstimateZoomFactor(this Camera camera, Vector3 worldPos)
		{
			return 0f;
		}

		public static float EstimateZoomFactorSpherical(this Camera camera, Vector3 worldPos)
		{
			return 0f;
		}

		public static void GetVisibleObjects(this Camera camera, CameraViewVolume viewVolume, List<GameObject> visibleObjects)
		{
		}
	}
}
