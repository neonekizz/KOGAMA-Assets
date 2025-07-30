using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class Tut_4_Mesh_and_Center_Pivots : MonoBehaviour
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

		private List<GameObject> _selectedObjects;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnGUI()
		{
		}

		private GameObject PickGameObject()
		{
			return null;
		}

		private void SetWorkGizmoId(GizmoId gizmoId)
		{
		}

		private void OnSelectionChanged()
		{
		}

		private void SetTransformSpace(GizmoSpace transformSpace)
		{
		}

		private void SetTransformPivot(GizmoObjectTransformPivot transformPivot)
		{
		}
	}
}
