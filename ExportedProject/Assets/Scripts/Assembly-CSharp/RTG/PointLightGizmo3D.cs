using UnityEngine;

namespace RTG
{
	public class PointLightGizmo3D : GizmoBehaviour
	{
		private class ExtentTick
		{
			public Vector3 Position;

			public Vector3 Normal;

			public GizmoCap2D Tick;
		}

		private Light _targetLight;

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

		private Light3DSnapshot _preChangeSnapshot;

		private Light3DSnapshot _postChangeSnapshot;

		private GizmoSglAxisOffsetDrag3D.WorkData _offsetDragWorkData;

		private GizmoSglAxisOffsetDrag3D _offsetDrag;

		private PointLightGizmo3DLookAndFeel _lookAndFeel;

		private PointLightGizmo3DLookAndFeel _sharedLookAndFeel;

		private PointLightGizmo3DSettings _settings;

		private PointLightGizmo3DSettings _sharedSettings;

		private PointLightGizmo3DHotkeys _hotkeys;

		private PointLightGizmo3DHotkeys _sharedHotkeys;

		public PointLightGizmo3DLookAndFeel LookAndFeel => null;

		public PointLightGizmo3DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PointLightGizmo3DSettings Settings => null;

		public PointLightGizmo3DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PointLightGizmo3DHotkeys Hotkeys => null;

		public PointLightGizmo3DHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Light TargetLight => null;

		public bool IsSnapEnabled => false;

		public void SetTargetLight(Light targetLight)
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
