using UnityEngine;

public class StreamedTextureToSharedMaterial : StreamingAsset<Texture2D, Texture2D>
{
	[Tooltip("For standard unity shaders \"_MainTex\" is the main textures name.")]
	[SerializeField]
	[Header("Configuration")]
	protected string shaderTextureVariableName;

	[SerializeField]
	[Header("Dependencies")]
	protected Material material;

	public void Reset()
	{
	}

	protected override void OnAssetSet()
	{
	}
}
