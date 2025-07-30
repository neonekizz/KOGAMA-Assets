using System.Collections.Generic;
using MV.WorldObject;
using UnityEngine;

public class AdvancedGhostBodyRotateWeapon : MonoBehaviour
{
	private const float Damage = 55f;

	private const float ImpulseStrength = 2500f;

	private float factor;

	private readonly TimeoutMap timeoutMap;

	private AudioSource weaponHitSound;

	public MVTeam alliedTeam;

	private readonly List<AdvancedGhostTriggerBase> ghostTriggers;

	public MVTeam AlliedTeam
	{
		get
		{
			return default(MVTeam);
		}
		set
		{
		}
	}

	public void SetAttackValueFactor(float attackFactor)
	{
	}

	public void Init(AudioSource hitSound, MVCubeModelBase body)
	{
	}

	private void body_Changed(CubeModelChangedEventArgs e)
	{
	}

	private void SetupWeaponCollision()
	{
	}

	private void Update()
	{
	}

	private void Attack(int woid)
	{
	}
}
