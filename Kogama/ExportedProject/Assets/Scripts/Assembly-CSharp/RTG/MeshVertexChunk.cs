using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class MeshVertexChunk : IEnumerable<Vector3>, IEnumerable
	{
		private List<Vector3> _modelSpaceVerts;

		private AABB _modelSpaceAABB;

		private Mesh _mesh;

		public Vector3 this[int vertexIndex] => default(Vector3);

		public Mesh Mesh => null;

		public int VertexCount => 0;

		public AABB ModelSpaceAABB => default(AABB);

		public MeshVertexChunk(List<Vector3> modelSpaceVerts, Mesh mesh)
		{
		}

		public IEnumerator<Vector3> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public Vector3 GetWorldVertClosestToScreenPt(Vector2 screenPoint, Matrix4x4 worldMtx, Camera camera)
		{
			return default(Vector3);
		}
	}
}
