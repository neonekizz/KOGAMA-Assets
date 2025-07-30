using UnityEngine;

namespace RTG
{
	public class GizmoDblAxisScaleDrag3D : GizmoPlaneDrag3D
	{
		public struct WorkData
		{
			public int AxisIndex0;

			public int AxisIndex1;

			public Vector3 DragOrigin;

			public Vector3 Axis0;

			public Vector3 Axis1;

			public float SnapStep;
		}

		private WorkData _workData;

		private float _accumSnapDrag0;

		private float _accumSnapDrag1;

		private float _scale0;

		private float _scale1;

		private float _relativeScale0;

		private float _relativeScale1;

		private float _totalScale0;

		private float _totalScale1;

		private Vector3 _scaleDragAxis;

		public override GizmoDragChannel DragChannel => default(GizmoDragChannel);

		public int AxisIndex0 => 0;

		public int AxisIndex1 => 0;

		public float RelativeScale0 => 0f;

		public float RelativeScale1 => 0f;

		public float TotalScale0 => 0f;

		public float TotalScale1 => 0f;

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
