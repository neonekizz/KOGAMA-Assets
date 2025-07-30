using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MV.WorldObject.OwnershipData;
using UnityEngine;

public class PlanetOwnershipsManager : MonoBehaviour
{
	public static PlanetOwnershipsManager Instance { get; private set; }

	public Dictionary<int, PlanetOwnershipsEntry> PlanetOwnershipsEntries { get; private set; }

	public bool RecievedPlanetOwnershipData { get; private set; }

	public event Action<Dictionary<int, PlanetOwnershipsEntry>> OnReceivedPlanetOwnershipData
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void RecievedPlanetOwnershipsDataCallback(PlanetOwnershipsData data)
	{
	}

	private void JSON_Unstripper()
	{
	}

	private void OnDestroy()
	{
	}
}
