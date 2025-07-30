using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class MeshTree
	{
		private RTMesh _mesh;

		private SphereTree<MeshTriangle> _tree;

		private List<SphereTreeNode<MeshTriangle>> _nodeBuffer;

		private List<SphereTreeNodeRayHit<MeshTriangle>> _nodeHitBuffer;

		private HashSet<int> _vertexIndexSet;

		private bool _isBuilt;

		public bool IsBuilt => false;

		public MeshTree(RTMesh mesh)
		{
		}

		public void SetDirty()
		{
		}

		public void Build()
		{
		}

		public bool OverlapVerts(OBB obb, MeshTransform meshTransform, List<Vector3> verts)
		{
			return false;
		}

		public bool OverlapModelVerts(OBB modelOBB, List<Vector3> verts)
		{
			return false;
		}

		public MeshRayHit RaycastClosest(Ray ray, Matrix4x4 meshTransform)
		{
			return null;
		}

		public void DebugDraw()
		{
		}
	}
}
