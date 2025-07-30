using UnityEngine;

namespace RTG
{
	public class InputDeviceScreenDragSession
	{
		private Vector2 _dragPoint;

		private Vector2 _dragDelta;

		private Vector2 _accumDrag;

		private IInputDevice _inputDevice;

		private bool _isActive;

		public Vector2 DragPoint => default(Vector2);

		public Vector2 DragDelta => default(Vector2);

		public Vector2 AccumDrag => default(Vector2);

		public bool IsActive => false;

		public InputDeviceScreenDragSession(IInputDevice inputDevice)
		{
		}

		public bool Begin()
		{
			return false;
		}

		public void End()
		{
		}

		public bool Update()
		{
			return false;
		}

		private bool UpdateDragPoint()
		{
			return false;
		}
	}
}
