using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoLineSlider3D : GizmoSlider
	{
		private SegmentShape3D _segment;

		private BoxShape3D _box;

		private CylinderShape3D _cylinder;

		private int _segmentIndex;

		private int _boxIndex;

		private int _cylinderIndex;

		private IGizmoLineSlider3DController[] _controllers;

		private GizmoLineSlider3DControllerData _controllerData;

		private GizmoDragChannel _dragChannel;

		private GizmoSglAxisOffsetDrag3D _offsetDrag;

		private GizmoSglAxisRotationDrag3D _rotationDrag;

		private GizmoRotationArc3D _rotationArc;

		private GizmoSglAxisScaleDrag3D _scaleDrag;

		private int _scaleDragAxisIndex;

		private List<GizmoScalerHandle> _scalerHandles;

		private IGizmoDragSession _selectedDragSession;

		private GizmoCap3D _cap3D;

		private GizmoTransform _transform;

		private GizmoTransformAxisMap3D _directionAxisMap;

		private GizmoTransformAxisMap3D _dragRotationAxisMap;

		private GizmoOverrideColor _overrideColor;

		private GizmoLineSlider3DSettings _settings;

		private GizmoLineSlider3DSettings _sharedSettings;

		private GizmoLineSlider3DLookAndFeel _lookAndFeel;

		private GizmoLineSlider3DLookAndFeel _sharedLookAndFeel;

		public Vector3 Direction => default(Vector3);

		public Vector3 DragRotationAxis => default(Vector3);

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

		public Vector3 StartPosition
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

		public bool IsDragged => false;

		public bool IsMoving => false;

		public bool IsRotating => false;

		public bool IsScaling => false;

		public bool Is3DCapVisible => false;

		public bool Is3DCapHoverable => false;

		public int Cap3DHandleId => 0;

		public Vector3 TotalDragOffset => default(Vector3);

		public Vector3 RelativeDragOffset => default(Vector3);

		public float TotalDragRotation => 0f;

		public float RelativeDragRotation => 0f;

		public float TotalDragScale => 0f;

		public float RelativeDragScale => 0f;

		public GizmoOverrideColor OverrideColor => null;

		public GizmoOverrideColor Cap3DOverrideColor => null;

		public GizmoLineSlider3DSettings Settings => null;

		public GizmoLineSlider3DSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GizmoLineSlider3DLookAndFeel LookAndFeel => null;

		public GizmoLineSlider3DLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GizmoLineSlider3D(Gizmo gizmo, int handleId, int capHandleId)
			: base(null, 0)
		{
		}

		public bool IsScalerHandleRegistered(int handleId)
		{
			return false;
		}

		public bool IsScalerHandleRegistered(int handleId, int scaleDragAxisIndex)
		{
			return false;
		}

		public void RegisterScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices)
		{
		}

		public void UnregisterScalerHandle(int handleId)
		{
		}

		public override void SetSnapEnabled(bool isEnabled)
		{
		}

		public void Set3DCapVisible(bool isVisible)
		{
		}

		public void Set3DCapHoverable(bool isHoverable)
		{
		}

		public void SetZoomFactorTransform(GizmoTransform transform)
		{
		}

		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		public Vector3 GetRealDirection()
		{
			return default(Vector3);
		}

		public float GetRealSizeAlongDirection(Camera camera, Vector3 direction)
		{
			return 0f;
		}

		public float GetRealLength(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealLengthWith3DCap(float zoomFactor)
		{
			return 0f;
		}

		public Vector3 GetRealEndPosition(float zoomFactor)
		{
			return default(Vector3);
		}

		public Vector3 GetRealEndPositionWith3DCap(float zoomFactor)
		{
			return default(Vector3);
		}

		public float GetRealBoxHeight(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealBoxDepth(float zoomFactor)
		{
			return 0f;
		}

		public float GetRealCylinderRadius(float zoomFactor)
		{
			return 0f;
		}

		public void MapDirection(int axisIndex, AxisSign axisSign)
		{
		}

		public void MapDragRotationAxis(GizmoTransform mapTransform, int axisIndex, AxisSign axisSign)
		{
		}

		public void UnmapDragRotationAxis()
		{
		}

		public void SetDirection(Vector3 directionAxis)
		{
		}

		public void SetDragRotationAxis(Vector3 rotationAxis)
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

		private void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId)
		{
		}

		private void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		private void OnGizmoHandleHoverEnter(Gizmo gizmo, int handleId)
		{
		}

		private void OnGizmoPostEnabled(Gizmo gizmo)
		{
		}

		private void OnGizmoPostDisabled(Gizmo gizmo)
		{
		}

		private void OnGizmoHandleHoverExit(Gizmo gizmo, int handleId)
		{
		}

		private void SetupSharedLookAndFeel()
		{
		}
	}
}
