using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class MoveGizmoSettings3D : Settings
	{
		[SerializeField]
		private GizmoObjectVertexSnapSettings _vertexSnapSettings;

		[SerializeField]
		private GizmoLineSlider3DSettings[] _sglSliderSettings;

		[SerializeField]
		private GizmoPlaneSlider3DSettings[] _dblSliderSettings;

		public GizmoObjectVertexSnapSettings VertexSnapSettings => null;

		public float LineSliderHoverEps => 0f;

		public float BoxSliderHoverEps => 0f;

		public float CylinderSliderHoverEps => 0f;

		public float XSnapStep => 0f;

		public float YSnapStep => 0f;

		public float ZSnapStep => 0f;

		public float DragSensitivity => 0f;

		public void SetLineSliderHoverEps(float eps)
		{
		}

		public void SetBoxSliderHoverEps(float eps)
		{
		}

		public void SetCylinderSliderHoverEps(float eps)
		{
		}

		public void SetXSnapStep(float snapStep)
		{
		}

		public void SetYSnapStep(float snapStep)
		{
		}

		public void SetZSnapStep(float snapStep)
		{
		}

		public void SetDragSensitivity(float sensitivity)
		{
		}

		public void ConnectSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		public void ConnectDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
		}

		private GizmoLineSlider3DSettings GetSglSliderSettings(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		private GizmoPlaneSlider3DSettings GetDblSliderSettings(PlaneId planeId)
		{
			return null;
		}
	}
}
