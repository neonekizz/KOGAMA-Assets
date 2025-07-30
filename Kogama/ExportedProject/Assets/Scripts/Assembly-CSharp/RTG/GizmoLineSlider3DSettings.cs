using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoLineSlider3DSettings
	{
		[SerializeField]
		private float _lineHoverEps;

		[SerializeField]
		private float _boxHoverEps;

		[SerializeField]
		private float _cylinderHoverEps;

		[SerializeField]
		private float _offsetSnapStep;

		[SerializeField]
		private float _rotationSnapStep;

		[SerializeField]
		private GizmoSnapMode _rotationSnapMode;

		[SerializeField]
		private float _scaleSnapStep;

		[SerializeField]
		private float _offsetSensitivity;

		[SerializeField]
		private float _rotationSensitivity;

		[SerializeField]
		private float _scaleSensitivity;

		public float LineHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BoxHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CylinderHoverEps
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float OffsetSnapStep
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

		public float ScaleSnapStep
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
