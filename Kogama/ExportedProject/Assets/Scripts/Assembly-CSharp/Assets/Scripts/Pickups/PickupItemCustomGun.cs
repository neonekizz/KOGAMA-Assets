using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.WorldObjectTypes.CustomGun;
using CodeStage.AntiCheat.ObscuredTypes;
using MV.Common;
using UnityEngine;

namespace Assets.Scripts.Pickups
{
	internal class PickupItemCustomGun : PickupItemEditable
	{
		protected class CustomGunConfiguration : EditableItemConfiguration
		{
			public float movementSpeedWhileHeld;

			public int fireMode;

			public Vector3 muzzlePosition;

			public Vector3 muzzleDirection;

			public bool muzzleFlareOnFire;

			public float muzzleFlareSize;

			public Color muzzleFlareColor;

			public bool thirdPersonCamera;

			public bool smokeOnFire;

			public float shotsPerBurst;

			public float burstCooldownBetweenShots;

			public float projectilesPerShot;

			public bool chargeEnabled;

			public float chargeTime;

			public int chargeSoundEffect;

			public float chargeSoundEffectVolume;

			public bool chargeParticlesEnabled;

			public float chargeParticlesSize;

			public Color chargeParticlesColor;

			public bool chargeZoomEnabled;

			public float chargeZoomAmmount;

			public float chargeZoomTime;

			public float projectileSpeed;

			public float projectileSize;

			public Color projectileColor;

			public Color projectileTrailColor;

			public bool sparksOnHit;

			public float sparksSize;

			public Color sparksColor;
		}

		[CompilerGenerated]
		private sealed class _003CChargeRoutine_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PickupItemCustomGun _003C_003E4__this;

			private float _003CchargeBeginTime_003E5__2;

			private float _003CtargetFieldOfView_003E5__3;

			private float _003CtargetMouseSensitivity_003E5__4;

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
			public _003CChargeRoutine_003Ed__68(int _003C_003E1__state)
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
		private sealed class _003CFetchFOV_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PickupItemCustomGun _003C_003E4__this;

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
			public _003CFetchFOV_003Ed__52(int _003C_003E1__state)
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

		private const float UnlimitedAmmoAmmount = 999f;

		private const float EffectTimeoutTime = 0.05f;

		[SerializeField]
		private CustomItemAudioPlayer chargeAudioPlayer;

		[SerializeField]
		private AnimationCurve chargeCurve;

		[SerializeField]
		private Transform staticMuzzlePoint;

		[SerializeField]
		private ParticleSystem chargeParticles;

		[SerializeField]
		private ParticleSystem smokeParticles;

		[SerializeField]
		private ParticleSystem flareParticles;

		private bool canDoFOVZoom;

		private TimeoutClock fireEffectTimeout;

		private TimeoutClock bulletEffectTimeout;

		private IEnumerator chargeRoutine;

		private ObscuredInt currentAmmo;

		private ObscuredInt firedInBurst;

		private ObscuredFloat currentCharge;

		private ObscuredFloat initialFOV;

		private ObscuredFloat initialMouseSensitivity;

		public override AvatarItemType Type => default(AvatarItemType);

		protected new CustomGunConfiguration Configuration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool HasUnlimitedAmmo => false;

		public override bool FirstPerson => false;

		public override float ChargeState => 0f;

		public override int Quantity => 0;

		protected override string FireSoundEffectName => null;

		protected override string HitSoundEffectName => null;

		protected override string AttackAnimationName => null;

		protected override bool IsAmmoDepleted => false;

		public override Color CrossHairColor => default(Color);

		protected override void InitializeAudioPlayers()
		{
		}

		public override void ResetAmmo()
		{
		}

		public override void TriggerBegin(int instigatorActorNr)
		{
		}

		public override void TriggerEnd()
		{
		}

		private void FireWithCharge(CustomGunData.FireMode fireMode)
		{
		}

		private void FireSemiAutomaticWithCharge()
		{
		}

		protected override EditableItemConfiguration GetDefaultConfiguration()
		{
			return null;
		}

		protected override void SetConfiguration(Dictionary<object, object> itemData)
		{
		}

		public override void OnEquip()
		{
		}

		public override void OnStateChanged(Dictionary<object, object> newState)
		{
		}

		protected override void OnPickupNewEditableItem()
		{
		}

		[IteratorStateMachine(typeof(_003CFetchFOV_003Ed__52))]
		private IEnumerator FetchFOV()
		{
			return null;
		}

		private void SoundStateUpdate()
		{
		}

		private void MuzzleStateUpdate()
		{
		}

		private void MovementSpeedStateUpdate()
		{
		}

		protected override void OnFire(bool isLocal)
		{
		}

		private Vector3 HandleBulletGenerationOnFire(bool isLocal)
		{
			return default(Vector3);
		}

		private void HandleRecoil(Vector3 direction)
		{
		}

		private void HandleFiringStateAndAmmoOnFire()
		{
		}

		private void HandleFireEffects(bool isLocal)
		{
		}

		protected void PlayFireSoundEffect(bool isLocal)
		{
		}

		protected override void OnHit(VoxelHit voxelHit, Ray lineOfFire)
		{
		}

		private void OnLocalHit(VoxelHit voxelHit, Ray lineOfFire)
		{
		}

		public override bool IsSameItemData(Dictionary<object, object> itemData)
		{
			return false;
		}

		protected override void InterruptFire()
		{
		}

		public override void OnLeaveVehicleWithWeapon()
		{
		}

		public override void OnEnterVehicleWithWeapon()
		{
		}

		[IteratorStateMachine(typeof(_003CChargeRoutine_003Ed__68))]
		private IEnumerator ChargeRoutine(int instigatorActorNr)
		{
			return null;
		}
	}
}
