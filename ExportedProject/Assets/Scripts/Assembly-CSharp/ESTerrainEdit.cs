internal class ESTerrainEdit : ESStateBase
{
	private MVCubeModelPrototypeTerrain terrain;

	public override void Enter(EditorStateMachine e)
	{
	}

	public override void Execute(EditorStateMachine esm)
	{
	}

	private bool SelectedObject(EditorStateMachine esm, VoxelHit targetHit, bool woPickSuccess, bool selectionAllowedByLogicEnabled)
	{
		return false;
	}

	private bool SelectedObjectLink(EditorStateMachine esm, bool didHitObject, float hitDistance)
	{
		return false;
	}

	private bool ResettingTerrain(VoxelHit targetHit)
	{
		return false;
	}

	public override void Exit(EditorStateMachine e)
	{
	}
}
