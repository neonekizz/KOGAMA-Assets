using System.Collections.Generic;

namespace RTG
{
	public class GizmoCollectionEnabledStateSnapshot
	{
		private Dictionary<Gizmo, bool> _gizmoToState;

		public void Snapshot(IEnumerable<Gizmo> gizmos)
		{
		}

		public void Apply()
		{
		}
	}
}
