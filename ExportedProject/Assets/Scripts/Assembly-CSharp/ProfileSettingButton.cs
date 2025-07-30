using MV.WorldObject.MetaData;
using UnityEngine;
using UnityEngine.UI;

public class ProfileSettingButton : MonoBehaviour
{
	private enum ProfileSettingButtonType
	{
		Increase = 0,
		Decrease = 1
	}

	[SerializeField]
	private ProfileSettingButtonType profileSettingButtonType;

	[SerializeField]
	private ProfileSettingKey profileSettingKey;

	private Button button;

	private bool isIncrease;

	private int minValue;

	private int maxValue;

	private void Start()
	{
	}

	public void OnClick()
	{
	}

	private void OnChange(object value)
	{
	}

	private object ProfileSettingValueToObj(int value)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
