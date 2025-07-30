using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class Vector3Ex
	{
		public static void OffsetPoints(List<Vector3> points, Vector3 offset)
		{
		}

		public static Vector2 ConvertDirTo2D(Vector3 start, Vector3 end, Camera camera)
		{
			return default(Vector2);
		}

		public static Vector3 Abs(this Vector3 v)
		{
			return default(Vector3);
		}

		public static Vector3 GetSignVector(this Vector3 v)
		{
			return default(Vector3);
		}

		public static float GetMaxAbsComp(this Vector3 v)
		{
			return 0f;
		}

		public static float Dot(this Vector3 v1, Vector3 v2)
		{
			return 0f;
		}

		public static float AbsDot(this Vector3 v1, Vector3 v2)
		{
			return 0f;
		}

		public static Vector3 FromValue(float value)
		{
			return default(Vector3);
		}

		public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			return 0f;
		}

		public static float GetDistanceToSegment(this Vector3 point, Vector3 point0, Vector3 point1)
		{
			return 0f;
		}

		public static Vector3 ProjectOnSegment(this Vector3 point, Vector3 point0, Vector3 point1)
		{
			return default(Vector3);
		}

		public static int GetPointClosestToPoint(List<Vector3> points, Vector3 pt)
		{
			return 0;
		}

		public static Vector3 GetPointCloudCenter(IEnumerable<Vector3> ptCloud)
		{
			return default(Vector3);
		}

		public static Vector3 GetInverse(this Vector3 vector)
		{
			return default(Vector3);
		}

		public static bool IsAligned(this Vector3 vector, Vector3 other, bool checkSameDirection)
		{
			return false;
		}

		public static bool PointsSameDir(this Vector3 vector, Vector3 other)
		{
			return false;
		}

		public static int GetMostAligned(Vector3[] vectors, Vector3 dir, bool checkSameDirection)
		{
			return 0;
		}
	}
}
