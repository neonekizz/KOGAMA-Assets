using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class CircleShape2D : Shape2D
	{
		private Vector2 _center;

		private float _radius;

		private float _rotationDegrees;

		private int _numBorderPoints;

		private List<Vector2> _modelBorderPoints;

		private bool _areModelBorderPointsDirty;

		private CircleEpsilon _epsilon;

		private Shape2DPtContainMode _ptContainMode;

		public Vector2 Center
		{
			get
			{
				return default(Vector2);
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

		public float RotationDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 Right => default(Vector2);

		public Vector2 Up => default(Vector2);

		public CircleEpsilon Epsilon
		{
			get
			{
				return default(CircleEpsilon);
			}
			set
			{
			}
		}

		public float RadiusEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float WireEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int NumBorderPoints
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Shape2DPtContainMode PtContainMode
		{
			get
			{
				return default(Shape2DPtContainMode);
			}
			set
			{
			}
		}

		public static Vector2 ModelRight => default(Vector2);

		public static Vector2 ModelUp => default(Vector2);

		public static Vector2 ModelCenter => default(Vector2);

		public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt)
		{
			return default(Vector2);
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

		public List<Vector2> GetExtentPoints()
		{
			return null;
		}

		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}

		private void CalcModelBorderPoints()
		{
		}
	}
}
