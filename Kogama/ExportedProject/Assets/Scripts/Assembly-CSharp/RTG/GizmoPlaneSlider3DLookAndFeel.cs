using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoPlaneSlider3DLookAndFeel
	{
		[SerializeField]
		private GizmoPlane3DType _planeType;

		[SerializeField]
		private float _scale;

		[SerializeField]
		private bool _useZoomFactor;

		[SerializeField]
		private float _quadWidth;

		[SerializeField]
		private float _quadHeight;

		[SerializeField]
		private float _raTriangleXLength;

		[SerializeField]
		private float _raTriangleYLength;

		[SerializeField]
		private float _circleRadius;

		[SerializeField]
		private float _borderBoxHeight;

		[SerializeField]
		private float _borderBoxDepth;

		[SerializeField]
		private float _borderTorusThickness;

		[SerializeField]
		private int _numBorderTorusWireAxialSlices;

		[SerializeField]
		private float _borderCylTorusWidth;

		[SerializeField]
		private float _borderCylTorusHeight;

		[SerializeField]
		private GizmoShadeMode _shadeMode;

		[SerializeField]
		private Color _color;

		[SerializeField]
		private Color _hoveredColor;

		[SerializeField]
		private Color _borderColor;

		[SerializeField]
		private Color _hoveredBorderColor;

		[SerializeField]
		private float _borderCircleCullAlphaScale;

		[SerializeField]
		private GizmoShadeMode _borderShadeMode;

		[SerializeField]
		private GizmoFillMode3D _borderFillMode;

		[SerializeField]
		private GizmoQuad3DBorderType _quadBorderType;

		[SerializeField]
		private GizmoRATriangle3DBorderType _raTriangleBorderType;

		[SerializeField]
		private GizmoCircle3DBorderType _circleBorderType;

		[SerializeField]
		private bool _isRotationArcVisible;

		[SerializeField]
		private GizmoRotationArc3DLookAndFeel _rotationArcLookAndFeel;

		public GizmoShadeMode ShadeMode
		{
			get
			{
				return default(GizmoShadeMode);
			}
			set
			{
			}
		}

		public GizmoPlane3DType PlaneType
		{
			get
			{
				return default(GizmoPlane3DType);
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

		public bool UseZoomFactor
		{
			get
			{
				return false;
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

		public float RATriangleXLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RATriangleYLength
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

		public float BorderCircleCullAlphaScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BorderBoxHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BorderBoxDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BorderTorusThickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BorderCylTorusWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BorderCylTorusHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int NumBorderTorusWireAxialSlices
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

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

		public GizmoShadeMode BorderShadeMode
		{
			get
			{
				return default(GizmoShadeMode);
			}
			set
			{
			}
		}

		public GizmoFillMode3D BorderFillMode
		{
			get
			{
				return default(GizmoFillMode3D);
			}
			set
			{
			}
		}

		public GizmoQuad3DBorderType QuadBorderType
		{
			get
			{
				return default(GizmoQuad3DBorderType);
			}
			set
			{
			}
		}

		public GizmoCircle3DBorderType CircleBorderType
		{
			get
			{
				return default(GizmoCircle3DBorderType);
			}
			set
			{
			}
		}

		public GizmoRATriangle3DBorderType RATriangleBorderType
		{
			get
			{
				return default(GizmoRATriangle3DBorderType);
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

		public GizmoRotationArc3DLookAndFeel RotationArcLookAndFeel => null;
	}
}
