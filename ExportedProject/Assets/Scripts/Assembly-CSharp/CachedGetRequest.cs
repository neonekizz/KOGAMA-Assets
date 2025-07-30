using System;
using UnityEngine.Networking;

public class CachedGetRequest : GetRequest
{
	public CachedGetRequest(string path, Action<UnityWebRequest> callback, WWWRequestPriority requestPriority)
		: base(null, null, default(WWWRequestPriority))
	{
	}

	public virtual bool FoundInCache(AsyncWWWManager.Cache cache)
	{
		return false;
	}

	protected void AddToCallback(Action<UnityWebRequest> callbackOther)
	{
	}
}
