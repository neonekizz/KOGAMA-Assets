using UnityEngine;

namespace RTG
{
	public class SegmentShape3D : Shape3D
	{
		private Vector3 _startPoint;

		private Vector3 _endPoint;

		private Vector3 _direction;

		private float _length;

		private SegmentEpsilon _epsilon;

		public float Length
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 StartPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 EndPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Direction
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public SegmentEpsilon Epsilon
		{
			get
			{
				return default(SegmentEpsilon);
			}
			set
			{
			}
		}

		public float RaycastEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PtOnSegmentEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void SetEndPtFromStart(Vector3 dirDromStart, float offset)
		{
		}

		public override void RenderSolid()
		{
		}

		public override void RenderWire()
		{
		}

		public override bool Raycast(Ray ray, out float t)
		{
			t = default(float);
			return false;
		}

		public override AABB GetAABB()
		{
			return default(AABB);
		}
	}
}
