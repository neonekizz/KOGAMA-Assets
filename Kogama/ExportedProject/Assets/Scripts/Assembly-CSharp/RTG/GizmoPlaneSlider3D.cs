using UnityEngine;

namespace RTG
{
	public class GizmoPlaneSlider3D : GizmoSlider
	{
		private int _quadIndex;

		private int _raTriangleIndex;

		private int _circleIndex;

		private QuadShape3D _quad;

		private RightAngTriangle3D _raTriangle;

		private CircleShape3D _circle;

		private GizmoQuad3DBorder _quadBorder;

		private GizmoRATriangle3DBorder _raTriangleBorder;

		private GizmoCircle3DBorder _circleBorder;

		private bool _isBorderHoverable;

		private bool _isBorderVisible;

		private GizmoTransform _transform;

		private GizmoDragChannel _dragChannel;

		private IGizmoDragSession _selectedDragSession;

		private GizmoDblAxisOffsetDrag3D _dblAxisOffsetDrag;

		private GizmoSglAxisRotationDrag3D _rotationDrag;

		private GizmoRotationArc3D _rotationArc;

		private GizmoDblAxisScaleDrag3D _scaleDrag;

		private int _scaleDragAxisIndexRight;

		private int _scaleDragAxisIndexUp;

		private GizmoPlaneSlider3DControllerData _controllerData;

		private IGizmoPlaneSlider3DController[] _controllers;

		private GizmoPlaneSlider3DSettings _settings;

		private GizmoPlaneSlider3DSettings _sharedSettings;

		private GizmoPlaneSlider3DLookAndFeel _lookAndFeel;

		private GizmoPlaneSlider3DLookAndFeel _sharedLookAndFeel;

		public GizmoPlaneSlider3DSettings Settings => null;

		public GizmoPlaneSlider3DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GizmoPlaneSlider3DLookAndFeel LookAndFeel => null;

		public GizmoPlaneSlider3DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Plane Plane => default(Plane);

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

		public Quaternion LocalRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 Right => default(Vector3);

		public Vector3 Up => default(Vector3);

		public Vector3 Look => default(Vector3);

		public Vector3 Normal => default(Vector3);

		public GizmoDragChannel DragChannel => default(GizmoDragChannel);

		public int ScaleDragAxisIndexRight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ScaleDragAxisIndexUp
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Vector3 TotalDragOffset => default(Vector3);

		public Vector3 RelativeDragOffset => default(Vector3);

		public float TotalDragRotation => 0f;

		public float RelativeDragRotation => 0f;

		public float TotalDragScaleRight => 0f;

		public float RelativeDragScaleRight => 0f;

		public float TotalDragScaleUp => 0f;

		public float RelativeDragScaleUp => 0f;

		public bool IsBorderVisible => false;

		public bool IsBorderHoverable => false;

		public bool IsDragged => false;

		public bool IsMoving => false;

		public bool IsRotating => false;

		public bool IsScaling => false;

		public GizmoPlaneSlider3D(Gizmo gizmo, int handleId)
			: base(null, 0)
		{
		}

		public void SetBorderVisible(bool isVisible)
		{
		}

		public void SetBorderHoverable(bool isHoverable)
		{
		}

		public override void SetSnapEnabled(bool isEnabled)
		{
		}

		public void SetZoomFactorTransform(GizmoTransform transform)
		{
		}

		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		public float GetRealQuadWidth(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealQuadHeight(float zoomFactor)
		{
			return 0f;
		}

		public Vector2 GetRealQuadSize(float zoomFactor)
		{
			return default(Vector2);
		}

		public float GetRealCircleRadius(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealRATriXLength(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealRATriYLength(float zoomFactor)
		{
			return 0f;
		}

		public Vector2 GetRealRATriSize(float zoomFactor)
		{
			return default(Vector2);
		}

		public void AlignToQuadrant(GizmoTransform transform, PlaneId planeId, PlaneQuadrantId quadrantId, bool alignXToFirstAxis)
		{
		}

		public void MakeSliderPlane(GizmoTransform sliderPlaneTransform, PlaneId planeId, GizmoLineSlider3D firstAxisSlider, GizmoLineSlider3D secondAxisSlider, Camera camera)
		{
		}

		public Vector3 GetQuadCornerPosition(QuadCorner corner)
		{
			return default(Vector3);
		}

		public void SetQuadCornerPosition(QuadCorner corner, Vector3 cornerPosition)
		{
		}

		public void ApplyZoomFactor(Camera camera)
		{
		}

		public void SetDragChannel(GizmoDragChannel dragChannel)
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

		private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId)
		{
		}

		private void OnCanHoverHandle(int handleId, Gizmo gizmo, GizmoHandleHoverData hoverData, YesNoAnswer answer)
		{
		}

		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}
	}
}
