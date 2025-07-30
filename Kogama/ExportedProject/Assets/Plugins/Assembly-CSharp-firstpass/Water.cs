using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Water : MonoBehaviour
{
	public enum WaterMode
	{
		Simple = 0,
		Reflective = 1
	}

	private static bool InsideWater;

	public WaterMode waterMode;

	public bool disablePixelLights;

	public bool isCameraAboveWater;

	public int textureSize;

	public float clipPlaneOffset;

	private Dictionary<object, object> reflectionCameras;

	private RenderTexture reflectionTexture;

	private WaterMode hardwareWaterSupport;

	private int oldReflectionTextureSize;

	private bool isLethal;

	[SerializeField]
	private Texture m_WaterBumpTexture;

	[SerializeField]
	private Texture m_LethalBumpTexture;

	[SerializeField]
	private Color m_WaterHorizon;

	[SerializeField]
	private Color m_LethalHorizon;

	[SerializeField]
	private Renderer meshRenderer;

	public Renderer Renderer => null;

	public bool IsLethal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Color WaterHorizon
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public void OnWillRenderObject()
	{
	}

	private void SetLethal(bool isLethal)
	{
	}

	private bool IsNanCheck(Vector3 v)
	{
		return false;
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}

	private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
	{
		reflectionCamera = null;
		refractionCamera = null;
	}

	private WaterMode GetWaterMode()
	{
		return default(WaterMode);
	}

	private WaterMode FindHardwareWaterSupport()
	{
		return default(WaterMode);
	}

	private static float sgn(float a)
	{
		return 0f;
	}

	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane)
	{
	}

	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}
}
