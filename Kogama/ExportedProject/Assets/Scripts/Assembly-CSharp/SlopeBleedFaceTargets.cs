using MV.WorldObject;

public struct SlopeBleedFaceTargets
{
	public int fromPrevoiusCornerTargetface;

	public int fromNextCornerTargetface;

	public SlopeBleedFaceTargets(Face pFaceTarget, Face nFaceTarget)
	{
		fromPrevoiusCornerTargetface = 0;
		fromNextCornerTargetface = 0;
	}
}
