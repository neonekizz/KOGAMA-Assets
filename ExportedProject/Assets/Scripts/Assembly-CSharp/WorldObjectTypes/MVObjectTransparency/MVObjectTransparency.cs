using System.Collections.Generic;
using MV.WorldObject;

namespace WorldObjectTypes.MVObjectTransparency
{
	public class MVObjectTransparency : MVLogicObject, ILogicWorldObject
	{
		private bool isInitialized;

		private readonly ObjectTransparency goObjectTransparency;

		public override MVWorldObjectDocumentationType DocumentationType => default(MVWorldObjectDocumentationType);

		public override bool HasInputConnector => false;

		public override bool HasOutputConnector => false;

		public override bool HasObjectConnector => false;

		protected override bool HasVisualsInPlaymode => false;

		public IInputSignalReceiver InputSignalReceiver { get; private set; }

		public bool ShowingOutline { get; private set; }

		public float Transparency { get; private set; }

		public MVObjectTransparency(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null, null)
		{
		}

		public override bool ValidateObjectLinkTarget(MVWorldObjectClient wo)
		{
			return false;
		}

		public override void Initialize()
		{
		}

		private void InputStateUpdateCallback(LogicInputState logicInputState, LogicObjectManager logicObjectManager)
		{
		}

		public override void Destroy()
		{
		}

		private void OnEditModeChange(EditModeChangeArgs arg)
		{
		}

		public override void PlayModeInitialize()
		{
		}

		public override void Reset()
		{
		}

		private void UpdateTransparency()
		{
		}

		public override void OnObjectLinkChanged(ObjectLinkChangeType changeType, ObjectLink objectLink)
		{
		}

		public override void OnDataUpdate()
		{
		}

		private void AdjustTransparency(bool currentlyIsHot)
		{
		}
	}
}
