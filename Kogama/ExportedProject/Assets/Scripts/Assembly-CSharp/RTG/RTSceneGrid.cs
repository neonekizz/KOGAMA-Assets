using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class RTSceneGrid : MonoSingleton<RTSceneGrid>, IXZGrid
	{
		private enum SnapToPointMode
		{
			Exact = 0,
			ClosestExtremity = 1
		}

		[SerializeField]
		private SceneGridHotkeys _hotkeys;

		[SerializeField]
		private XZGridSettings _settings;

		[SerializeField]
		private XZGridLookAndFeel _lookAndFeel;

		private List<Camera> _renderIgnoreCameras;

		public Quaternion Rotation => default(Quaternion);

		public Vector3 Right => default(Vector3);

		public Vector3 Look => default(Vector3);

		public Vector3 Normal => default(Vector3);

		public Plane WorldPlane => default(Plane);

		public Matrix4x4 WorldMatrix => default(Matrix4x4);

		public float YOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public SceneGridHotkeys Hotkeys => null;

		public XZGridSettings Settings => null;

		public XZGridLookAndFeel LookAndFeel => null;

		public void Initialize_SystemCall()
		{
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

		public XZGridCell CellFromWorldPoint(Vector3 worldPoint)
		{
			return null;
		}

		public bool Raycast(Ray ray, out float t)
		{
			t = default(float);
			return false;
		}

		public void Update_SystemCall()
		{
		}

		public void Render_SystemCall(Camera renderCamera)
		{
		}

		private void MoveUp()
		{
		}

		private void MoveDown()
		{
		}

		private float CalculateCellFadeZoom(Camera camera)
		{
			return 0f;
		}

		private SceneRaycastHit GetSceneHitForGridSnap()
		{
			return null;
		}

		private void OnInputDeviceDoubleTap(IInputDevice inputDevice, Vector2 position)
		{
		}

		private void SnapToObjectHitPoint(GameObjectRayHit objectHit, SnapToPointMode snapMode)
		{
		}
	}
}
