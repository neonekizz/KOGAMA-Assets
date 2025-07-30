using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public abstract class GizmoBehaviour : IGizmoBehaviour
	{
		protected Gizmo _gizmo;

		protected bool _isEnabled;

		public Gizmo Gizmo => null;

		public bool IsEnabled => false;

		public void Init_SystemCall(GizmoBehaviorInitParams initParams)
		{
		}

		public void SetEnabled(bool enabled)
		{
		}

		public virtual void OnAttached()
		{
		}

		public virtual void OnDetached()
		{
		}

		public virtual void OnGizmoEnabled()
		{
		}

		public virtual void OnGizmoDisabled()
		{
		}

		public virtual void OnEnabled()
		{
		}

		public virtual void OnDisabled()
		{
		}

		public virtual void OnGizmoHandlePicked(int handleId)
		{
		}

		public virtual bool OnGizmoCanBeginDrag(int handleId)
		{
			return false;
		}

		public virtual void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		public virtual void OnGizmoDragBegin(int handleId)
		{
		}

		public virtual void OnGizmoDragUpdate(int handleId)
		{
		}

		public virtual void OnGizmoDragEnd(int handleId)
		{
		}

		public virtual void OnGizmoHoverEnter(int handleId)
		{
		}

		public virtual void OnGizmoHoverExit(int handleId)
		{
		}

		public virtual void OnGizmoUpdateBegin()
		{
		}

		public virtual void OnGizmoUpdateEnd()
		{
		}

		public virtual void OnGUI()
		{
		}

		public virtual void OnGizmoRender(Camera camera)
		{
		}

		protected void CheckRequiredBehaviours(List<Type> reqBehaviourTypes)
		{
		}

		private void ThrowReqBehaviourExeception(Type reqBehaviorType)
		{
		}
	}
}
