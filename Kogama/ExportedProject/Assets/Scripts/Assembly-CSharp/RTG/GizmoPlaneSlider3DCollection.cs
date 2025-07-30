using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoPlaneSlider3DCollection
	{
		private List<GizmoPlaneSlider3D> _sliders;

		private Dictionary<int, GizmoPlaneSlider3D> _handleIdToSlider;

		public int Count => 0;

		public GizmoPlaneSlider3D this[int id] => null;

		public bool Contains(GizmoPlaneSlider3D slider)
		{
			return false;
		}

		public bool Contains(int sliderHandleId)
		{
			return false;
		}

		public void Add(GizmoPlaneSlider3D slider)
		{
		}

		public void Remove(GizmoPlaneSlider3D slider)
		{
		}

		public void ApplyZoomFactor(Camera camera)
		{
		}

		public void SetZoomFactorTransform(GizmoTransform zoomFactorTransform)
		{
		}

		public void Make3DHoverPriorityLowerThan(Priority priority)
		{
		}

		public void Make3DHoverPriorityHigherThan(Priority priority)
		{
		}

		public void SetSnapEnabled(bool isEnabled)
		{
		}

		public void SetVisible(bool isVisible, bool includeBorder)
		{
		}

		public void SetBorderVisible(bool isVisible)
		{
		}

		public void SetHoverable(bool isHoverable, bool includeBorder)
		{
		}

		public void SetBorderHoverable(bool isHoverable)
		{
		}

		public List<GizmoPlaneSlider3D> GetRenderSortedSliders(Camera renderCamera)
		{
			return null;
		}
	}
}
