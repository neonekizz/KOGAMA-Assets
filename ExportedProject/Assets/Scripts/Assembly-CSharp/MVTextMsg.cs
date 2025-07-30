using System.Collections.Generic;
using UnityEngine;

public class MVTextMsg : MVLogicObject, ILogicWorldObject
{
	private readonly Bounds localBounds;

	private readonly MVTextMsgObject msgObject;

	public override MVWorldObjectDocumentationType DocumentationType => default(MVWorldObjectDocumentationType);

	public override bool HasInputConnector => false;

	public override bool HasOutputConnector => false;

	protected override bool HasVisualsInPlaymode => false;

	public IInputSignalReceiver InputSignalReceiver { get; private set; }

	public MVTextMsg(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}

	public override Bounds GetLocalBounds(BoundsContext boundsContext)
	{
		return default(Bounds);
	}

	public override void Initialize()
	{
	}

	private void ToggleText(bool visible)
	{
	}

	private void InputStateUpdateCallback(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
	{
	}

	public override void InitializeInventory()
	{
	}

	public override void OnDataUpdate()
	{
	}

	private void UpdateText()
	{
	}
}
