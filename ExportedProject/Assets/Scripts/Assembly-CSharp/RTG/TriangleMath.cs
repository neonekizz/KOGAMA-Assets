using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class TriangleMath
	{
		private static readonly float _eqTriangleAltFactor;

		public static float EqTriangleAltFactor => 0f;

		public static float GetEqTriangleAltitude(float sideLength)
		{
			return 0f;
		}

		public static float GetEqTriangleCentroidAltitude(float sideLength)
		{
			return 0f;
		}

		public static List<Vector3> CalcEqTriangle3DPoints(Vector3 centroid, float sideLength, Quaternion rotation)
		{
			return null;
		}

		public static List<Vector2> CalcEqTriangle2DPoints(Vector2 centroid, float sideLength, Quaternion rotation)
		{
			return null;
		}

		public static float CalcRATriangleHypotenuse(float side0, float side1)
		{
			return 0f;
		}

		public static float CalcRATriangleHypotenuse(Vector2 sides)
		{
			return 0f;
		}

		public static float CalcRATriangleAltitude(Vector2 sides)
		{
			return 0f;
		}

		public static List<Vector3> CalcRATriangle3DPoints(Vector3 rightAngleCorner, float xLength, float yLength, Quaternion triangleRotation)
		{
			return null;
		}

		public static List<Vector2> CalcRATriangle2DPoints(Vector2 rightAngleCorner, float xLength, float yLength, float degreeTriRotation)
		{
			return null;
		}

		public static OBB Calc3DTriangleOBB(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 normal, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			return default(OBB);
		}

		public static bool Raycast(Ray ray, out float t, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool RaycastWire(Ray ray, out float t, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			return false;
		}

		public static bool Contains2DPoint(Vector2 point, Vector2 p0, Vector2 p1, Vector2 p2, TriangleEpsilon epsilon = default(TriangleEpsilon))
		{
			return false;
		}
	}
}
