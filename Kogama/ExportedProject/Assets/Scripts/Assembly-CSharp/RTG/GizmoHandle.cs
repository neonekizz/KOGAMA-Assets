using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	public class GizmoHandle : IGizmoHandle
	{
		public GizmoHandleCanHoverHandler CanHover;

		private int _id;

		private Gizmo _gizmo;

		private GizmoTransform _zoomFactorTransform;

		private Priority _genericHoverPriority;

		private Priority _hoverPriority2D;

		private Priority _hoverPriority3D;

		private List<GizmoHandleShape3D> _3DShapes;

		private List<GizmoHandleShape2D> _2DShapes;

		public int Id => 0;

		public Gizmo Gizmo => null;

		public IGizmoDragSession DragSession { get; set; }

		public Priority GenericHoverPriority => null;

		public Priority HoverPriority2D => null;

		public Priority HoverPriority3D => null;

		public int Num3DShapes => 0;

		public int Num2DShapes => 0;

		public bool Has3DShapes => false;

		public bool Has2DShapes => false;

		public bool Is2DHoverable { get; set; }

		public bool Is3DHoverable { get; set; }

		public bool Is2DVisible { get; set; }

		public bool Is3DVisible { get; set; }

		public GizmoHandle(Gizmo gizmo, int id)
		{
		}

		public float GetZoomFactor(Camera camera)
		{
			return 0f;
		}

		public void SetZoomFactorTransform(GizmoTransform transform)
		{
		}

		public void SetHoverable(bool isHoverable)
		{
		}

		public void SetVisible(bool isVisible)
		{
		}

		public Shape3D Get3DShape(int shapeIndex)
		{
			return null;
		}

		public Shape2D Get2DShape(int shapeIndex)
		{
			return null;
		}

		public void SetAll3DShapesVisible(bool visible)
		{
		}

		public void Set3DShapeVisible(int shapeIndex, bool isVisible)
		{
		}

		public bool Is3DShapeVisible(int shapeIndex)
		{
			return false;
		}

		public void Set3DShapeHoverable(int shapeIndex, bool isHoverable)
		{
		}

		public void SetAll2DShapesVisible(bool visible)
		{
		}

		public void Set2DShapeVisible(int shapeIndex, bool isVisible)
		{
		}

		public bool Is2DShapeVisible(int shapeIndex)
		{
			return false;
		}

		public void Set2DShapeHoverable(int shapeIndex, bool isHoverable)
		{
		}

		public bool Contains3DShape(Shape3D shape)
		{
			return false;
		}

		public bool Contains2DShape(Shape2D shape)
		{
			return false;
		}

		public int Add3DShape(Shape3D shape)
		{
			return 0;
		}

		public int Add2DShape(Shape2D shape)
		{
			return 0;
		}

		public void Remove3DShape(Shape3D shape)
		{
		}

		public void Remove2DShape(Shape2D shape)
		{
		}

		public void Render3DSolid()
		{
		}

		public void Render3DWire()
		{
		}

		public void Render3DSolid(int shapeIndex)
		{
		}

		public void Render3DWire(int shapeIndex)
		{
		}

		public void Render2DSolid(Camera camera)
		{
		}

		public void Render2DWire(Camera camera)
		{
		}

		public void Render2DSolid(Camera camera, int shapeIndex)
		{
		}

		public void Render2DWire(Camera camera, int shapeIndex)
		{
		}

		public GizmoHandleHoverData GetHoverData(Ray hoverRay)
		{
			return null;
		}
	}
}
