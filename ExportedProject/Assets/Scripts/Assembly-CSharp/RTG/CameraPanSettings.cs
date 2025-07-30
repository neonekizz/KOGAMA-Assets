using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CameraPanSettings : Settings
	{
		[SerializeField]
		private CameraPanMode _panMode;

		[SerializeField]
		private float _standardPanSensitivity;

		[SerializeField]
		private float _smoothPanSensitivity;

		[SerializeField]
		private float _smoothValue;

		[SerializeField]
		private bool _invertX;

		[SerializeField]
		private bool _invertY;

		[SerializeField]
		private bool _isPanningEnabled;

		public CameraPanMode PanMode
		{
			get
			{
				return default(CameraPanMode);
			}
			set
			{
			}
		}

		public float StandardPanSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SmoothPanSensitivity
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

		public bool IsPanningEnabled
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
