using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IngameController.CubeModeling;
using UnityEngine;
using UnityEngine.UI;

public class DesktopCubeModelingController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetButtonTextureRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DesktopCubeModelingController _003C_003E4__this;

		public byte materialId;

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
		public _003CSetButtonTextureRoutine_003Ed__8(int _003C_003E1__state)
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
	private RawImage materialsButtonImage;

	[SerializeField]
	private DesktopCubeModelingToolsController desktopCubeModelingController;

	[SerializeField]
	private DesktopCubeModelingTogglesController togglesController;

	[SerializeField]
	private Sprite errorSprite;

	[SerializeField]
	private UploadGameScreenshotHandler screenshotHandler;

	private IEnumerator setButtonTextureRoutine;

	public void Initialize(CubeModelingStateMachine cubeModelingStateMachine)
	{
	}

	public void SetMaterial(byte materialId)
	{
	}

	[IteratorStateMachine(typeof(_003CSetButtonTextureRoutine_003Ed__8))]
	private IEnumerator SetButtonTextureRoutine(byte materialId)
	{
		return null;
	}

	public void SwitchToDefaultTool()
	{
	}

	public void PublishGame()
	{
	}

	public void PublishCallback(bool confirmed, ConfirmationPopup popup)
	{
	}

	private void OnPublishPlanetFinished(string completionMessage)
	{
	}

	public void TakeScreenshot()
	{
	}
}
