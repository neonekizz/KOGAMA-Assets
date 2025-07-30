using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class TorusMath
	{
		public static float CalcSphereRadius(float torusCoreRadius, float torusTubeRadius)
		{
			return 0f;
		}

		public static AABB CalcCylModelAABB(float torusCoreRadius, float torusHrzRadius, float torusVertRadius)
		{
			return default(AABB);
		}

		public static AABB CalcCylAABB(Vector3 torusCenter, float torusCoreRadius, float torusHrzRadius, float torusVertRadius, Quaternion torusRotation)
		{
			return default(AABB);
		}

		public static List<Vector3> Calc3DHrzExtentPoints(Vector3 torusCenter, float torusCoreRadius, float torusTubeRadius, Quaternion torusRotation)
		{
			return null;
		}

		public static bool Raycast(Ray ray, out float t, Vector3 torusCenter, float torusCoreRadius, float torusTubeRadius, Quaternion torusRotation, TorusEpsilon epsilon = default(TorusEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool RaycastCylindrical(Ray ray, out float t, Vector3 torusCenter, float torusCoreRadius, float torusHrzRadius, float torusVertRadius, Quaternion torusRotation, TorusEpsilon epsilon = default(TorusEpsilon))
		{
			t = default(float);
			return false;
		}
	}
}
