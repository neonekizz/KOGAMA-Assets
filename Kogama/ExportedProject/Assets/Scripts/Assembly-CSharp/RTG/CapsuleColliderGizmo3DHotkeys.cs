using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CapsuleColliderGizmo3DHotkeys
	{
		[SerializeField]
		private Hotkeys _enableSnapping;

		[SerializeField]
		private Hotkeys _scaleFromCenter;

		public Hotkeys EnableSnapping => null;

		public Hotkeys ScaleFromCenter => null;
	}
}
