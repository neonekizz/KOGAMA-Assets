using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LeavePlayModeButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CExecuteLeaveEditDelayed_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LeavePlayModeButton _003C_003E4__this;

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
		public _003CExecuteLeaveEditDelayed_003Ed__2(int _003C_003E1__state)
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

	private void Awake()
	{
	}

	public void Execute()
	{
	}

	[IteratorStateMachine(typeof(_003CExecuteLeaveEditDelayed_003Ed__2))]
	private IEnumerator ExecuteLeaveEditDelayed()
	{
		return null;
	}
}
