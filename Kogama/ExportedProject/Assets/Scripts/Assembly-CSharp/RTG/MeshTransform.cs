using UnityEngine;

namespace RTG
{
	public class MeshTransform
	{
		private Vector3 _position;

		private Quaternion _rotation;

		private Vector3 _scale;

		public Vector3 Position => default(Vector3);

		public Quaternion Rotation => default(Quaternion);

		public Vector3 Scale => default(Vector3);

		public MeshTransform(Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		public MeshTransform(Transform transform)
		{
		}

		public OBB InverseTransformOBB(OBB obb)
		{
			return default(OBB);
		}

		public Vector3 TransformPoint(Vector3 point)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformPoint(Vector3 point)
		{
			return default(Vector3);
		}
	}
}
