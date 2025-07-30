using UnityEngine;

namespace RTG
{
	public class EqTriangle2D : Shape2D
	{
		private float _sideLength;

		private float _rotationDegrees;

		private TriangleEpsilon _epsilon;

		private Vector2[] _points;

		private Vector2 _centroid;

		private bool _arePointsDirty;

		public float SideLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 Centroid
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float Altitude => 0f;

		public float CentroidAltitude => 0f;

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

		public Vector2 Right => default(Vector2);

		public Vector2 Up => default(Vector2);

		public static Vector2 ModelRight => default(Vector2);

		public static Vector2 ModelUp => default(Vector2);

		public static Vector2 ModelCentroid => default(Vector2);

		public Vector2 GetPoint(EqTrianglePoint point)
		{
			return default(Vector2);
		}

		public void SetPoint(EqTrianglePoint point, Vector2 pointValue)
		{
		}

		public Vector2 GetEdgeMidPoint(EqTriangleEdge edge)
		{
			return default(Vector2);
		}

		public Vector2 GetEdge(EqTriangleEdge edge)
		{
			return default(Vector2);
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

		private void OnPointsFoundDirty()
		{
		}
	}
}
