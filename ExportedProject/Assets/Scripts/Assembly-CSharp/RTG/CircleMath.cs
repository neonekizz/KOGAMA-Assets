using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class CircleMath
	{
		public static List<Vector3> Calc3DExtentPoints(Vector3 circleCenter, float circleRadius, Quaternion circleRotation)
		{
			return null;
		}

		public static List<Vector2> Calc2DExtentPoints(Vector2 circleCenter, float circleRadius, float degreeCircleRotation)
		{
			return null;
		}

		public static bool Raycast(Ray ray, out float t, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool RaycastWire(Ray ray, out float t, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 circleCenter, float circleRadius, Vector3 circleNormal, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			return false;
		}

		public static bool Contains2DPoint(Vector2 point, Vector2 circleCenter, float circleRadius, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			return false;
		}

		public static bool Is2DPointOnBorder(Vector2 point, Vector2 circleCenter, float circleRadius, CircleEpsilon epsilon = default(CircleEpsilon))
		{
			return false;
		}
	}
}
