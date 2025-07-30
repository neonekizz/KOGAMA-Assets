using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class SceneTree
	{
		private static float _nonMeshObjectSize;

		private SphereTree<GameObject> _objectTree;

		private List<SphereTreeNodeRayHit<GameObject>> _nodeHitBuffer;

		private List<SphereTreeNode<GameObject>> _nodeBuffer;

		private Dictionary<GameObject, SphereTreeNode<GameObject>> _objectToNode;

		public GameObjectRayHit RaycastMeshObject(Ray ray, GameObject gameObject)
		{
			return null;
		}

		public GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject gameObject)
		{
			return null;
		}

		public bool RaycastAll(Ray ray, SceneRaycastPrecision raycastPresicion, List<GameObjectRayHit> hits)
		{
			return false;
		}

		public bool OverlapBox(OBB obb, List<GameObject> gameObjects)
		{
			return false;
		}

		public bool IsObjectRegistered(GameObject gameObject)
		{
			return false;
		}

		public bool RegisterObject(GameObject gameObject)
		{
			return false;
		}

		public bool UnregisterObject(GameObject gameObject)
		{
			return false;
		}

		public void OnObjectTransformChanged(Transform objectTransform)
		{
		}

		public void RemoveNodesWithNullObjects()
		{
		}

		public void DebugDraw()
		{
		}

		private bool CanRegisterObject(GameObject gameObject)
		{
			return false;
		}
	}
}
