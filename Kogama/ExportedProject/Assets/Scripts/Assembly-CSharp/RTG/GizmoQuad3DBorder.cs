using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoQuad3DBorder
	{
		private GizmoPlaneSlider3D _planeSlider;

		private GizmoHandle _targetHandle;

		private QuadShape3D _targetQuad;

		private bool _isVisible;

		private bool _isHoverable;

		private int _borderQuadIndex;

		private QuadShape3D _borderQuad;

		private int _topBoxIndex;

		private BoxShape3D _topBox;

		private int _rightBoxIndex;

		private BoxShape3D _rightBox;

		private int _bottomBoxIndex;

		private BoxShape3D _bottomBox;

		private int _leftBoxIndex;

		private BoxShape3D _leftBox;

		private int _topLeftBoxIndex;

		private BoxShape3D _topLeftBox;

		private int _topRightBoxIndex;

		private BoxShape3D _topRightBox;

		private int _bottomRightBoxIndex;

		private BoxShape3D _bottomRightBox;

		private int _bottomLeftBoxIndex;

		private BoxShape3D _bottomLeftBox;

		private List<int> _sortedBoxIndices;

		private GizmoQuad3DBorderControllerData _controllerData;

		private IGizmoQuad3DBorderController[] _controllers;

		public bool IsVisible => false;

		public bool IsHoverable => false;

		public Gizmo Gizmo => null;

		public GizmoQuad3DBorder(GizmoPlaneSlider3D planeSlider, GizmoHandle targetHandle, QuadShape3D targetQuad)
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

		public float GetRealBoxHeight(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealBoxDepth(float zoomFactor)
		{
			return 0f;
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
