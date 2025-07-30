using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoLineSlider2DLookAndFeel
	{
		[SerializeField]
		private GizmoLine2DType _lineType;

		[SerializeField]
		private GizmoFillMode2D _fillMode;

		[SerializeField]
		private float _length;

		[SerializeField]
		private float _scale;

		[SerializeField]
		private float _boxThickness;

		[SerializeField]
		private bool _isRotationArcVisible;

		[SerializeField]
		private Color _color;

		[SerializeField]
		private Color _hoveredColor;

		[SerializeField]
		private Color _borderColor;

		[SerializeField]
		private Color _hoveredBorderColor;

		[SerializeField]
		private GizmoRotationArc2DLookAndFeel _rotationArcLookAndFeel;

		[SerializeField]
		private GizmoCap2DLookAndFeel _capLookAndFeel;

		public GizmoLine2DType LineType
		{
			get
			{
				return default(GizmoLine2DType);
			}
			set
			{
			}
		}

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

		public GizmoCap2DLookAndFeel CapLookAndFeel => null;

		public float BoxThickness
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

		public GizmoRotationArc2DLookAndFeel RotationArcLookAndFeel => null;
	}
}
