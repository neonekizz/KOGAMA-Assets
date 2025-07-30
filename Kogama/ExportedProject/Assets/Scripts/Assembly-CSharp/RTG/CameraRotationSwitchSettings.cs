using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CameraRotationSwitchSettings : Settings
	{
		private static readonly float _minConstantDuration;

		[SerializeField]
		private CameraRotationSwitchMode _switchMode;

		[SerializeField]
		private CameraRotationSwitchType _switchType;

		[SerializeField]
		private float _constantSwitchDurationInSeconds;

		[SerializeField]
		private float _smoothValue;

		public CameraRotationSwitchMode SwitchMode
		{
			get
			{
				return default(CameraRotationSwitchMode);
			}
			set
			{
			}
		}

		public CameraRotationSwitchType SwitchType
		{
			get
			{
				return default(CameraRotationSwitchType);
			}
			set
			{
			}
		}

		public float ConstantSwitchDurationInSeconds
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

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
	}
}
