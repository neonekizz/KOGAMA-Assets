using UnityEngine;

namespace RTG
{
	public abstract class GizmoSlider : IGizmoSlider
	{
		private GizmoHandle _handle;

		private Gizmo _gizmo;

		private bool _isVisible;

		private bool _isHoverable;

		protected GizmoHandle Handle => null;

		public Gizmo Gizmo => null;

		public int HandleId => 0;

		public bool IsVisible => false;

		public bool IsHoverable => false;

		public bool IsHovered => false;

		public Priority HoverPriority3D => null;

		public Priority HoverPriority2D => null;

		public Priority GenericHoverPriority => null;

		public GizmoSlider(Gizmo gizmo, int handleId)
		{
		}

		public void SetVisible(bool isVisible)
		{
		}

		public void SetHoverable(bool isHoverable)
		{
		}

		public abstract void SetSnapEnabled(bool isEnabled);

		public abstract void Render(Camera camera);

		protected abstract void OnVisibilityStateChanged();

		protected abstract void OnHoverableStateChanged();
	}
}
