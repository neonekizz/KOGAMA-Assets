namespace RTG
{
	public static class SnapMath
	{
		public static NumSnapSteps CalculateNumSnapSteps(float snapStep, float total)
		{
			return default(NumSnapSteps);
		}

		public static bool CanExtractSnap(float snapStep, float accumulated)
		{
			return false;
		}

		public static float ExtractSnap(float snapStep, ref float accumulated)
		{
			return 0f;
		}

		public static float ExtractSnap(float snapStep, float accumulated)
		{
			return 0f;
		}
	}
}
