using MV.Common;
using UnityEngine;

public class SelectionHelperAvatarAccessory : MonoBehaviour
{
	private AvatarAccessory avatarAccessory;

	private AccessorySlotType slot;

	private int avatarBodyWoID;

	[HideInInspector]
	[SerializeField]
	private int streamingAssetsId;

	public AvatarAccessory AvatarAccessory => null;

	public AccessorySlotType Slot => default(AccessorySlotType);

	public int AvatarBodyWoID => 0;

	public int StreamingAssetsId => 0;

	public void Init(AvatarAccessory avatarAccessory, AccessorySlotType slot, int avatarBodyWoID, int accessoryStreamingAssetsId)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
