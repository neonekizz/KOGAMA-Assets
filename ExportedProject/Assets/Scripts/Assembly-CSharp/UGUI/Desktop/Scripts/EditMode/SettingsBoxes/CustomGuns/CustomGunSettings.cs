using System.Collections.Generic;
using Assets.UGUI.Desktop.Scripts.EditMode.SettingsBoxes;
using UnityEngine;
using UnityEngine.UI;

namespace UGUI.Desktop.Scripts.EditMode.SettingsBoxes.CustomGuns
{
	public class CustomGunSettings : SettingsUI
	{
		[Space(10f)]
		[Header("Gun settings serialized fields")]
		[SerializeField]
		private GameObject chargeSettingsContent;

		[SerializeField]
		private GameObject projectileSettingsContent;

		[SerializeField]
		[Space(20f)]
		private SettingsInputField nameInputField;

		[SerializeField]
		[Space(10f)]
		private SettingsToggle muzzleFlareOnFireToggle;

		[SerializeField]
		private SettingsToggle thirdPersonCameraToggle;

		[SerializeField]
		private SettingsToggle smokeOnFireToggle;

		[Space(10f)]
		[SerializeField]
		private SettingsDropdown fireModeDropdown;

		[SerializeField]
		private SettingsDropdown fireSoundEffectDropdown;

		[SerializeField]
		[Space(10f)]
		private SettingsInputFieldSlider weaponDamageInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider maxAmmoInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider impulseStrengthInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider recoilStrengthInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider attackAnimationInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider attackCooldownInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider spreadInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider movementSpeedInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider shotsPerBurstInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider burstCooldownBetweenShotsInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider projectilesPerShotInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider muzzleFlareSizeInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider fireSoundVolumeInputSlider;

		[Space(10f)]
		[SerializeField]
		private Image muzzleFlareColorImage;

		[SerializeField]
		[Space(10f)]
		[Header("Charge settings serialized fields")]
		[Space(20f)]
		private SettingsToggle chargeEnabledToggle;

		[SerializeField]
		private SettingsToggle chargeParticlesToggle;

		[SerializeField]
		private SettingsToggle chargeZoomToggle;

		[SerializeField]
		[Space(10f)]
		private SettingsDropdown chargeSoundEffectDropdown;

		[SerializeField]
		[Space(10f)]
		private SettingsInputFieldSlider chargeTimeInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider chargeSoundVolumeInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider chargeZoomAmmountInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider chargeParticlesSizeInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider chargeZoomTimeInputSlider;

		[SerializeField]
		[Space(10f)]
		private Image chargeParticlesColorImage;

		[Space(10f)]
		[SerializeField]
		[Space(20f)]
		[Header("Projectile settings serialized fields")]
		private SettingsToggle sparksOnHitToggle;

		[Space(10f)]
		[SerializeField]
		private SettingsDropdown hitSoundEffectDropdown;

		[SerializeField]
		[Space(10f)]
		private SettingsInputFieldSlider rangeInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider projectileSpeedInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider projectileSizeInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider hitSoundVolumeInputSlider;

		[SerializeField]
		private SettingsInputFieldSlider sparksSizeInputSlider;

		[Space(10f)]
		[SerializeField]
		private Image projectileColorImage;

		[SerializeField]
		private Image projectileTrailColorImage;

		[SerializeField]
		private Image sparksColorImage;

		[Space(10f)]
		[SerializeField]
		private CustomItemAudioPlayer fireAudioPlayer;

		[SerializeField]
		private CustomItemAudioPlayer chargeAudioPlayer;

		[SerializeField]
		private CustomItemAudioPlayer hitAudioPlayer;

		protected override Vector2 NormalEditingCanvasSize => default(Vector2);

		protected Vector2 ChargeSettingsCanvasSize => default(Vector2);

		protected Vector2 ProjectileSettingsCanvasSize => default(Vector2);

		protected override Dictionary<object, object> DefaultItemData => null;

		public override void Initialize(int woID, GameObject root)
		{
		}

		public override void OnSettingChanged(string key, object value)
		{
		}

		private void OnSettingsChangedStateUpdate()
		{
		}

		protected override Dictionary<object, object> ReadWorldObjectItemData(Dictionary<object, object> woData)
		{
			return null;
		}

		public override void OnColorPressed(string colorKey)
		{
		}

		public override void OnColorEdited()
		{
		}

		public void OnChargeSettingsOpen()
		{
		}

		public void OnChargeSettingsClose()
		{
		}

		public void OnProjectileSettingsOpen()
		{
		}

		public void OnProjectileSettingsClose()
		{
		}

		public void OnClickPreviewSound(string soundCategory, int index)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
