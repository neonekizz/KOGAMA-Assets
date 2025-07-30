using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class Object2ObjectSnapData
	{
		private GameObject _gameObject;

		private AABB[] _snapAreaBounds;

		private BoxFaceAreaDesc[] _snapAreaDesc;

		private List<Vector3> _vertsBuffer;

		public bool Initialize(GameObject gameObject)
		{
			return false;
		}

		public BoxFaceAreaDesc GetWorldSnapAreaDesc(BoxFace boxFace)
		{
			return default(BoxFaceAreaDesc);
		}

		public List<OBB> GetAllWorldSnapAreaBounds()
		{
			return null;
		}

		public OBB GetWorldSnapAreaBounds(BoxFace boxFace)
		{
			return default(OBB);
		}

		private List<AABB> BuildVertOverlapAABBs(GameObject gameObject, Sprite sprite, RTMesh rtMesh)
		{
			return null;
		}
	}
}
