using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoPlaneSlider2DLookAndFeel
	{
		[SerializeField]
		private GizmoFillMode2D _fillMode;

		[SerializeField]
		private GizmoPlane2DType _planeType;

		[SerializeField]
		private float _scale;

		[SerializeField]
		private float _quadWidth;

		[SerializeField]
		private float _quadHeight;

		[SerializeField]
		private float _circleRadius;

		[SerializeField]
		private bool _isRotationArcVisible;

		[SerializeField]
		private GizmoRotationArc2DLookAndFeel _rotationArcLookAndFeel;

		[SerializeField]
		private Color _color;

		[SerializeField]
		private Color _hoveredColor;

		[SerializeField]
		private Color _borderColor;

		[SerializeField]
		private Color _hoveredBorderColor;

		[SerializeField]
		private GizmoQuad2DBorderType _quadBorderType;

		[SerializeField]
		private GizmoCircle2DBorderType _circleBorderType;

		[SerializeField]
		private GizmoPolygon2DBorderType _polygonBorderType;

		[SerializeField]
		private float _borderPolyThickness;

		public GizmoFillMode2D FillMode
		{
			get
			{
				return default(GizmoFillMode2D);
			}
			set
			{
			}
		}

		public GizmoPlane2DType PlaneType
		{
			get
			{
				return default(GizmoPlane2DType);
			}
			set
			{
			}
		}

		public float Scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float QuadWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float QuadHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CircleRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsRotationArcVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GizmoRotationArc2DLookAndFeel RotationArcLookAndFeel => null;

		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color HoveredColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color HoveredBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public GizmoQuad2DBorderType QuadBorderType
		{
			get
			{
				return default(GizmoQuad2DBorderType);
			}
			set
			{
			}
		}

		public GizmoCircle2DBorderType CircleBorderType
		{
			get
			{
				return default(GizmoCircle2DBorderType);
			}
			set
			{
			}
		}

		public GizmoPolygon2DBorderType PolygonBorderType
		{
			get
			{
				return default(GizmoPolygon2DBorderType);
			}
			set
			{
			}
		}

		public float BorderPolyThickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
