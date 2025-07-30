using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class Object2ObjectSnapDataDb : Singleton<Object2ObjectSnapDataDb>
	{
		private Dictionary<GameObject, Object2ObjectSnapData> _objectToSnapData;

		public Object2ObjectSnapData GetObject2ObjectSnapData(GameObject gameObject)
		{
			return null;
		}
	}
}
