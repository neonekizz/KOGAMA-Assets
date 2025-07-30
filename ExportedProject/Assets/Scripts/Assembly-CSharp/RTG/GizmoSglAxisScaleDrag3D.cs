using UnityEngine;

namespace RTG
{
	public class GizmoSglAxisScaleDrag3D : GizmoPlaneDrag3D
	{
		public struct WorkData
		{
			public int AxisIndex;

			public Vector3 DragOrigin;

			public Vector3 Axis;

			public float SnapStep;

			public float EntityScale;
		}

		private float _accumSnapDrag;

		private WorkData _workData;

		private float _scale;

		private float _relativeScale;

		private float _totalScale;

		public override GizmoDragChannel DragChannel => default(GizmoDragChannel);

		public int AxisIndex => 0;

		public float RelativeScale => 0f;

		public float TotalScale => 0f;

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
