using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MV.Common;
using UnityEngine;

public class PickupItemMeleeWeapon : PickupItemEditable
{
	protected class MeleeWeaponConfiguration : EditableItemConfiguration
	{
		public Color trailColor;

		public Color hitEffectColor;
	}

	[CompilerGenerated]
	private sealed class _003CCheckHitCoroutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PickupItemMeleeWeapon _003C_003E4__this;

		public bool isLocal;

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
		public _003CCheckHitCoroutine_003Ed__28(int _003C_003E1__state)
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
	private MeleeWeaponAnimationEventHandler animationEventHandler;

	private IEnumerator checkHitCoroutine;

	private bool isUnequipped;

	public override AvatarItemType Type => default(AvatarItemType);

	public override bool FirstPerson => false;

	public override bool GunMode => false;

	public Color TrailColor => default(Color);

	public Color HitEffectColor => default(Color);

	protected new MeleeWeaponConfiguration Configuration
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override string FireSoundEffectName => null;

	protected override string HitSoundEffectName => null;

	protected override string AttackAnimationName => null;

	protected override void InitializeAudioPlayers()
	{
	}

	protected override EditableItemConfiguration GetDefaultConfiguration()
	{
		return null;
	}

	protected override void SetConfiguration(Dictionary<object, object> itemData)
	{
	}

	protected override void OnPickupNewEditableItem()
	{
	}

	protected override void OnFire(bool isLocal)
	{
	}

	[IteratorStateMachine(typeof(_003CCheckHitCoroutine_003Ed__28))]
	private IEnumerator CheckHitCoroutine(bool isLocal)
	{
		return null;
	}

	private void CheckHit(bool isLocal)
	{
	}

	private void OnHit(List<VoxelHit> voxelHits, Ray lineOfFire)
	{
	}

	private void OnLocalHit(List<VoxelHit> voxelHits)
	{
	}

	private void OnLocalHit(VoxelHit voxelHit)
	{
	}

	public override void UpdateWithDirection(Vector3 dir)
	{
	}

	public override bool IsSameItemData(Dictionary<object, object> itemData)
	{
		return false;
	}

	public override void OnUnequip()
	{
	}

	protected override void InterruptFire()
	{
	}
}
