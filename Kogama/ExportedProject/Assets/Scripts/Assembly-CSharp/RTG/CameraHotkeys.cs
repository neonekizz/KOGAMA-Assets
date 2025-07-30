using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class CameraHotkeys : Settings
	{
		[SerializeField]
		private Hotkeys _moveForward;

		[SerializeField]
		private Hotkeys _moveBack;

		[SerializeField]
		private Hotkeys _strafeLeft;

		[SerializeField]
		private Hotkeys _strafeRight;

		[SerializeField]
		private Hotkeys _moveUp;

		[SerializeField]
		private Hotkeys _moveDown;

		[SerializeField]
		private Hotkeys _pan;

		[SerializeField]
		private Hotkeys _lookAround;

		[SerializeField]
		private Hotkeys _orbit;

		public Hotkeys MoveForward => null;

		public Hotkeys MoveBack => null;

		public Hotkeys StrafeLeft => null;

		public Hotkeys StrafeRight => null;

		public Hotkeys MoveUp => null;

		public Hotkeys MoveDown => null;

		public Hotkeys Pan => null;

		public Hotkeys LookAround => null;

		public Hotkeys Orbit => null;
	}
}
