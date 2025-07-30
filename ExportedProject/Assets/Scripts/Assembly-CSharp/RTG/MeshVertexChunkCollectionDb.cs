using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class MeshVertexChunkCollectionDb : Singleton<MeshVertexChunkCollectionDb>
	{
		private Dictionary<Mesh, MeshVertexChunkCollection> _meshToVChunkCollection;

		public MeshVertexChunkCollection this[Mesh mesh] => null;

		public void SetMeshDirty(Mesh mesh)
		{
		}

		public bool HasChunkCollectionForMesh(Mesh mesh)
		{
			return false;
		}

		private bool CreateMeshVertChunkCollection(Mesh mesh)
		{
			return false;
		}
	}
}
