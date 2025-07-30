using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class MoveGizmoHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _enable2DMode;

		[SerializeField]
		private Hotkeys _enableSnapping;

		[SerializeField]
		private Hotkeys _enableVertexSnapping;

		public Hotkeys Enable2DMode => null;

		public Hotkeys EnableSnapping => null;

		public Hotkeys EnableVertexSnapping => null;
	}
}
