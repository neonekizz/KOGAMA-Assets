using MV.WorldObject;

public class InputSignalReceiverClient : InputSignalReceiverBase
{
	public override bool CurrentlyIsHot { get; set; }

	public InputSignalReceiverClient(MVWorldObject worldObject, LogicEvaluateSignalComponentBase logicEvaluateSignalComponentBase, bool defaultInput, LogicObjectManager logicObjectManager)
		: base(null, null, defaultInput: false, null)
	{
	}
}
