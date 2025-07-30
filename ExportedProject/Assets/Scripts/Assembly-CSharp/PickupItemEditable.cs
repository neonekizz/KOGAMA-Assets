using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class PickupItemEditable : PickupItemWithDelay
{
	protected abstract class EditableItemConfiguration
	{
		public string name;

		public int cubeModelId;

		public float maxAmmo;

		public float damage;

		public float impulseStrength;

		public float recoilStrength;

		public float fireAnimationTime;

		public float attackCooldown;

		public float range;

		public float radius;

		public int fireSoundEffect;

		public float fireSoundEffectVolume;

		public int hitSoundEffect;

		public float hitSoundEffectVolume;
	}

	[CompilerGenerated]
	private sealed class _003CDisableAnimatorCoroutine_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PickupItemEditable _003C_003E4__this;

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
		public _003CDisableAnimatorCoroutine_003Ed__39(int _003C_003E1__state)
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
	protected Transform weaponParent;

	[SerializeField]
	protected Transform weaponHandle;

	[SerializeField]
	protected Transform cubeModelParent;

	[SerializeField]
	protected Animator animator;

	[SerializeField]
	protected CustomItemAudioPlayer fireAudioPlayer;

	[SerializeField]
	protected CustomItemAudioPlayer hitAudioPlayer;

	protected int hitLayerMask;

	protected GameObject cubeModelObject;

	private IEnumerator animatorRoutine;

	public int CubeModelPid { get; private set; }

	public virtual string Name => null;

	protected virtual string FireSoundEffectName => null;

	protected virtual string HitSoundEffectName => null;

	protected virtual string AttackAnimationName => null;

	protected EditableItemConfiguration Configuration { get; set; }

	public abstract bool IsSameItemData(Dictionary<object, object> itemData);

	protected abstract void SetConfiguration(Dictionary<object, object> data);

	protected abstract EditableItemConfiguration GetDefaultConfiguration();

	protected abstract void InitializeAudioPlayers();

	private void Awake()
	{
	}

	protected virtual void Initialize()
	{
	}

	protected virtual void SetValuesBasedOnConfiguration()
	{
	}

	public override void OnStateChanged(Dictionary<object, object> newState)
	{
	}

	protected virtual void OnPickupNewEditableItem()
	{
	}

	protected void OnCubeModelStateChanged()
	{
	}

	protected virtual void SetAnimation()
	{
	}

	protected void PlayAnimation()
	{
	}

	protected virtual void OnHit(VoxelHit voxelHit, Ray lineOfFire)
	{
	}

	[IteratorStateMachine(typeof(_003CDisableAnimatorCoroutine_003Ed__39))]
	private IEnumerator DisableAnimatorCoroutine()
	{
		return null;
	}

	private void DisableAnimation()
	{
	}

	protected bool IsSamePickupItem(Dictionary<object, object> itemData)
	{
		return false;
	}

	protected virtual void InterruptFire()
	{
	}

	public override void OnUnequip()
	{
	}

	protected override void OnHolstered()
	{
	}

	public override void OnEnterVehicleWithWeapon()
	{
	}
}
