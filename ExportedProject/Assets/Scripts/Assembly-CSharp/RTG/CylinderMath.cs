using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class CylinderMath
	{
		public static List<Vector3> CalcExtentPoints(Vector3 center, float cylinderRadius, Quaternion cylinderRotation)
		{
			return null;
		}

		public static bool Raycast(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool Raycast(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool RaycastNoCaps(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool RaycastNoCaps(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool ContainsPoint(Vector3 point, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			return false;
		}

		public static bool ContainsPoint(Vector3 point, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = default(CylinderEpsilon))
		{
			return false;
		}
	}
}
