using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class ArcShape2D : Shape2D
	{
		public enum BorderRenderFlags
		{
			None = 0,
			ExtremitiesBorder = 1,
			ArcBorder = 2,
			All = 3
		}

		public class BorderRenderDescriptor
		{
			private BorderRenderFlags _borderFlags;

			public BorderRenderFlags BorderFlags
			{
				get
				{
					return default(BorderRenderFlags);
				}
				set
				{
				}
			}
		}

		private BorderRenderDescriptor _borderRenderDesc;

		private Rect _rect;

		private bool _forceShortestArc;

		private float _radius;

		private Vector2 _origin;

		private Vector2 _startPoint;

		private Vector2 _endPoint;

		private List<Vector2> _borderPoints;

		private float _degreeAngleFromStart;

		private int _numBorderPoints;

		private bool _areBorderPointsDirty;

		private ArcEpsilon _epsilon;

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

		public bool ForceShortestArc
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float DegreeAngleFromStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AbsDegreeAngleFromStart => 0f;

		public Vector2 Origin
		{
			get
			{
				return default(Vector2);
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

		public Vector2 StartPoint => default(Vector2);

		public Vector2 EndPoint => default(Vector2);

		public ArcEpsilon Epsilon
		{
			get
			{
				return default(ArcEpsilon);
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

		public BorderRenderDescriptor BorderRenderDesc => null;

		public override void RenderArea(Camera camera)
		{
		}

		public override void RenderBorder(Camera camera)
		{
		}

		public void SetArcData(Vector2 startPoint, float radius)
		{
		}

		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}

		public override bool ContainsPoint(Vector2 point)
		{
			return false;
		}

		private void OnBorderPointsFoundDirty()
		{
		}

		private void CalculateEndPoint()
		{
		}
	}
}
