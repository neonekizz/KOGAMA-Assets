using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class UniversalGizmo : GizmoBehaviour
	{
		public enum MvVertexSnapState
		{
			SelectingPivot = 0,
			Snapping = 1,
			Inactive = 2
		}

		private GizmoLineSlider3D _mvPXSlider;

		private GizmoLineSlider3D _mvPYSlider;

		private GizmoLineSlider3D _mvPZSlider;

		private GizmoLineSlider3D _mvNXSlider;

		private GizmoLineSlider3D _mvNYSlider;

		private GizmoLineSlider3D _mvNZSlider;

		private GizmoLineSlider3DCollection _mvAxesSliders;

		private GizmoPlaneSlider3D _mvXYSlider;

		private GizmoPlaneSlider3D _mvYZSlider;

		private GizmoPlaneSlider3D _mvZXSlider;

		private GizmoPlaneSlider3DCollection _mvDblSliders;

		private bool _isMvVertexSnapEnabled;

		private GizmoCap2D _mvVertSnapCap;

		private GizmoObjectVertexSnapDrag3D _mvVertexSnapDrag;

		private Vector3 _mvPostVSnapPosRestore;

		private GizmoLineSlider2D _mvP2DModeXSlider;

		private GizmoLineSlider2D _mvP2DModeYSlider;

		private GizmoLineSlider2D _mvN2DModeXSlider;

		private GizmoLineSlider2D _mvN2DModeYSlider;

		private GizmoLineSlider2DCollection _mv2DModeSliders;

		private GizmoPlaneSlider2D _mv2DModeDblSlider;

		private GizmoPlaneSlider3D _rtXSlider;

		private GizmoPlaneSlider3D _rtYSlider;

		private GizmoPlaneSlider3D _rtZSlider;

		private GizmoPlaneSlider3DCollection _rtAxesSliders;

		private GizmoCap3D _rtMidCap;

		private GizmoDblAxisRotationDrag3D _rtCamXYRotationDrag;

		private GizmoPlaneSlider2D _rtCamLookSlider;

		private GizmoCap3D _scMidCap;

		private GizmoUniformScaleDrag3D _scUnformScaleDrag;

		private GizmoScaleGuide _scScaleGuide;

		private IEnumerable<GameObject> _scScaleGuideTargetObjects;

		private bool _is2DModeEnabled;

		[SerializeField]
		private UniversalGizmoSettings2D _settings2D;

		private UniversalGizmoSettings2D _sharedSettings2D;

		[SerializeField]
		private UniversalGizmoSettings3D _settings3D;

		private UniversalGizmoSettings3D _sharedSettings3D;

		[SerializeField]
		private UniversalGizmoLookAndFeel2D _lookAndFeel2D;

		private UniversalGizmoLookAndFeel2D _sharedLookAndFeel2D;

		[SerializeField]
		private UniversalGizmoLookAndFeel3D _lookAndFeel3D;

		private UniversalGizmoLookAndFeel3D _sharedLookAndFeel3D;

		[SerializeField]
		private UniversalGizmoHotkeys _hotkeys;

		private UniversalGizmoHotkeys _sharedHotkeys;

		[SerializeField]
		private bool _useSnapEnableHotkey;

		[SerializeField]
		private bool _useVertSnapEnableHotkey;

		[SerializeField]
		private bool _use2DModeEnableHotkey;

		public UniversalGizmoSettings2D Settings2D => null;

		public UniversalGizmoSettings2D SharedSettings2D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UniversalGizmoSettings3D Settings3D => null;

		public UniversalGizmoSettings3D SharedSettings3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UniversalGizmoLookAndFeel2D LookAndFeel2D => null;

		public UniversalGizmoLookAndFeel2D SharedLookAndFeel2D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UniversalGizmoLookAndFeel3D LookAndFeel3D => null;

		public UniversalGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UniversalGizmoHotkeys Hotkeys => null;

		public UniversalGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseSnapEnableHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseVertSnapEnableHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Use2DModeEnableHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MvVertexSnapState GetMvVertexSnapState()
		{
			return default(MvVertexSnapState);
		}

		public float GetMvZoomFactor(Vector3 position)
		{
			return 0f;
		}

		public float GetMvZoomFactor(Vector3 position, Camera camera)
		{
			return 0f;
		}

		public float GetRtZoomFactor(Vector3 position)
		{
			return 0f;
		}

		public float GetRtZoomFactor(Vector3 position, Camera camera)
		{
			return 0f;
		}

		public float GetScZoomFactor(Vector3 position)
		{
			return 0f;
		}

		public float GetScZoomFactor(Vector3 position, Camera camera)
		{
			return 0f;
		}

		public bool IsDraggingMoveHandle()
		{
			return false;
		}

		public bool IsDraggingRotationHandle()
		{
			return false;
		}

		public bool IsDraggingScaleHandle()
		{
			return false;
		}

		public bool IsMoveHandle(int handleId)
		{
			return false;
		}

		public bool IsRotationHandle(int handleId)
		{
			return false;
		}

		public bool IsScaleHandle(int handleId)
		{
			return false;
		}

		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		public void SetSnapEnabled(bool isEnabled)
		{
		}

		public void SetMvVertexSnapEnabled(bool isEnabled)
		{
		}

		public void Set2DModeEnabled(bool isEnabled)
		{
		}

		public void SetMvVertexSnapTargetObjects(IEnumerable<GameObject> targetObjects)
		{
		}

		public void SetMvAxesLinesHoverable(bool hoverable)
		{
		}

		public void SetRtMidCapHoverable(bool hoverable)
		{
		}

		public void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects)
		{
		}

		public override void OnAttached()
		{
		}

		public override void OnDetached()
		{
		}

		public override void OnEnabled()
		{
		}

		public override void OnDisabled()
		{
		}

		public override void OnGizmoEnabled()
		{
		}

		public override void OnGizmoUpdateBegin()
		{
		}

		public override void OnGizmoRender(Camera camera)
		{
		}

		public override void OnGizmoDragUpdate(int handleId)
		{
		}

		public override void OnGizmoDragBegin(int handleId)
		{
		}

		public override void OnGizmoDragEnd(int handleId)
		{
		}

		public override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		private void PlaceMvDblSlidersInSliderPlanes(Camera camera)
		{
		}

		private void SetupSharedLookAndFeel()
		{
		}

		private void SetupSharedSettings()
		{
		}

		private void Update2DGizmoPosition()
		{
		}

		private void Update2DModeHandlePositions()
		{
		}

		private void OnGizmoTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
		}

		private void Hide2DModeHandles()
		{
		}

		private void UpdateRtCamLookSlider(Camera camera)
		{
		}

		private void SetMoveHandlesVisible(bool visible)
		{
		}

		private void SetRotationHandlesVisible(bool visible)
		{
		}

		private void SetScaleHandlesVisible(bool visible)
		{
		}
	}
}
