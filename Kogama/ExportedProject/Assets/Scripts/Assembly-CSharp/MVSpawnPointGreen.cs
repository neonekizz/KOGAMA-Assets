using System.Collections.Generic;

public class MVSpawnPointGreen : MVSpawnPoint
{
	public override MVWorldObjectDocumentationType DocumentationType => default(MVWorldObjectDocumentationType);

	public MVSpawnPointGreen(Dictionary<object, object> data, Dictionary<int, MVWorldObjectClient> worldObjects)
		: base(null, null, null)
	{
	}
}
