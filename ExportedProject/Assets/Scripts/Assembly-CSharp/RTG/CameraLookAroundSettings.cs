using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CameraLookAroundSettings : Settings
	{
		[SerializeField]
		private CameraLookAroundMode _lookAroundMode;

		[SerializeField]
		private float _standardLookAroundSensitivity;

		[SerializeField]
		private float _smoothLookAroundSensitivity;

		[SerializeField]
		private float smoothValue;

		[SerializeField]
		private bool _invertX;

		[SerializeField]
		private bool _invertY;

		[SerializeField]
		private bool _isLookAroundEnabled;

		public CameraLookAroundMode LookAroundMode
		{
			get
			{
				return default(CameraLookAroundMode);
			}
			set
			{
			}
		}

		public float StandardLookAroundSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SmoothLookAroundSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Sensitivity => 0f;

		public float SmoothValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool InvertX
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool InvertY
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsLookAroundEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
