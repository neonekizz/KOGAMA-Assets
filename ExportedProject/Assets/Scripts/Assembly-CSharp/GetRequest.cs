using System;
using UnityEngine.Networking;

public class GetRequest : AsyncWebRequest
{
	public GetRequest(string path, Action<UnityWebRequest> callback, WWWRequestPriority requestPriority)
		: base(null, null, default(WWWRequestPriority))
	{
	}

	protected override UnityWebRequest Create()
	{
		return null;
	}
}
