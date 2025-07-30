using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class QuaternionEx
	{
		public static void RotatePoints(this Quaternion quat, List<Vector3> points, Vector3 pivot)
		{
		}

		public static Quaternion GetRelativeRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		public static float Length(this Quaternion quat)
		{
			return 0f;
		}

		public static Quaternion Normalize(Quaternion quat)
		{
			return default(Quaternion);
		}

		public static Quaternion FromToRotation3D(Vector3 from, Vector3 to, Vector3 perp180)
		{
			return default(Quaternion);
		}

		public static Quaternion FromToRotation2D(Vector2 from, Vector2 to)
		{
			return default(Quaternion);
		}

		public static float ConvertTo2DRotation(this Quaternion quat)
		{
			return 0f;
		}
	}
}
