using UnityEngine;

namespace RTG
{
	public class Plane2D
	{
		private Vector2 _normal;

		private float _distance;

		public Vector2 Normal
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float Distance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Plane2D(Vector2 normal, float distance)
		{
		}

		public Plane2D(Vector2 normal, Vector2 pointOnPlane)
		{
		}

		public float GetDistanceToPoint(Vector2 point)
		{
			return 0f;
		}

		public bool Raycast(Vector2 rayOrigin, Vector2 rayDir, out float t)
		{
			t = default(float);
			return false;
		}
	}
}
