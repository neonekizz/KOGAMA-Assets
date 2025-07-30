using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasRenderer))]
[ExecuteInEditMode]
public class RoundedRectangle : Image
{
	public float radius;

	protected override void Awake()
	{
	}

	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}
}
