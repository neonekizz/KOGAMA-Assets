using UnityEngine;

namespace RTG
{
	public class GizmoSglAxisOffsetDrag3D : GizmoPlaneDrag3D
	{
		public struct WorkData
		{
			public Vector3 DragOrigin;

			public Vector3 Axis;

			public float SnapStep;
		}

		private float _accumSnapDrag;

		private WorkData _workData;

		public Vector3 Axis => default(Vector3);

		public override GizmoDragChannel DragChannel => default(GizmoDragChannel);

		public void SetWorkData(WorkData workData)
		{
		}

		protected override Plane CalculateDragPlane()
		{
			return default(Plane);
		}

		protected override void CalculateDragValues()
		{
		}

		protected override void OnSessionEnd()
		{
		}
	}
}
