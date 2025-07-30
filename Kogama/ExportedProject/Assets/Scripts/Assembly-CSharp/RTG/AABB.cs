using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public struct AABB
	{
		private Vector3 _size;

		private Vector3 _center;

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

		public Vector3 Min
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Max
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public AABB(Vector3 center, Vector3 size)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_isValid = false;
		}

		public AABB(Bounds bounds)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_isValid = false;
		}

		public AABB(IEnumerable<Vector3> pointCloud)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_isValid = false;
		}

		public AABB(IEnumerable<Vector2> pointCloud)
		{
			_size = default(Vector3);
			_center = default(Vector3);
			_isValid = false;
		}

		public static AABB GetInvalid()
		{
			return default(AABB);
		}

		public void Inflate(float amount)
		{
		}

		public void Inflate(Vector3 amount)
		{
		}

		public void Encapsulate(Vector3 point)
		{
		}

		public void Encapsulate(IEnumerable<Vector3> points)
		{
		}

		public void Encapsulate(AABB aabb)
		{
		}

		public void Transform(Matrix4x4 transformMatrix)
		{
		}

		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		public List<Vector3> GetCornerPoints()
		{
			return null;
		}

		public List<Vector3> GetCenterAndCornerPoints()
		{
			return null;
		}

		public List<Vector2> GetScreenCornerPoints(Camera camera)
		{
			return null;
		}

		public List<Vector2> GetScreenCenterAndCornerPoints(Camera camera)
		{
			return null;
		}

		public Rect GetScreenRectangle(Camera camera)
		{
			return default(Rect);
		}

		public Matrix4x4 GetUnitBoxTransform()
		{
			return default(Matrix4x4);
		}

		public Bounds ToBounds()
		{
			return default(Bounds);
		}

		private void RecalculateCenterAndSize(Vector3 min, Vector3 max)
		{
		}
	}
}
