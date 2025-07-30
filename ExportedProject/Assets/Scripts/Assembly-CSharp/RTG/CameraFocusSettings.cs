using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CameraFocusSettings : Settings
	{
		[SerializeField]
		private CameraFocusMode _focusMode;

		[SerializeField]
		private float _constantSpeed;

		[SerializeField]
		private float _smoothTime;

		[SerializeField]
		private float _focusDistanceAdd;

		public CameraFocusMode FocusMode
		{
			get
			{
				return default(CameraFocusMode);
			}
			set
			{
			}
		}

		public float ConstantSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SmoothTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float FocusDistanceAdd
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
