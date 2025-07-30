using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoCap3DLookAndFeel
	{
		[SerializeField]
		private GizmoCap3DType _capType;

		[SerializeField]
		private GizmoFillMode3D _fillMode;

		[SerializeField]
		private GizmoShadeMode _shadeMode;

		[SerializeField]
		private float _scale;

		[SerializeField]
		private bool _useZoomFactor;

		[SerializeField]
		private float _coneHeight;

		[SerializeField]
		private float _coneRadius;

		[SerializeField]
		private float _pyramidHeight;

		[SerializeField]
		private float _pyramidWidth;

		[SerializeField]
		private float _pyramidDepth;

		[SerializeField]
		private float _boxWidth;

		[SerializeField]
		private float _boxHeight;

		[SerializeField]
		private float _boxDepth;

		[SerializeField]
		private float _sphereRadius;

		[SerializeField]
		private float _trPrismWidth;

		[SerializeField]
		private float _trPrismHeight;

		[SerializeField]
		private float _trPrismDepth;

		[SerializeField]
		private bool _isSphereBorderVisible;

		[SerializeField]
		private Color _sphereBorderColor;

		[SerializeField]
		private int _numSphereBorderPoints;

		[SerializeField]
		private Color _color;

		[SerializeField]
		private Color _hoveredColor;

		public GizmoCap3DType CapType
		{
			get
			{
				return default(GizmoCap3DType);
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

		public float ConeHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ConeRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PyramidHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PyramidWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PyramidDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BoxWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

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

		public float SphereRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float TrPrismWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float TrPrismHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float TrPrismDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsSphereBorderVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color SphereBorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public int NumSphereBorderPoints
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

		public static float DefaultConeHeight => 0f;

		public static float DefaultConeRadius => 0f;

		public static float DefaultPyramidHeight => 0f;

		public static float DefaultPyramidWidth => 0f;

		public static float DefaultPyramidDepth => 0f;
	}
}
