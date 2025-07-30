using UnityEngine;

namespace RTG
{
	public class RTSceneGizmoCamera : MonoBehaviour
	{
		private Camera _camera;

		private Transform _transform;

		private Vector3 _lookAtPoint;

		private float _fieldOfView;

		private float _orthoSize;

		private float _offsetFromFocusPt;

		private Camera _sceneCamera;

		private ISceneGizmoCamViewportUpdater _viewportUpdater;

		public Camera Camera => null;

		public Camera SceneCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ISceneGizmoCamViewportUpdater ViewportUpdater
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 WorldPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion WorldRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 Right => default(Vector3);

		public Vector3 Up => default(Vector3);

		public Vector3 Look => default(Vector3);

		public Vector3 LookAtPoint => default(Vector3);

		public void Update_SystemCall()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}
	}
}
