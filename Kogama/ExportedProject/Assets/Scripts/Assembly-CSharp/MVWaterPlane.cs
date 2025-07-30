using System.Collections.Generic;
using UnityEngine;

public class MVWaterPlane : MVLogicObject
{
	protected WaterPlaneManager waterManager;

	private Bounds localBounds;

	private bool addedToWPManager;

	public override MVWorldObjectDocumentationType DocumentationType => default(MVWorldObjectDocumentationType);

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public override Vector3 WorldPivot => default(Vector3);

	public MVWaterPlane(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override bool IsSingletonObject()
	{
		return false;
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default(Bounds);
	}

	public override void Initialize()
	{
	}

	public override void OnDataUpdate()
	{
	}

	public override void Destroy()
	{
	}
}
