using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoPlaneSlider2DSettings
	{
		[SerializeField]
		private float _areaHoverEps;

		[SerializeField]
		private float _borderLineHoverEps;

		[SerializeField]
		private float _thickBorderPolyHoverEps;

		[SerializeField]
		private float _offsetSnapStepRight;

		[SerializeField]
		private float _offsetSnapStepUp;

		[SerializeField]
		private float _rotationSnapStep;

		[SerializeField]
		private GizmoSnapMode _rotationSnapMode;

		[SerializeField]
		private GizmoDblAxisScaleMode _scaleMode;

		[SerializeField]
		private float _scaleSnapStepRight;

		[SerializeField]
		private float _scaleSnapStepUp;

		[SerializeField]
		private float _proportionalScaleSnapStep;

		[SerializeField]
		private float _offsetSensitivity;

		[SerializeField]
		private float _rotationSensitivity;

		[SerializeField]
		private float _scaleSensitivity;

		public float AreaHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BorderLineHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ThickBorderPolyHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float OffsetSnapStepRight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float OffsetSnapStepUp
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RotationSnapStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public GizmoSnapMode RotationSnapMode
		{
			get
			{
				return default(GizmoSnapMode);
			}
			set
			{
			}
		}

		public GizmoDblAxisScaleMode ScaleMode
		{
			get
			{
				return default(GizmoDblAxisScaleMode);
			}
			set
			{
			}
		}

		public float ScaleSnapStepRight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScaleSnapStepUp
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ProportionalScaleSnapStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float OffsetSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RotationSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScaleSensitivity
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
