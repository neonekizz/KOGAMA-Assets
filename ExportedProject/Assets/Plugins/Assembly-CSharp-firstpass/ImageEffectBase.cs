using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu(null)]
public class ImageEffectBase : MonoBehaviour
{
	public Shader shader;

	private Material m_Material;

	protected Material material => null;

	protected void Start()
	{
	}

	protected void OnDisable()
	{
	}
}
