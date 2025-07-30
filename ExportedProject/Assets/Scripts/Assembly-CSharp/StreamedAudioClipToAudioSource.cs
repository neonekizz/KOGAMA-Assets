using UnityEngine;

public class StreamedAudioClipToAudioSource : StreamingAsset<AudioClip, AudioClip>
{
	[SerializeField]
	[Header("Dependencies")]
	protected AudioSource audioSource;

	public void Reset()
	{
	}

	protected override void OnAssetSet()
	{
	}
}
