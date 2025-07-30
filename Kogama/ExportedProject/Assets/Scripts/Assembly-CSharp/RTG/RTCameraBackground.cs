using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class RTCameraBackground : MonoSingleton<RTCameraBackground>
	{
		[SerializeField]
		private CameraBackgroundSettings _bkSettings;

		[SerializeField]
		private List<Camera> _renderIgnoreCameras;

		private Dictionary<Camera, CameraBackgroundSettings> _cameraToBkSettings;

		public CameraBackgroundSettings Settings => null;

		public void SetCameraBkSettings(Camera camera, CameraBackgroundSettings bkSettings)
		{
		}

		public List<Camera> GetAllRenderIgnoreCameras()
		{
			return null;
		}

		public bool IsRenderIgnoreCamera(Camera camera)
		{
			return false;
		}

		public void AddRenderIgnoreCamera(Camera camera)
		{
		}

		public void RemoveRenderIgnoreCamera(Camera camera)
		{
		}

		public void Render_SystemCall(Camera renderCamera)
		{
		}
	}
}
