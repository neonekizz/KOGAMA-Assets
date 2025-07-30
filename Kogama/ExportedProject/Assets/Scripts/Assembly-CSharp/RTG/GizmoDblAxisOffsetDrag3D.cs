using UnityEngine;

namespace RTG
{
	public class GizmoDblAxisOffsetDrag3D : GizmoPlaneDrag3D
	{
		public struct WorkData
		{
			public Vector3 DragOrigin;

			public Vector3 Axis0;

			public Vector3 Axis1;

			public float SnapStep0;

			public float SnapStep1;
		}

		private float _accumSnapDrag0;

		private float _accumSnapDrag1;

		private WorkData _workData;

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
