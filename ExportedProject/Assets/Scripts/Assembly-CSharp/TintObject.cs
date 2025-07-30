using MV.WorldObject;
using UnityEngine;

public abstract class TintObject : MonoBehaviour
{
	public abstract void Tint(Color c);

	public virtual void TeamTint(MVTeam team)
	{
	}

	public virtual void Tint(float r, float g, float b, float a = 1f)
	{
	}
}
