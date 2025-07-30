using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using WorldObjectTypes.VehicleEnergy;

namespace UGUI.Framework.Scripts.Shared.VehicleUI
{
	public class VehicleEnergyMeter : VehicleMeterBase
	{
		[CompilerGenerated]
		private sealed class _003CBlinkingBar_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VehicleEnergyMeter _003C_003E4__this;

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
			public _003CBlinkingBar_003Ed__17(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CStopBlinking_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VehicleEnergyMeter _003C_003E4__this;

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
			public _003CStopBlinking_003Ed__14(int _003C_003E1__state)
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
		private ProgressBar progressBar;

		[SerializeField]
		private Image progressBarImage;

		private bool updateEnergy;

		private VehicleEnergyContainer vehicleEnergyContainer;

		private const float BlinkingLimit = 0.15f;

		private const float BlinkingTime = 0.3f;

		private Color originalColor;

		private Color? currentColor;

		private static readonly Color WarningColor;

		private static readonly Color RefillColor;

		private void Awake()
		{
		}

		public override void Initialize(bool insideVehicle, MVRigidBody rigidBody)
		{
		}

		public void UpdateEnergy()
		{
		}

		private void OnRefillCallback()
		{
		}

		[IteratorStateMachine(typeof(_003CStopBlinking_003Ed__14))]
		private IEnumerator StopBlinking()
		{
			return null;
		}

		private void VisualStuff()
		{
		}

		private void StopBlinkingBar()
		{
		}

		[IteratorStateMachine(typeof(_003CBlinkingBar_003Ed__17))]
		private IEnumerator BlinkingBar()
		{
			return null;
		}
	}
}
