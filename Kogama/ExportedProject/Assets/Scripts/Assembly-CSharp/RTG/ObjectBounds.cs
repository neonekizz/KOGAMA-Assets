using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public static class ObjectBounds
	{
		public struct QueryConfig
		{
			public GameObjectType ObjectTypes;

			public Vector3 NoVolumeSize;
		}

		private static QueryConfig _defaultQConfig;

		public static QueryConfig DefaultQConfig => default(QueryConfig);

		static ObjectBounds()
		{
		}

		public static Rect CalcScreenRect(GameObject gameObject, Camera camera, QueryConfig queryConfig)
		{
			return default(Rect);
		}

		public static OBB CalcSpriteWorldOBB(GameObject gameObject)
		{
			return default(OBB);
		}

		public static AABB CalcSpriteWorldAABB(GameObject gameObject)
		{
			return default(AABB);
		}

		public static AABB CalcSpriteModelAABB(GameObject spriteObject)
		{
			return default(AABB);
		}

		public static OBB GetMeshWorldOBB(GameObject gameObject)
		{
			return default(OBB);
		}

		public static AABB GetMeshWorldAABB(GameObject gameObject)
		{
			return default(AABB);
		}

		public static AABB CalcObjectCollectionWorldAABB(IEnumerable<GameObject> gameObjectCollection, QueryConfig queryConfig)
		{
			return default(AABB);
		}

		public static AABB CalcHierarchyCollectionWorldAABB(IEnumerable<GameObject> roots, QueryConfig queryConfig)
		{
			return default(AABB);
		}

		public static OBB CalcHierarchyWorldOBB(GameObject root, QueryConfig queryConfig)
		{
			return default(OBB);
		}

		public static AABB CalcHierarchyWorldAABB(GameObject root, QueryConfig queryConfig)
		{
			return default(AABB);
		}

		public static OBB CalcWorldOBB(GameObject gameObject, QueryConfig queryConfig)
		{
			return default(OBB);
		}

		public static AABB CalcWorldAABB(GameObject gameObject, QueryConfig queryConfig)
		{
			return default(AABB);
		}

		public static AABB CalcMeshWorldAABB(GameObject gameObject)
		{
			return default(AABB);
		}

		public static AABB CalcHierarchyModelAABB(GameObject root, QueryConfig queryConfig)
		{
			return default(AABB);
		}

		public static AABB CalcMeshModelAABB(GameObject gameObject)
		{
			return default(AABB);
		}

		public static AABB CalcModelAABB(GameObject gameObject, QueryConfig queryConfig, GameObjectType objectType)
		{
			return default(AABB);
		}
	}
}
