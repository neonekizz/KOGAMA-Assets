using System.Collections.Generic;
using Assets.Scripts.WorldObjectTypes.EditablePickupItem;
using MV.WorldObject;

namespace Assets.Scripts.WorldObjectTypes.CustomGun
{
	internal class MVCustomGunBase : MVEditablePickupItemBase
	{
		public MVCustomGunBase(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
			: base(null, null)
		{
		}

		public override (IntVector, IntVector) GetEditPoints()
		{
			return default((IntVector, IntVector));
		}
	}
}
