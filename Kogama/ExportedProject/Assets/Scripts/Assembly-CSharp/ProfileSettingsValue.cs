using MV.WorldObject.MetaData;
using UnityEngine;
using UnityEngine.UI;

public class ProfileSettingsValue : MonoBehaviour
{
	[SerializeField]
	private ProfileSettingKey profileSettingKey;

	private Text text;

	public void Start()
	{
	}

	private void OnChange(object value)
	{
	}

	private string TargetFrameRateValueToString(TargetFrameRateValue value)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
