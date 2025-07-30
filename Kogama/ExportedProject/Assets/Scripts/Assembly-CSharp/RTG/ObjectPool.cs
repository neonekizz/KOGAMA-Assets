using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class ObjectPool
	{
		public enum GrowMode
		{
			None = 0,
			Increment = 1,
			ByAmount = 2
		}

		private GameObject _sourceObject;

		private GrowMode _growMode;

		private int _growAmount;

		private List<GameObject> _pooledObjects;

		private Transform _pooledParent;

		public GrowMode PoolGrowMode
		{
			get
			{
				return default(GrowMode);
			}
			set
			{
			}
		}

		public int GrowAmount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ObjectPool(GameObject sourceObject, int numPooled, GrowMode growMode)
		{
		}

		public void SetPooledObjectsParent(Transform parent)
		{
		}

		public GameObject GetPooledObject()
		{
			return null;
		}

		public void MarkAsUnused(GameObject gameObject)
		{
		}

		public void MarkAllAsUnused()
		{
		}

		private void Grow()
		{
		}

		private GameObject CreatePooledObject()
		{
			return null;
		}
	}
}
