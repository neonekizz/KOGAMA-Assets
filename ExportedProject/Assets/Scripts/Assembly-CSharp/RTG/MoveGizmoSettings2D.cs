using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class MoveGizmoSettings2D : Settings
	{
		[SerializeField]
		private GizmoPlaneSlider2DSettings _dblSliderSettings;

		[SerializeField]
		private GizmoLineSlider2DSettings[] _sglSliderSettings;

		public float LineSliderHoverEps => 0f;

		public float BoxSliderHoverEps => 0f;

		public float XSnapStep => 0f;

		public float YSnapStep => 0f;

		public float DragSensitivity => 0f;

		public void SetLineSliderHoverEps(float eps)
		{
		}

		public void SetBoxSliderHoverEps(float eps)
		{
		}

		public void SetXSnapStep(float snapStep)
		{
		}

		public void SetYSnapStep(float snapStep)
		{
		}

		public void SetDragSensitivity(float sensitivity)
		{
		}

		public void ConnectSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign)
		{
		}

		public void ConnectDblSliderSettings(GizmoPlaneSlider2D slider)
		{
		}

		private GizmoLineSlider2DSettings GetSliderSettings(int axisIndex, AxisSign axisSign)
		{
			return null;
		}
	}
}
