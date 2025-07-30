using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class SpotLightGizmo3D : GizmoBehaviour
	{
		private enum AngleTickId
		{
			Top = 0,
			Right = 1,
			Bottom = 2,
			Left = 3
		}

		private class AngleTick
		{
			public Vector3 Position;

			public Vector3 LightAxis;

			public GizmoCap2D Tick;
		}

		private Light _targetLight;

		private Vector3 _pickedWorldSnapPoint;

		private bool _isSnapEnabled;

		private List<Vector3> _coneCirclePoints;

		private GizmoCap2D _dirSnapTick;

		private SceneRaycastFilter _raycastFilter;

		private AngleTick[] _angleTicks;

		private GizmoCap2D _rangeTick;

		private GizmoSglAxisOffsetDrag3D _dummyDragSession;

		private GizmoSglAxisOffsetDrag3D.WorkData _dummySessionWorkData;

		private GizmoSglAxisOffsetDrag3D _sglAxisDrag;

		private GizmoSglAxisOffsetDrag3D.WorkData _sglAxisDragWorkData;

		private Light3DSnapshot _preChangeSnapshot;

		private Light3DSnapshot _postChangeSnapshot;

		private SpotLightGizmo3DLookAndFeel _lookAndFeel;

		private SpotLightGizmo3DLookAndFeel _sharedLookAndFeel;

		private SpotLightGizmo3DSettings _settings;

		private SpotLightGizmo3DSettings _sharedSettings;

		private SpotLightGizmo3DHotkeys _hotkeys;

		private SpotLightGizmo3DHotkeys _sharedHotkeys;

		public SpotLightGizmo3DLookAndFeel LookAndFeel => null;

		public SpotLightGizmo3DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SpotLightGizmo3DSettings Settings => null;

		public SpotLightGizmo3DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SpotLightGizmo3DHotkeys Hotkeys => null;

		public SpotLightGizmo3DHotkeys SharedHotkeys
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

		public void SetSnapEnabled(bool isEnabled)
		{
		}

		public bool OwnsHandle(int handleId)
		{
			return false;
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

		private float CalcConeRadius()
		{
			return 0f;
		}

		private Vector3 CalcConeBase()
		{
			return default(Vector3);
		}

		private float CalcSpotAngleDegrees(float radius)
		{
			return 0f;
		}

		private void UpdateTicks()
		{
		}

		private void SetupSharedLookAndFeel()
		{
		}

		private void SnapDirection()
		{
		}

		private bool IsTargetReady()
		{
			return false;
		}
	}
}
