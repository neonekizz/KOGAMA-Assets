using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public struct OBB
	{
		private Vector3 _size;

		private Vector3 _center;

		private Quaternion _rotation;

		private bool _isValid;

		public bool IsValid => false;

		public Vector3 Center
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Extents => default(Vector3);

		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Matrix4x4 RotationMatrix => default(Matrix4x4);

		public Vector3 Right => default(Vector3);

		public Vector3 Up => default(Vector3);

		public Vector3 Look => default(Vector3);

		public OBB(Vector3 center, Vector3 size)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_rotation = default(Quaternion);
			_isValid = false;
		}

		public OBB(Vector3 center, Vector3 size, Quaternion rotation)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_rotation = default(Quaternion);
			_isValid = false;
		}

		public OBB(Vector3 center, Quaternion rotation)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_rotation = default(Quaternion);
			_isValid = false;
		}

		public OBB(Quaternion rotation)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_rotation = default(Quaternion);
			_isValid = false;
		}

		public OBB(Bounds bounds, Quaternion rotation)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_rotation = default(Quaternion);
			_isValid = false;
		}

		public OBB(AABB aabb)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_rotation = default(Quaternion);
			_isValid = false;
		}

		public OBB(AABB aabb, Quaternion rotation)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_rotation = default(Quaternion);
			_isValid = false;
		}

		public OBB(AABB modelSpaceAABB, Transform worldTransform)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_rotation = default(Quaternion);
			_isValid = false;
		}

		public OBB(OBB copy)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_rotation = default(Quaternion);
			_isValid = false;
		}

		public static OBB GetInvalid()
		{
			return default(OBB);
		}

		public void Inflate(float amount)
		{
		}

		public Matrix4x4 GetUnitBoxTransform()
		{
			return default(Matrix4x4);
		}

		public List<Vector3> GetCornerPoints()
		{
			return null;
		}

		public List<Vector3> GetCenterAndCornerPoints()
		{
			return null;
		}

		public void Encapsulate(OBB otherOBB)
		{
		}

		public Vector3 GetPointFaceNormal(Vector3 pointOnFace)
		{
			return default(Vector3);
		}

		public bool IntersectsOBB(OBB otherOBB)
		{
			return false;
		}

		public Vector3 GetClosestPoint(Vector3 point)
		{
			return default(Vector3);
		}

		public bool IntersectsSphere(Sphere sphere)
		{
			return false;
		}
	}
}
