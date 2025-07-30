using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class PlaneEx
	{
		public static Plane InvertNormal(this Plane plane)
		{
			return default(Plane);
		}

		public static float GetAbsDistanceToPoint(this Plane plane, Vector3 point)
		{
			return 0f;
		}

		public static Vector3 ProjectPoint(this Plane plane, Vector3 pt)
		{
			return default(Vector3);
		}

		public static List<Vector3> ProjectAllPoints(this Plane plane, List<Vector3> points)
		{
			return null;
		}

		public static int GetFurthestPtInFront(this Plane plane, List<Vector3> points)
		{
			return 0;
		}

		public static int GetClosestPtInFront(this Plane plane, List<Vector3> points)
		{
			return 0;
		}

		public static int GetClosestPtInFrontOrOnPlane(this Plane plane, List<Vector3> points)
		{
			return 0;
		}

		public static int GetFurthestPtBehind(this Plane plane, List<Vector3> points)
		{
			return 0;
		}

		public static Plane GetCameraFacingAxisSlicePlane(Vector3 axisOrigin, Vector3 axis, Camera camera)
		{
			return default(Plane);
		}
	}
}
