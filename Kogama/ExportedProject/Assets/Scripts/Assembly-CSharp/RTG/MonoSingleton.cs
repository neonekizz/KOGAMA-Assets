using UnityEngine;

namespace RTG
{
	public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		private static object _singletonLock;

		private static T _instance;

		public static T Get => null;
	}
}
