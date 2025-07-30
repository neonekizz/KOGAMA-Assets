using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MV.WorldObject.MetaData;
using UnityEngine;
using UnityEngine.Networking;

public class MaterialLoader : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDownloadNoiseAfterInit_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaterialLoader _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDownloadNoiseAfterInit_003Ed__54(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const string NoisePath = "AssetBundles/Textures/noisetexture.unity3d";

	private const string AtlasPath = "AssetBundles/Atlas/";

	private const string HighResAtlasFileName = "atlashigh";

	private const string MidResAtlasFileName = "atlasmid";

	private const string LowResAtlasFileName = "atlaslow";

	private const string SM3FileEnding = "array.unity3d";

	private const string SM2FileEnding = ".unity3d";

	[SerializeField]
	private Material cubeModelMaterialSM3;

	[SerializeField]
	private Material cubeModelMaterialSM3Transp;

	[SerializeField]
	private Material cubeModelMaterialSM2;

	[SerializeField]
	private Material cubeModelMaterialSM2Transp;

	[SerializeField]
	private Material cubeModelMaterialMobile;

	[SerializeField]
	private Material cubeModelMaterialMobileTransp;

	[SerializeField]
	private Shader pickupUnavailableShaderArray;

	[SerializeField]
	private Shader pickupUnavailableShader;

	[SerializeField]
	private Shader wireframeShader;

	[SerializeField]
	private Shader defaultDiffuseShader;

	[SerializeField]
	private Texture2DArray veryLowTextureArray;

	[SerializeField]
	private Texture2D veryLowTexture;

	private uint atlasHash;

	private bool isUsingSM3Shader;

	private bool isUsingMobileShader;

	private bool isStreamingTexture;

	private int storedTextureQuality;

	private TextureQualityLevel selectedQuality;

	private Texture2DArray highTexture2DArray;

	private Texture2DArray midTexture2DArray;

	private Texture2DArray lowTexture2DArray;

	private Texture2D highTexture2D;

	private Texture2D midTexture2D;

	private Texture2D lowTexture2D;

	public Material CubeModelMaterial { get; private set; }

	public Material CubeModelMaterialTransp { get; private set; }

	public Shader WireframeShader => null;

	public Shader DefaultDiffuseShader => null;

	public Shader StandardItemUnavailableShader => null;

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}

	public bool CheckAtlasIntegrity()
	{
		return false;
	}

	public Shader GetCubeModelUnavailableShader()
	{
		return null;
	}

	private void SetMainTexture(Texture texture, bool isGameModeInitialized = true)
	{
	}

	private bool CalculateIfUsingSM3Shader()
	{
		return false;
	}

	private bool CalculateIsUsingMobileShader()
	{
		return false;
	}

	private Material PickMaterial(bool opaque)
	{
		return null;
	}

	public void SetTextureQuality(TextureQualityLevel quality)
	{
	}

	[IteratorStateMachine(typeof(_003CDownloadNoiseAfterInit_003Ed__54))]
	private IEnumerator DownloadNoiseAfterInit()
	{
		return null;
	}

	private void DownloadNoiseWhenPossible()
	{
	}

	private void NoiseCallback(UnityWebRequest www)
	{
	}

	private void DownloadAtlasWhenPossible()
	{
	}

	private void AtlasCallback(UnityWebRequest www)
	{
	}

	private Texture StoreAtlasTexture(AssetBundle assetBundle, string assetName)
	{
		return null;
	}

	private uint Hash(Texture tex)
	{
		return 0u;
	}

	public string MaterialLoaderInfo()
	{
		return null;
	}
}
