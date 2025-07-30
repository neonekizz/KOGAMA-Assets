using UnityEngine;

namespace RTG
{
	public class GizmoUniformScaleDrag3D : GizmoPlaneDrag3D
	{
		public struct WorkData
		{
			public Vector3 CameraRight;

			public Vector3 CameraUp;

			public Vector3 DragOrigin;

			public float SnapStep;
		}

		private WorkData _workData;

		private Vector3 _planeAxis0;

		private Vector3 _planeAxis1;

		private float _accumSnapDrag;

		private float _scale;

		private float _relativeScale;

		private float _totalScale;

		private Vector3 _scaleDragAxis;

		public override GizmoDragChannel DragChannel => default(GizmoDragChannel);

		public float TotalScale => 0f;

		public float RelativeScale => 0f;

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
