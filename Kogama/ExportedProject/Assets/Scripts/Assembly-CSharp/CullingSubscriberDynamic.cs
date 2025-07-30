using UnityEngine;

public class CullingSubscriberDynamic : IUpdatecontrollerSubscriberUpdate, IUpdatecontrollerSubscriberBase, ICullingSubscriber
{
	private readonly int cullingBandIndex;

	private readonly int overrideDistanceBandIndex;

	private readonly bool keepRootAlive;

	private readonly GameObject root;

	private readonly GameObject[] cullingGroup;

	private readonly Transform rootTransform;

	public int CullingIndex { get; set; }

	public CullingSubscriberDynamic(float radius, int cullingBandIndex, GameObject root, GameObject[] cullingGroup = null, bool keepRootAlive = false)
	{
	}

	public void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	private void SetStateRoot(bool visible)
	{
	}

	private void SetStateCullingGroupUpdate(bool visible)
	{
	}

	public void UpdateControllerUpdate()
	{
	}

	public void SetCullingRadius(float radius)
	{
	}

	public void UpdateControllerFixedUpdate()
	{
	}

	public void Destroy()
	{
	}
}
