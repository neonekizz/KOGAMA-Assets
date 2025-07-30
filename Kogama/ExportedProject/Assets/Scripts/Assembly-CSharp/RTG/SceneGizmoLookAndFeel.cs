using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class SceneGizmoLookAndFeel : Settings
	{
		private static readonly float _baseScreenSize;

		private static readonly float _invBaseScreenSize;

		[SerializeField]
		private GizmoCap3DLookAndFeel _midCapLookAndFeel;

		[SerializeField]
		private GizmoCap3DLookAndFeel[] _axesCapsLookAndFeel;

		[SerializeField]
		private SceneGizmoScreenCorner _screenCorner;

		[SerializeField]
		private Vector2 _screenOffset;

		[SerializeField]
		private float _screenSize;

		[SerializeField]
		private Color _axesLabelTint;

		[SerializeField]
		private Color _camPrjSwitchLabelTint;

		[SerializeField]
		private bool _isCamPrjSwitchLabelVisible;

		private GizmoCap3DLookAndFeel AxisCapLookAndFeel => null;

		public SceneGizmoScreenCorner ScreenCorner
		{
			get
			{
				return default(SceneGizmoScreenCorner);
			}
			set
			{
			}
		}

		public Vector2 ScreenOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float ScreenSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color AxesLabelTint
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color CamPrjSwitchLabelTint
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool IsCamPrjSwitchLabelVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Texture2D CamPerspModeLabelTexture => null;

		public Texture2D CamOrthoModeLabelTexture => null;

		public Color HoveredColor => default(Color);

		public GizmoCap3DType AxesCapType => default(GizmoCap3DType);

		public GizmoCap3DType MidCapType => default(GizmoCap3DType);

		public float MidCapBoxSize => 0f;

		public float MidCapSphereRadius => 0f;

		public float AxisConeHeight => 0f;

		public float AxisConeRadius => 0f;

		public float AxisPyramidWidth => 0f;

		public float AxisPyramidHeight => 0f;

		public float AxisPyramidDepth => 0f;

		public float AxisLabelScreenSize => 0f;

		public float AxisCamAlignFadeOutThreshold => 0f;

		public float AxisCamAlignFadeOutDuration => 0f;

		public float AxisCamAlignFadeOutAlpha => 0f;

		public void SetMidCapColor(Color color)
		{
		}

		public void SetAxisCapColor(Color color, int axisIndex, AxisSign axisSign)
		{
		}

		public Color GetAxisCapColor(int axisIndex, AxisSign axisSign)
		{
			return default(Color);
		}

		public void SetHoveredColor(Color hoveredColor)
		{
		}

		public void SetMidCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetAxisCapFillMode(GizmoFillMode3D fillMode)
		{
		}

		public void SetMidCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public void SetAxisCapShadeMode(GizmoShadeMode shadeMode)
		{
		}

		public List<Enum> GetAllowedMidCapTypes()
		{
			return null;
		}

		public List<Enum> GetAllowedAxesCapTypes()
		{
			return null;
		}

		public bool IsMidCapTypeAllowed(GizmoCap3DType capType)
		{
			return false;
		}

		public void SetMidCapType(GizmoCap3DType capType)
		{
		}

		public bool IsAxisCapTypeAllowed(GizmoCap3DType capType)
		{
			return false;
		}

		public void SetAxisCapType(GizmoCap3DType capType)
		{
		}

		public float GetAxesLabelWorldSize(Camera gizmoCam, Vector3 labelWorldPos)
		{
			return 0f;
		}

		public Vector2 CalculateMaxPrjSwitchLabelRectSize()
		{
			return default(Vector2);
		}

		public void ConnectMidCapLookAndFeel(GizmoCap3D midCap)
		{
		}

		public void ConnectAxisCapLookAndFeel(GizmoCap3D axisCap, int axisIndex, AxisSign axisSign)
		{
		}

		private GizmoCap3DLookAndFeel GetAxisCapLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			return null;
		}

		private void OnScreenSizeChanged()
		{
		}
	}
}
