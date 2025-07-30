using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class UniversalGizmoLookAndFeel3D : Settings
	{
		[SerializeField]
		private UniversalGizmoSettingsCategory _displayCategory;

		[SerializeField]
		private GizmoCap2DLookAndFeel _mvVertSnapCapLookAndFeel;

		[SerializeField]
		private bool[] _mvSglSliderVis;

		[SerializeField]
		private bool[] _mvSglSliderCapVis;

		[SerializeField]
		private bool[] _mvDblSliderVis;

		[SerializeField]
		private GizmoLineSlider3DLookAndFeel[] _mvSglSlidersLookAndFeel;

		[SerializeField]
		private GizmoPlaneSlider3DLookAndFeel[] _mvDblSlidersLookAndFeel;

		[SerializeField]
		private bool _isRtMidCapVisible;

		[SerializeField]
		private GizmoCap3DLookAndFeel _rtMidCapLookAndFeel;

		[SerializeField]
		private bool[] _rtAxesVis;

		[SerializeField]
		private GizmoPlaneSlider3DLookAndFeel[] _rtAxesLookAndFeel;

		[SerializeField]
		private bool _isRtCamLookSliderVisible;

		[SerializeField]
		private float _rtCamLookSliderRadiusOffset;

		[SerializeField]
		private GizmoPlaneSlider2DLookAndFeel _rtCamLookSliderLookAndFeel;

		[SerializeField]
		private GizmoCap3DLookAndFeel _scMidCapLookAndFeel;

		[SerializeField]
		private bool[] _scSglSliderVis;

		[SerializeField]
		private bool[] _scSglSliderCapVis;

		[SerializeField]
		private bool[] _scDblSliderVis;

		[SerializeField]
		private bool _isScMidCapVisible;

		[SerializeField]
		private GizmoScaleGuideLookAndFeel _scScaleGuideLookAndFeel;

		[SerializeField]
		private bool _isScScaleGuideVisible;

		[SerializeField]
		private GizmoLineSlider3DLookAndFeel[] _scSglSlidersLookAndFeel;

		[SerializeField]
		private GizmoPlaneSlider3DLookAndFeel[] _scDblSlidersLookAndFeel;

		public float MvScale => 0f;

		public bool MvUseZoomFactor => false;

		public float MvSliderLength => 0f;

		public float MvBoxSliderHeight => 0f;

		public float MvBoxSliderDepth => 0f;

		public float MvCylinderSliderRadius => 0f;

		public float MvSliderBoxCapWidth => 0f;

		public float MvSliderBoxCapHeight => 0f;

		public float MvSliderBoxCapDepth => 0f;

		public float MvSliderConeCapHeight => 0f;

		public float MvSliderConeCapBaseRadius => 0f;

		public float MvSliderPyramidCapWidth => 0f;

		public float MvSliderPyramidCapHeight => 0f;

		public float MvSliderPyramidCapDepth => 0f;

		public float MvSliderTriPrismCapWidth => 0f;

		public float MvSliderTriPrismCapHeight => 0f;

		public float MvSliderTriPrismCapDepth => 0f;

		public float MvSliderSphereCapRadius => 0f;

		public GizmoFillMode3D MvSliderFillMode => default(GizmoFillMode3D);

		public GizmoFillMode3D MvSliderCapFillMode => default(GizmoFillMode3D);

		public GizmoCap3DType MvSliderCapType => default(GizmoCap3DType);

		public GizmoShadeMode MvSliderShadeMode => default(GizmoShadeMode);

		public GizmoShadeMode MvSliderCapShadeMode => default(GizmoShadeMode);

		public GizmoLine3DType MvSliderLineType => default(GizmoLine3DType);

		public Color MvPXColor => default(Color);

		public Color MvNXColor => default(Color);

		public Color MvPYColor => default(Color);

		public Color MvNYColor => default(Color);

		public Color MvPZColor => default(Color);

		public Color MvNZColor => default(Color);

		public float MvDblSliderSize => 0f;

		public float MvDblSliderBorderBoxHeight => 0f;

		public float MvDblSliderBorderBoxDepth => 0f;

		public float MvDblSliderFillAlpha => 0f;

		public GizmoShadeMode MvDblSliderBorderShadeMode => default(GizmoShadeMode);

		public GizmoQuad3DBorderType MvDblSliderBorderType => default(GizmoQuad3DBorderType);

		public GizmoFillMode3D MvDblSliderBorderFillMode => default(GizmoFillMode3D);

		public float MvVertSnapCapQuadWidth => 0f;

		public float MvVertSnapCapQuadHeight => 0f;

		public float MvVertSnapCapCircleRadius => 0f;

		public Color MvVertSnapCapColor => default(Color);

		public Color MvVertSnapCapBorderColor => default(Color);

		public Color MvVertSnapCapHoveredColor => default(Color);

		public Color MvVertSnapCapHoveredBorderColor => default(Color);

		public GizmoFillMode2D MvVertSnapCapFillMode => default(GizmoFillMode2D);

		public GizmoCap2DType MvVertSnapCapType => default(GizmoCap2DType);

		public Color MvHoveredColor => default(Color);

		public float RtScale => 0f;

		public float RtRadius => 0f;

		public bool RtUseZoomFactor => false;

		public Color RtXBorderColor => default(Color);

		public Color RtYBorderColor => default(Color);

		public Color RtZBorderColor => default(Color);

		public Color RtHoveredColor => default(Color);

		public float RtAxisTorusThickness => 0f;

		public float RtAxisCylTorusWidth => 0f;

		public float RtAxisCylTorusHeight => 0f;

		public float RtAxisCullAlphaScale => 0f;

		public GizmoShadeMode RtShadeMode => default(GizmoShadeMode);

		public GizmoCircle3DBorderType RtAxisBorderType => default(GizmoCircle3DBorderType);

		public GizmoFillMode3D RtAxisBorderFillMode => default(GizmoFillMode3D);

		public int RtNumAxisTorusWireAxialSlices => 0;

		public Color RtRotationArcColor => default(Color);

		public Color RtRotationArcBorderColor => default(Color);

		public bool RtUseShortestRotationArc => false;

		public bool IsRtRotationArcVisible => false;

		public Color RtMidCapColor => default(Color);

		public Color RtHoveredMidCapColor => default(Color);

		public bool IsRtMidCapVisible => false;

		public bool IsRtMidCapBorderVisible => false;

		public float RtCamLookSliderRadiusOffset => 0f;

		public Color RtCamLookSliderBorderColor => default(Color);

		public Color RtCamLookSliderHoveredBorderColor => default(Color);

		public GizmoPolygon2DBorderType RtCamLookSliderPolyBorderType => default(GizmoPolygon2DBorderType);

		public float RtCamLookSliderPolyBorderThickness => 0f;

		public bool IsRtCamLookSliderVisible => false;

		public float ScScale => 0f;

		public bool ScUseZoomFactor => false;

		public float ScSliderLength => 0f;

		public float ScBoxSliderHeight => 0f;

		public float ScBoxSliderDepth => 0f;

		public float ScCylinderSliderRadius => 0f;

		public float ScSliderBoxCapWidth => 0f;

		public float ScSliderBoxCapHeight => 0f;

		public float ScSliderBoxCapDepth => 0f;

		public float ScSliderConeCapHeight => 0f;

		public float ScSliderConeCapBaseRadius => 0f;

		public float ScSliderPyramidCapWidth => 0f;

		public float ScSliderPyramidCapHeight => 0f;

		public float ScSliderPyramidCapDepth => 0f;

		public float ScSliderTriPrismCapWidth => 0f;

		public float ScSliderTriPrismCapHeight => 0f;

		public float ScSliderTriPrismCapDepth => 0f;

		public float ScSliderSphereCapRadius => 0f;

		public GizmoFillMode3D ScSliderFillMode => default(GizmoFillMode3D);

		public GizmoFillMode3D ScSliderCapFillMode => default(GizmoFillMode3D);

		public GizmoCap3DType ScSliderCapType => default(GizmoCap3DType);

		public GizmoShadeMode ScSliderShadeMode => default(GizmoShadeMode);

		public GizmoShadeMode ScSliderCapShadeMode => default(GizmoShadeMode);

		public GizmoLine3DType ScSliderLineType => default(GizmoLine3DType);

		public Color ScPXColor => default(Color);

		public Color ScNXColor => default(Color);

		public Color ScPYColor => default(Color);

		public Color ScNYColor => default(Color);

		public Color ScPZColor => default(Color);

		public Color ScNZColor => default(Color);

		public float ScDblSliderSize => 0f;

		public float ScDblSliderFillAlpha => 0f;

		public float ScMidCapBoxWidth => 0f;

		public float ScMidCapBoxHeight => 0f;

		public float ScMidCapBoxDepth => 0f;

		public float ScMidCapSphereRadius => 0f;

		public GizmoCap3DType ScMidCapType => default(GizmoCap3DType);

		public GizmoShadeMode ScMidCapShadeMode => default(GizmoShadeMode);

		public GizmoFillMode3D ScMidCapFillMode => default(GizmoFillMode3D);

		public bool IsScMidCapVisible => false;

		public Color ScMidCapColor => default(Color);

		public Color ScHoveredColor => default(Color);

		public bool IsScScaleGuideVisible => false;

		public float ScScaleGuideAxisLength => 0f;

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

		public bool IsMvVertSnapCapTypeAllowed(GizmoCap2DType capType)
		{
			return false;
		}

		public List<Enum> GetAllowedMvVertSnapCapTypes()
		{
			return null;
		}

		public void SetMvVertSnapCapType(GizmoCap2DType capType)
		{
		}

		public void SetMvVertSnapCapQuadWidth(float width)
		{
		}

		public void SetMvVertSnapCapQuadHeight(float height)
		{
		}

		public void SetMvVertSnapCapCircleRadius(float radius)
		{
		}

		public void SetMvVertSnapCapFillMode(GizmoFillMode2D fillMode)
		{
		}

		public void SetMvVertSnapCapColor(Color color)
		{
		}

		public void SetMvVertSnapCapBorderColor(Color color)
		{
		}

		public void SetMvVertSnapCapHoveredColor(Color color)
		{
		}

		public void SetMvVertSnapCapHoveredBorderColor(Color color)
		{
		}

		public bool IsMvSliderVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		public bool IsMvDblSliderVisible(PlaneId planeId)
		{
			return false;
		}

		public bool IsMvSliderCapVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		public bool IsMvPositiveSliderVisible(int axisIndex)
		{
			return false;
		}

		public bool IsMvPositiveSliderCapVisible(int axisIndex)
		{
			return false;
		}

		public bool IsMvNegativeSliderVisible(int axisIndex)
		{
			return false;
		}

		public bool IsMvNegativeSliderCapVisible(int axisIndex)
		{
			return false;
		}

		public void SetMvSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		public void SetMvDblSliderVisible(PlaneId planeId, bool isVisible)
		{
		}

		public void SetMvSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		public void SetMvPositiveSliderVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetMvPositiveSliderCapVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetMvNegativeSliderVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetMvNegativeSliderCapVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetMvSliderLength(float axisLength)
		{
		}

		public void SetMvSliderLineType(GizmoLine3DType lineType)
		{
		}

		public void SetMvDblSliderBorderType(GizmoQuad3DBorderType borderType)
		{
		}

		public void SetMvDblSliderBorderBoxHeight(float height)
		{
		}

		public void SetMvDblSliderBorderBoxDepth(float depth)
		{
		}

		public void SetMvBoxSliderHeight(float height)
		{
		}

		public void SetMvBoxSliderDepth(float depth)
		{
		}

		public void SetMvCylinderSliderRadius(float radius)
		{
		}

		public void SetMvDblSliderSize(float size)
		{
		}

		public void SetMvScale(float scale)
		{
		}

		public void SetMvUseZoomFactor(bool useZoomFactor)
		{
		}

		public void SetMvAxisColor(int axisIndex, Color color)
		{
		}

		public void SetMvDblSliderFillAlpha(float alpha)
		{
		}

		public void SetMvHoveredColor(Color hoveredColor)
		{
		}

		public void SetMvSliderShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetMvSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetMvDblSliderBorderShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetMvSliderCapType(GizmoCap3DType capType)
		{
		}

		public void SetMvSliderFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetMvSliderCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetMvDblSliderBorderFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetMvSliderBoxCapWidth(float width)
		{
		}

		public void SetMvSliderBoxCapHeight(float height)
		{
		}

		public void SetMvSliderBoxCapDepth(float depth)
		{
		}

		public void SetMvSliderConeCapHeight(float height)
		{
		}

		public void SetMvSliderConeCapBaseRadius(float radius)
		{
		}

		public void SetMvSliderPyramidCapWidth(float width)
		{
		}

		public void SetMvSliderPyramidCapHeight(float height)
		{
		}

		public void SetMvSliderPyramidCapDepth(float depth)
		{
		}

		public void SetMvSliderTriPrismCapWidth(float width)
		{
		}

		public void SetMvSliderTriPrismCapHeight(float height)
		{
		}

		public void SetMvSliderTriPrismCapDepth(float depth)
		{
		}

		public void SetMvSliderSphereCapRadius(float radius)
		{
		}

		public void ConnectMvSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		public void ConnectMvDblSliderLookAndFeel(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
		}

		public void ConnectMvVertSnapCapLookAndFeel(GizmoCap2D vertSnapCap)
		{
		}

		public void Inherit(MoveGizmoLookAndFeel3D lookAndFeel)
		{
		}

		private GizmoLineSlider3DLookAndFeel GetMvSglSliderLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		private GizmoPlaneSlider3DLookAndFeel GetMvDblSliderLookAndFeel(PlaneId planeId)
		{
			return null;
		}

		public bool IsRtAxisVisible(int axisIndex)
		{
			return false;
		}

		public void SetRtAxisVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetRtShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetRtAxisBorderFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetRtNumAxisTorusWireAxialSlices(int numSlices)
		{
		}

		public void SetRtUseZoomFactor(bool useZoomFactor)
		{
		}

		public void SetRtScale(float scale)
		{
		}

		public void SetRtRadius(float radius)
		{
		}

		public void SetRtAxisBorderCullAlphaScale(float scale)
		{
		}

		public void SetRtAxisBorderType(GizmoCircle3DBorderType borderType)
		{
		}

		public void SetRtAxisTorusThickness(float thickness)
		{
		}

		public void SetRtAxisCylTorusWidth(float width)
		{
		}

		public void SetRtAxisCylTorusHeight(float height)
		{
		}

		public void SetRtMidCapVisible(bool isVisible)
		{
		}

		public void SetRtMidCapColor(Color color)
		{
		}

		public void SetRtHoveredMidCapColor(Color color)
		{
		}

		public void SetRtMidCapBorderVisible(bool isVisible)
		{
		}

		public void SetRtMidCapBorderColor(Color color)
		{
		}

		public void SetRtAxisBorderColor(int axisIndex, Color color)
		{
		}

		public void SetRtHoveredColor(Color hoveredColor)
		{
		}

		public void SetRtRotationArcColor(Color color)
		{
		}

		public void SetRtRotationArcBorderColor(Color color)
		{
		}

		public void SetRtUseShortestRotationArc(bool useShortest)
		{
		}

		public void SetRtRotationArcVisible(bool isVisible)
		{
		}

		public void SetRtCamLookSliderRadiusOffset(float offset)
		{
		}

		public void SetRtCamLookSliderBorderColor(Color color)
		{
		}

		public void SetRtCamLookSliderHoveredBorderColor(Color color)
		{
		}

		public void SetRtCamLookSliderVisible(bool isVisible)
		{
		}

		public void SetRtCamLookSliderPolyBorderType(GizmoPolygon2DBorderType polyBorderType)
		{
		}

		public void SetRtCamLookSliderPolyBorderThickness(float thickness)
		{
		}

		public void ConnectRtSliderLookAndFeel(GizmoPlaneSlider3D slider, int axisIndex)
		{
		}

		public void ConnectRtMidCapLookAndFeel(GizmoCap3D cap)
		{
		}

		public void ConnectRtCamLookSliderLookAndFeel(GizmoPlaneSlider2D slider)
		{
		}

		public void Inherit(RotationGizmoLookAndFeel3D lookAndFeel)
		{
		}

		public void SetScScaleGuideVisible(bool isVisible)
		{
		}

		public bool IsScDblSliderVisible(PlaneId planeId)
		{
			return false;
		}

		public void SetScDblSliderVisible(PlaneId planeId, bool isVisible)
		{
		}

		public bool IsScSliderVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		public bool IsScSliderCapVisible(int axisIndex, AxisSign axisSign)
		{
			return false;
		}

		public bool IsScPositiveSliderVisible(int axisIndex)
		{
			return false;
		}

		public bool IsScPositiveSliderCapVisible(int axisIndex)
		{
			return false;
		}

		public bool IsScNegativeSliderVisible(int axisIndex)
		{
			return false;
		}

		public bool IsScNegativeSliderCapVisible(int axisIndex)
		{
			return false;
		}

		public void SetScSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		public void SetScSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
		}

		public void SetScPositiveSliderVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetScPositiveSliderCapVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetScNegativeSliderVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetScNegativeSliderCapVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetScSliderLength(float axisLength)
		{
		}

		public void SetScSliderLineType(GizmoLine3DType lineType)
		{
		}

		public void SetScBoxSliderHeight(float height)
		{
		}

		public void SetScBoxSliderDepth(float depth)
		{
		}

		public void SetScCylinderSliderRadius(float radius)
		{
		}

		public void SetScScale(float scale)
		{
		}

		public void SetScUseZoomFactor(bool useZoomFactor)
		{
		}

		public void SetScScaleGuideAxisLength(float length)
		{
		}

		public void SetScAxisColor(int axisIndex, Color color)
		{
		}

		public void SetScDblSliderFillAlpha(float alpha)
		{
		}

		public void SetScMidCapColor(Color color)
		{
		}

		public void SetScMidCapVisible(bool visible)
		{
		}

		public void SetScHoveredColor(Color hoveredColor)
		{
		}

		public void SetScSliderShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetScSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetScMidCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetScSliderCapType(GizmoCap3DType capType)
		{
		}

		public void SetScMidCapType(GizmoCap3DType capType)
		{
		}

		public bool IsScMidCapTypeAllowed(GizmoCap3DType capType)
		{
			return false;
		}

		public List<Enum> GetAllowedScMidCapTypes()
		{
			return null;
		}

		public void SetScSliderFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetScSliderCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetScMidCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetScSliderBoxCapWidth(float width)
		{
		}

		public void SetScSliderBoxCapHeight(float height)
		{
		}

		public void SetScSliderBoxCapDepth(float depth)
		{
		}

		public void SetScSliderConeCapHeight(float height)
		{
		}

		public void SetScSliderConeCapBaseRadius(float radius)
		{
		}

		public void SetScSliderPyramidCapWidth(float width)
		{
		}

		public void SetScSliderPyramidCapHeight(float height)
		{
		}

		public void SetScSliderPyramidCapDepth(float depth)
		{
		}

		public void SetScSliderTriPrismCapWidth(float width)
		{
		}

		public void SetScSliderTriPrismCapHeight(float height)
		{
		}

		public void SetScSliderTriPrismCapDepth(float depth)
		{
		}

		public void SetScSliderSphereCapRadius(float radius)
		{
		}

		public void SetScMidCapBoxWidth(float width)
		{
		}

		public void SetScMidCapBoxHeight(float height)
		{
		}

		public void SetScMidCapBoxDepth(float depth)
		{
		}

		public void SetScMidCapSphereRadius(float radius)
		{
		}

		public void SetScDblSliderSize(float size)
		{
		}

		public void ConnectScSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
		}

		public void ConnectScMidCapLookAndFeel(GizmoCap3D cap)
		{
		}

		public void ConnectScDblSliderLookAndFeel(GizmoPlaneSlider3D slider, PlaneId planeId)
		{
		}

		public void ConnectScGizmoScaleGuideLookAndFeel(GizmoScaleGuide scaleGuide)
		{
		}

		public void Inherit(ScaleGizmoLookAndFeel3D lookAndFeel)
		{
		}

		private GizmoLineSlider3DLookAndFeel GetScSglSliderLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		private GizmoPlaneSlider3DLookAndFeel GetScDblSliderLookAndFeel(PlaneId planeId)
		{
			return null;
		}
	}
}
