using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class ScaleGizmoLookAndFeel3D : Settings
	{
		[SerializeField]
		private GizmoCap3DLookAndFeel _midCapLookAndFeel;

		[SerializeField]
		private bool[] _sglSliderVis;

		[SerializeField]
		private bool[] _sglSliderCapVis;

		[SerializeField]
		private bool[] _dblSliderVis;

		[SerializeField]
		private GizmoScaleGuideLookAndFeel _scaleGuideLookAndFeel;

		[SerializeField]
		private bool _isScaleGuideVisible;

		[SerializeField]
		private GizmoLineSlider3DLookAndFeel[] _sglSlidersLookAndFeel;

		[SerializeField]
		private GizmoPlaneSlider3DLookAndFeel[] _dblSlidersLookAndFeel;

		public float Scale => 0f;

		public bool UseZoomFactor => false;

		public float SliderLength => 0f;

		public float BoxSliderHeight => 0f;

		public float BoxSliderDepth => 0f;

		public float CylinderSliderRadius => 0f;

		public float SliderBoxCapWidth => 0f;

		public float SliderBoxCapHeight => 0f;

		public float SliderBoxCapDepth => 0f;

		public float SliderConeCapHeight => 0f;

		public float SliderConeCapBaseRadius => 0f;

		public float SliderPyramidCapWidth => 0f;

		public float SliderPyramidCapHeight => 0f;

		public float SliderPyramidCapDepth => 0f;

		public float SliderTriPrismCapWidth => 0f;

		public float SliderTriPrismCapHeight => 0f;

		public float SliderTriPrismCapDepth => 0f;

		public float SliderSphereCapRadius => 0f;

		public GizmoFillMode3D SliderFillMode => default(GizmoFillMode3D);

		public GizmoFillMode3D SliderCapFillMode => default(GizmoFillMode3D);

		public GizmoCap3DType SliderCapType => default(GizmoCap3DType);

		public GizmoShadeMode SliderShadeMode => default(GizmoShadeMode);

		public GizmoShadeMode SliderCapShadeMode => default(GizmoShadeMode);

		public GizmoLine3DType SliderLineType => default(GizmoLine3DType);

		public Color XColor => default(Color);

		public Color YColor => default(Color);

		public Color ZColor => default(Color);

		public float DblSliderSize => 0f;

		public float DblSliderFillAlpha => 0f;

		public float MidCapBoxWidth => 0f;

		public float MidCapBoxHeight => 0f;

		public float MidCapBoxDepth => 0f;

		public float MidCapSphereRadius => 0f;

		public GizmoCap3DType MidCapType => default(GizmoCap3DType);

		public GizmoShadeMode MidCapShadeMode => default(GizmoShadeMode);

		public GizmoFillMode3D MidCapFillMode => default(GizmoFillMode3D);

		public Color MidCapColor => default(Color);

		public Color HoveredColor => default(Color);

		public bool IsScaleGuideVisible => false;

		public float ScaleGuideAxisLength => 0f;

		public void SetScaleGuideVisible(bool isVisible)
		{
		}

		public bool IsDblSliderVisible(PlaneId planeId)
		{
			return false;
		}

		public void SetDblSliderVisible(PlaneId planeId, bool isVisible)
		{
		}

		public bool IsSliderVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		public bool IsSliderCapVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		public bool IsPositiveSliderVisible(int axisIndex)
		{
			return false;
		}

		public bool IsPositiveSliderCapVisible(int axisIndex)
		{
			return false;
		}

		public bool IsNegativeSliderVisible(int axisIndex)
		{
			return false;
		}

		public bool IsNegativeSliderCapVisible(int axisIndex)
		{
			return false;
		}

		public void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		public void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		public void SetPositiveSliderVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetPositiveCapVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetNegativeSliderVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetNegativeCapVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetSliderLength(float axisLength)
		{
		}

		public void SetSliderLineType(GizmoLine3DType lineType)
		{
		}

		public void SetBoxSliderHeight(float height)
		{
		}

		public void SetBoxSliderDepth(float depth)
		{
		}

		public void SetCylinderSliderRadius(float radius)
		{
		}

		public void SetScale(float scale)
		{
		}

		public void SetUseZoomFactor(bool useZoomFactor)
		{
		}

		public void SetScaleGuideAxisLength(float length)
		{
		}

		public void SetAxisColor(int axisIndex, Color color)
		{
		}

		public void SetDblSliderFillAlpha(float alpha)
		{
		}

		public void SetMidCapColor(Color color)
		{
		}

		public void SetHoveredColor(Color hoveredColor)
		{
		}

		public void SetSliderShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetMidCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetSliderCapType(GizmoCap3DType capType)
		{
		}

		public void SetMidCapType(GizmoCap3DType capType)
		{
		}

		public bool IsMidCapTypeAllowed(GizmoCap3DType capType)
		{
			return false;
		}

		public List<Enum> GetAllowedMidCapTypes()
		{
			return null;
		}

		public void SetSliderFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetSliderCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetMidCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetSliderBoxCapWidth(float width)
		{
		}

		public void SetSliderBoxCapHeight(float height)
		{
		}

		public void SetSliderBoxCapDepth(float depth)
		{
		}

		public void SetSliderConeCapHeight(float height)
		{
		}

		public void SetSliderConeCapBaseRadius(float radius)
		{
		}

		public void SetSliderPyramidCapWidth(float width)
		{
		}

		public void SetSliderPyramidCapHeight(float height)
		{
		}

		public void SetSliderPyramidCapDepth(float depth)
		{
		}

		public void SetSliderTriPrismCapWidth(float width)
		{
		}

		public void SetSliderTriPrismCapHeight(float height)
		{
		}

		public void SetSliderTriPrismCapDepth(float depth)
		{
		}

		public void SetSliderSphereCapRadius(float radius)
		{
		}

		public void SetMidCapBoxWidth(float width)
		{
		}

		public void SetMidCapBoxHeight(float height)
		{
		}

		public void SetMidCapBoxDepth(float depth)
		{
		}

		public void SetMidCapSphereRadius(float radius)
		{
		}

		public void SetDblSliderSize(float size)
		{
		}

		public void ConnectSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		public void ConnectMidCapLookAndFeel(GizmoCap3D cap)
		{
		}

		public void ConnectDblSliderLookAndFeel(GizmoPlaneSlider3D slider, PlaneId planeId)
		{
		}

		public void ConnectGizmoScaleGuideLookAndFeel(GizmoScaleGuide scaleGuide)
		{
		}

		private GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		private GizmoPlaneSlider3DLookAndFeel GetDblSliderLookAndFeel(PlaneId planeId)
		{
			return null;
		}
	}
}
