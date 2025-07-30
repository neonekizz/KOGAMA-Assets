using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class PolygonMath
	{
		public static bool Raycast(Ray ray, out float t, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			return false;
		}

		public static bool Contains2DPoint(Vector2 point, List<Vector2> polyPoints, bool isClosed, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			return false;
		}

		public static bool Is3DPointOnBorder(Vector3 point, bool checkOnPlane, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			return false;
		}

		public static bool Is2DPointOnBorder(Vector2 point, List<Vector2> polyPoints, bool isClosed, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			return false;
		}

		public static bool Is2DPointOnThickBorder(Vector2 point, List<Vector2> polyPoints, List<Vector2> thickBorderPoints, bool isClosed, PolygonEpsilon epsilon = default(PolygonEpsilon))
		{
			return false;
		}
	}
}
