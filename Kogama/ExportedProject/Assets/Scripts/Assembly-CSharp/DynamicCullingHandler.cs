using UnityEngine;

public class DynamicCullingHandler
{
	private CullingSubscriberDynamic cullingSubscriberDynamic;

	private float cullingRadius;

	public DynamicCullingHandler(float cullingRadius)
	{
	}

	public void ActivateCulling(GameObject cullingObject, GameObject[] cullingGroup = null, bool keepRootAlive = false)
	{
	}

	public void DeActivateCulling()
	{
	}

	public void UpdateCullingRadius(MVWorldObjectClient objArg, ScaleChangedEventArgs scaleArg)
	{
	}
}
