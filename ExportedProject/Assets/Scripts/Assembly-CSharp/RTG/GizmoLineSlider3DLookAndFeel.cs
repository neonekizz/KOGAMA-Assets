using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoLineSlider3DLookAndFeel
	{
		[SerializeField]
		private GizmoShadeMode _shadeMode;

		[SerializeField]
		private GizmoLine3DType _lineType;

		[SerializeField]
		private GizmoFillMode3D _fillMode;

		[SerializeField]
		private float _length;

		[SerializeField]
		private float _scale;

		[SerializeField]
		private bool _useZoomFactor;

		[SerializeField]
		private float _boxHeight;

		[SerializeField]
		private float _boxDepth;

		[SerializeField]
		private float _cylinderRadius;

		[SerializeField]
		private bool _isRotationArcVisible;

		[SerializeField]
		private GizmoRotationArc3DLookAndFeel _rotationArcLookAndFeel;

		[SerializeField]
		private Color _color;

		[SerializeField]
		private Color _hoveredColor;

		[SerializeField]
		private GizmoCap3DLookAndFeel _capLookAndFeel;

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

		public GizmoLine3DType LineType
		{
			get
			{
				return default(GizmoLine3DType);
			}
			set
			{
			}
		}

		public GizmoFillMode3D FillMode
		{
			get
			{
				return default(GizmoFillMode3D);
			}
			set
			{
			}
		}

		public float Length
		{
			get
			{
				return 0f;
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

		public GizmoCap3DLookAndFeel CapLookAndFeel => null;

		public float BoxHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BoxDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CylinderRadius
		{
			get
			{
				return 0f;
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
	}
}
