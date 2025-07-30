using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CameraBackgroundSettings : Settings
	{
		[SerializeField]
		private Color _firstColor;

		[SerializeField]
		private Color _secondColor;

		[SerializeField]
		private float _gradientOffset;

		[SerializeField]
		private bool _isVisible;

		public Color FirstColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color SecondColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float GradientOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsVisible
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
