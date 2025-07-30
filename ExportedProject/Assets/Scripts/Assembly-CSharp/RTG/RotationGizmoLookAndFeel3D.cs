using System;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class RotationGizmoLookAndFeel3D : Settings
	{
		[SerializeField]
		private bool _isMidCapVisible;

		[SerializeField]
		private GizmoCap3DLookAndFeel _midCapLookAndFeel;

		[SerializeField]
		private bool[] _axesVis;

		[SerializeField]
		private GizmoPlaneSlider3DLookAndFeel[] _axesLookAndFeel;

		[SerializeField]
		private bool _isCamLookSliderVisible;

		[SerializeField]
		private float _camLookSliderRadiusOffset;

		[SerializeField]
		private GizmoPlaneSlider2DLookAndFeel _camLookSliderLookAndFeel;

		public float Scale => 0f;

		public float Radius => 0f;

		public bool UseZoomFactor => false;

		public Color XBorderColor => default(Color);

		public Color YBorderColor => default(Color);

		public Color ZBorderColor => default(Color);

		public Color HoveredColor => default(Color);

		public float AxisTorusThickness => 0f;

		public float AxisCylTorusWidth => 0f;

		public float AxisCylTorusHeight => 0f;

		public float AxisCullAlphaScale => 0f;

		public GizmoShadeMode ShadeMode => default(GizmoShadeMode);

		public GizmoCircle3DBorderType AxisBorderType => default(GizmoCircle3DBorderType);

		public GizmoFillMode3D AxisBorderFillMode => default(GizmoFillMode3D);

		public int NumAxisTorusWireAxialSlices => 0;

		public Color RotationArcColor => default(Color);

		public Color RotationArcBorderColor => default(Color);

		public bool UseShortestRotationArc => false;

		public bool IsRotationArcVisible => false;

		public Color MidCapColor => default(Color);

		public Color MidCapBorderColor => default(Color);

		public Color HoveredMidCapColor => default(Color);

		public bool IsMidCapVisible => false;

		public bool IsMidCapBorderVisible => false;

		public float CamLookSliderRadiusOffset => 0f;

		public Color CamLookSliderBorderColor => default(Color);

		public Color CamLookSliderHoveredBorderColor => default(Color);

		public GizmoPolygon2DBorderType CamLookSliderPolyBorderType => default(GizmoPolygon2DBorderType);

		public float CamLookSliderPolyBorderThickness => 0f;

		public bool IsCamLookSliderVisible => false;

		public bool IsAxisVisible(int axisIndex)
		{
			return false;
		}

		public void SetAxisVisible(int axisIndex, bool isVisible)
		{
		}

		public void SetShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetAxisBorderFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetNumAxisTorusWireAxialSlices(int numSlices)
		{
		}

		public void SetUseZoomFactor(bool useZoomFactor)
		{
		}

		public void SetScale(float scale)
		{
		}

		public void SetRadius(float radius)
		{
		}

		public void SetAxisBorderCullAlphaScale(float scale)
		{
		}

		public void SetAxisBorderType(GizmoCircle3DBorderType borderType)
		{
		}

		public void SetAxisTorusThickness(float thickness)
		{
		}

		public void SetAxisCylTorusWidth(float width)
		{
		}

		public void SetAxisCylTorusHeight(float height)
		{
		}

		public void SetMidCapVisible(bool isVisible)
		{
		}

		public void SetMidCapColor(Color color)
		{
		}

		public void SetHoveredMidCapColor(Color color)
		{
		}

		public void SetMidCapBorderVisible(bool isVisible)
		{
		}

		public void SetMidCapBorderColor(Color color)
		{
		}

		public void SetAxisBorderColor(int axisIndex, Color color)
		{
		}

		public void SetHoveredColor(Color hoveredColor)
		{
		}

		public void SetRotationArcColor(Color color)
		{
		}

		public void SetRotationArcBorderColor(Color color)
		{
		}

		public void SetUseShortestRotationArc(bool useShortest)
		{
		}

		public void SetRotationArcVisible(bool isVisible)
		{
		}

		public void SetCamLookSliderRadiusOffset(float offset)
		{
		}

		public void SetCamLookSliderBorderColor(Color color)
		{
		}

		public void SetCamLookSliderHoveredBorderColor(Color color)
		{
		}

		public void SetCamLookSliderVisible(bool isVisible)
		{
		}

		public void SetCamLookSliderPolyBorderType(GizmoPolygon2DBorderType polyBorderType)
		{
		}

		public void SetCamLookSliderPolyBorderThickness(float thickness)
		{
		}

		public void ConnectSliderLookAndFeel(GizmoPlaneSlider3D slider, int axisIndex)
		{
		}

		public void ConnectMidCapLookAndFeel(GizmoCap3D cap)
		{
		}

		public void ConnectCamLookSliderLookAndFeel(GizmoPlaneSlider2D slider)
		{
		}
	}
}
