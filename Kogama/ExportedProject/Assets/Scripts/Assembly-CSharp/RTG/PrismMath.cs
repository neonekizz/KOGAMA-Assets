using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class PrismMath
	{
		public static List<Vector3> CalcTriangPrismCornerPoints(Vector3 baseCenter, float baseWidth, float baseDepth, float topWidth, float topDepth, float height, Quaternion prismRotation)
		{
			return null;
		}

		public static bool RaycastTriangular(Ray ray, out float t, Vector3 baseCenter, float baseWidth, float baseDepth, float topWidth, float topDepth, float height, Quaternion prismRotation)
		{
			t = default(float);
			return false;
		}

		public static bool ContainsPoint(Vector3 point, Vector3 baseCenter, float baseWidth, float baseDepth, float topWidth, float topDepth, float height, Quaternion prismRotation, PrismEpsilon epsilon = default(PrismEpsilon))
		{
			return false;
		}
	}
}
