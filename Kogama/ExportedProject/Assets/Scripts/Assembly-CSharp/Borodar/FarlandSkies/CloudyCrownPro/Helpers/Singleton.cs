using UnityEngine;

namespace Borodar.FarlandSkies.CloudyCrownPro.Helpers
{
	public class Singleton<T> : MonoBehaviour where T : Component
	{
		private static T _instance;

		public static T Instance => null;
	}
}
