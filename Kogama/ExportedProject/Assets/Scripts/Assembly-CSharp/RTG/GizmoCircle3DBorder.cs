using UnityEngine;

namespace RTG
{
	public class GizmoCircle3DBorder
	{
		private GizmoPlaneSlider3D _planeSlider;

		private GizmoHandle _targetHandle;

		private CircleShape3D _targetCircle;

		private bool _isVisible;

		private bool _isHoverable;

		private int _borderCircleIndex;

		private int _borderTorusIndex;

		private int _borderCylTorusIndex;

		private CircleShape3D _borderCircle;

		private TorusShape3D _borderTorus;

		private CylTorusShape3D _borderCylTorus;

		private GizmoCircle3DBorderControllerData _controllerData;

		private IGizmoCircle3DBorderController[] _controllers;

		public bool IsVisible => false;

		public bool IsHoverable => false;

		public Gizmo Gizmo => null;

		public GizmoCircle3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, CircleShape3D targetCircle)
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

		public float GetRealTorusThickness(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealCylTorusWidth(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealCylTorusHeight(float zoomFactor)
		{
			return 0f;
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
