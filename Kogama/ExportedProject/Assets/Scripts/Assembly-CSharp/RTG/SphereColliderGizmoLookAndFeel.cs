using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class SphereColliderGizmoLookAndFeel
	{
		[SerializeField]
		private Color _sphereBorderColor;

		[SerializeField]
		private GizmoCap2DLookAndFeel[] _tickLookAndFeel;

		[SerializeField]
		private Color _wireColor;

		[SerializeField]
		private float _axialCircleCullAlphaScale;

		[SerializeField]
		private float _tickCullAlphaScale;

		public static Color DefaultSphereBorderColor => default(Color);

		public static Color DefaultWireColor => default(Color);

		public static float DefaultAxialCircleCullAlphaScale => 0f;

		public static Color DefaultTickColor => default(Color);

		public static float DefaultTickQuadWidth => 0f;

		public static float DefaultTickQuadHeight => 0f;

		public static float DefaultTickCircleRadius => 0f;

		public static float DefaultTickCullAlphaScale => 0f;

		public static GizmoCap2DType DefaultTickCapType => default(GizmoCap2DType);

		public static Color DefaultTickHoveredColor => default(Color);

		public static Color DefaultTickBorderColor => default(Color);

		public static Color DefaultTickHoveredBorderColor => default(Color);

		public Color SphereBorderColor => default(Color);

		public Color WireColor => default(Color);

		public float AxialCircleCullAlphaScale => 0f;

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

		public List<Enum> GetAllowedTickTypes()
		{
			return null;
		}

		public bool IsTickTypeAllowed(GizmoCap2DType tickType)
		{
			return false;
		}

		public void SetSphereBorderColor(Color color)
		{
		}

		public void SetWireColor(Color color)
		{
		}

		public void SetAxialCircleCullAlphaScale(float scale)
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

		private GizmoCap2DLookAndFeel GetTickLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}
	}
}
