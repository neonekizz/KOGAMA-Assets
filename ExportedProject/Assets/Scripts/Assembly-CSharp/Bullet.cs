using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private class CollisionBullet
	{
		public enum State
		{
			Moving = 0,
			Hit = 1,
			OutOfRange = 2,
			Expiring = 3
		}

		private readonly float speed;

		private readonly float range;

		private float distanceTraveled;

		private Vector3 currentPos;

		private Vector3 prevPos;

		private Ray ray;

		private readonly HashSet<int> ignoreWoIDs;

		public CollisionBullet(float range, float speed, Vector3 origin, Vector3 direction, HashSet<int> ignoreWoIDs)
		{
		}

		public State Update(out VoxelHit voxelHit)
		{
			voxelHit = default(VoxelHit);
			return default(State);
		}

		private bool DoCollisionCheck(out VoxelHit voxelHit)
		{
			voxelHit = default(VoxelHit);
			return false;
		}

		private static bool DoBulletCollision(Ray ray, out VoxelHit voxelHit, float distance, HashSet<int> ignoreWoIDs)
		{
			voxelHit = default(VoxelHit);
			return false;
		}
	}

	public delegate void OnHitDelegate(VoxelHit hit, Ray lineOfFire);

	[CompilerGenerated]
	private sealed class _003CMakeVisibleOverTime_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Bullet _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CMakeVisibleOverTime_003Ed__48(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const float MaxAllowedBulletAirTime = 20f;

	private const float ColorOverTime = 0.01f;

	public OnHitDelegate onHit;

	public OnHitDelegate onHitLocal;

	public Action<Ray> onOutOfRange;

	private PoolEnums initiatedPoolType;

	private MonoBehaviour pooledObjectReference;

	private HashSet<int> ignoreWoIDs;

	private bool isFired;

	private Ray lineOfFire;

	[SerializeField]
	private TrailRenderer trailRenderer;

	[SerializeField]
	private ParticleSystem pSystem;

	[SerializeField]
	private MeshRenderer[] meshRenderers;

	[SerializeField]
	private SpriteRenderer[] spriteRenderers;

	private CollisionBullet collisionBullet;

	private bool hit;

	private bool hasCleaned;

	private float currentAirTime;

	private float targetAirTime;

	private float maxAirTime;

	private float handToMuzzleDist;

	private Vector3 startPosition;

	private Vector3 targetPosition;

	private Color storedBulletColor;

	private Transform localTransform;

	private CullingSubscriberBase cullingSubscriberBase;

	private VoxelHit voxelHit;

	public PoolEnums InitiatedPoolType
	{
		get
		{
			return default(PoolEnums);
		}
		set
		{
		}
	}

	public MonoBehaviour PooledObjectReference
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private CollisionBullet.State UpdateBulletState()
	{
		return default(CollisionBullet.State);
	}

	private void Expire()
	{
	}

	public static Bullet CreateBullet(PoolEnums bulletType, Vector3 pos, float handToMuzzleDist = 0f)
	{
		return null;
	}

	public void SetBulletAndTrailSettings(Color bulletColor, Color trailColor, float speed, float size)
	{
	}

	public void ResetBullet()
	{
	}

	public void ReturnToPool(PoolEnums bulletType)
	{
	}

	public void Fire(float speed, float range, Ray lineOfFire, HashSet<int> ignoreWoIDs, bool thirdPersonWeapon = false)
	{
	}

	private void DoFire(float speed, float maxRange, bool thirdPersonWeapon)
	{
	}

	private void OnStateChanged(CullingGroupEvent cullingGroupEvent)
	{
	}

	private Vector3 FindTargetPos(float maxRange)
	{
		return default(Vector3);
	}

	private Ray CalculateLineOfFireFromMuzzle(float maxRange)
	{
		return default(Ray);
	}

	[IteratorStateMachine(typeof(_003CMakeVisibleOverTime_003Ed__48))]
	private IEnumerator MakeVisibleOverTime()
	{
		return null;
	}
}
