using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public struct Sphere
	{
		private Vector3 _center;

		private float _radius;

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

		public float Radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Sphere(Vector3 center, float radius)
		{
			_center = default(Vector3);
			_radius = 0f;
		}

		public Sphere(AABB aabb)
		{
			_center = default(Vector3);
			_radius = 0f;
		}

		public Sphere(IEnumerable<Vector3> pointCloud)
		{
			_center = default(Vector3);
			_radius = 0f;
		}

		public bool ContainsPoint(Vector3 point)
		{
			return false;
		}

		public List<Vector3> GetRightUpExtents(Vector3 right, Vector3 up)
		{
			return null;
		}

		public void Encapsulate(Sphere sphere)
		{
		}
	}
}
