using System;
using UnityEngine.Networking;

public class AssetBundleRequest : GetRequest
{
	public AssetBundleRequest(string path, Action<UnityWebRequest> callback, WWWRequestPriority requestPriority)
		: base(null, null, default(WWWRequestPriority))
	{
	}

	protected override UnityWebRequest Create()
	{
		return null;
	}
}
