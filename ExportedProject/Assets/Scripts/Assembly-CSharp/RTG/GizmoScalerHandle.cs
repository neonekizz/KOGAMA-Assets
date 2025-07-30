using System.Collections.Generic;

namespace RTG
{
	public class GizmoScalerHandle
	{
		private int _handleId;

		private List<int> _scaleDragAxisIndices;

		public int HandleId => 0;

		public List<int> ScaleDragAxisIndices => null;

		public GizmoScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices)
		{
		}

		public bool ContainsScaleDragAxisIndex(int scaleDragAxisIndex)
		{
			return false;
		}
	}
}
