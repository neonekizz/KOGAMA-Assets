using UnityEngine;

namespace RTG
{
	public class GizmoLineSlider2D : GizmoSlider
	{
		private SegmentShape2D _segment;

		private QuadShape2D _quad;

		private int _segmentIndex;

		private int _quadIndex;

		private GizmoDragChannel _dragChannel;

		private GizmoSglAxisOffsetDrag3D _offsetDrag;

		private Vector3 _offsetDragOrigin;

		private GizmoSglAxisRotationDrag3D _rotationDrag;

		private GizmoRotationArc2D _rotationArc;

		private GizmoSglAxisScaleDrag3D _scaleDrag;

		private Vector3 _scaleDragOrigin;

		private Vector3 _scaleAxis;

		private int _scaleDragAxisIndex;

		private IGizmoDragSession _selectedDragSession;

		private GizmoCap2D _cap2D;

		private GizmoTransform _transform;

		private GizmoTransformAxisMap2D _directionAxisMap;

		private GizmoOverrideColor _overrideFillColor;

		private GizmoOverrideColor _overrideBorderColor;

		private GizmoLineSlider2DControllerData _controllerData;

		private IGizmoLineSlider2DController[] _controllers;

		private GizmoLineSlider2DSettings _settings;

		private GizmoLineSlider2DSettings _sharedSettings;

		private GizmoLineSlider2DLookAndFeel _lookAndFeel;

		private GizmoLineSlider2DLookAndFeel _sharedLookAndFeel;

		public Quaternion Rotation => default(Quaternion);

		public float RotationDegrees => 0f;

		public Vector2 StartPosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 Direction => default(Vector2);

		public Vector3 OffsetDragOrigin
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 ScaleDragOrigin
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public int ScaleDragAxisIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Cap2DHandleId => 0;

		public bool IsDragged => false;

		public bool IsMoving => false;

		public bool IsRotating => false;

		public bool IsScaling => false;

		public bool Is2DCapVisible => false;

		public bool Is2DCapHoverable => false;

		public Vector3 TotalDragOffset => default(Vector3);

		public Vector3 RelativeDragOffset => default(Vector3);

		public float TotalDragRotation => 0f;

		public float RelativeDragRotation => 0f;

		public float TotalDragScale => 0f;

		public float RelativeDragScale => 0f;

		public GizmoOverrideColor OverrideFillColor => null;

		public GizmoOverrideColor OverrideBorderColor => null;

		public GizmoLineSlider2DSettings Settings => null;

		public GizmoLineSlider2DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GizmoLineSlider2DLookAndFeel LookAndFeel => null;

		public GizmoLineSlider2DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GizmoLineSlider2D(Gizmo gizmo, int handleId, int capHandleId)
			: base(null, 0)
		{
		}

		public override void SetSnapEnabled(bool isEnabled)
		{
		}

		public void Set2DCapVisible(bool isVisible)
		{
		}

		public void Set2DCapHoverable(bool isHoverable)
		{
		}

		public Vector2 GetRealDirection()
		{
			return default(Vector2);
		}

		public float GetRealLength()
		{
			return 0f;
		}

		public Vector2 GetRealEndPosition()
		{
			return default(Vector2);
		}

		public float GetRealBoxThickness()
		{
			return 0f;
		}

		public void MapDirection(int axisIndex, AxisSign axisSign)
		{
		}

		public void SetDirection(Vector2 directionAxis)
		{
		}

		public void AddTargetTransform(GizmoTransform transform)
		{
		}

		public void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
		}

		public void RemoveTargetTransform(GizmoTransform transform)
		{
		}

		public void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
		}

		public void SetDragChannel(GizmoDragChannel dragChannel)
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

		private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId)
		{
		}

		private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		private void OnGizmoHandleHoverEnter(Gizmo gizmo, int handleId)
		{
		}

		private void OnGizmoHandleHoverExit(Gizmo gizmo, int handleId)
		{
		}

		private void OnGizmoHandleDragUpdate(Gizmo gizmo, int handleId)
		{
		}

		private void SetupSharedLookAndFeel()
		{
		}

		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}
	}
}
