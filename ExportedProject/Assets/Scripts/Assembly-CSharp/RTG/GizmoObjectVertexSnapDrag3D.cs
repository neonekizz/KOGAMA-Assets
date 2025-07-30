using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoObjectVertexSnapDrag3D : GizmoDragSession
	{
		private IEnumerable<GameObject> _targetObjects;

		private Vector3 _snapPivot;

		private bool _isActive;

		private List<GameObject> _destinationObjects;

		private GizmoObjectVertexSnapSettings _settings;

		private List<GameObject> _visibleObjectBuffer;

		public override bool IsActive => false;

		public override GizmoDragChannel DragChannel => default(GizmoDragChannel);

		public Vector3 SnapPivot => default(Vector3);

		public GizmoObjectVertexSnapSettings Settings
		{
			set
			{
			}
		}

		public void SetTargetObjects(IEnumerable<GameObject> targetObjects)
		{
		}

		public bool SelectSnapPivotPoint(Gizmo gizmo)
		{
			return false;
		}

		protected override bool DoBeginSession()
		{
			return false;
		}

		protected override bool DoUpdateSession()
		{
			return false;
		}

		protected override void DoEndSession()
		{
		}

		protected override void CalculateDragValues()
		{
		}

		protected bool GetWorldPointClosestToInputDevice(Camera focusCamera, IEnumerable<GameObject> gameObjects, out Vector3 point)
		{
			point = default(Vector3);
			return false;
		}

		protected bool CanUseObjectAsSnapDestination(GameObject gameObject)
		{
			return false;
		}

		private void GatherDestinationObjects()
		{
		}
	}
}
