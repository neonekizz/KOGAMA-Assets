using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class MoveGizmoLookAndFeel2D : Settings
	{
		[SerializeField]
		private GizmoPlaneSlider2DLookAndFeel _dblSliderLookAndFeel;

		[SerializeField]
		private GizmoLineSlider2DLookAndFeel[] _sglSliderLookAndFeel;

		[SerializeField]
		private bool _isDblSliderVisible;

		[SerializeField]
		private bool[] _sglSliderVis;

		[SerializeField]
		private bool[] _sglSliderCapVis;

		public float Scale => 0f;

		public float SliderLength => 0f;

		public float BoxSliderThickness => 0f;

		public float SliderArrowCapHeight => 0f;

		public float SliderArrowCapBaseRadius => 0f;

		public float SliderQuadCapWidth => 0f;

		public float SliderQuadCapHeight => 0f;

		public float SliderCircleCapRadius => 0f;

		public float DblSliderQuadWidth => 0f;

		public float DblSliderQuadHeight => 0f;

		public float DblSliderCircleRadius => 0f;

		public Color XColor => default(Color);

		public Color YColor => default(Color);

		public Color XBorderColor => default(Color);

		public Color YBorderColor => default(Color);

		public Color DblSliderColor => default(Color);

		public Color DblSliderBorderColor => default(Color);

		public Color DblSliderHoveredColor => default(Color);

		public Color DblSliderHoveredBorderColor => default(Color);

		public bool IsDblSliderVisible => false;

		public Color SliderHoveredColor => default(Color);

		public Color SliderHoveredBorderColor => default(Color);

		public GizmoFillMode2D SliderFillMode => default(GizmoFillMode2D);

		public GizmoFillMode2D SliderCapFillMode => default(GizmoFillMode2D);

		public GizmoFillMode2D DblSliderFillMode => default(GizmoFillMode2D);

		public GizmoCap2DType SliderCapType => default(GizmoCap2DType);

		public GizmoLine2DType SliderLineType => default(GizmoLine2DType);

		public GizmoPlane2DType DblSliderPlaneType => default(GizmoPlane2DType);

		public bool IsDblSliderPlaneTypeAllowed(GizmoPlane2DType planeType)
		{
			return false;
		}

		public List<Enum> GetAllowedDblSliderPlaneTypes()
		{
			return null;
		}

		public void SetDblSliderVisible(bool isVisible)
		{
		}

		public bool IsSliderVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		public bool IsPositiveSliderVisible(int axisIndex)
		{
			return false;
		}

		public bool IsNegativeSliderVisible(int axisIndex)
		{
			return false;
		}

		public void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		public bool IsSliderCapVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		public bool IsPositiveSliderCapVisible(int axisIndex)
		{
			return false;
		}

		public bool IsNegativeSliderCapVisible(int axisIndex)
		{
			return false;
		}

		public void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		public void SetAxisColor(int axisIndex, Color color)
		{
		}

		public void SetAxisBorderColor(int axisIndex, Color color)
		{
		}

		public void SetSliderHoveredFillColor(Color color)
		{
		}

		public void SetSliderHoveredBorderColor(Color color)
		{
		}

		public void SetSliderFillMode(GizmoFillMode2D fillMode)
		{
		}

		public void SetDblSliderFillMode(GizmoFillMode2D fillMode)
		{
		}

		public void SetSliderCapFillMode(GizmoFillMode2D fillMode)
		{
		}

		public void SetSliderLineType(GizmoLine2DType lineType)
		{
		}

		public void SetBoxSliderThickness(float thickness)
		{
		}

		public void SetSliderLength(float length)
		{
		}

		public void SetSliderCapType(GizmoCap2DType capType)
		{
		}

		public void SetSliderArrowCapBaseRadius(float radius)
		{
		}

		public void SetSliderArrowCapHeight(float height)
		{
		}

		public void SetSliderQuadCapWidth(float width)
		{
		}

		public void SetSliderQuadCapHeight(float height)
		{
		}

		public void SetSliderCircleCapRadius(float radius)
		{
		}

		public void SetDblSliderPlaneType(GizmoPlane2DType sliderType)
		{
		}

		public void SetDblSliderQuadWidth(float width)
		{
		}

		public void SetDblSliderQuadHeight(float height)
		{
		}

		public void SetDblSliderCircleRadius(float radius)
		{
		}

		public void SetDblSliderColor(Color color)
		{
		}

		public void SetDblSliderBorderColor(Color color)
		{
		}

		public void SetDblSliderHoveredColor(Color color)
		{
		}

		public void SetDblSliderHoveredBorderColor(Color color)
		{
		}

		public void SetScale(float scale)
		{
		}

		public void ConnectSliderLookAndFeel(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign)
		{
		}

		public void ConnectDblSliderLookAndFeel(GizmoPlaneSlider2D slider)
		{
		}

		private GizmoLineSlider2DLookAndFeel GetSliderLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}
	}
}
