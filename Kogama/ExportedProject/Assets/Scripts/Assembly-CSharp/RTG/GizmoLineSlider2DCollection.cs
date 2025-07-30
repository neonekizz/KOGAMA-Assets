using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoLineSlider2DCollection
	{
		private List<GizmoLineSlider2D> _sliders;

		private Dictionary<int, GizmoLineSlider2D> _handleIdToSlider;

		public int Count => 0;

		public GizmoLineSlider2D this[int id] => null;

		public bool Contains(GizmoLineSlider2D slider)
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

		public void Add(GizmoLineSlider2D slider)
		{
		}

		public void Remove(GizmoLineSlider2D slider)
		{
		}

		public void Make2DHoverPriorityLowerThan(Priority priority)
		{
		}

		public void Make2DHoverPriorityHigherThan(Priority priority)
		{
		}

		public void SetSnapEnabled(bool isEnabled)
		{
		}

		public void SetVisible(bool visible)
		{
		}

		public void Set2DCapsVisible(bool visible)
		{
		}

		public void SetOffsetDragOrigin(Vector3 dragOrigin)
		{
		}

		public void Render(Camera camera)
		{
		}
	}
}
