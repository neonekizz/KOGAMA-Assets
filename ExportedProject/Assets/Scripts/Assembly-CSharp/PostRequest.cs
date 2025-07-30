using System;
using UnityEngine;
using UnityEngine.Networking;

public class PostRequest : AsyncWebRequest
{
	private readonly WWWForm form;

	public PostRequest(string path, WWWForm form, Action<UnityWebRequest> callback, WWWRequestPriority requestPriority)
		: base(null, null, default(WWWRequestPriority))
	{
	}

	protected override UnityWebRequest Create()
	{
		return null;
	}
}
