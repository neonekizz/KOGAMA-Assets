using UnityEngine;

namespace RTG
{
	public class Tut_1_Enabling_and_Disabling_Gizmos : MonoBehaviour
	{
		private enum GizmoId
		{
			Move = 1,
			Rotate = 2,
			Scale = 3,
			Universal = 4
		}

		private ObjectTransformGizmo _objectMoveGizmo;

		private ObjectTransformGizmo _objectRotationGizmo;

		private ObjectTransformGizmo _objectScaleGizmo;

		private ObjectTransformGizmo _objectUniversalGizmo;

		private GizmoId _workGizmoId;

		private ObjectTransformGizmo _workGizmo;

		private GameObject _targetObject;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private GameObject PickGameObject()
		{
			return null;
		}

		private void SetWorkGizmoId(GizmoId gizmoId)
		{
		}

		private void OnTargetObjectChanged(GameObject newTargetObject)
		{
		}
	}
}
