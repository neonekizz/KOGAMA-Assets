using System.Collections.Generic;
using UnityEngine;

public class TimeAttackFlagDebriefingCamera : MVCameraBase
{
	[SerializeField]
	private Vector3 offset;

	[SerializeField]
	private float height;

	private Transform flagTransform;

	private HashSet<int> ignoreAvatarId;

	private MVAvatarLocal avatarLocal;

	public override CameraType CameraType => default(CameraType);

	public void Initialize(MVAvatarLocal avatarLocal)
	{
	}

	public override void Enter(MVCameraController camController)
	{
	}

	public override void Exit(MVCameraController camController)
	{
	}

	public override void Reset()
	{
	}

	public override void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}

	private Vector3 PositionAfterCollision(Vector3 desiredPosition, Vector3 moveToPosition)
	{
		return default(Vector3);
	}

	private Vector3 GetLookAtPosition()
	{
		return default(Vector3);
	}

	private Transform GetClosestTimeAttackFlag()
	{
		return null;
	}
}
