using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class GameObjectEx
	{
		private static List<Transform> _transformsChildren;

		public static void SetStatic(this GameObject gameObject, bool isStatic, bool affectChildren)
		{
		}

		public static bool IsRTGAppObject(this GameObject gameObject)
		{
			return false;
		}

		public static GameObjectType GetGameObjectType(this GameObject gameObject)
		{
			return default(GameObjectType);
		}

		public static bool HierarchyHasMesh(this GameObject root)
		{
			return false;
		}

		public static bool HierarchyHasSprite(this GameObject root)
		{
			return false;
		}

		public static bool HierarchyHasObjectsOfType(this GameObject root, GameObjectType typeFlags)
		{
			return false;
		}

		public static List<GameObject> GetMeshObjectsInHierarchy(this GameObject root)
		{
			return null;
		}

		public static List<GameObject> GetSpriteObjectsInHierarchy(this GameObject root)
		{
			return null;
		}

		public static void SetHierarchyWorldScaleByPivot(this GameObject root, Vector3 worldScale, Vector3 pivotPoint)
		{
		}

		public static List<GameObject> GetAllChildren(this GameObject gameObject)
		{
			return null;
		}

		public static List<GameObject> GetAllChildrenAndSelf(this GameObject gameObject)
		{
			return null;
		}

		public static void GetAllChildrenAndSelf(this GameObject gameObject, List<GameObject> childrenAndSelf)
		{
		}

		public static Mesh GetMesh(this GameObject gameObject)
		{
			return null;
		}

		public static Renderer GetMeshRenderer(this GameObject gameObject)
		{
			return null;
		}

		public static Sprite GetSprite(this GameObject gameObject)
		{
			return null;
		}

		public static List<GameObject> GetRoots(IEnumerable<GameObject> gameObjects)
		{
			return null;
		}

		public static void FilterParentsOnly(IEnumerable<GameObject> gameObjects, List<GameObject> parents)
		{
		}

		public static List<GameObject> FilterParentsOnly(IEnumerable<GameObject> gameObjects)
		{
			return null;
		}
	}
}
