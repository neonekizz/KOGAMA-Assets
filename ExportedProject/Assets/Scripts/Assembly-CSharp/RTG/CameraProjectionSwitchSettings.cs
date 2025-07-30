using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CameraProjectionSwitchSettings : Settings
	{
		[SerializeField]
		private CameraProjectionSwitchMode _switchMode;

		[SerializeField]
		private float _transitionDurationInSeconds;

		public CameraProjectionSwitchMode SwitchMode
		{
			get
			{
				return default(CameraProjectionSwitchMode);
			}
			set
			{
			}
		}

		public float TransitionDurationInSeconds
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
