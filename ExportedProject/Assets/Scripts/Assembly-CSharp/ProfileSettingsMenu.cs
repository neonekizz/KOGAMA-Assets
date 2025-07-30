using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ProfileSettingsMenu : LobbyFlowMenu
{
	[CompilerGenerated]
	private sealed class _003CMouseSetRoutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProfileSettingsMenu _003C_003E4__this;

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
		public _003CMouseSetRoutine_003Ed__12(int _003C_003E1__state)
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

	[SerializeField]
	private VerticalLayoutGroup settingsLayoutGroup;

	[SerializeField]
	private GameObject backButton;

	[SerializeField]
	private SettingsSlider mouseSensitivitySlider;

	private IEnumerator mouseSenseSetRoutine;

	protected override LobbyFlowMenuType MenuType => default(LobbyFlowMenuType);

	public override void Start()
	{
	}

	private void Update()
	{
	}

	private void SetMouseSensitivitySlider(object value)
	{
	}

	public void UpdateBackButtonVisibility()
	{
	}

	public override void GoToPreviousMenu()
	{
	}

	public void MouseSensitivityChanged()
	{
	}

	[IteratorStateMachine(typeof(_003CMouseSetRoutine_003Ed__12))]
	private IEnumerator MouseSetRoutine()
	{
		return null;
	}

	public void ResetProfileSettings()
	{
	}

	protected override void OnDestroy()
	{
	}
}
