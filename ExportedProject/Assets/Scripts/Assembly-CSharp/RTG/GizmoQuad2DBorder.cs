using UnityEngine;

namespace RTG
{
	public class GizmoQuad2DBorder
	{
		private GizmoPlaneSlider2D _planeSlider;

		private GizmoHandle _targetHandle;

		private QuadShape2D _targetQuad;

		private bool _isVisible;

		private bool _isHoverable;

		private int _borderQuadIndex;

		private QuadShape2D _borderQuad;

		private GizmoQuad2DBorderControllerData _controllerData;

		private IGizmoQuad2DBorderController[] _controllers;

		public bool IsVisible => false;

		public bool IsHoverable => false;

		public GizmoQuad2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, QuadShape2D targetQuad)
		{
		}

		public void SetVisible(bool isVisible)
		{
		}

		public void SetHoverable(bool isHoverable)
		{
		}

		public void OnQuadShapeChanged()
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
