using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class SerializableDictionary<SerializedKeyType, SerializedValueType> : ISerializationCallbackReceiver
	{
		private Dictionary<SerializedKeyType, SerializedValueType> _dictionary;

		[SerializeField]
		private List<SerializedKeyType> _serializedKeys;

		[SerializeField]
		private List<SerializedValueType> _serializedValues;

		public Dictionary<SerializedKeyType, SerializedValueType> Dictionary => null;

		public SerializedValueType this[SerializedKeyType index]
		{
			get
			{
				return default(SerializedValueType);
			}
			set
			{
			}
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void Clear()
		{
		}

		public void Add(SerializedKeyType key, SerializedValueType value)
		{
		}

		public bool ContainsKey(SerializedKeyType key)
		{
			return false;
		}

		public void Copy(SerializableDictionary<SerializedKeyType, SerializedValueType> other)
		{
		}

		public void RemoveNullKeys()
		{
		}
	}
}
