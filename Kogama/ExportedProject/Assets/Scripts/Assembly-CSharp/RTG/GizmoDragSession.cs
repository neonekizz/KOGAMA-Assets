using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public abstract class GizmoDragSession : IGizmoDragSession
	{
		private List<GizmoTransform> _targetTransforms;

		protected Vector3 _totalDragOffset;

		protected Quaternion _totalDragRotation;

		protected Vector3 _totalDragScale;

		protected Vector3 _relativeDragOffset;

		protected Quaternion _relativeDragRotation;

		protected Vector3 _relativeDragScale;

		public int NumTargetTransforms => 0;

		public Vector3 TotalDragOffset => default(Vector3);

		public Quaternion TotalDragRotation => default(Quaternion);

		public Vector3 TotalDragScale => default(Vector3);

		public Vector3 RelativeDragOffset => default(Vector3);

		public Quaternion RelativeDragRotation => default(Quaternion);

		public Vector3 RelativeDragScale => default(Vector3);

		public abstract bool IsActive { get; }

		public abstract GizmoDragChannel DragChannel { get; }

		public bool ContainsTargetTransform(GizmoTransform transform)
		{
			return false;
		}

		public void AddTargetTransform(GizmoTransform transform)
		{
		}

		public void RemoveTargetTransform(GizmoTransform transform)
		{
		}

		public bool Begin()
		{
			return false;
		}

		public bool Update()
		{
			return false;
		}

		public void End()
		{
		}

		protected abstract bool DoBeginSession();

		protected abstract bool DoUpdateSession();

		protected abstract void DoEndSession();

		protected abstract void CalculateDragValues();

		protected void ApplyDrag()
		{
		}

		protected virtual bool CanBegin()
		{
			return false;
		}

		protected virtual void OnSessionBegin()
		{
		}

		protected virtual void OnSessionEnd()
		{
		}
	}
}
