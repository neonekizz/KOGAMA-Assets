using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class BoxMath
	{
		private static List<BoxFace> _allBoxFaces;

		private static Vector3[] A;

		private static Vector3[] B;

		private static float[,] R;

		private static float[,] absR;

		public static List<BoxFace> AllBoxFaces => null;

		static BoxMath()
		{
		}

		public static int GetFaceAxisIndex(BoxFace face)
		{
			return 0;
		}

		public static BoxFaceDesc GetFaceClosestToPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation)
		{
			return default(BoxFaceDesc);
		}

		public static BoxFaceDesc GetFaceClosestToPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, Vector3 viewVector)
		{
			return default(BoxFaceDesc);
		}

		public static BoxFace GetMostAlignedFace(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, Vector3 direction)
		{
			return default(BoxFace);
		}

		public static Vector3 CalcBoxFaceSize(Vector3 boxSize, BoxFace boxFace)
		{
			return default(Vector3);
		}

		public static BoxFaceAreaDesc GetBoxFaceAreaDesc(Vector3 boxSize, BoxFace boxFace)
		{
			return default(BoxFaceAreaDesc);
		}

		public static Plane CalcBoxFacePlane(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace)
		{
			return default(Plane);
		}

		public static Vector3 CalcBoxFaceNormal(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace)
		{
			return default(Vector3);
		}

		public static Vector3 CalcBoxFaceCenter(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxFace boxFace)
		{
			return default(Vector3);
		}

		public static List<Vector3> CalcBoxCornerPoints(Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation)
		{
			return null;
		}

		public static void TransformBox(Vector3 boxCenter, Vector3 boxSize, Matrix4x4 transformMatrix, out Vector3 newBoxCenter, out Vector3 newBoxSize)
		{
			newBoxCenter = default(Vector3);
			newBoxSize = default(Vector3);
		}

		public static bool BoxIntersectsBox(Vector3 center0, Vector3 size0, Quaternion rotation0, Vector3 center1, Vector3 size1, Quaternion rotation1)
		{
			return false;
		}

		public static Vector3 CalcBoxPtClosestToPt(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation)
		{
			return default(Vector3);
		}

		public static bool Raycast(Ray ray, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = default(BoxEpsilon))
		{
			return false;
		}

		public static bool Raycast(Ray ray, out float t, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = default(BoxEpsilon))
		{
			t = default(float);
			return false;
		}

		public static bool ContainsPoint(Vector3 point, Vector3 boxCenter, Vector3 boxSize, Quaternion boxRotation, BoxEpsilon epsilon = default(BoxEpsilon))
		{
			return false;
		}
	}
}
