using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class ScaleGizmoHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _enableSnapping;

		[SerializeField]
		private Hotkeys _changeMultiAxisMode;

		public Hotkeys EnableSnapping => null;

		public Hotkeys ChangeMultiAxisMode => null;
	}
}
