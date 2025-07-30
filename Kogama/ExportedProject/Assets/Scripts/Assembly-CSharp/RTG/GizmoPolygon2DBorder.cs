using UnityEngine;

namespace RTG
{
	public class GizmoPolygon2DBorder
	{
		private GizmoPlaneSlider2D _planeSlider;

		private GizmoHandle _targetHandle;

		private PolygonShape2D _targetPolygon;

		private bool _isVisible;

		private bool _isHoverable;

		private int _borderPolygonIndex;

		private int _thickBorderPolygonIndex;

		private PolygonShape2D _borderPolygon;

		private PolygonShape2D _thickBorderPolygon;

		private GizmoPolygon2DBorderControllerData _controllerData;

		private IGizmoPolygon2DBorderController[] _controllers;

		public bool IsVisible => false;

		public bool IsHoverable => false;

		public GizmoPolygon2DBorder(GizmoPlaneSlider2D planeSlider, GizmoHandle targetHandle, PolygonShape2D targetPolygon)
		{
		}

		public void SetVisible(bool isVisible)
		{
		}

		public void SetHoverable(bool isHoverable)
		{
		}

		public void OnPolygonShapeChanged()
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
