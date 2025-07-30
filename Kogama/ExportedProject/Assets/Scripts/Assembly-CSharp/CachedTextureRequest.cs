using System;
using UnityEngine.Networking;

public class CachedTextureRequest : CachedGetRequest
{
	private bool ReadableTextureData { get; set; }

	public CachedTextureRequest(string path, Action<UnityWebRequest> callback, WWWRequestPriority requestPriority, bool readable = false)
		: base(null, null, default(WWWRequestPriority))
	{
	}

	protected override UnityWebRequest Create()
	{
		return null;
	}
}
