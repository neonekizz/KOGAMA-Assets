using MV.Common;
using UnityEngine.Events;

namespace UnityEngine.EventSystems
{
	public interface IModalPopupCreator : IEventSystemHandler
	{
		void Create(MVPurchaseReturnCode returnCode, int priceGold);

		void CreateErrorNotificationPopup(string error, string header = "Error");

		PleaseWaitPopup Create();

		ConfirmationPopup Create(string text, UnityAction<bool, ConfirmationPopup> resultCallback, string header = "");

		NotificationPopup Create(string text, string header = "");
	}
}
