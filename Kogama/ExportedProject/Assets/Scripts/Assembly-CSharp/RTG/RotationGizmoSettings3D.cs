using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class RotationGizmoSettings3D : Settings
	{
		[SerializeField]
		private float _camRightSnapStep;

		[SerializeField]
		private float _camUpSnapStep;

		[SerializeField]
		private GizmoPlaneSlider3DSettings[] _sliderSettings;

		[SerializeField]
		private GizmoPlaneSlider2DSettings _camLookSliderSettings;

		public float AxisLineHoverEps => 0f;

		public float AxisTorusHoverEps => 0f;

		public float CamLookLineHoverEps => 0f;

		public float CamLookThickHoverEps => 0f;

		public bool CanHoverCulledPixels => false;

		public GizmoSnapMode SnapMode => default(GizmoSnapMode);

		public float XSnapStep => 0f;

		public float YSnapStep => 0f;

		public float ZSnapStep => 0f;

		public float CamRightSnapStep => 0f;

		public float CamUpSnapStep => 0f;

		public float CamLookSnapStep => 0f;

		public float DragSensitivity => 0f;

		public void SetCanHoverCulledPixels(bool canHover)
		{
		}

		public void SetAxisLineHoverEps(float eps)
		{
		}

		public void SetAxisTorusHoverEps(float eps)
		{
		}

		public void SetCamLookLineHoverEps(float eps)
		{
		}

		public void SetCamLookThickHoverEps(float eps)
		{
		}

		public void SetAxisSnapStep(int axisIndex, float snapStep)
		{
		}

		public void SetCamRightSnapStep(float snapStep)
		{
		}

		public void SetCamUpSnapStep(float snapStep)
		{
		}

		public void SetCamLookSnapStep(float snapStep)
		{
		}

		public void SetSnapMode(GizmoSnapMode snapMode)
		{
		}

		public void SetDragSensitivity(float sensitivity)
		{
		}

		public void ConnectSliderSettings(GizmoPlaneSlider3D slider, int axisIndex)
		{
		}

		public void ConnectCamLookSliderSettings(GizmoPlaneSlider2D slider)
		{
		}
	}
}
