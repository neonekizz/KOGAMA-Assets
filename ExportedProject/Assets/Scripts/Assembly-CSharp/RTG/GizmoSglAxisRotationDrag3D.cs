using UnityEngine;

namespace RTG
{
	public class GizmoSglAxisRotationDrag3D : GizmoScreenDrag
	{
		public struct WorkData
		{
			public Vector3 RotationPlanePos;

			public Vector3 Axis;

			public GizmoSnapMode SnapMode;

			public float SnapStep;
		}

		private float _accumSnapDrag;

		private Plane _rotationPlane;

		private Vector3 _screenDragCircleTangent;

		private WorkData _workData;

		private bool _adjustRotationForAbsSnap;

		private float _relativeRotation;

		private float _totalRotation;

		public override GizmoDragChannel DragChannel => default(GizmoDragChannel);

		public float RelativeRotation => 0f;

		public float TotalRotation => 0f;

		public Plane RotationPlane => default(Plane);

		public void SetWorkData(WorkData workData)
		{
		}

		protected override void CalculateDragValues()
		{
		}

		protected override void OnSessionBegin()
		{
		}

		protected override void OnSessionEnd()
		{
		}
	}
}
