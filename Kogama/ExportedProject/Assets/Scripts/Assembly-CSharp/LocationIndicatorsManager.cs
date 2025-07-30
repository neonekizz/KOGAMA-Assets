using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MV.WorldObject.OwnershipData;
using UnityEngine;

public class LocationIndicatorsManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LocationIndicatorsManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CUpdateCoroutine_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const float UpdateIntervalSeconds = 0.5f;

	[SerializeField]
	private LocationIndicator indicatorPrefab;

	private Dictionary<int, LocationIndicator> indicators;

	private IEnumerator updateCoroutine;

	public static LocationIndicatorsManager Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void JSON_Unstripper()
	{
	}

	public void RecievedPlanetOwnershipsDataCallback(Dictionary<int, PlanetOwnershipsEntry> data)
	{
	}

	private void SetIndicatorsOwnership()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateCoroutine_003Ed__13))]
	private IEnumerator UpdateCoroutine()
	{
		return null;
	}

	private void CreateOrDestroyIndicators()
	{
	}

	private bool CreateIndicatorIfNotDefined(MVPlayer player)
	{
		return false;
	}

	private void OnDestroy()
	{
	}
}
