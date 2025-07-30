using System;
using System.Collections.Generic;
using UnityEngine;

public class AvatarLimbManagerLocal : AvatarLimbManager
{
	private class AvatarEmoteHandlerLocal : AvatarEmoteHandler
	{
		private Dictionary<EmoteTypes, AvatarEmoteRecogniser> emoteRecognisers;

		protected override void CreateLimbEvents(AvatarLimbManager limbManager, AvatarLookDirectionHandler lookDirectionHandler, AvatarPointingHandler pointingHandler, AvatarHeadRotationHandler headRotationHandler, LimbRotator limbRotator)
		{
		}

		public override void UpdateEmotes()
		{
		}

		private void OnShakeEmoteStart()
		{
		}

		private void OnNodEmoteStart()
		{
		}

		private void OnWaveEmoteStart()
		{
		}

		public void StartEmoteAndNetworkIt(EmoteTypes emoteType)
		{
		}
	}

	private class AvatarEmoteRecogniser
	{
		public Action OnStartEvent;

		private bool isActive;

		private float angleSensitivity;

		private float previousAngle;

		private short eventRecognitioner;

		private short recognitionsBeforeEvent;

		private float resetInterval;

		private float resetCooldown;

		private short startModulusOffset;

		private const float maxRotationMovement = 45f;

		public void Initlialize(AvatarLimbManager limbManager, float angleSensitivity, float resetInterval, short recognitionsBeforeEvent, bool shouldRecognisePositiveAngleFirst, bool isActive)
		{
		}

		public void HandleNewAngle(float angle)
		{
		}

		private void HandleRecognition(float newAngle, float previousAngle, bool checkPositiveRotation)
		{
		}

		private bool IsRotationPositive(float newAngle, float previousAngle)
		{
			return false;
		}

		private bool IsEventRecognitionDone()
		{
			return false;
		}

		public void Update()
		{
		}

		private void ResetRecognition()
		{
		}

		public void SetIsActive(bool shouldBeActive)
		{
		}

		public void Deactivate()
		{
		}

		public void Activate()
		{
		}
	}

	public struct HeadRotationCalculationResult
	{
		public Quaternion YawRotation;

		public Quaternion PitchRotation;

		public bool ShouldLean;
	}

	public class AvatarHeadRotationCalculator
	{
		private const float maxYaw = 90f;

		private const float maxPitch = 45f;

		private const float cameraPitchOffset = 40f;

		private const float maxCameraPitch = 80f;

		private const float yawDeadzone = 135f;

		private bool shouldLean;

		public HeadRotationCalculationResult CalculateHeadRotation(Vector3 localLookDirection)
		{
			return default(HeadRotationCalculationResult);
		}

		private Quaternion GetClampedYawRotation(Vector3 localDirection)
		{
			return default(Quaternion);
		}

		private Quaternion GetClampedPitchRotation(Vector3 localDirection)
		{
			return default(Quaternion);
		}

		private float HandleCameraPitchOffset(float pitch)
		{
			return 0f;
		}

		private float HandleYawDeadZone(float yaw)
		{
			return 0f;
		}
	}

	private class AvatarHeadRotationHandlerLocal : AvatarHeadRotationHandler
	{
		private const float networkMessageInterval = 1f;

		private float networkMessageCooldown;

		private bool shouldSendNetworkMessage;

		private Quaternion yawRotation;

		private Quaternion pitchRotation;

		public Action<Quaternion> OnUpdateHeadRotationValue;

		public override void UpdateRotation()
		{
		}

		public override void Initialize(AvatarLimbManager limbManager, LimbRotator limbRotator, AvatarLookDirectionHandler lookDirectionHandler)
		{
		}

		private void UpdateNetworkMessage(Quaternion rotation)
		{
		}

		public void ResetNetworkMessageCooldown(float networkMessageDelay)
		{
		}

		public void HandleResult(HeadRotationCalculationResult result)
		{
		}

		protected void HandleOnRotationChange()
		{
		}
	}

	private class AvatarLimbDataManagerLocal
	{
		private LimbRotationRuntimeData limbRotationRuntimeData;

		public void Initialize(LimbRotationRuntimeData limbRotationRuntimeData)
		{
		}

		public void SynchronizeHeadRotationUpdate(Quaternion newHeadRotation)
		{
		}

		public void SynchronizePointRotationUpdate(Quaternion newPointRotation)
		{
		}

		public void SynchronizeHasHandEquippableUpdate(bool newIsPoingtingWeaponValue)
		{
		}

		public void SynchronizeEmoteUpdate(int newEmote)
		{
		}
	}

	private class AvatarPointingHandlerLocal : AvatarPointingHandler
	{
		private float networkMessageCooldown;

		private Quaternion yawRotation;

		private Quaternion pitchRotation;

		private PointState storedState;

		private const float lArmYawRotationOffset = -30f;

		private const float rArmYawRotationOffset = 20f;

		public Action<bool> OnIsPointingChange;

		public Action<bool> OnHasHandEquippableItemChange;

		public Action<Quaternion> OnUpdatePointingValue;

		public Vector3 PointingDirection => default(Vector3);

		public void StartPointing()
		{
		}

		public void StartPointingWeapon()
		{
		}

		public void StartPointingWeaponOnlyNetworked()
		{
		}

		public void SetHandEquipableItem(bool hasHandEquipableItem)
		{
		}

		public override void UpdatePointing(Vector3 localLookDirection)
		{
		}

		private void UpdateNetworkMessage(Quaternion rotation)
		{
		}

		public void ResetNetworkMessageDelay(float networkMessageDelay)
		{
		}

		public void HandleResult(PointingRotationCalculationResult result)
		{
		}

		private Quaternion ApplyYawOffset(Quaternion newYawRotation)
		{
			return default(Quaternion);
		}
	}

	public struct PointingRotationCalculationResult
	{
		public Quaternion YawRotation;

		public Quaternion PitchRotation;

		public bool ShouldPoint;
	}

	public class AvatarPointingRotationCalculator
	{
		private const float smallOffset = 0.5f;

		private const float minYaw = -80f;

		private const float maxYaw = 130f;

		private const float minPitch = -90f;

		private const float maxPitch = 90f;

		public float previousYawRotation;

		public PointingRotationCalculationResult CalculateRotation(Vector3 pointingDirection)
		{
			return default(PointingRotationCalculationResult);
		}

		private Quaternion GetClampedYawRotation(Vector3 localDirection)
		{
			return default(Quaternion);
		}

		private Quaternion GetClampedPitchRotation(Vector3 localDirection)
		{
			return default(Quaternion);
		}
	}

	private AvatarHeadRotationHandlerLocal headRotationHandler;

	private AvatarHeadRotationCalculator headRotationCalculator;

	private AvatarPointingHandlerLocal pointingHandler;

	private AvatarPointingRotationCalculator pointingRotationCalculator;

	private AvatarLimbDataManagerLocal dataManager;

	public Action<float> DelayHeadRotationNetworkMessage;

	public Action<float> DelayPointingNetworkMessage;

	public override void Initialize(MVWorldObjectClient avatarWO, MVBody body, AvatarEnabledChangeHandler enabledChangeHandler, LimbRotationRuntimeData limbRotationRuntimeData)
	{
	}

	public override void UpdateLimbRotations(Vector3 lookDirection)
	{
	}

	public override void StartEmote(EmoteTypes emoteType)
	{
	}

	public void StartPointing()
	{
	}

	public void StartPointingWeapon()
	{
	}

	public void StartPointingWeaponOnlyNetworked()
	{
	}

	public void SetHandEquippableItem(bool value)
	{
	}

	private void OnShakeChatCommand()
	{
	}

	private void OnNodChatCommand()
	{
	}

	private void OnWaveChatCommand()
	{
	}

	private void SynchronizeHeadRotation(Quaternion newHeadRotation)
	{
	}

	private void SynchronizePointing(Quaternion newPointRotation)
	{
	}

	private void SynchronizeHasHandEquippableValue(bool newHasHandEquippableItemValue)
	{
	}

	private void SynchronizeEmote(int newEmote)
	{
	}
}
