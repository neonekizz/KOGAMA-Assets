namespace RTG
{
	public class AxisDescriptor
	{
		private AxisSign _sign;

		private int _index;

		public AxisSign Sign => default(AxisSign);

		public int Index => 0;

		public bool IsPositive => false;

		public bool IsNegative => false;

		public AxisDescriptor(int axisIndex, AxisSign axisSign)
		{
		}

		public AxisDescriptor(int axisIndex, bool isNegative)
		{
		}

		public BoxFace GetAssociatedBoxFace()
		{
			return default(BoxFace);
		}
	}
}
