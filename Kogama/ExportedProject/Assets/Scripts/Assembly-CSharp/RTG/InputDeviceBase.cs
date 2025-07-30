using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
	public abstract class InputDeviceBase : IInputDevice
	{
		private float _doubleTapDelay;

		private float _lastTapTime;

		private bool _didDoubleTap;

		private int _maxNumDeltaCaptures;

		private InputDeviceDeltaCapture[] _deltaCaptures;

		public bool DidDoubleTap => false;

		public float DoubleTapDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public abstract InputDeviceType DeviceType { get; }

		public event InputDeviceDoubleTapHandler DoubleTap
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public InputDeviceBase()
		{
		}

		public void SetMaxNumDeltaCaptures(int maxNumDeltaCaptures)
		{
		}

		public bool CreateDeltaCapture(Vector3 deltaOrigin, out int deltaCaptureId)
		{
			deltaCaptureId = default(int);
			return false;
		}

		public void RemoveDeltaCapture(int deltaCaptureId)
		{
		}

		public Vector3 GetCaptureDelta(int deltaCaptureId)
		{
			return default(Vector3);
		}

		public abstract Vector3 GetFrameDelta();

		public abstract Ray GetRay(Camera camera);

		public abstract Vector3 GetPositionYAxisUp();

		public abstract bool HasPointer();

		public abstract bool IsButtonPressed(int buttonIndex);

		public abstract bool WasButtonPressedInCurrentFrame(int buttonIndex);

		public abstract bool WasButtonReleasedInCurrentFrame(int buttonIndex);

		public abstract bool WasMoved();

		public void Update()
		{
		}

		protected abstract void UpateFrameDeltas();

		private void UpdateDeltaCaptures()
		{
		}

		private void DetectAndHandleDoubleTap()
		{
		}
	}
}
