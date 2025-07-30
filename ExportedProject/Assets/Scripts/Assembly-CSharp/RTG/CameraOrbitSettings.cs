using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CameraOrbitSettings : Settings
	{
		[SerializeField]
		private CameraOrbitMode _orbitMode;

		[SerializeField]
		private float _standardOrbitSensitivity;

		[SerializeField]
		private float _smoothOrbitSensitivity;

		[SerializeField]
		private float _smoothValue;

		[SerializeField]
		private bool _invertX;

		[SerializeField]
		private bool _invertY;

		[SerializeField]
		private bool _isOrbitEnabled;

		public CameraOrbitMode OrbitMode
		{
			get
			{
				return default(CameraOrbitMode);
			}
			set
			{
			}
		}

		public float StandardOrbitSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SmoothOrbitSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float OrbitSensitivity => 0f;

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

		public bool IsOrbitEnabled
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
