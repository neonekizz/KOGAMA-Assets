using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class ScaleGizmo : GizmoBehaviour
	{
		private GizmoLineSlider3D _pstvXSlider;

		private GizmoLineSlider3D _pstvYSlider;

		private GizmoLineSlider3D _pstvZSlider;

		private GizmoLineSlider3D _negXSlider;

		private GizmoLineSlider3D _negYSlider;

		private GizmoLineSlider3D _negZSlider;

		private GizmoLineSlider3DCollection _axesSliders;

		private GizmoMultiAxisScaleMode _multiAxisScaleMode;

		private GizmoPlaneSlider3D _xySlider;

		private GizmoPlaneSlider3D _yzSlider;

		private GizmoPlaneSlider3D _zxSlider;

		private GizmoPlaneSlider3DCollection _dblSliders;

		private GizmoCap3D _midCap;

		private GizmoUniformScaleDrag3D _unformScaleDrag;

		private GizmoScaleGuide _scaleGuide;

		private IEnumerable<GameObject> _scaleGuideTargetObjects;

		[SerializeField]
		private ScaleGizmoLookAndFeel3D _lookAndFeel3D;

		[SerializeField]
		private ScaleGizmoSettings3D _settings3D;

		[SerializeField]
		private ScaleGizmoHotkeys _hotkeys;

		[SerializeField]
		private bool _useSnapEnableHotkey;

		[SerializeField]
		private bool _useMultiAxisScaleModeHotkey;

		private ScaleGizmoLookAndFeel3D _sharedLookAndFeel3D;

		private ScaleGizmoSettings3D _sharedSettings3D;

		private ScaleGizmoHotkeys _sharedHotkeys;

		public GizmoMultiAxisScaleMode MultiAxisScaleMode => default(GizmoMultiAxisScaleMode);

		public ScaleGizmoLookAndFeel3D LookAndFeel3D => null;

		public ScaleGizmoSettings3D Settings3D => null;

		public ScaleGizmoHotkeys Hotkeys => null;

		public ScaleGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ScaleGizmoSettings3D SharedSettings3D
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ScaleGizmoLookAndFeel3D SharedLookAndFeel3D
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

		public bool UseMultiAxisScaleModeHotkey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float GetZoomFactor(Vector3 position)
		{
			return 0f;
		}

		public float GetZoomFactor(Vector3 position, Camera camera)
		{
			return 0f;
		}

		public bool OwnsHandle(int handleId)
		{
			return false;
		}

		public void SetAxesLinesHoverable(bool hoverable)
		{
		}

		public void SetSnapEnabled(bool isEnabled)
		{
		}

		public void SetMultiAxisScaleMode(GizmoMultiAxisScaleMode scaleMode)
		{
		}

		public void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects)
		{
		}

		public override void OnGizmoEnabled()
		{
		}

		public override void OnAttached()
		{
		}

		public override void OnGizmoUpdateBegin()
		{
		}

		public override void OnGizmoRender(Camera camera)
		{
		}

		public override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		private void PlaceDblSlidersInSliderPlanes(Camera camera)
		{
		}

		private void SetupSharedLookAndFeel()
		{
		}

		private void SetupSharedSettings()
		{
		}
	}
}
