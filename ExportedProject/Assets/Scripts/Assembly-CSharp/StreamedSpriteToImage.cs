using UnityEngine;
using UnityEngine.UI;

public class StreamedSpriteToImage : StreamingAsset<Sprite, Texture2D>
{
	[SerializeField]
	[Header("Dependencies")]
	protected Image image;

	public void Reset()
	{
	}

	protected override void OnAssetSet()
	{
	}
}
