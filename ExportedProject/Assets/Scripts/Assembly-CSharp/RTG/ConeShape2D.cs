using UnityEngine;

namespace RTG
{
	public class ConeShape2D : Shape2D
	{
		private Vector2 _baseCenter;

		private float _rotationDegrees;

		private float _baseRadius;

		private float _height;

		public Vector2 BaseCenter
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 BaseLeft
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 BaseRight
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 Tip
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float BaseRadius
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

		public Vector2 CentralAxis => default(Vector2);

		public Vector2 Right => default(Vector2);

		public Vector2 Up => default(Vector2);

		public static Vector2 ModelRight => default(Vector2);

		public static Vector2 ModelUp => default(Vector2);

		public static Vector2 ModelBaseCenter => default(Vector2);

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
