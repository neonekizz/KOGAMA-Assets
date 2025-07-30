using UnityEngine;
using UnityEngine.Events;

public class PreviewSound : MonoBehaviour
{
	[SerializeField]
	private string soundCategory;

	[SerializeField]
	private bool playSelected;

	[SerializeField]
	private UnityEvent<string, int> onClick;

	private int index;

	private void Start()
	{
	}

	public void OnClick()
	{
	}
}
