using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class RightAngTriangle2D : Shape2D
	{
		private Vector2 _rightAngleCorner;

		private float _XLength;

		private float _YLength;

		private float _rotationDegrees;

		private TriangleEpsilon _epsilon;

		public Vector2 RightAngleCorner
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float XLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float YLength
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

		public TriangleEpsilon Epsilon
		{
			get
			{
				return default(TriangleEpsilon);
			}
			set
			{
			}
		}

		public float AreaEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static Vector2 ModelRight => default(Vector2);

		public static Vector2 ModelUp => default(Vector2);

		public static Vector2 ModelRightAngleCorner => default(Vector2);

		public override void RenderArea(Camera camera)
		{
		}

		public override void RenderBorder(Camera camera)
		{
		}

		public List<Vector2> GetPoints()
		{
			return null;
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
