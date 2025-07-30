using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
	public class RTCameraViewports : Singleton<RTCameraViewports>
	{
		public delegate void CameraAddedHandler(Camera camera);

		public delegate void CameraRemovedHandler(Camera camera);

		public delegate void FocusCameraChangedHandler(Camera oldFocusCam, Camera newFocusCam);

		private List<Camera> _cameras;

		public Camera FocusCamera => null;

		public int NumCameras => 0;

		public event CameraAddedHandler CameraAdded
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

		public event CameraRemovedHandler CameraRemoved
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

		public event FocusCameraChangedHandler FocusCameraChanged
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

		public bool ContainsCamera(Camera camera)
		{
			return false;
		}

		public void AddCamera(Camera camera, Rect normViewRect)
		{
		}

		public void AddCamera(Camera camera)
		{
		}

		public void RemoveCamera(Camera camera)
		{
		}

		public void SetFocusCamera(int cameraIndex)
		{
		}

		public void SetFocusCamera(Camera camera)
		{
		}
	}
}
