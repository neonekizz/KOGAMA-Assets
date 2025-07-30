using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoCap2DCollection
	{
		private List<GizmoCap2D> _caps;

		private Dictionary<int, GizmoCap2D> _handleIdToCap;

		public int Count => 0;

		public GizmoCap2D this[int id] => null;

		public bool Contains(GizmoCap2D cap)
		{
			return false;
		}

		public bool Contains(int capHandleId)
		{
			return false;
		}

		public void Add(GizmoCap2D cap)
		{
		}

		public void Remove(GizmoCap2D cap)
		{
		}

		public void Make2DHoverPriorityLowerThan(Priority priority)
		{
		}

		public void Make2DHoverPriorityHigherThan(Priority priority)
		{
		}

		public void SetVisible(bool visible)
		{
		}

		public void SetHoverable(bool hoverable)
		{
		}

		public void SetDragSession(IGizmoDragSession dragSession)
		{
		}

		public void Render(Camera camera)
		{
		}
	}
}
