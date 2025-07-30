using UnityEngine;

namespace RTG
{
	public class GizmoCap2D : GizmoCap
	{
		private int _quadIndex;

		private QuadShape2D _quad;

		private int _circleIndex;

		private CircleShape2D _circle;

		private int _arrowIndex;

		private ConeShape2D _arrow;

		private GizmoTransform _transform;

		private GizmoOverrideColor _overrideFillColor;

		private GizmoOverrideColor _overrideBorderColor;

		private GizmoCap2DControllerData _controllerData;

		private IGizmoCap2DController[] _controllers;

		private GizmoCap2DLookAndFeel _lookAndFeel;

		private GizmoCap2DLookAndFeel _sharedLookAndFeel;

		public Vector2 Position
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Quaternion Rotation => default(Quaternion);

		public float RotationDegrees
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public GizmoOverrideColor OverrideFillColor => null;

		public GizmoOverrideColor OverrideBorderColor => null;

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

		public GizmoCap2DLookAndFeel LookAndFeel => null;

		public GizmoCap2DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GizmoCap2D(Gizmo gizmo, int handleId)
			: base(null, 0)
		{
		}

		public void RegisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
		}

		public void UnregisterTransformAsDragTarget(IGizmoDragSession dragSession)
		{
		}

		public void AlignTransformAxis(int axisIndex, AxisSign axisSign, Vector2 axis)
		{
		}

		public float GetRealQuadWidth()
		{
			return 0f;
		}

		public float GetRealQuadHeight()
		{
			return 0f;
		}

		public float GetRealCircleRadius()
		{
			return 0f;
		}

		public float GetRealArrowHeight()
		{
			return 0f;
		}

		public float GetRealArrowBaseRadius()
		{
			return 0f;
		}

		public void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt)
		{
		}

		public void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt)
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
	}
}
