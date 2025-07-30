using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class ObjectTransformGizmoSettings : Settings
	{
		[SerializeField]
		private int _transformableLayers;

		private HashSet<GameObject> _nonTransformableObjects;

		public int TransformableLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsLayerTransformable(int objectLayer)
		{
			return false;
		}

		public void SetLayerTransformable(int objectLayer, bool isTransformable)
		{
		}

		public bool IsObjectTransformable(GameObject gameObject)
		{
			return false;
		}

		public void SetObjectTransformable(GameObject gameObject, bool isTransformable)
		{
		}

		public void SetObjectCollectionTransformable(List<GameObject> gameObjectCollection, bool areTransformable)
		{
		}
	}
}
