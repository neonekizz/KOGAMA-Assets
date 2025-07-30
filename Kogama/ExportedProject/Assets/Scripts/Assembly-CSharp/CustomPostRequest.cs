using System;
using UnityEngine.Networking;

public class CustomPostRequest : AsyncWebRequest
{
	public CustomPostRequest(UnityWebRequest request, Action<UnityWebRequest> callback, WWWRequestPriority requestPriority)
		: base(null, null, default(WWWRequestPriority))
	{
	}

	protected override UnityWebRequest Create()
	{
		return null;
	}
}
