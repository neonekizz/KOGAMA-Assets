using UnityEngine;

namespace RTG
{
	public class SphereColliderGizmo : GizmoBehaviour
	{
		private class ExtentTick
		{
			public Vector3 Position;

			public Vector3 Normal;

			public GizmoCap2D Tick;
		}

		private SphereCollider _targetCollider;

		private bool _scaleFromCenter;

		private bool _isSnapEnabled;

		private GizmoCap2D _rightTick;

		private GizmoCap2D _topTick;

		private GizmoCap2D _backTick;

		private GizmoCap2D _leftTick;

		private GizmoCap2D _bottomTick;

		private GizmoCap2D _frontTick;

		private ExtentTick[] _extentTicks;

		private GizmoPlaneSlider3D _axialCircleXY;

		private GizmoPlaneSlider3D _axialCircleYZ;

		private GizmoPlaneSlider3D _axialCircleZX;

		private PolygonShape2D _sphereBorderPoly;

		private SphereColliderSnapshot _preChangeColliderSnapshot;

		private SphereColliderSnapshot _postChangeColliderSnapshot;

		private GizmoSglAxisOffsetDrag3D.WorkData _offsetDragWorkData;

		private GizmoSglAxisOffsetDrag3D _offsetDrag;

		private SphereColliderGizmoLookAndFeel _lookAndFeel;

		private SphereColliderGizmoLookAndFeel _sharedLookAndFeel;

		private SphereColliderGizmoSettings _settings;

		private SphereColliderGizmoSettings _sharedSettings;

		private SphereColliderGizmoHotkeys _hotkeys;

		private SphereColliderGizmoHotkeys _sharedHotkeys;

		public SphereColliderGizmoLookAndFeel LookAndFeel => null;

		public SphereColliderGizmoLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SphereColliderGizmoSettings Settings => null;

		public SphereColliderGizmoSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SphereColliderGizmoHotkeys Hotkeys => null;

		public SphereColliderGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SphereCollider TargetCollider => null;

		public bool IsSnapEnabled => false;

		public void SetTargetCollider(SphereCollider sphereCollider)
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

		private float CalcMaxTransformAbsScale()
		{
			return 0f;
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
