using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class TransformEx
	{
		public static void TransformPoints(this Transform transform, List<Vector3> points)
		{
		}

		public static List<Transform> GetGameObjectTransformCollection(IEnumerable<GameObject> gameObjects)
		{
			return null;
		}

		public static List<Transform> FilterParentsOnly(IEnumerable<Transform> transforms)
		{
			return null;
		}

		public static void SetWorldScale(this Transform transform, Vector3 worldScale)
		{
		}

		public static void ScaleFromPivot(this Transform transform, Vector3 scaleFactor, Vector3 pivot)
		{
		}

		public static void RotateAroundPivot(this Transform transform, Quaternion rotation, Vector3 pivot)
		{
		}

		public static Vector3 GetLocalAxis(this Transform transform, AxisDescriptor axisDesc)
		{
			return default(Vector3);
		}

		public static Plane GetLocalPlane(this Transform transform, PlaneDescriptor planeDesc)
		{
			return default(Plane);
		}

		public static Quaternion Align(this Transform transform, Vector3 normAlignVector, TransformAxis alignmentAxis)
		{
			return default(Quaternion);
		}
	}
}
