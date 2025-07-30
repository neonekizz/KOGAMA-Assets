using UnityEngine;

public class AvatarInputControllerTouch : IAvatarInputController, IMotorAPI
{
	private Vector3 direction;

	private Quaternion rotation;

	private bool jump;

	private AvatarInputControllerTouchSettings settings;

	private static Camera mainCamera;

	public Vector3 Direction
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion Rotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public bool Jump => false;

	public void HandleDead()
	{
	}

	public void HandleInput(Vector3 moveDirection, bool jump, bool didShoot, Vector3 velocity, bool inGunMode, bool forceRotateToCamDirection)
	{
	}

	private Vector3 GetDirectionBias(Vector3 absolutDirection)
	{
		return default(Vector3);
	}

	private Vector3 GetBiasedDirection(Vector3 absoluteDirection, Vector3 testDirection)
	{
		return default(Vector3);
	}

	private static Vector3 ToCameraDirection(Vector3 moveDirection)
	{
		return default(Vector3);
	}

	private static Quaternion GetCameraYRotation()
	{
		return default(Quaternion);
	}

	private static Quaternion GetRotationMoveDirection(Vector3 moveDirection)
	{
		return default(Quaternion);
	}
}
