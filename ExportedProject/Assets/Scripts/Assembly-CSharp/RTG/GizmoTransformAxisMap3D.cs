using UnityEngine;

namespace RTG
{
	public class GizmoTransformAxisMap3D
	{
		private Vector3 _freeAxis;

		private AxisDescriptor _mappedAxisDesc;

		private GizmoTransform _transform;

		public AxisDescriptor MappedAxisDesc => null;

		public int MappedAxisIndex => 0;

		public AxisSign MappedAxisSign => default(AxisSign);

		public bool IsMapped => false;

		public Vector3 Axis => default(Vector3);

		public GizmoTransform Transform => null;

		public void Map(GizmoTransform transform, int axisIndex, AxisSign axisSign)
		{
		}

		public void Unmap()
		{
		}

		public void SetAxis(Vector3 axis)
		{
		}

		public void SetMappedAxis(Vector3 axis)
		{
		}

		public void SetFreeAxis(Vector3 axis)
		{
		}
	}
}
