using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class UniversalGizmoSettings3D : Settings
	{
		[SerializeField]
		private UniversalGizmoSettingsCategory _displayCategory;

		[SerializeField]
		private GizmoObjectVertexSnapSettings _mvVertexSnapSettings;

		[SerializeField]
		private GizmoLineSlider3DSettings[] _mvSglSliderSettings;

		[SerializeField]
		private GizmoPlaneSlider3DSettings[] _mvDblSliderSettings;

		[SerializeField]
		private float _rtCamRightSnapStep;

		[SerializeField]
		private float _rtCamUpSnapStep;

		[SerializeField]
		private GizmoPlaneSlider3DSettings[] _rtSliderSettings;

		[SerializeField]
		private GizmoPlaneSlider2DSettings _rtCamLookSliderSettings;

		[SerializeField]
		private float _scUniformSnapStep;

		[SerializeField]
		private GizmoLineSlider3DSettings[] _scSglSliderSettings;

		[SerializeField]
		private GizmoPlaneSlider3DSettings[] _scDblSliderSettings;

		public GizmoObjectVertexSnapSettings VertexSnapSettings => null;

		public float MvLineSliderHoverEps => 0f;

		public float MvBoxSliderHoverEps => 0f;

		public float MvCylinderSliderHoverEps => 0f;

		public float MvXSnapStep => 0f;

		public float MvYSnapStep => 0f;

		public float MvZSnapStep => 0f;

		public float MvDragSensitivity => 0f;

		public float RtAxisLineHoverEps => 0f;

		public float RtAxisTorusHoverEps => 0f;

		public float RtCamLookLineHoverEps => 0f;

		public float RtCamLookThickHoverEps => 0f;

		public bool RtCanHoverCulledPixels => false;

		public GizmoSnapMode RtSnapMode => default(GizmoSnapMode);

		public float RtXSnapStep => 0f;

		public float RtYSnapStep => 0f;

		public float RtZSnapStep => 0f;

		public float RtCamRightSnapStep => 0f;

		public float RtCamUpSnapStep => 0f;

		public float RtCamLookSnapStep => 0f;

		public float RtDragSensitivity => 0f;

		public float ScLineSliderHoverEps => 0f;

		public float ScBoxSliderHoverEps => 0f;

		public float ScCylinderSliderHoverEps => 0f;

		public float ScXSnapStep => 0f;

		public float ScYSnapStep => 0f;

		public float ScZSnapStep => 0f;

		public float ScXYSnapStep => 0f;

		public float ScYZSnapStep => 0f;

		public float ScZXSnapStep => 0f;

		public float ScUniformSnapStep => 0f;

		public float ScDragSensitivity => 0f;

		public UniversalGizmoSettingsCategory DisplayCategory
		{
			get
			{
				return default(UniversalGizmoSettingsCategory);
			}
			set
			{
			}
		}

		public void SetMvLineSliderHoverEps(float eps)
		{
		}

		public void SetMvBoxSliderHoverEps(float eps)
		{
		}

		public void SetMvCylinderSliderHoverEps(float eps)
		{
		}

		public void SetMvXSnapStep(float snapStep)
		{
		}

		public void SetMvYSnapStep(float snapStep)
		{
		}

		public void SetMvZSnapStep(float snapStep)
		{
		}

		public void SetMvDragSensitivity(float sensitivity)
		{
		}

		public void ConnectMvSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		public void ConnectMvDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
		}

		public void Inherit(MoveGizmoSettings3D settings)
		{
		}

		private GizmoLineSlider3DSettings GetMvSglSliderSettings(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		private GizmoPlaneSlider3DSettings GetMvDblSliderSettings(PlaneId planeId)
		{
			return null;
		}

		public void SetRtCanHoverCulledPixels(bool canHover)
		{
		}

		public void SetRtAxisLineHoverEps(float eps)
		{
		}

		public void SetRtAxisTorusHoverEps(float eps)
		{
		}

		public void SetRtCamLookLineHoverEps(float eps)
		{
		}

		public void SetRtCamLookThickHoverEps(float eps)
		{
		}

		public void SetRtAxisSnapStep(int axisIndex, float snapStep)
		{
		}

		public void SetRtCamRightSnapStep(float snapStep)
		{
		}

		public void SetRtCamUpSnapStep(float snapStep)
		{
		}

		public void SetRtCamLookSnapStep(float snapStep)
		{
		}

		public void SetRtSnapMode(GizmoSnapMode snapMode)
		{
		}

		public void SetRtDragSensitivity(float sensitivity)
		{
		}

		public void ConnectRtSliderSettings(GizmoPlaneSlider3D slider, int axisIndex)
		{
		}

		public void ConnectRtCamLookSliderSettings(GizmoPlaneSlider2D slider)
		{
		}

		public void Inherit(RotationGizmoSettings3D settings)
		{
		}

		public void SetScLineSliderHoverEps(float eps)
		{
		}

		public void SetScBoxSliderHoverEps(float eps)
		{
		}

		public void SetScCylinderSliderHoverEps(float eps)
		{
		}

		public void SetScXSnapStep(float snapStep)
		{
		}

		public void SetScYSnapStep(float snapStep)
		{
		}

		public void SetScZSnapStep(float snapStep)
		{
		}

		public void SetScXYSnapStep(float snapStep)
		{
		}

		public void SetScYZSnapStep(float snapStep)
		{
		}

		public void SetScZXSnapStep(float snapStep)
		{
		}

		public void SetScUniformScaleSnapStep(float snapStep)
		{
		}

		public void SetScDragSensitivity(float sensitivity)
		{
		}

		public void ConnectScSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		public void ConnectScDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
		}

		public void Inherit(ScaleGizmoSettings3D settings)
		{
		}

		private GizmoLineSlider3DSettings GetScSglSliderSettings(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		private GizmoPlaneSlider3DSettings GetScDblSliderSettings(PlaneId planeId)
		{
			return null;
		}
	}
}
