using UnityEngine;

namespace RTG
{
	public class GizmoPyramidCap3DController : GizmoCap3DController
	{
		public GizmoPyramidCap3DController(GizmoCap3DControllerData controllerData)
			: base(null)
		{
		}

		public override void UpdateHandles()
		{
		}

		public override void UpdateTransforms(float zoomFactor)
		{
		}

		public override void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor)
		{
		}

		public override void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor)
		{
		}

		public override float GetSliderAlignedRealLength(float zoomFactor)
		{
			return 0f;
		}
	}
}
