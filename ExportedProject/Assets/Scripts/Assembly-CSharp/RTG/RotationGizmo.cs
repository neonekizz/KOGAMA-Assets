using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class RotationGizmo : GizmoBehaviour
	{
		private GizmoPlaneSlider3D _xSlider;

		private GizmoPlaneSlider3D _ySlider;

		private GizmoPlaneSlider3D _zSlider;

		private GizmoPlaneSlider3DCollection _axesSliders;

		private GizmoCap3D _midCap;

		private GizmoDblAxisRotationDrag3D _camXYRotationDrag;

		private GizmoPlaneSlider2D _camLookSlider;

		[SerializeField]
		private RotationGizmoHotkeys _hotkeys;

		[SerializeField]
		private RotationGizmoSettings3D _settings3D;

		[SerializeField]
		private RotationGizmoLookAndFeel3D _lookAndFeel3D;

		[SerializeField]
		private bool _useSnapEnableHotkey;

		private RotationGizmoHotkeys _sharedHotkeys;

		private RotationGizmoSettings3D _sharedSettings3D;

		private RotationGizmoLookAndFeel3D _sharedLookAndFeel3D;

		public RotationGizmoSettings3D Settings3D => null;

		public RotationGizmoLookAndFeel3D LookAndFeel3D => null;

		public RotationGizmoHotkeys Hotkeys => null;

		public RotationGizmoSettings3D SharedSettings3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RotationGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RotationGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseSnapEnableHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float GetZoomFactor(Vector3 position)
		{
			return 0f;
		}

		public float GetZoomFactor(Vector3 position, Camera camera)
		{
			return 0f;
		}

		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		public void SetMidCapHoverable(bool hoverable)
		{
		}

		public void SetSnapEnabled(bool isEnabled)
		{
		}

		public override void OnGizmoEnabled()
		{
		}

		public override void OnDetached()
		{
		}

		public override void OnEnabled()
		{
		}

		public override void OnDisabled()
		{
		}

		public override void OnAttached()
		{
		}

		public override void OnGizmoUpdateBegin()
		{
		}

		public override void OnGizmoRender(Camera camera)
		{
		}

		public override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		private void UpdateCamLookSlider(Camera camera)
		{
		}

		private void SetupSharedLookAndFeel()
		{
		}

		private void SetupSharedSettings()
		{
		}

		private void OnGizmoTransformChanged(GizmoTransform gizmoTransform, GizmoTransform.ChangeData changeData)
		{
		}
	}
}
