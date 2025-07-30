using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class RTMesh
	{
		private Mesh _unityMesh;

		private Vector3[] _vertices;

		private int[] _vertIndices;

		private int _numTriangles;

		private AABB _aabb;

		private MeshTree _meshTree;

		public int NumTriangles => 0;

		public Mesh UnityMesh => null;

		public AABB AABB => default(AABB);

		public bool IsTreeBuilt => false;

		public RTMesh(Mesh unityMesh)
		{
		}

		public static RTMesh Create(Mesh unityMesh)
		{
			return null;
		}

		public void BuildTree()
		{
		}

		public void SetDirty()
		{
		}

		public MeshTriangle GetTriangle(int triangleIndex)
		{
			return null;
		}

		public MeshRayHit Raycast(Ray ray, Matrix4x4 meshTransform)
		{
			return null;
		}

		public bool OverlapVerts(OBB obb, Transform meshObjectTransform, List<Vector3> verts)
		{
			return false;
		}

		public bool OverlapModelVerts(OBB modelOBB, List<Vector3> verts)
		{
			return false;
		}

		public bool OverlapModelVerts(AABB modelAABB, List<Vector3> verts)
		{
			return false;
		}

		public void DebugDrawTree()
		{
		}
	}
}
