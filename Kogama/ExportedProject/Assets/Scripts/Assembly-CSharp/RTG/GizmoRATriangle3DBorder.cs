using UnityEngine;

namespace RTG
{
	public class GizmoRATriangle3DBorder
	{
		private GizmoPlaneSlider3D _planeSlider;

		private GizmoHandle _targetHandle;

		private RightAngTriangle3D _targetTriangle;

		private bool _isVisible;

		private bool _isHoverable;

		private int _borderTriangleIndex;

		private RightAngTriangle3D _borderTriangle;

		private GizmoRATriangle3DBorderControllerData _controllerData;

		private IGizmoRATriangle3DBorderController[] _controllers;

		public bool IsVisible => false;

		public bool IsHoverable => false;

		public Gizmo Gizmo => null;

		public GizmoRATriangle3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, RightAngTriangle3D targetRiangle)
		{
		}

		public void SetVisible(bool isVisible)
		{
		}

		public void SetHoverable(bool isHoverable)
		{
		}

		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		public void OnTriangleShapeChanged()
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
