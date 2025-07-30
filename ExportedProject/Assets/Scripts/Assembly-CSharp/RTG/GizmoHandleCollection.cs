using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoHandleCollection
	{
		private Gizmo _gizmo;

		private List<IGizmoHandle> _handles;

		private Dictionary<int, IGizmoHandle> _idToHandle;

		public Gizmo Gizmo => null;

		public int Count => 0;

		public IGizmoHandle this[int index] => null;

		public GizmoHandleCollection(Gizmo gizmo)
		{
		}

		public void Clear()
		{
		}

		public IGizmoHandle GetHandleById(int handleId)
		{
			return null;
		}

		public bool Contains(IGizmoHandle handle)
		{
			return false;
		}

		public bool Contains(int handleId)
		{
			return false;
		}

		public void Add(IGizmoHandle handle)
		{
		}

		public void Remove(IGizmoHandle handle)
		{
		}

		public List<IGizmoHandle> GetAll()
		{
			return null;
		}

		public List<GizmoHandleHoverData> GetAllHandlesHoverData(Ray hoverRay)
		{
			return null;
		}
	}
}
