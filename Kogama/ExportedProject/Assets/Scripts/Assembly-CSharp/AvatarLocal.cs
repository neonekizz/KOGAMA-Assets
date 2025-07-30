using UnityEngine;

public class AvatarLocal : Avatar
{
	private IAvatarCameraController avatarCameraController;

	[SerializeField]
	private AvatarCamerasTouch avatarCamerasMobile;

	[SerializeField]
	private AvatarCamerasDesktop avatarCamerasDesktop;

	[SerializeField]
	private AudioListener audioListener;

	public IAvatarCameraController CameraController => null;

	public override void Initialize(MVAvatar mvAvatar, bool isLocal)
	{
	}

	private void OnDestroy()
	{
	}

	private void PrewarmXPParticles()
	{
	}

	private void CreateXPParticlesWithLayer(int xp, int layer)
	{
	}

	public void OnXpProgressing(int xp)
	{
	}

	public void ToggleAudioListener(bool on)
	{
	}
}
