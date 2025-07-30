using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class PyramidMath
	{
		public static List<Vector3> CalcBaseCornerPoints(Vector3 baseCenter, float baseWidth, float baseDepth, Quaternion rotation)
		{
			return null;
		}

		public static bool Raycast(Ray ray, out float t, Vector3 baseCenter, float baseWidth, float baseDepth, float height, Quaternion rotation)
		{
			t = default(float);
			return false;
		}

		public static bool ContainsPoint(Vector3 point, Vector3 baseCenter, float baseWidth, float baseDepth, float height, Quaternion rotation, PyramidEpsilon epsilon = default(PyramidEpsilon))
		{
			return false;
		}
	}
}
