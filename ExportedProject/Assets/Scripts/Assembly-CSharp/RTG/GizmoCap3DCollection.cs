using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoCap3DCollection
	{
		private List<GizmoCap3D> _caps;

		private Dictionary<int, GizmoCap3D> _handleIdToCap;

		public int Count => 0;

		public GizmoCap3D this[int id] => null;

		public bool Contains(GizmoCap3D cap)
		{
			return false;
		}

		public bool Contains(int capHandleId)
		{
			return false;
		}

		public void Add(GizmoCap3D cap)
		{
		}

		public void Remove(GizmoCap3D cap)
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

		public void SetVisible(bool visible)
		{
		}

		public List<GizmoCap3D> GetRenderSortedCaps(Camera renderCamera)
		{
			return null;
		}
	}
}
