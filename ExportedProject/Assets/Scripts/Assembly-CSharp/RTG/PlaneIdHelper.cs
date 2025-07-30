using System.Collections.Generic;

namespace RTG
{
	public static class PlaneIdHelper
	{
		private struct PlaneQuadrantInfo
		{
			public PlaneQuadrantId Quadrant;

			public AxisSign FirstAxisSign;

			public AxisSign SecondAxisSign;
		}

		private struct PlaneInfo
		{
			public PlaneId PlaneId;

			public List<PlaneQuadrantInfo> QuadrantInfo;
		}

		private static List<PlaneInfo> _planeInfo;

		private static PlaneId[] _allPlaneIds;

		public static PlaneId[] AllPlaneIds => null;

		static PlaneIdHelper()
		{
		}

		public static AxisDescriptor GetFirstAxisDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			return null;
		}

		public static AxisDescriptor GetSecondAxisDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			return null;
		}

		public static AxisSign GetFirstAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			return default(AxisSign);
		}

		public static AxisSign GetSecondAxisSign(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			return default(AxisSign);
		}

		public static PlaneQuadrantId GetQuadrantFromAxesSigns(PlaneId planeId, AxisSign firstAxisSign, AxisSign secondAxisSign)
		{
			return default(PlaneQuadrantId);
		}

		public static int PlaneIdToFirstAxisIndex(PlaneId planeId)
		{
			return 0;
		}

		public static int PlaneIdToSecondAxisIndex(PlaneId planeId)
		{
			return 0;
		}

		public static PlaneId NormalAxisIndexToPlaneId(int axisIndex)
		{
			return default(PlaneId);
		}
	}
}
