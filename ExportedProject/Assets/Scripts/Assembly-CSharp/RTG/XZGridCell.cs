using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class XZGridCell
	{
		private IXZGrid _parentGrid;

		private int _xIndex;

		private int _zIndex;

		private Vector3 _min;

		private Vector3 _max;

		public IXZGrid ParentGrid => null;

		public int XIndex => 0;

		public int ZIndex => 0;

		public Vector3 Min => default(Vector3);

		public Vector3 Max => default(Vector3);

		public Vector3 Center => default(Vector3);

		public XZGridCell(int xIndex, int zIndex, Vector3 min, Vector3 max, IXZGrid parentGrid)
		{
		}

		public static XZGridCell FromPoint(Vector3 point, float cellSizeX, float cellSizeZ, IXZGrid parentGrid)
		{
			return null;
		}

		public List<Vector3> GetCenterAndCorners()
		{
			return null;
		}
	}
}
