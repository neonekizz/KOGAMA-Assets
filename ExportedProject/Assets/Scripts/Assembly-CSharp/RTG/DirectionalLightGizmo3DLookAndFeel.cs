using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class DirectionalLightGizmo3DLookAndFeel
	{
		[SerializeField]
		private GizmoCap2DLookAndFeel _dirSnapTickLookAndFeel;

		[SerializeField]
		private Color _lightRaysColor;

		[SerializeField]
		private Color _sourceCircleBorderColor;

		[SerializeField]
		private float _sourceCircleRadius;

		[SerializeField]
		private int _numLightRays;

		[SerializeField]
		private float _lightRayLength;

		[SerializeField]
		private Color _dirSnapSegmentColor;

		public static Color DefaultLightRaysColor => default(Color);

		public static Color DefaultSourceCircleBorderColor => default(Color);

		public static float DefaultSourceCircleRadius => 0f;

		public static int DefaultNumLightRays => 0;

		public static float DefaultLightRayLength => 0f;

		public static Color DefaultDirSnapSegmentColor => default(Color);

		public static Color DefaultDirSnapTickColor => default(Color);

		public static float DefaultDirSnapTickQuadWidth => 0f;

		public static float DefaultDirSnapTickQuadHeight => 0f;

		public static float DefaultDirSnapTickCircleRadius => 0f;

		public static GizmoCap2DType DefaultDirSnapTickCapType => default(GizmoCap2DType);

		public static Color DefaultDirSnapTickHoveredColor => default(Color);

		public static Color DefaultDirSnapTickBorderColor => default(Color);

		public static Color DefaultDirSnapTickHoveredBorderColor => default(Color);

		public Color LightRaysColor => default(Color);

		public Color SourceCircleBorderColor => default(Color);

		public float SourceCircleRadius => 0f;

		public int NumLightRays => 0;

		public float LightRayLength => 0f;

		public Color DirSnapSegmentColor => default(Color);

		public Color DirSnapTickBorderColor => default(Color);

		public Color DirSnapTickHoveredColor => default(Color);

		public Color DirSnapTickHoveredBorderColor => default(Color);

		public GizmoCap2DType DirSnapTickType => default(GizmoCap2DType);

		public float DirSnapTickQuadWidth => 0f;

		public float DirSnapTickQuadHeight => 0f;

		public float DirSnapTickCircleRadius => 0f;

		public List<Enum> GetAllowedTickTypes()
		{
			return null;
		}

		public bool IsTickTypeAllowed(GizmoCap2DType tickType)
		{
			return false;
		}

		public void SetNumLightRays(int numLightRays)
		{
		}

		public void SetDirSnapSegmentColor(Color color)
		{
		}

		public void SetLightRayLength(float length)
		{
		}

		public void SetSourceCircleRadius(float radius)
		{
		}

		public void SetLightRaysColor(Color color)
		{
		}

		public void SetSourceCircleBorderColor(Color color)
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
	}
}
