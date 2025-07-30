using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class QuadMath
	{
		public static void Calc2DQuadRightUp(float degreeRotation, out Vector2 right, out Vector2 up)
		{
			right = default(Vector2);
			up = default(Vector2);
		}

		public static List<Vector2> Calc2DQuadCornerPoints(Vector2 quadCenter, Vector2 quadSize, float degreeRotation)
		{
			return null;
		}

		public static List<Vector2> Calc2DQuadCornerPoints(Vector2 quadCenter, Vector2 quadSize, Vector2 right, Vector2 up)
		{
			return null;
		}

		public static List<Vector3> Calc3DQuadCornerPoints(Vector3 quadCenter, Vector2 quadSize, Quaternion quadRotation)
		{
			return null;
		}

		public static Vector3 Calc3DQuadCorner(Vector3 quadCenter, Vector2 quadSize, Quaternion quadRotation, QuadCorner quadCorner)
		{
			return default(Vector3);
		}

		public static OBB Calc3DQuadOBB(Vector3 quadCenter, Vector2 quadSize, Quaternion quadRotation, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return default(OBB);
		}

		public static bool Raycast(Ray ray, out float t, Vector3 quadCenter, float quadWidth, float quadHeight, Vector3 quadRight, Vector3 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool RaycastWire(Ray ray, out float t, Vector3 quadCenter, float quadWidth, float quadHeight, Vector3 quadRight, Vector3 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 quadCenter, float quadWidth, float quadHeight, Vector3 quadRight, Vector3 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return false;
		}

		public static bool Contains2DPoint(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, float degreeRotation, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return false;
		}

		public static bool Contains2DPoint(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, Vector2 quadRight, Vector2 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return false;
		}

		public static bool Is2DPointOnBorder(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, float degreeRotation, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return false;
		}

		public static bool Is2DPointOnBorder(Vector2 point, Vector2 quadCenter, float quadWidth, float quadHeight, Vector2 quadRight, Vector2 quadUp, QuadEpsilon epsilon = default(QuadEpsilon))
		{
			return false;
		}
	}
}
