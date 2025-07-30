using System.Collections.Generic;
using Assets.Scripts.WorldObjectTypes.EditablePickupItem;

namespace Assets.Scripts.WorldObjectTypes.Costume
{
	public class MVCostumeBaseBlueprint : MVEditablePickupItemBaseBlueprint
	{
		public override MVWorldObjectDocumentationType DocumentationType => default(MVWorldObjectDocumentationType);

		public MVCostumeBaseBlueprint(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null)
		{
		}

		public override void OnEndEditing()
		{
		}
	}
}
