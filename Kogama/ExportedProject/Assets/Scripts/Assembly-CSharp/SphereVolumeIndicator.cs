using UnityEngine;

[ExecuteInEditMode]
public class SphereVolumeIndicator : MonoBehaviour
{
	[Header("Configuration")]
	[SerializeField]
	private float lineDotDensity;

	[SerializeField]
	private int circleSergmentCount;

	[SerializeField]
	private float lineWidth;

	[Header("Dependencies")]
	[SerializeField]
	private LineRenderer rangeIndicatorXY;

	[SerializeField]
	private LineRenderer rangeIndicatorYZ;

	[SerializeField]
	private LineRenderer rangeIndicatorZX;

	[SerializeField]
	private Material lineDotMaterial;

	private Material materialCopy;

	protected void Awake()
	{
	}

	private void CopyMaterial()
	{
	}

	public void SetRadius(float radius)
	{
	}

	private void SetLineWidths(float w)
	{
	}
}
