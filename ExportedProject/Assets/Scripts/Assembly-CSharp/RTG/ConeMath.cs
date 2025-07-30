using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class ConeMath
	{
		public static List<Vector3> CalcConeBaseExtentPoints(Vector3 coneBaseCenter, float coneBaseRadius, Quaternion coneRotation)
		{
			return null;
		}

		public static bool Raycast(Ray ray, out float t, Vector3 coneBaseCenter, float coneBaseRadius, float coneHeight, Quaternion coneRotation, ConeEpsilon epsilon = default(ConeEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool ContainsPoint(Vector3 point, Vector3 coneBaseCenter, float coneBaseRadius, float coneHeight, Quaternion coneRotation, ConeEpsilon epsilon = default(ConeEpsilon))
		{
			return false;
		}
	}
}
