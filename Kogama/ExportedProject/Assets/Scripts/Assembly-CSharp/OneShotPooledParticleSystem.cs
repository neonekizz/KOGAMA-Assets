using UnityEngine;

public class OneShotPooledParticleSystem : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem particles;

	private PoolEnums type;

	public static ParticleSystem Instantiate(PoolEnums type)
	{
		return null;
	}

	public static ParticleSystem Instantiate(PoolEnums type, Vector3 position, Quaternion rotation, float? scale = null, Color? color = null)
	{
		return null;
	}

	private void OnValidate()
	{
	}

	private void Update()
	{
	}
}
