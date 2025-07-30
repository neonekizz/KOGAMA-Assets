using UnityEngine;

namespace RTG
{
	public class GizmoCircle2DBorder
	{
		private GizmoPlaneSlider2D _planeSlider;

		private GizmoHandle _targetHandle;

		private CircleShape2D _targetCircle;

		private bool _isVisible;

		private bool _isHoverable;

		private int _borderCircleIndex;

		private CircleShape2D _borderCircle;

		private GizmoCircle2DBorderControllerData _controllerData;

		private IGizmoCircle2DBorderController[] _controllers;

		public bool IsVisible => false;

		public bool IsHoverable => false;

		public GizmoCircle2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, CircleShape2D targetCircle)
		{
		}

		public void SetVisible(bool isVisible)
		{
		}

		public void SetHoverable(bool isHoverable)
		{
		}

		public void OnCircleShapeChanged()
		{
		}

		public void Render(Camera camera)
		{
		}

		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}
	}
}
