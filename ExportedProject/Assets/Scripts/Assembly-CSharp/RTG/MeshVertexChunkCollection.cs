using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class MeshVertexChunkCollection : IEnumerable<MeshVertexChunk>, IEnumerable
	{
		private struct VertexChunkIndices
		{
			private int _XIndex;

			private int _YIndex;

			private int _ZIndex;

			public int XIndex => 0;

			public int YIndex => 0;

			public int ZIndex => 0;

			public VertexChunkIndices(int xIndex, int yIndex, int zIndex)
			{
				_XIndex = 0;
				_YIndex = 0;
				_ZIndex = 0;
			}
		}

		private Mesh _mesh;

		private List<MeshVertexChunk> _vertexChunks;

		public MeshVertexChunk this[int chunkIndex] => null;

		public int Count => 0;

		public IEnumerator<MeshVertexChunk> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public List<MeshVertexChunk> GetWorldChunksHoveredByPoint(Vector3 hoverPoint, Matrix4x4 worldMtx, Camera camera)
		{
			return null;
		}

		public MeshVertexChunk GetWorldVertChunkClosestToScreenPt(Vector2 screenPoint, Matrix4x4 worldMtx, Camera camera)
		{
			return null;
		}

		public bool FromMesh(Mesh mesh)
		{
			return false;
		}
	}
}
