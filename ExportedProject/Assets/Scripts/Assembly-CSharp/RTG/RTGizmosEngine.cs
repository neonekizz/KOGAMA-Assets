using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
	public class RTGizmosEngine : MonoSingleton<RTGizmosEngine>, IHoverableSceneEntityContainer
	{
		[SerializeField]
		private EditorToolbar _mainToolbar;

		[SerializeField]
		private GizmoEngineSettings _settings;

		private GizmosEnginePipelineStage _pipelineStage;

		private Gizmo _draggedGizmo;

		private bool _justReleasedDrag;

		private Gizmo _hoveredGizmo;

		private GizmoHoverInfo _gizmoHoverInfo;

		private List<Gizmo> _gizmos;

		private List<ISceneGizmo> _sceneGizmos;

		private List<RTSceneGizmoCamera> _sceneGizmoCameras;

		private List<Camera> _renderCameras;

		[SerializeField]
		private SceneGizmoLookAndFeel _sceneGizmoLookAndFeel;

		[SerializeField]
		private MoveGizmoSettings2D _moveGizmoSettings2D;

		[SerializeField]
		private MoveGizmoSettings3D _moveGizmoSettings3D;

		[SerializeField]
		private MoveGizmoLookAndFeel2D _moveGizmoLookAndFeel2D;

		[SerializeField]
		private MoveGizmoLookAndFeel3D _moveGizmoLookAndFeel3D;

		[SerializeField]
		private MoveGizmoHotkeys _moveGizmoHotkeys;

		[SerializeField]
		private ObjectTransformGizmoSettings _objectMoveGizmoSettings;

		[SerializeField]
		private RotationGizmoSettings3D _rotationGizmoSettings3D;

		[SerializeField]
		private RotationGizmoLookAndFeel3D _rotationGizmoLookAndFeel3D;

		[SerializeField]
		private RotationGizmoHotkeys _rotationGizmoHotkeys;

		[SerializeField]
		private ObjectTransformGizmoSettings _objectRotationGizmoSettings;

		[SerializeField]
		private ScaleGizmoSettings3D _scaleGizmoSettings3D;

		[SerializeField]
		private ScaleGizmoLookAndFeel3D _scaleGizmoLookAndFeel3D;

		[SerializeField]
		private ScaleGizmoHotkeys _scaleGizmoHotkeys;

		[SerializeField]
		private ObjectTransformGizmoSettings _objectScaleGizmoSettings;

		[SerializeField]
		private UniversalGizmoConfig _universalGizmoConfig;

		[SerializeField]
		private UniversalGizmoSettings2D _universalGizmoSettings2D;

		[SerializeField]
		private UniversalGizmoSettings3D _universalGizmoSettings3D;

		[SerializeField]
		private UniversalGizmoLookAndFeel2D _universalGizmoLookAndFeel2D;

		[SerializeField]
		private UniversalGizmoLookAndFeel3D _universalGizmoLookAndFeel3D;

		[SerializeField]
		private UniversalGizmoHotkeys _universalGizmoHotkeys;

		[SerializeField]
		private ObjectTransformGizmoSettings _objectUniversalGizmoSettings;

		public GizmoEngineSettings Settings => null;

		public GizmosEnginePipelineStage PipelineStage => default(GizmosEnginePipelineStage);

		public Camera RenderStageCamera => null;

		public bool HasHoveredSceneEntity => false;

		public bool IsAnyGizmoHovered => false;

		public Gizmo HoveredGizmo => null;

		public Gizmo DraggedGizmo => null;

		public bool JustReleasedDrag => false;

		public int NumRenderCameras => 0;

		public SceneGizmoLookAndFeel SceneGizmoLookAndFeel => null;

		public MoveGizmoSettings2D MoveGizmoSettings2D => null;

		public MoveGizmoSettings3D MoveGizmoSettings3D => null;

		public MoveGizmoLookAndFeel2D MoveGizmoLookAndFeel2D => null;

		public MoveGizmoLookAndFeel3D MoveGizmoLookAndFeel3D => null;

		public MoveGizmoHotkeys MoveGizmoHotkeys => null;

		public ObjectTransformGizmoSettings ObjectMoveGizmoSettings => null;

		public RotationGizmoSettings3D RotationGizmoSettings3D => null;

		public RotationGizmoLookAndFeel3D RotationGizmoLookAndFeel3D => null;

		public RotationGizmoHotkeys RotationGizmoHotkeys => null;

		public ObjectTransformGizmoSettings ObjectRotationGizmoSettings => null;

		public ScaleGizmoSettings3D ScaleGizmoSettings3D => null;

		public ScaleGizmoLookAndFeel3D ScaleGizmoLookAndFeel3D => null;

		public ScaleGizmoHotkeys ScaleGizmoHotkeys => null;

		public ObjectTransformGizmoSettings ObjectScaleGizmoSettings => null;

		public UniversalGizmoSettings2D UniversalGizmoSettings2D => null;

		public UniversalGizmoSettings3D UniversalGizmoSettings3D => null;

		public UniversalGizmoLookAndFeel2D UniversalGizmoLookAndFeel2D => null;

		public UniversalGizmoLookAndFeel3D UniversalGizmoLookAndFeel3D => null;

		public UniversalGizmoHotkeys UniversalGizmoHotkeys => null;

		public ObjectTransformGizmoSettings ObjectUniversalGizmoSettings => null;

		public event GizmoEngineCanDoHoverUpdateHandler CanDoHoverUpdate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void AddRenderCamera(Camera camera)
		{
		}

		public bool IsRenderCamera(Camera camera)
		{
			return false;
		}

		public void RemoveRenderCamera(Camera camera)
		{
		}

		public RTSceneGizmoCamera CreateSceneGizmoCamera(Camera sceneCamera, ISceneGizmoCamViewportUpdater viewportUpdater)
		{
			return null;
		}

		public bool IsSceneGizmoCamera(Camera camera)
		{
			return false;
		}

		public ISceneGizmo GetSceneGizmoByCamera(Camera sceneCamera)
		{
			return null;
		}

		public Gizmo CreateGizmo()
		{
			return null;
		}

		public void RemoveGizmo(Gizmo gizmo)
		{
		}

		public SceneGizmo CreateSceneGizmo(Camera sceneCamera)
		{
			return null;
		}

		public MoveGizmo CreateMoveGizmo()
		{
			return null;
		}

		public ObjectTransformGizmo CreateObjectMoveGizmo()
		{
			return null;
		}

		public RotationGizmo CreateRotationGizmo()
		{
			return null;
		}

		public ObjectTransformGizmo CreateObjectRotationGizmo()
		{
			return null;
		}

		public ScaleGizmo CreateScaleGizmo()
		{
			return null;
		}

		public ObjectTransformGizmo CreateObjectScaleGizmo()
		{
			return null;
		}

		public UniversalGizmo CreateUniversalGizmo()
		{
			return null;
		}

		public ObjectTransformGizmo CreateObjectUniversalGizmo()
		{
			return null;
		}

		public void Update_SystemCall()
		{
		}

		public GizmoHandleHoverData GetGizmoHandleHoverData(Gizmo gizmo)
		{
			return null;
		}

		public void Render_SystemCall(Camera renderCamera)
		{
		}

		private void SortHandleHoverDataCollection(List<GizmoHandleHoverData> hoverDataCollection, Vector3 inputDevicePos)
		{
		}

		private void RegisterGizmo(Gizmo gizmo)
		{
		}

		private void UnregisterGizmo(Gizmo gizmo)
		{
		}

		private void OnGUI()
		{
		}

		private void OnGizmoDragBegin(Gizmo gizmo, int handleId)
		{
		}

		private void OnGizmoDragEnd(Gizmo gizmo, int handleId)
		{
		}
	}
}
