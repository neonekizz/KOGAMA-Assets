namespace RTG
{
	public struct PlaneDescriptor
	{
		private PlaneId _id;

		private PlaneQuadrantId _quadrant;

		private AxisDescriptor _firstAxisDescriptor;

		private AxisDescriptor _secondAxisDescriptor;

		public PlaneId Id => default(PlaneId);

		public PlaneQuadrantId Quadrant => default(PlaneQuadrantId);

		public AxisSign FirstAxisSign => default(AxisSign);

		public AxisSign SecondAxisSign => default(AxisSign);

		public int FirstAxisIndex => 0;

		public int SecondAxisIndex => 0;

		public AxisDescriptor FirstAxisDescriptor => null;

		public AxisDescriptor SecondAxisDescriptor => null;

		public PlaneDescriptor(PlaneId planeId, PlaneQuadrantId planeQuadrant)
		{
			_id = default(PlaneId);
			_quadrant = default(PlaneQuadrantId);
			_firstAxisDescriptor = null;
			_secondAxisDescriptor = null;
		}
	}
}
