using UnityEngine;

namespace RTG
{
	public class GizmoCap3D : GizmoCap
	{
		private int _coneIndex;

		private ConeShape3D _cone;

		private int _pyramidIndex;

		private PyramidShape3D _pyramid;

		private int _boxIndex;

		private BoxShape3D _box;

		private int _sphereIndex;

		private SphereShape3D _sphere;

		private int _trPrismIndex;

		private TriangPrismShape3D _trPrism;

		private GizmoCap3DControllerData _controllerData;

		private IGizmoCap3DController[] _controllers;

		private GizmoTransform _transform;

		private GizmoOverrideColor _overrideColor;

		private GizmoCap3DLookAndFeel _lookAndFeel;

		private GizmoCap3DLookAndFeel _sharedLookAndFeel;

		public Vector3 Position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion Rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public GizmoOverrideColor OverrideColor => null;

		public IGizmoDragSession DragSession
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GizmoCap3DLookAndFeel LookAndFeel => null;

		public GizmoCap3DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GizmoCap3D(Gizmo gizmo, int handleId)
			: base(null, 0)
		{
		}

		public void RegisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
		}

		public void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
		}

		public void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector3 axis)
		{
		}

		public void SetZoomFactorTransform(GizmoTransform transform)
		{
		}

		public void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt)
		{
		}

		public void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt)
		{
		}

		public float GetSliderAlignedRealLength(float zoomFactor)
		{
			return 0f;
		}

		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		public float GetRealConeHeight(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealConeRadius(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealPyramidWidth(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealPyramidDepth(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealPyramidHeight(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealBoxWidth(float zoomFactor)
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

		public Vector3 GetRealBoxSize(float zoomFactor)
		{
			return default(Vector3);
		}

		public float GetRealSphereRadius(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealTriPrismWidth(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealTriPrismHeight(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealTriPrismDepth(float zoomFactor)
		{
			return 0f;
		}

		public void ApplyZoomFactor(Camera camera)
		{
		}

		public override void Render(Camera camera)
		{
		}

		public void Refresh()
		{
		}

		protected override void OnVisibilityStateChanged()
		{
		}

		protected override void OnHoverableStateChanged()
		{
		}

		private void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
		}

		private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}

		private void OnGizmoPostDisabled(Gizmo gizmo)
		{
		}
	}
}
