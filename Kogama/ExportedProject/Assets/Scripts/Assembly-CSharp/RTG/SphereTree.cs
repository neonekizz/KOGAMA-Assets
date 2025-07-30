using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class SphereTree<T>
	{
		private SphereTreeNode<T> _root;

		public void DebugDraw()
		{
		}

		public SphereTreeNode<T> AddNode(T nodeData, Sphere sphere)
		{
			return null;
		}

		public void RemoveNode(SphereTreeNode<T> node)
		{
		}

		public void OnNodeSphereUpdated(SphereTreeNode<T> node)
		{
		}

		public bool RaycastAll(Ray ray, List<SphereTreeNodeRayHit<T>> hits)
		{
			return false;
		}

		public bool OverlapBox(OBB box, List<SphereTreeNode<T>> nodes)
		{
			return false;
		}

		private void InsertNode(SphereTreeNode<T> node)
		{
		}
	}
}
