using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace RTG
{
	public class RTGApp : MonoSingleton<RTGApp>, IRLDApplication
	{
		private Camera _renderCamera;

		private RenderPipelineId _renderPipelineId;

		public RenderPipelineId RenderPipelineId => default(RenderPipelineId);

		public Camera RenderCamera => null;

		public event RTGAppInitializedHandler Initialized
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

		private void OnCanCameraUseScrollWheel(YesNoAnswer answer)
		{
		}

		private void OnCanCameraProcessInput(YesNoAnswer answer)
		{
		}

		private void OnCanUndoRedo(UndoRedoOpType undoRedoOpType, YesNoAnswer answer)
		{
		}

		private void OnCanDoGizmoHoverUpdate(YesNoAnswer answer)
		{
		}

		private void OnViewportsCameraAdded(Camera camera)
		{
		}

		private void OnViewportCameraRemoved(Camera camera)
		{
		}

		private void Start()
		{
		}

		private void DetectRenderPipeline()
		{
		}

		private void Update()
		{
		}

		private void OnRenderObject()
		{
		}

		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		private void OnDisable()
		{
		}
	}
}
