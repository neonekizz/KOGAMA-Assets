using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class TerrainGizmo : GizmoBehaviour
	{
		[Flags]
		public enum TargetTypeFlags
		{
			Terrain = 1,
			ObjectsInRadius = 2,
			All = 3
		}

		private class RadiusTick
		{
			public GizmoCap2D Tick;

			public Vector3 DragAxis;

			public Vector3 WorldPosition;
		}

		private class ObjectRotationData
		{
			public bool RotatingObjects;

			public List<GameObject> GameObjects;

			public List<LocalTransformSnapshot> PreSnapshots;
		}

		private struct Patch
		{
			public int MinCol;

			public int MaxCol;

			public int MinDepth;

			public int MaxDepth;

			public void Clamp(int heightmapRes)
			{
			}
		}

		private TargetTypeFlags _targetTypeFlags;

		private bool _isSnapEnabled;

		private bool _isVisible;

		private Terrain _targetTerrain;

		private TerrainCollider _terrainCollider;

		private float[,] _terrainHeights;

		private float[,] _preChangeTerrainHeights;

		private float _radius;

		private AnimationCurve _elevationCurve;

		private ObjectRotationData _objectRotationData;

		private SceneOverlapFilter _sceneOverlapFilter;

		private Patch _editPatch;

		private List<Vector3> _modelRadiusCirclePoints;

		private List<Vector3> _radiusCirclePoints;

		private HashSet<GameObject> _affectedObjectsSet;

		private List<TerrainGizmoAffectedObject> _affectedObjects;

		private List<LocalTransformSnapshot> _preChangeTransformSnapshots;

		private Vector3 _preChangeGizmoPos;

		private List<GameObject> _objectsInRadius;

		private GizmoLineSlider3D _axisSlider;

		private GizmoCap3D _midCap;

		private RadiusTick _leftRadiusTick;

		private RadiusTick _rightRadiusTick;

		private RadiusTick _backRadiusTick;

		private RadiusTick _forwardRadiusTick;

		private GizmoSglAxisOffsetDrag3D _radiusDrag;

		private GizmoUniformScaleDrag3D _dummyDrag;

		private TerrainGizmoLookAndFeel _lookAndFeel;

		private TerrainGizmoLookAndFeel _sharedLookAndFeel;

		private TerrainGizmoSettings _settings;

		private TerrainGizmoSettings _sharedSettings;

		private TerrainGizmoHotkeys _hotkeys;

		private TerrainGizmoHotkeys _sharedHotkeys;

		private List<GameObject> _objectCollectRadius;

		public TerrainGizmoLookAndFeel LookAndFeel => null;

		public TerrainGizmoLookAndFeel SharedLookAndFeel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TerrainGizmoSettings Settings => null;

		public TerrainGizmoSettings SharedSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TerrainGizmoHotkeys Hotkeys => null;

		public TerrainGizmoHotkeys SharedHotkeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Terrain TargetTerrain => null;

		public float Radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimationCurve ElevationCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsSnapEnabled => false;

		public bool IsRotatingObjects => false;

		public TargetTypeFlags TargetTypes
		{
			get
			{
				return default(TargetTypeFlags);
			}
			set
			{
			}
		}

		public bool HasTerrainTarget => false;

		public bool HasObjectsInRadiusTarget => false;

		public void SetSnapEnabled(bool enabled)
		{
		}

		public void SetTargetTerrain(Terrain terrain)
		{
		}

		public override void OnAttached()
		{
		}

		public override void OnDisabled()
		{
		}

		public override void OnEnabled()
		{
		}

		public override void OnGizmoUpdateBegin()
		{
		}

		public override bool OnGizmoCanBeginDrag(int handleId)
		{
			return false;
		}

		public override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
		}

		public override void OnGizmoDragUpdate(int handleId)
		{
		}

		public override void OnGizmoDragEnd(int handleId)
		{
		}

		public override void OnGizmoRender(Camera camera)
		{
		}

		private bool CanObjectBeMovedHrz(GameObject go)
		{
			return false;
		}

		private bool CanObjectBeMovedVert(GameObject go)
		{
			return false;
		}

		private bool CanObjectBeRotated(GameObject go)
		{
			return false;
		}

		private RadiusTick GetRadiusTickFromHandleId(int handleId)
		{
			return null;
		}

		private void OnUndoRedoPerformed(IUndoRedoAction action)
		{
		}

		private float GetTerrainYPos()
		{
			return 0f;
		}

		private void ProjectGizmoOnTerrain()
		{
		}

		private void DragObjectsWithMidCap()
		{
		}

		private void OffsetTerrainPatch(float offset)
		{
		}

		private void OffsetObjectsInRadius(float offset)
		{
		}

		private void CollectObjectsInRadius(List<GameObject> objectsInRadius)
		{
		}

		private bool IsObjectInRadius(GameObject gameObject)
		{
			return false;
		}

		private void UpdateTicks()
		{
		}

		private Vector3 GetRadiusCircleMinExtents()
		{
			return default(Vector3);
		}

		private Vector3 GetRadiusCircleMaxExtents()
		{
			return default(Vector3);
		}

		private void SnapGizmoToTerrain()
		{
		}

		private bool IsTargetReady()
		{
			return false;
		}

		private void SetupSharedLookAndFeel()
		{
		}

		private void SetVisible(bool visible)
		{
		}
	}
}
