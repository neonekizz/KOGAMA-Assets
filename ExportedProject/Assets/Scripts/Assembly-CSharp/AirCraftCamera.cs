using UnityEngine;

public class AirCraftCamera : MVPlaymodeCameraBase
{
	public Transform lookAt;

	private float baseDistanceFromLookAt;

	private Vector3 initialLocalCamPosition;

	private Vector3 lookAtToCamDir;

	public override CameraType CameraType => default(CameraType);

	public override void Enter(MVCameraController camController)
	{
	}

	public override void UpdateCamera(MVCameraController camController, ProtectedTransform targetTransform)
	{
	}

	protected override void CameraCollision()
	{
	}

	private void UpdateCameraPosition()
	{
	}
}
