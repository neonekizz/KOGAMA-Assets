using UnityEngine;

namespace RTG
{
	public class GizmoQuadCap2DController : GizmoCap2DController
	{
		public GizmoQuadCap2DController(GizmoCap2DControllerData controllerData)
			: base(null)
		{
		}

		public override void UpdateHandles()
		{
		}

		public override void UpdateTransforms()
		{
		}

		public override void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt)
		{
		}

		public override void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt)
		{
		}

		public override float GetSliderAlignedRealLength()
		{
			return 0f;
		}
	}
}
