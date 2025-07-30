using System.Collections.Generic;
using UnityEngine;
using WorldObjectTypes.HoverCraft.Shared;

public class HoverCraftVisualization : VehicleVisualizationBase
{
	public struct HoverCraftVisualizationSettings
	{
		public bool useThruster;

		public float thrustersSize;

		public ThrustersColor thrustersColor;
	}

	public Transform hoverCraftHullRoot;

	public ParticleSystem damageSmokeEmitter;

	public ParticleSystem fire;

	public VehicleBlinker vehicleBlinker;

	private const bool DefaultUseThrusters = true;

	private bool useThrusters;

	public List<HoverCraftThruster> hoverCraftThrusters;

	public const float DefaultThrusterSize = 0.872f;

	public const float MinThrusterSize = 0.2f;

	public const float MaxThrusterSize = 0.95f;

	private float thrustersSize;

	public static readonly ThrustersColor DefaultThrustersColor;

	private Gradient thrustersColor;

	public AudioSource moving;

	public float HoverPeriod;

	public float HoverAmplitude;

	public float rotateRollFactor;

	public float rollSpeed;

	public float rollMax;

	public float pitchMax;

	public float pitchSpeedTime;

	public float pitchFactor;

	public float damageParticleFactor;

	private readonly Vector3 hoverOffset;

	private float angleDiff;

	private Quaternion prevWorldRot;

	private float maxHealth;

	private float prevHealth;

	private bool vehicleIsUnoccupied;

	private float unoccupiedTime;

	private const float VehicleAboutToBeRemovedTime = 3f;

	private Vector3 prevWorldPosition;

	private const float MinVolume = 0.03f;

	private float smoothMoveSpeed;

	private float smoothPitchFactor;

	private const float SmoothMoveSpeedTime = 5f;

	private Vector3 smoothVelocity;

	private float moveSpeed;

	private float smoothAcceleration;

	private float signedAcceleration;

	private VehicleSeatManager vehicleSeatManager;

	private Vector3 localHoverCraftHullRootBasePosition;

	private void Awake()
	{
	}

	public void Init(Transform hoverCraftHull, VehicleSeatManager vsm, float maxHealthVal, MVRuntimeDataVariableClampedFloat health, bool inSpawner, HoverCraftVisualizationSettings hoverCraftVisualizationSettings)
	{
	}

	private void OnEnable()
	{
	}

	private void ActivateThrusters()
	{
	}

	private void OnDisable()
	{
	}

	private void OnHealthChange(float newHealth)
	{
	}

	private void Update()
	{
	}

	private void HandleUnoccupiedVehicle()
	{
	}

	private void PassiveAnim()
	{
	}

	private void AnimateHullInertia()
	{
	}

	private void CalculateMovementValues()
	{
	}

	private void AnimateHullSpeed()
	{
	}

	private void HandleSound()
	{
	}

	public void UpdateSettings(HoverCraftVisualizationSettings hoverCraftVisualizationSettings)
	{
	}

	private static Gradient CreateGradient(ThrustersColor thrustersColor)
	{
		return null;
	}
}
