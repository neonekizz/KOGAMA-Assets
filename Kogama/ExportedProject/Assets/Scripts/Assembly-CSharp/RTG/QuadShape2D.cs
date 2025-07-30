using UnityEngine;

namespace RTG
{
	public class QuadShape2D : Shape2D
	{
		private Vector2 _center;

		private Vector2 _size;

		private float _rotationDegrees;

		private QuadEpsilon _epsilon;

		private Shape2DPtContainMode _ptContainMode;

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

		public Quaternion Rotation => default(Quaternion);

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

		public Vector2 Size
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 Extents => default(Vector2);

		public float Width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Height
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public QuadEpsilon Epsilon
		{
			get
			{
				return default(QuadEpsilon);
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

		public Vector2 SizeEps
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float WidthEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float HeightEps
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

		public Vector2 Right => default(Vector2);

		public Vector2 Up => default(Vector2);

		public static Vector2 ModelRight => default(Vector2);

		public static Vector2 ModelUp => default(Vector2);

		public static Vector2 ModelCenter => default(Vector2);

		public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt)
		{
			return default(Vector2);
		}

		public void AlignWidth(Vector2 axis)
		{
		}

		public float GetSizeAlongDirection(Vector2 direction)
		{
			return 0f;
		}

		public override void RenderArea(Camera camera)
		{
		}

		public override void RenderBorder(Camera camera)
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
