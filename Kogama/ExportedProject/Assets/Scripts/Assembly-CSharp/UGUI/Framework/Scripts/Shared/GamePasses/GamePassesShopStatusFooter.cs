using UnityEngine;

namespace UGUI.Framework.Scripts.Shared.GamePasses
{
	public class GamePassesShopStatusFooter : MonoBehaviour
	{
		[SerializeField]
		private GameObject levelBar;

		[SerializeField]
		private GameObject goldAmount;

		[SerializeField]
		private EmbeddedPlayerConfig embeddedPlayerConfig;

		private void Awake()
		{
		}
	}
}
