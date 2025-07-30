using UnityEngine;

namespace RTG
{
	public class SegmentShape2D : Shape2D
	{
		private Vector2 _startPoint;

		private Vector2 _endPoint;

		private Vector2 _direction;

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

		public Vector2 StartPoint
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 EndPoint
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 Direction
		{
			get
			{
				return default(Vector2);
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

		public void SetEndPtFromStart(Vector2 dirDromStart, float offset)
		{
		}

		public override void RenderBorder(Camera camera)
		{
		}

		public override void RenderArea(Camera camera)
		{
		}

		public override bool ContainsPoint(Vector2 point)
		{
			return false;
		}

		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}
	}
}
