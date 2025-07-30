using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoLineSlider3DCollection
	{
		private List<GizmoLineSlider3D> _sliders;

		private Dictionary<int, GizmoLineSlider3D> _handleIdToSlider;

		public int Count => 0;

		public GizmoLineSlider3D this[int id] => null;

		public bool Contains(GizmoLineSlider3D slider)
		{
			return false;
		}

		public bool Contains(int sliderHandleId)
		{
			return false;
		}

		public bool ContainsCapId(int capHandleId)
		{
			return false;
		}

		public void Add(GizmoLineSlider3D slider)
		{
		}

		public void Remove(GizmoLineSlider3D slider)
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

		public void SetVisible(bool visible)
		{
		}

		public void Set3DCapsVisible(bool visible)
		{
		}

		public void SetDragChannel(GizmoDragChannel dragChannel)
		{
		}

		public void RegisterScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices)
		{
		}

		public List<GizmoLineSlider3D> GetRenderSortedSliders(Camera renderCamera)
		{
			return null;
		}
	}
}
