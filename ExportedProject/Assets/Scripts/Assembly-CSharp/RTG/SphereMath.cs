using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class SphereMath
	{
		public static List<Vector3> CalcRightUpExtents(Vector3 sphereCenter, float sphereRadius, Vector3 right, Vector3 up)
		{
			return null;
		}

		public static bool Raycast(Ray ray, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			return false;
		}

		public static bool Raycast(Ray ray, out float t, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool Raycast(Ray ray, out float t0, out float t1, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			t0 = default(float);
			t1 = default(float);
			return false;
		}

		public static bool ContainsPoint(Vector3 point, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = default(SphereEpsilon))
		{
			return false;
		}
	}
}
