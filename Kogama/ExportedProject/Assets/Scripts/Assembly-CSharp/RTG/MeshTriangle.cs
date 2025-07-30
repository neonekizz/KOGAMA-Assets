using UnityEngine;

namespace RTG
{
	public class MeshTriangle
	{
		private Vector3[] _vertices;

		private Vector3 _normal;

		private int _triangleIndex;

		private int[] _vertIndices;

		public int TriangleIndex => 0;

		public Vector3[] Vertices => null;

		public Vector3 Vertex0 => default(Vector3);

		public Vector3 Vertex1 => default(Vector3);

		public Vector3 Vertex2 => default(Vector3);

		public Vector3 Normal => default(Vector3);

		public int[] VertIndices => null;

		public int VertIndex0 => 0;

		public int VertIndex1 => 0;

		public int VertIndex2 => 0;

		public MeshTriangle(Vector3[] vertices, int triangleIndex, int vertIndex0, int vertIndex1, int vertIndex2)
		{
		}

		public int GetVertIndex(int arrayIndex)
		{
			return 0;
		}
	}
}
