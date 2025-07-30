using System.Collections.Generic;

public class MVSpawnPointRed : MVSpawnPoint
{
	public override MVWorldObjectDocumentationType DocumentationType => default(MVWorldObjectDocumentationType);

	public MVSpawnPointRed(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}
}
