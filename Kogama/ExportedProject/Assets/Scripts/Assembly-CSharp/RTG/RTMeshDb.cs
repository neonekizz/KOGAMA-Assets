using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class RTMeshDb : Singleton<RTMeshDb>
	{
		private Dictionary<Mesh, RTMesh> _meshes;

		public bool Contains(RTMesh rtMesh)
		{
			return false;
		}

		public bool Contains(Mesh unityMesh)
		{
			return false;
		}

		public void SetMeshDirty(Mesh unityMesh)
		{
		}

		public RTMesh GetRTMesh(Mesh unityMesh)
		{
			return null;
		}

		public void OnMeshWillBeDestroyed(Mesh unityMesh)
		{
		}

		private RTMesh CreateRTMesh(Mesh unityMesh)
		{
			return null;
		}
	}
}
