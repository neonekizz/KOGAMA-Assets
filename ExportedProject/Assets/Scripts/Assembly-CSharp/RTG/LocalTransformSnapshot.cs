using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class LocalTransformSnapshot
	{
		private Transform _transform;

		private Transform _parentTransform;

		private Vector3 _localPosition;

		private Quaternion _localRotation;

		private Vector3 _localScale;

		public Transform Transform => null;

		public static List<LocalTransformSnapshot> GetSnapshotCollection(IEnumerable<GameObject> gameObjects)
		{
			return null;
		}

		public void Snapshot(Transform transform)
		{
		}

		public bool SameAs(Transform transform)
		{
			return false;
		}

		public void Apply()
		{
		}
	}
}
