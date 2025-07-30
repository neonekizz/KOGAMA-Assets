using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class UniversalGizmoLookAndFeel2D : Settings
	{
		[SerializeField]
		private UniversalGizmoSettingsCategory _displayCategory;

		[SerializeField]
		private GizmoPlaneSlider2DLookAndFeel _mvDblSliderLookAndFeel;

		[SerializeField]
		private GizmoLineSlider2DLookAndFeel[] _mvSglSliderLookAndFeel;

		[SerializeField]
		private bool _isMvDblSliderVisible;

		[SerializeField]
		private bool[] _mvSglSliderVis;

		[SerializeField]
		private bool[] _mvSglSliderCapVis;

		public float MvScale => 0f;

		public float MvSliderLength => 0f;

		public float MvBoxSliderThickness => 0f;

		public float MvSliderArrowCapHeight => 0f;

		public float MvSliderArrowCapBaseRadius => 0f;

		public float MvSliderQuadCapWidth => 0f;

		public float MvSliderQuadCapHeight => 0f;

		public float MvSliderCircleCapRadius => 0f;

		public float MvDblSliderQuadWidth => 0f;

		public float MvDblSliderQuadHeight => 0f;

		public float MvDblSliderCircleRadius => 0f;

		public Color MvXColor => default(Color);

		public Color MvYColor => default(Color);

		public Color MvXBorderColor => default(Color);

		public Color MvYBorderColor => default(Color);

		public Color MvDblSliderColor => default(Color);

		public Color MvDblSliderBorderColor => default(Color);

		public Color MvDblSliderHoveredColor => default(Color);

		public Color MvDblSliderHoveredBorderColor => default(Color);

		public bool IsMvDblSliderVisible => false;

		public Color MvSliderHoveredColor => default(Color);

		public Color MvSliderHoveredBorderColor => default(Color);

		public GizmoFillMode2D MvSliderFillMode => default(GizmoFillMode2D);

		public GizmoFillMode2D MvSliderCapFillMode => default(GizmoFillMode2D);

		public GizmoFillMode2D MvDblSliderFillMode => default(GizmoFillMode2D);

		public GizmoCap2DType MvSliderCapType => default(GizmoCap2DType);

		public GizmoLine2DType MvSliderLineType => default(GizmoLine2DType);

		public GizmoPlane2DType MvDblSliderPlaneType => default(GizmoPlane2DType);

		public UniversalGizmoSettingsCategory DisplayCategory
		{
			get
			{
				return default(UniversalGizmoSettingsCategory);
			}
			set
			{
			}
		}

		public void SetMvDblSliderVisible(bool isVisible)
		{
		}

		public bool IsMvSliderVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		public bool IsMvPositiveSliderVisible(int axisIndex)
		{
			return false;
		}

		public bool IsMvNegativeSliderVisible(int axisIndex)
		{
			return false;
		}

		public void SetMvSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		public bool IsMvSliderCapVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		public bool IsMvPositiveSliderCapVisible(int axisIndex)
		{
			return false;
		}

		public bool IsMvNegativeSliderCapVisible(int axisIndex)
		{
			return false;
		}

		public void SetMvSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		public void SetMvAxisColor(int axisIndex, Color color)
		{
		}

		public void SetMvAxisBorderColor(int axisIndex, Color color)
		{
		}

		public void SetMvSliderHoveredFillColor(Color color)
		{
		}

		public void SetMvSliderHoveredBorderColor(Color color)
		{
		}

		public void SetMvSliderFillMode(GizmoFillMode2D fillMode)
		{
		}

		public void SetMvDblSliderFillMode(GizmoFillMode2D fillMode)
		{
		}

		public void SetMvSliderCapFillMode(GizmoFillMode2D fillMode)
		{
		}

		public void SetMvSliderLineType(GizmoLine2DType lineType)
		{
		}

		public void SetMvBoxSliderThickness(float thickness)
		{
		}

		public void SetMvSliderLength(float length)
		{
		}

		public void SetMvSliderCapType(GizmoCap2DType capType)
		{
		}

		public void SetMvSliderArrowCapBaseRadius(float radius)
		{
		}

		public void SetMvSliderArrowCapHeight(float height)
		{
		}

		public void SetMvSliderQuadCapWidth(float width)
		{
		}

		public void SetMvSliderQuadCapHeight(float height)
		{
		}

		public void SetMvSliderCircleCapRadius(float radius)
		{
		}

		public void SetMvDblSliderPlaneType(GizmoPlane2DType sliderType)
		{
		}

		public void SetMvDblSliderQuadWidth(float width)
		{
		}

		public void SetMvDblSliderQuadHeight(float height)
		{
		}

		public void SetMvDblSliderCircleRadius(float radius)
		{
		}

		public void SetMvDblSliderColor(Color color)
		{
		}

		public void SetMvDblSliderBorderColor(Color color)
		{
		}

		public void SetMvDblSliderHoveredColor(Color color)
		{
		}

		public void SetMvDblSliderHoveredBorderColor(Color color)
		{
		}

		public void SetMvScale(float scale)
		{
		}

		public void ConnectMvSliderLookAndFeel(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign)
		{
		}

		public void ConnectMvDblSliderLookAndFeel(GizmoPlaneSlider2D slider)
		{
		}

		public void Inherit(MoveGizmoLookAndFeel2D lookAndFeel)
		{
		}

		private GizmoLineSlider2DLookAndFeel GetMvSliderLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}
	}
}
