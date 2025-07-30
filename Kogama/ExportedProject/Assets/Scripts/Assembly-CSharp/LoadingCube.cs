using UnityEngine;

public class LoadingCube : MonoBehaviour
{
	private const float hueChangePerSecond = 0.2f;

	private const float cubeSpinSpeed = 0.75f;

	[SerializeField]
	private GameObject cube;

	private bool visible;

	private float time;

	private Material cubeMaterial;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void SelfDestruct()
	{
	}
}
