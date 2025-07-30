using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoCap2DLookAndFeel
	{
		[SerializeField]
		private GizmoFillMode2D _fillMode;

		[SerializeField]
		private GizmoCap2DType _capType;

		[SerializeField]
		private float _scale;

		[SerializeField]
		private float _circleRadius;

		[SerializeField]
		private float _quadWidth;

		[SerializeField]
		private float _quadHeight;

		[SerializeField]
		private float _arrowBaseRadius;

		[SerializeField]
		private float _arrowHeight;

		[SerializeField]
		private Color _color;

		[SerializeField]
		private Color _hoveredColor;

		[SerializeField]
		private Color _borderColor;

		[SerializeField]
		private Color _hoveredBorderColor;

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

		public GizmoCap2DType CapType
		{
			get
			{
				return default(GizmoCap2DType);
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

		public float ArrowBaseRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ArrowHeight
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
	}
}
