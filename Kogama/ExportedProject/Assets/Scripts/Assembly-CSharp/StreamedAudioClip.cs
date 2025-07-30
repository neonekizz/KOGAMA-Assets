using UnityEngine;

public class StreamedAudioClip : StreamingAsset<AudioClip, AudioClip>
{
	public interface IReceiver
	{
		void OnAudioReceived(AudioClip a);
	}

	private IReceiver receiver;

	public void Initialize(IReceiver receiver)
	{
	}

	protected override void OnAssetSet()
	{
	}
}
