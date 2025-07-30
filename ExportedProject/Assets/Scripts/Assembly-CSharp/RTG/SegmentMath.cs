using UnityEngine;

namespace RTG
{
	public static class SegmentMath
	{
		public static bool Raycast(Ray ray, out float t, Vector3 startPoint, Vector3 endPoint, SegmentEpsilon epsilon = default(SegmentEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool Is3DPointOnSegment(Vector3 point, Vector3 startPoint, Vector3 endPoint, SegmentEpsilon epsilon = default(SegmentEpsilon))
		{
			return false;
		}

		public static bool Is2DPointOnSegment(Vector2 point, Vector2 startPoint, Vector2 endPoint, SegmentEpsilon epsilon = default(SegmentEpsilon))
		{
			return false;
		}

		public static Vector3 ProjectPtOnSegment(Vector3 point, Vector3 startPoint, Vector3 endPoint)
		{
			return default(Vector3);
		}
	}
}
