using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RTG
{
	public class RTScene : MonoSingleton<RTScene>
	{
		[SerializeField]
		private SceneSettings _settings;

		private List<IHoverableSceneEntityContainer> _hoverableSceneEntityContainers;

		private SceneTree _sceneTree;

		private HashSet<GameObject> _ignoredRootObjects;

		private List<GameObject> _childrenAndSelfBuffer;

		private List<GameObject> _rootGameObjectsBuffer;

		private List<GameObjectRayHit> _objectHitBuffer;

		public SceneSettings Settings => null;

		public void SetRootObjectIgnored(GameObject root, bool ignored)
		{
		}

		public void OnGameObjectWillBeDestroyed(GameObject gameObject)
		{
		}

		public AABB CalculateBounds()
		{
			return default(AABB);
		}

		public bool IsAnySceneEntityHovered()
		{
			return false;
		}

		public void RegisterHoverableSceneEntityContainer(IHoverableSceneEntityContainer container)
		{
		}

		public bool IsAnyUIElementHovered()
		{
			return false;
		}

		public List<RaycastResult> GetHoveredUIElements()
		{
			return null;
		}

		public GameObject[] GetSceneObjects()
		{
			return null;
		}

		public bool OverlapBox(OBB obb, List<GameObject> gameObjects)
		{
			return false;
		}

		public bool OverlapBox(OBB obb, SceneOverlapFilter overlapFilter, List<GameObject> gameObjects)
		{
			return false;
		}

		public SceneRaycastHit Raycast(Ray ray, SceneRaycastPrecision rtRaycastPrecision, SceneRaycastFilter raycastFilter)
		{
			return null;
		}

		public bool RaycastAllObjects(Ray ray, SceneRaycastPrecision rtRaycastPrecision, List<GameObjectRayHit> hits)
		{
			return false;
		}

		public bool RaycastAllObjectsSorted(Ray ray, SceneRaycastPrecision raycastPresicion, List<GameObjectRayHit> hits)
		{
			return false;
		}

		public bool RaycastAllObjectsSorted(Ray ray, SceneRaycastPrecision rtRaycastPrecision, SceneRaycastFilter raycastFilter, List<GameObjectRayHit> hits)
		{
			return false;
		}

		public GameObjectRayHit RaycastMeshObject(Ray ray, GameObject meshObject)
		{
			return null;
		}

		public GameObjectRayHit RaycastMeshObjectReverseIfFail(Ray ray, GameObject meshObject)
		{
			return null;
		}

		public GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject spriteObject)
		{
			return null;
		}

		public GameObjectRayHit RaycastTerrainObject(Ray ray, GameObject terrainObject)
		{
			return null;
		}

		public GameObjectRayHit RaycastTerrainObject(Ray ray, GameObject terrainObject, TerrainCollider terrainCollider)
		{
			return null;
		}

		public GameObjectRayHit RaycastTerrainObjectReverseIfFail(Ray ray, GameObject terrainObject)
		{
			return null;
		}

		public XZGridRayHit RaycastSceneGridIfVisible(Ray ray)
		{
			return null;
		}

		public void Update_SystemCall()
		{
		}
	}
}
