using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class Matrix4x4Ex
	{
		public static Matrix4x4 GetInverse(this Matrix4x4 mtx)
		{
			return default(Matrix4x4);
		}

		public static Matrix4x4 GetRelativeTransform(this Matrix4x4 matrix, Matrix4x4 referenceTransform)
		{
			return default(Matrix4x4);
		}

		public static Matrix4x4 Translation(Vector3 translation)
		{
			return default(Matrix4x4);
		}

		public static Matrix4x4 RotationMatrixFromRightUp(Vector3 right, Vector3 up)
		{
			return default(Matrix4x4);
		}

		public static Vector3 GetTranslation(this Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		public static Vector3 GetScale(this Matrix4x4 matrix)
		{
			return default(Vector3);
		}

		public static Vector3 GetNormalizedAxis(this Matrix4x4 matrix, int axisIndex)
		{
			return default(Vector3);
		}

		public static Vector3[] GetNormalizedAxes(this Matrix4x4 matrix)
		{
			return null;
		}

		public static List<Vector3> TransformPoints(this Matrix4x4 matrix, List<Vector3> points)
		{
			return null;
		}
	}
}
