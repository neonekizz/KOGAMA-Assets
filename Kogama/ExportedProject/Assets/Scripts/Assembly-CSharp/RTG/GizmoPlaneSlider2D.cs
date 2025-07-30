using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoPlaneSlider2D : GizmoSlider
	{
		private int _quadIndex;

		private int _circleIndex;

		private int _polygonIndex;

		private QuadShape2D _quad;

		private CircleShape2D _circle;

		private PolygonShape2D _polygon;

		private GizmoQuad2DBorder _quadBorder;

		private GizmoCircle2DBorder _circleBorder;

		private GizmoPolygon2DBorder _polygonBorder;

		private bool _isBorderVisible;

		private bool _isBorderHoverable;

		private GizmoTransform _transform;

		private GizmoDragChannel _dragChannel;

		private IGizmoDragSession _selectedDragSession;

		private GizmoDblAxisOffsetDrag3D _offsetDrag;

		private Vector3 _offsetDragOrigin;

		private GizmoSglAxisRotationDrag3D _rotationDrag;

		private GizmoRotationArc2D _rotationArc;

		private GizmoDblAxisScaleDrag3D _scaleDrag;

		private Vector3 _scaleDragOrigin;

		private Vector3 _scaleAxisRight;

		private Vector3 _scaleAxisUp;

		private int _scaleDragAxisIndexRight;

		private int _scaleDragAxisIndexUp;

		private GizmoPlaneSlider2DControllerData _controllerData;

		private IGizmoPlaneSlider2DController[] _controllers;

		private GizmoPlaneSlider2DSettings _settings;

		private GizmoPlaneSlider2DSettings _sharedSettings;

		private GizmoPlaneSlider2DLookAndFeel _lookAndFeel;

		private GizmoPlaneSlider2DLookAndFeel _sharedLookAndFeel;

		public GizmoPlaneSlider2DSettings Settings => null;

		public GizmoPlaneSlider2DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GizmoPlaneSlider2DLookAndFeel LookAndFeel => null;

		public GizmoPlaneSlider2DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public Vector2 PolyCenter => default(Vector2);

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

		public Vector2 Right => default(Vector2);

		public Vector2 Up => default(Vector2);

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

		public GizmoDragChannel DragChannel => default(GizmoDragChannel);

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

		public GizmoPlaneSlider2D(Gizmo gizmo, int handleId)
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

		public void SetPolyCwPoints(List<Vector2> cwPoints, bool isClosed)
		{
		}

		public void MakePolySphereBorder(Vector3 sphereCenter, float sphereRadius, int numPoints, Camera camera)
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

		public Vector2 GetRealQuadSize()
		{
			return default(Vector2);
		}

		public float GetRealCircleRadius()
		{
			return 0f;
		}

		public Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt)
		{
			return default(Vector2);
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

		private void OnGizmoHandleDragUpdate(Gizmo gizmo, int handleId)
		{
		}

		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}
	}
}
