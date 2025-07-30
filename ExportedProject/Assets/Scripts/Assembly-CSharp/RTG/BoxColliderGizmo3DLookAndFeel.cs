using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class BoxColliderGizmo3DLookAndFeel
	{
		[SerializeField]
		private Color _wireColor;

		[SerializeField]
		private GizmoCap2DLookAndFeel[] _tickLookAndFeel;

		[SerializeField]
		private GizmoCap3DLookAndFeel _midCapLookAndFeel;

		[SerializeField]
		private bool _isMidCapVisible;

		[SerializeField]
		private float _tickCullAlphaScale;

		public static Color DefaultWireColor => default(Color);

		public static Color DefaultTickColor => default(Color);

		public static float DefaultTickQuadWidth => 0f;

		public static float DefaultTickQuadHeight => 0f;

		public static float DefaultTickCircleRadius => 0f;

		public static float DefaultTickCullAlphaScale => 0f;

		public static GizmoCap2DType DefaultTickCapType => default(GizmoCap2DType);

		public static Color DefaultTickHoveredColor => default(Color);

		public static Color DefaultTickBorderColor => default(Color);

		public static Color DefaultTickHoveredBorderColor => default(Color);

		public static Color DefaultMidCapColor => default(Color);

		public static Color DefaultMidCapHoveredColor => default(Color);

		public static GizmoFillMode3D DefaultMidCapFillMode => default(GizmoFillMode3D);

		public static GizmoCap3DType DefaultMidCapType => default(GizmoCap3DType);

		public static bool DefaultMidCapVisible => false;

		public static float DefaultMidCapBoxWidth => 0f;

		public static float DefaultMidCapBoxHeight => 0f;

		public static float DefaultMidCapBoxDepth => 0f;

		public Color WireColor => default(Color);

		public Color XTickColor => default(Color);

		public Color YTickColor => default(Color);

		public Color ZTickColor => default(Color);

		public Color TickBorderColor => default(Color);

		public Color TickHoveredColor => default(Color);

		public Color TickHoveredBorderColor => default(Color);

		public GizmoCap2DType TickType => default(GizmoCap2DType);

		public float TickQuadWidth => 0f;

		public float TickQuadHeight => 0f;

		public float TickCircleRadius => 0f;

		public float TickCullAlphaScale => 0f;

		public Color MidCapColor => default(Color);

		public Color MidCapHoveredColor => default(Color);

		public GizmoFillMode3D MidCapFillMode => default(GizmoFillMode3D);

		public GizmoCap3DType MidCapType => default(GizmoCap3DType);

		public bool IsMidCapVisible => false;

		public float MidCapBoxWidth => 0f;

		public float MidCapBoxHeight => 0f;

		public float MidCapBoxDepth => 0f;

		public void SetMidCapBoxWidth(float width)
		{
		}

		public void SetMidCapBoxHeight(float height)
		{
		}

		public void SetMidCapBoxDepth(float depth)
		{
		}

		public void SetMidCapColor(Color color)
		{
		}

		public void SetMidCapHoveredColor(Color color)
		{
		}

		public void SetMidCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetMidCapType(GizmoCap3DType capType)
		{
		}

		public void SetMidCapVisible(bool visible)
		{
		}

		public List<Enum> GetAllowedMidCapTypes()
		{
			return null;
		}

		public bool IsMidCapTypeAllowed(GizmoCap3DType capType)
		{
			return false;
		}

		public List<Enum> GetAllowedTickTypes()
		{
			return null;
		}

		public bool IsTickTypeAllowed(GizmoCap2DType tickType)
		{
			return false;
		}

		public void SetBoxWireColor(Color color)
		{
		}

		public void SetTickCullAlphaScale(float alphaScale)
		{
		}

		public void SetTickColor(int axisIndex, Color color)
		{
		}

		public void SetAllTicksColor(Color color)
		{
		}

		public void SetTickBorderColor(Color color)
		{
		}

		public void SetTickHoveredColor(Color color)
		{
		}

		public void SetTickHoveredBorderColor(Color color)
		{
		}

		public void SetTickType(GizmoCap2DType tickType)
		{
		}

		public void SetTickQuadWidth(float width)
		{
		}

		public void SetTickQuadHeight(float height)
		{
		}

		public void SetTickCircleRadius(float radius)
		{
		}

		public void ConnectTickLookAndFeel(GizmoCap2D tick, int axisIndex, AxisSign axisSign)
		{
		}

		public void ConnectMidCapLookAndFeel(GizmoCap3D midCap)
		{
		}

		private GizmoCap2DLookAndFeel GetTickLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}
	}
}
