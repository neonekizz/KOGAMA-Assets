using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class SpotLightGizmo3DLookAndFeel
	{
		[SerializeField]
		private Color _wireColor;

		[SerializeField]
		private GizmoCap2DLookAndFeel _tickLookAndFeel;

		[SerializeField]
		private GizmoCap2DLookAndFeel _dirSnapTickLookAndFeel;

		[SerializeField]
		private Color _dirSnapSegmentColor;

		public static Color DefaultWireColor => default(Color);

		public static Color DefaultTickColor => default(Color);

		public static float DefaultTickQuadWidth => 0f;

		public static float DefaultTickQuadHeight => 0f;

		public static float DefaultTickCircleRadius => 0f;

		public static GizmoCap2DType DefaultTickCapType => default(GizmoCap2DType);

		public static Color DefaultTickHoveredColor => default(Color);

		public static Color DefaultTickBorderColor => default(Color);

		public static Color DefaultTickHoveredBorderColor => default(Color);

		public static Color DefaultDirSnapSegmentColor => default(Color);

		public static Color DefaultDirSnapTickColor => default(Color);

		public static float DefaultDirSnapTickQuadWidth => 0f;

		public static float DefaultDirSnapTickQuadHeight => 0f;

		public static float DefaultDirSnapTickCircleRadius => 0f;

		public static GizmoCap2DType DefaultDirSnapTickCapType => default(GizmoCap2DType);

		public static Color DefaultDirSnapTickHoveredColor => default(Color);

		public static Color DefaultDirSnapTickBorderColor => default(Color);

		public static Color DefaultDirSnapTickHoveredBorderColor => default(Color);

		public Color WireColor => default(Color);

		public Color DirSnapSegmentColor => default(Color);

		public Color DirSnapTickBorderColor => default(Color);

		public Color DirSnapTickHoveredColor => default(Color);

		public Color DirSnapTickHoveredBorderColor => default(Color);

		public GizmoCap2DType DirSnapTickType => default(GizmoCap2DType);

		public float DirSnapTickQuadWidth => 0f;

		public float DirSnapTickQuadHeight => 0f;

		public float DirSnapTickCircleRadius => 0f;

		public Color TickBorderColor => default(Color);

		public Color TickHoveredColor => default(Color);

		public Color TickHoveredBorderColor => default(Color);

		public GizmoCap2DType TickType => default(GizmoCap2DType);

		public float TickQuadWidth => 0f;

		public float TickQuadHeight => 0f;

		public float TickCircleRadius => 0f;

		public void SetWireColor(Color color)
		{
		}

		public void SetTickColor(Color color)
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

		public List<Enum> GetAllowedTickTypes()
		{
			return null;
		}

		public bool IsTickTypeAllowed(GizmoCap2DType tickType)
		{
			return false;
		}

		public void SetDirSnapSegmentColor(Color color)
		{
		}

		public void SetDirSnapTickColor(Color color)
		{
		}

		public void SetDirSnapTickBorderColor(Color color)
		{
		}

		public void SetDirSnapTickHoveredColor(Color color)
		{
		}

		public void SetDirSnapTickHoveredBorderColor(Color color)
		{
		}

		public void SetDirSnapTickType(GizmoCap2DType tickType)
		{
		}

		public void SetDirSnapTickQuadWidth(float width)
		{
		}

		public void SetDirSnapTickQuadHeight(float height)
		{
		}

		public void SetDirSnapTickCircleRadius(float radius)
		{
		}

		public void ConnectDirSnapTickLookAndFeel(GizmoCap2D tick)
		{
		}

		public void ConnectTickLookAndFeel(GizmoCap2D tick)
		{
		}
	}
}
