namespace RTG
{
	public struct BoxFaceAreaDesc
	{
		public BoxFaceAreaType AreaType;

		public float Area;

		public BoxFaceAreaDesc(BoxFaceAreaType areaType, float area)
		{
			AreaType = default(BoxFaceAreaType);
			Area = 0f;
		}

		public static BoxFaceAreaDesc GetInvalid()
		{
			return default(BoxFaceAreaDesc);
		}
	}
}
