using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class GizmoScaleGuideLookAndFeel
	{
		[SerializeField]
		private bool _useZoomFactor;

		[SerializeField]
		private Color _xAxisColor;

		[SerializeField]
		private Color _yAxisColor;

		[SerializeField]
		private Color _zAxisColor;

		[SerializeField]
		private float _axisLength;

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

		public Color XAxisColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color YAxisColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color ZAxisColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float AxisLength
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
