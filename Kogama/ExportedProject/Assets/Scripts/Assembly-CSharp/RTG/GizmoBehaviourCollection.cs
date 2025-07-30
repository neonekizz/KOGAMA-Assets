using System;
using System.Collections;
using System.Collections.Generic;

namespace RTG
{
	public class GizmoBehaviourCollection : IEnumerable
	{
		private List<IGizmoBehaviour> _behaviours;

		public int Count => 0;

		public bool Add(IGizmoBehaviour behaviour)
		{
			return false;
		}

		public bool Remove(IGizmoBehaviour behaviour)
		{
			return false;
		}

		public Type GetFirstBehaviourOfType<Type>() where Type : class, IGizmoBehaviour
		{
			return null;
		}

		public IGizmoBehaviour GetFirstBehaviourOfType(Type behaviourType)
		{
			return null;
		}

		public List<Type> GetBehavioursOfType<Type>() where Type : class, IGizmoBehaviour
		{
			return null;
		}

		public List<IGizmoBehaviour> GetBehavioursOfType(Type behaviourType)
		{
			return null;
		}

		public bool Contains(IGizmoBehaviour behaviour)
		{
			return false;
		}

		public IEnumerator<IGizmoBehaviour> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
