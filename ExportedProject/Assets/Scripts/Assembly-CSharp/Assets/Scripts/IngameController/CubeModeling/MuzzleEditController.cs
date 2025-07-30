using UnityEngine;

namespace Assets.Scripts.IngameController.CubeModeling
{
	internal class MuzzleEditController : MonoBehaviour
	{
		private static bool InMuzzleEdit;

		[SerializeField]
		private GameObject resetPositionButton;

		[SerializeField]
		private GameObject resetRotationButton;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public static void EnterMuzzleEdit()
		{
		}

		public static void ExitMuzzleEdit()
		{
		}
	}
}
