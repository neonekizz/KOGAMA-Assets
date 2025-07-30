using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class DirectionalLightGizmo3D : GizmoBehaviour
	{
		private Light _targetLight;

		private Vector3 _pickedWorldSnapPoint;

		private GizmoCap2D _dirSnapTick;

		private List<Vector3> _sourceCirclePoints;

		private List<Vector3> _lightRayEmissionPoints;

		private SceneRaycastFilter _raycastFilter;

		private GizmoSglAxisOffsetDrag3D _dummyDragSession;

		private GizmoSglAxisOffsetDrag3D.WorkData _dummySessionWorkData;

		private Light3DSnapshot _preChangeSnapshot;

		private Light3DSnapshot _postChangeSnapshot;

		private DirectionalLightGizmo3DLookAndFeel _lookAndFeel;

		private DirectionalLightGizmo3DLookAndFeel _sharedLookAndFeel;

		public DirectionalLightGizmo3DLookAndFeel LookAndFeel => null;

		public DirectionalLightGizmo3DLookAndFeel SharedLookAndFeel
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

		public void SetTargetLight(Light targetLight)
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

		private void UpdateTicks(Camera camera)
		{
		}

		private void SetupSharedLookAndFeel()
		{
		}

		private void GenerateLightRayEmissionPoints(Camera camera)
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
