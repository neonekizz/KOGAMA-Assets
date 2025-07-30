using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class TerrainGizmoLookAndFeel
	{
		[SerializeField]
		private Color _radiusCircleColor;

		[SerializeField]
		private GizmoLineSlider3DLookAndFeel _axisSliderLookAndFeel;

		[SerializeField]
		private GizmoCap3DLookAndFeel _midCapLookAndFeel;

		[SerializeField]
		private GizmoCap2DLookAndFeel _radiusTickLookAndFeel;

		public Color AxisSliderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color AxisSliderHoveredColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color AxisSliderCapColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color AxisSliderCapHoveredColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public GizmoCap3DType AxisSliderCapType
		{
			get
			{
				return default(GizmoCap3DType);
			}
			set
			{
			}
		}

		public GizmoLine3DType AxisSliderLineType
		{
			get
			{
				return default(GizmoLine3DType);
			}
			set
			{
			}
		}

		public float AxisSliderLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public GizmoCap3DType MidCapType
		{
			get
			{
				return default(GizmoCap3DType);
			}
			set
			{
			}
		}

		public float MidCapBoxWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MidCapBoxHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MidCapBoxDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MidSphereRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color MidCapColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color MidCapHoveredColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color RadiusCircleColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public GizmoCap2DType RadiusTickType
		{
			get
			{
				return default(GizmoCap2DType);
			}
			set
			{
			}
		}

		public Color RadiusTickColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color RadiusTickHoveredColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float RadiusTickQuadWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RadiusTickQuadHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RadiusTickCircleRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void ConnectAxisSliderLookAndFeel(GizmoLineSlider3D axisSlider)
		{
		}

		public void ConnectMidCapLookAndFeel(GizmoCap3D pickPointCap)
		{
		}

		public void ConnectRadiusTickLookAndFeel(GizmoCap2D radiusTick)
		{
		}
	}
}
