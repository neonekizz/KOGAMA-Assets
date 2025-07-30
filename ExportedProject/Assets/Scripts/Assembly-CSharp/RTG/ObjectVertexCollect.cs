using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class ObjectVertexCollect
	{
		private static List<Vector3> _hierarchyVertsCollectBuffer;

		public static List<Vector3> CollectModelSpriteVerts(Sprite sprite, AABB collectAABB)
		{
			return null;
		}

		public static List<Vector3> CollectWorldSpriteVerts(Sprite sprite, Transform spriteTransform, OBB collectOBB)
		{
			return null;
		}

		public static List<Vector3> CollectHierarchyVerts(GameObject root, BoxFace collectFace, float collectBoxScale, float collectEps)
		{
			return null;
		}
	}
}
