namespace RTG
{
	public class Priority
	{
		private int _priority;

		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int Lowest => 0;

		public static int Highest => 0;

		public void MakeLowest()
		{
		}

		public void MakeHighest()
		{
		}

		public void MakeLowerThan(Priority priority)
		{
		}

		public void MakeHigherThan(Priority priority)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public int CompareTo(Priority other)
		{
			return 0;
		}

		public static bool operator ==(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}

		public static bool operator !=(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}

		public static bool operator >(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}

		public static bool operator >=(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}

		public static bool operator <(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}

		public static bool operator <=(Priority firstPriority, Priority secondPriority)
		{
			return false;
		}
	}
}
