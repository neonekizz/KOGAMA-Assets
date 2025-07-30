using UnityEngine;

[ExecuteInEditMode]
public class LineRangeIndicator : MonoBehaviour
{
	[SerializeField]
	[Header("Configuration")]
	private float lineDotDensity;

	[SerializeField]
	private float lineWidth;

	[Header("Dependencies")]
	[SerializeField]
	private MeshRenderer rangeIndicator;

	[SerializeField]
	private MeshRenderer rangeIndicator_backside;

	[SerializeField]
	private Material lineDotMaterial;

	private Material materialCopy;

	protected void Awake()
	{
	}

	private void CopyMaterial()
	{
	}

	public void SetRange(float range)
	{
	}
}
