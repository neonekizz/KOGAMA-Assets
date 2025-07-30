using UnityEngine;

namespace RTG
{
	public class GizmoTransformAxisMap2D
	{
		private Vector2 _freeAxis;

		private AxisDescriptor _mappedAxisDesc;

		private GizmoTransform _transform;

		public AxisDescriptor MappedAxisDesc => null;

		public int MappedAxisIndex => 0;

		public AxisSign MappedAxisSign => default(AxisSign);

		public bool IsMapped => false;

		public Vector2 Axis => default(Vector2);

		public GizmoTransform Transform => null;

		public void Map(GizmoTransform transform, int axisIndex, AxisSign axisSign)
		{
		}

		public void Unmap()
		{
		}

		public void SetAxis(Vector2 axis)
		{
		}

		public void SetMappedAxis(Vector2 axis)
		{
		}

		public void SetFreeAxis(Vector2 axis)
		{
		}
	}
}
