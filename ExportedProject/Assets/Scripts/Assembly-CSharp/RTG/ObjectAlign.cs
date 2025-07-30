using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class ObjectAlign
	{
		public enum Result
		{
			Err_NoObjects = 0,
			Success = 1
		}

		public static Result AlignToWorldAxis(IEnumerable<GameObject> gameObjects, Axis axis, Vector3 alignmentPlaneOrigin)
		{
			return default(Result);
		}

		public static Result AlignToWorldPlane(IEnumerable<GameObject> gameObjects, Plane alignmentPlane)
		{
			return default(Result);
		}

		private static void AlignRootsToPlane(List<GameObject> roots, Plane alignmentPlane)
		{
		}
	}
}
