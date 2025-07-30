using UnityEngine;

namespace RTG
{
	public class GizmoRotationArc2D
	{
		public enum ArcType
		{
			Standard = 0,
			PolyProjected = 1
		}

		private ArcShape2D _arc;

		private ArcType _type;

		private PolygonShape2D _projectionPoly;

		private int _numProjectedPoints;

		public float RotationAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ArcType Type
		{
			get
			{
				return default(ArcType);
			}
			set
			{
			}
		}

		public PolygonShape2D ProjectionPoly
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int NumProjectedPoints
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void SetArcData(Vector2 arcOrigin, Vector2 arcStart, float radius)
		{
		}

		public void Render(GizmoRotationArc2DLookAndFeel lookAndFeel, Camera camera)
		{
		}
	}
}
