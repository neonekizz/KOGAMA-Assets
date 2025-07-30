using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CameraZoomSettings : Settings
	{
		[SerializeField]
		private CameraZoomMode _zoomMode;

		[SerializeField]
		private float _orthoStandardZoomSensitivity;

		[SerializeField]
		private float _perspStandardZoomSensitivity;

		[SerializeField]
		private float _orthoSmoothZoomSensitivity;

		[SerializeField]
		private float _perspSmoothZoomSensitivity;

		[SerializeField]
		private float _orthoZoomSmoothValue;

		[SerializeField]
		private float _perspZoomSmoothValue;

		[SerializeField]
		private bool _invertZoomAxis;

		[SerializeField]
		private bool _isZoomEnabled;

		public CameraZoomMode ZoomMode
		{
			get
			{
				return default(CameraZoomMode);
			}
			set
			{
			}
		}

		public float OrthoStandardZoomSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PerspStandardZoomSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float OrthoSmoothZoomSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PerspSmoothZoomSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float OrthoZoomSmoothValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PerspZoomSmoothValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool InvertZoomAxis
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsZoomEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float GetZoomSmoothValue(Camera camera)
		{
			return 0f;
		}

		public float GetZoomSensitivity(Camera camera)
		{
			return 0f;
		}
	}
}
