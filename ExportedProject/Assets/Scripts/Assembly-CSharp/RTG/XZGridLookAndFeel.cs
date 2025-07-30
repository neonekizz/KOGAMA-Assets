using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class XZGridLookAndFeel : Settings
	{
		[SerializeField]
		private Color _lineColor;

		[SerializeField]
		private bool _useCellFading;

		public Color LineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool UseCellFading
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
