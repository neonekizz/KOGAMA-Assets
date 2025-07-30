using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class CharacterControllerGizmo3D : GizmoBehaviour
	{
		private class ExtentTick
		{
			public Vector3 Position;

			public Vector3 Normal;

			public GizmoCap2D Tick;
		}

		private CharacterController _targetController;

		private bool _scaleFromCenter;

		private bool _isSnapEnabled;

		private float _heightOnDragBegin;

		private GizmoCap2D _rightTick;

		private GizmoCap2D _topTick;

		private GizmoCap2D _backTick;

		private GizmoCap2D _leftTick;

		private GizmoCap2D _bottomTick;

		private GizmoCap2D _frontTick;

		private ExtentTick[] _extentTicks;

		private List<Vector3> _semiCirclePts;

		private List<Vector3> _circlePts;

		private CharacterController3DSnapshot _preChangeColliderSnapshot;

		private CharacterController3DSnapshot _postChangeColliderSnapshot;

		private GizmoSglAxisOffsetDrag3D.WorkData _offsetDragWorkData;

		private GizmoSglAxisOffsetDrag3D _offsetDrag;

		private CharacterControllerGizmo3DLookAndFeel _lookAndFeel;

		private CharacterControllerGizmo3DLookAndFeel _sharedLookAndFeel;

		private CharacterControllerGizmo3DSettings _settings;

		private CharacterControllerGizmo3DSettings _sharedSettings;

		private CharacterControllerGizmo3DHotkeys _hotkeys;

		private CharacterControllerGizmo3DHotkeys _sharedHotkeys;

		public CharacterControllerGizmo3DLookAndFeel LookAndFeel => null;

		public CharacterControllerGizmo3DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CharacterControllerGizmo3DSettings Settings => null;

		public CharacterControllerGizmo3DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CharacterControllerGizmo3DHotkeys Hotkeys => null;

		public CharacterControllerGizmo3DHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CharacterController TargetController => null;

		public bool IsSnapEnabled => false;

		public void SetTargetController(CharacterController characterController)
		{
		}

		public override void OnGizmoEnabled()
		{
		}

		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		public void SetSnapEnabled(bool isEnabled)
		{
		}

		public void SetScaleFromCenterEnabled(bool isEnabled)
		{
		}

		public override void OnAttached()
		{
		}

		public override void OnGizmoUpdateBegin()
		{
		}

		public override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		public override void OnGizmoDragUpdate(int handleId)
		{
		}

		public override void OnGizmoDragEnd(int handleId)
		{
		}

		public override void OnGizmoRender(Camera camera)
		{
		}

		private Vector3 CalcScalePivot(int handleId)
		{
			return default(Vector3);
		}

		private Vector3 CalcWorldCenter()
		{
			return default(Vector3);
		}

		private float CalcWorldRadius()
		{
			return 0f;
		}

		private float CalcWorldHeight()
		{
			return 0f;
		}

		private float CalcHeightScale()
		{
			return 0f;
		}

		private float CalcRadiusScale()
		{
			return 0f;
		}

		private Quaternion CalcRotationByDirection()
		{
			return default(Quaternion);
		}

		private void UpdateHandles()
		{
		}

		private void UpdateTickColors(Camera camera)
		{
		}

		private void UpdateHoverPriorities(Camera camera)
		{
		}

		private void SetupSharedLookAndFeel()
		{
		}

		private bool IsTargetReady()
		{
			return false;
		}
	}
}
