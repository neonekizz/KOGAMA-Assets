using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class UniversalGizmoSettings2D : Settings
	{
		[SerializeField]
		private UniversalGizmoSettingsCategory _displayCategory;

		[SerializeField]
		private GizmoPlaneSlider2DSettings _mvDblSliderSettings;

		[SerializeField]
		private GizmoLineSlider2DSettings[] _mvSglSliderSettings;

		public float MvLineSliderHoverEps => 0f;

		public float MvBoxSliderHoverEps => 0f;

		public float MvXSnapStep => 0f;

		public float MvYSnapStep => 0f;

		public float MvDragSensitivity => 0f;

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

		public void SetMvXSnapStep(float snapStep)
		{
		}

		public void SetMvYSnapStep(float snapStep)
		{
		}

		public void SetMvDragSensitivity(float sensitivity)
		{
		}

		public void ConnectMvSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign)
		{
		}

		public void ConnectMvDblSliderSettings(GizmoPlaneSlider2D slider)
		{
		}

		public void Inherit(MoveGizmoSettings2D settings)
		{
		}

		private GizmoLineSlider2DSettings GetMvSliderSettings(int axisIndex, AxisSign axisSign)
		{
			return null;
		}
	}
}
