using UnityEngine;
using WorldObjectTypes.VehicleEnergy;

public abstract class SimpleVehicleMotorBase : MVRigidBody
{
	private ImpactState impactState;

	protected MVMovableMotorState movableMotorState;

	protected MVInteractableBase interactableLocal;

	protected SmoothCharacterController smoothController;

	protected StuckEvaluator stuckEvaluator;

	protected VehicleEnergyContainer vehicleEnergyContainer;

	protected const float WaterProximityThreshold = 0.01f;

	protected const float WaterDownVelocity = 50f;

	protected const float WaterOffset = -0.6f;

	protected const float MaxUnderWaterYMovement = 40f;

	public Vector3 DirectInputMoveMap;

	public bool Jump;

	public bool HandleInput;

	protected MvCharacterController Controller => null;

	public IVehicleCamera VehicleCamera { protected get; set; }

	public override bool Grounded => false;

	public virtual void Init(SmoothCharacterController smoothController, VehicleInteractable interactableLocalParam, VehicleEnergyContainerConfig vehicleEnergyContainerConfig)
	{
	}

	public virtual void OnLocalVehicleLeave()
	{
	}

	public virtual void OnLocalVehicleEnter()
	{
	}

	public bool IsStuck()
	{
		return false;
	}

	public abstract void VehicleUpdateFunction();

	public override void Reset()
	{
	}

	protected override void SuspendImpactDamage()
	{
	}

	public void UpdateFunction()
	{
	}

	protected float WaterProximity()
	{
		return 0f;
	}

	protected static Vector3 ApplyWaterGravity(Vector3 velocity, float waterProximity, float deltaTime)
	{
		return default(Vector3);
	}

	protected void DealImpactDamage(Vector3 curVelocity, Vector3 prevVelocity)
	{
	}

	protected void Move(Vector3 velocity, Vector3 baseVelocity, float deltaTime)
	{
	}

	public void RefillEnergy(VehicleEnergyRefill vehicleEnergyRefill)
	{
	}

	public bool UsesEnergy()
	{
		return false;
	}

	public void RollbackRefillEnergyPrediction(int spawnerId)
	{
	}
}
