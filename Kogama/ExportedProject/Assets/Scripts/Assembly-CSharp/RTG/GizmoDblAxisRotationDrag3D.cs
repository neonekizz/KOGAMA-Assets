using UnityEngine;

namespace RTG
{
	public class GizmoDblAxisRotationDrag3D : GizmoScreenDrag
	{
		public struct WorkData
		{
			public Vector2 ScreenAxis0;

			public Vector2 ScreenAxis1;

			public Vector3 Axis0;

			public Vector3 Axis1;

			public GizmoSnapMode SnapMode;

			public float SnapStep0;

			public float SnapStep1;
		}

		private WorkData _workData;

		private bool _adjustRotationForAbsSnap;

		private float _accumSnapDrag0;

		private float _accumSnapDrag1;

		private float _relativeRotation0;

		private float _relativeRotation1;

		private float _totalRotation0;

		private float _totalRotation1;

		public override GizmoDragChannel DragChannel => default(GizmoDragChannel);

		public float RelativeRotation0 => 0f;

		public float RelativeRotation1 => 0f;

		public float TotalRotation0 => 0f;

		public float TotalRotation1 => 0f;

		public void SetWorkData(WorkData workData)
		{
		}

		protected override void CalculateDragValues()
		{
		}

		protected override void OnSessionEnd()
		{
		}
	}
}
