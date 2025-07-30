using UnityEngine;

namespace RTG
{
	public class InputDevicePlaneDragSession3D
	{
		private Plane _plane;

		private Camera _raycastCamera;

		private Vector3 _dragPoint;

		private Vector3 _dragDelta;

		private Vector3 _accumDrag;

		private IInputDevice _inputDevice;

		private bool _isActive;

		public Plane Plane
		{
			get
			{
				return default(Plane);
			}
			set
			{
			}
		}

		public Camera RaycastCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 DragPoint => default(Vector3);

		public Vector3 DragDelta => default(Vector3);

		public Vector3 AccumDrag => default(Vector3);

		public bool IsActive => false;

		public InputDevicePlaneDragSession3D(IInputDevice inputDevice, Camera raycastCamera)
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
