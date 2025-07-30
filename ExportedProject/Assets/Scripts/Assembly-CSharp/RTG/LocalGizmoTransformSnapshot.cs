using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class LocalGizmoTransformSnapshot
	{
		private GizmoTransform _transform;

		private GizmoTransform _parentTransform;

		private Vector3 _localPosition3D;

		private Quaternion _localRotation3D;

		private Vector2 _localPosition2D;

		private float _localRotation2D_Degrees;

		public GizmoTransform Transform => null;

		public static List<LocalGizmoTransformSnapshot> GetSnapshotCollection(IEnumerable<Gizmo> gizmos)
		{
			return null;
		}

		public void Snapshot(GizmoTransform transform)
		{
		}

		public void Apply()
		{
		}
	}
}
