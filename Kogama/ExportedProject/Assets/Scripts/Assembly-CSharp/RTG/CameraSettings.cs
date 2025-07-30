using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CameraSettings : Settings
	{
		[SerializeField]
		private bool _canProcessInput;

		public bool CanProcessInput
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
