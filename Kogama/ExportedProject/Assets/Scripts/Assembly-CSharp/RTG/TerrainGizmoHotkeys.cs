using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class TerrainGizmoHotkeys
	{
		[SerializeField]
		private Hotkeys _enableSnapping;

		private Hotkeys _rotateObjects;

		public Hotkeys EnableSnapping => null;

		public Hotkeys RotateObjects => null;
	}
}
