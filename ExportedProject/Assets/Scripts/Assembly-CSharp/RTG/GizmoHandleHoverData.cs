using UnityEngine;

namespace RTG
{
	public class GizmoHandleHoverData
	{
		private int _handleId;

		private Gizmo _gizmo;

		private GizmoDimension _handleDimension;

		private Ray _hoverRay;

		private Vector3 _hoverPoint;

		private float _hoverEnter3D;

		public int HandleId => 0;

		public Gizmo Gizmo => null;

		public GizmoDimension HandleDimension => default(GizmoDimension);

		public Ray HoverRay => default(Ray);

		public Vector3 HoverPoint => default(Vector3);

		public float HoverEnter3D => 0f;

		public GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, float hoverEnter3D)
		{
		}

		public GizmoHandleHoverData(Ray hoverRay, IGizmoHandle gizmoHandle, Vector2 hoverPt2D)
		{
		}
	}
}
