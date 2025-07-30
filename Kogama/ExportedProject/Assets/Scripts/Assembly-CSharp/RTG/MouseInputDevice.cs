using UnityEngine;

namespace RTG
{
	public class MouseInputDevice : InputDeviceBase
	{
		private Vector3 _frameDelta;

		private Vector3 _mousePosInLastFrame;

		public override InputDeviceType DeviceType => default(InputDeviceType);

		public override Vector3 GetFrameDelta()
		{
			return default(Vector3);
		}

		public override Ray GetRay(Camera camera)
		{
			return default(Ray);
		}

		public override Vector3 GetPositionYAxisUp()
		{
			return default(Vector3);
		}

		public override bool HasPointer()
		{
			return false;
		}

		public override bool IsButtonPressed(int buttonIndex)
		{
			return false;
		}

		public override bool WasButtonPressedInCurrentFrame(int buttonIndex)
		{
			return false;
		}

		public override bool WasButtonReleasedInCurrentFrame(int buttonIndex)
		{
			return false;
		}

		public override bool WasMoved()
		{
			return false;
		}

		protected override void UpateFrameDeltas()
		{
		}
	}
}
