using UnityEngine;

namespace RTG
{
	public class WorldTransformSnapshot
	{
		private Vector3 _worldPosition;

		private Quaternion _worldRotation;

		private Vector3 _worldScale;

		public Vector3 WorldPosition => default(Vector3);

		public Quaternion WorldRotation => default(Quaternion);

		public Vector3 WorldScale => default(Vector3);

		public void Snaphot(Transform transform)
		{
		}

		public bool SameAs(Transform transform)
		{
			return false;
		}
	}
}
