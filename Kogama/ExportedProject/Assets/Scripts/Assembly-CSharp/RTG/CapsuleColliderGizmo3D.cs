using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class CapsuleColliderGizmo3D : GizmoBehaviour
	{
		private class ExtentTick
		{
			public Vector3 Position;

			public Vector3 Normal;

			public GizmoCap2D Tick;
		}

		private CapsuleCollider _targetCollider;

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

		private CapsuleCollider3DSnapshot _preChangeColliderSnapshot;

		private CapsuleCollider3DSnapshot _postChangeColliderSnapshot;

		private GizmoSglAxisOffsetDrag3D.WorkData _offsetDragWorkData;

		private GizmoSglAxisOffsetDrag3D _offsetDrag;

		private CapsuleColliderGizmo3DLookAndFeel _lookAndFeel;

		private CapsuleColliderGizmo3DLookAndFeel _sharedLookAndFeel;

		private CapsuleColliderGizmo3DSettings _settings;

		private CapsuleColliderGizmo3DSettings _sharedSettings;

		private CapsuleColliderGizmo3DHotkeys _hotkeys;

		private CapsuleColliderGizmo3DHotkeys _sharedHotkeys;

		public CapsuleColliderGizmo3DLookAndFeel LookAndFeel => null;

		public CapsuleColliderGizmo3DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CapsuleColliderGizmo3DSettings Settings => null;

		public CapsuleColliderGizmo3DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CapsuleColliderGizmo3DHotkeys Hotkeys => null;

		public CapsuleColliderGizmo3DHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CapsuleCollider TargetCollider => null;

		public bool IsSnapEnabled => false;

		public void SetTargetCollider(CapsuleCollider capsuleCollider)
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
