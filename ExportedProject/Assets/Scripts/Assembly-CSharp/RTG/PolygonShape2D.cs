using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class PolygonShape2D : Shape2D
	{
		public enum ThickBorderFillMode
		{
			Filled = 0,
			Border = 1
		}

		public class BorderRenderDescriptor
		{
			private Shape2DBorderType _borderType;

			private float _thickness;

			private Shape2DBorderDirection _direction;

			private ThickBorderFillMode _fillMode;

			public Shape2DBorderType BorderType
			{
				get
				{
					return default(Shape2DBorderType);
				}
				set
				{
				}
			}

			public float Thickness
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public Shape2DBorderDirection Direction
			{
				get
				{
					return default(Shape2DBorderDirection);
				}
				set
				{
				}
			}

			public ThickBorderFillMode FillMode
			{
				get
				{
					return default(ThickBorderFillMode);
				}
				set
				{
				}
			}
		}

		private Rect _rect;

		private bool _isRectDirty;

		private bool _isClosed;

		private List<Vector2> _cwPolyPoints;

		private List<Vector2> _thickCwBorderPoints;

		private bool _isThickBorderDirty;

		private PolygonEpsilon _epsilon;

		private Shape2DPtContainMode _ptContainMode;

		private BorderRenderDescriptor _borderRenderDesc;

		public int NumPoints => 0;

		public PolygonEpsilon Epsilon
		{
			get
			{
				return default(PolygonEpsilon);
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

		public float ThickWireEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsClosed => false;

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

		public BorderRenderDescriptor BorderRenderDesc => null;

		public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt)
		{
			return default(Vector2);
		}

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

		public override Rect GetEncapsulatingRect()
		{
			return default(Rect);
		}

		public void CopyPoints(PolygonShape2D sourcePoly)
		{
		}

		public void SetClockwisePoints(List<Vector2> cwBorderPoints, bool isClosed)
		{
		}

		public void MakeSphereBorder(Vector3 sphereCenter, float sphereRadius, int numPoints, Camera camera)
		{
		}

		public override bool ContainsPoint(Vector2 point)
		{
			return false;
		}

		private void CalculateRect()
		{
		}

		private void CalculateThickBorderPoints()
		{
		}
	}
}
