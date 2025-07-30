using UnityEngine;

public class PlayModeOnlyStateMachine : FSMEntity
{
	private readonly MainCameraManager weCamera;

	private readonly GameObject gameObject;

	public MainCameraManager MainCameraManager => null;

	public PlayModeOnlyEvent CurEvent => default(PlayModeOnlyEvent);

	public PlayModeOnlyEvent PrevEvent => default(PlayModeOnlyEvent);

	public PlayModeOnlyEvent NextEvent => default(PlayModeOnlyEvent);

	public GameObject GameObject => null;

	public PlayModeOnlyStateMachine(GameObject gameObject)
	{
	}

	public override void Update()
	{
	}
}
