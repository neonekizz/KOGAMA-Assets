Shader "Skybox/Farland Skies/Cloudy Crown_Android" {
	Properties {
		[Header(Sky)] _TopColor ("Color Top", Vector) = (0.247,0.318,0.561,1)
		_BottomColor ("Color Bottom", Vector) = (0.773,0.455,0.682,1)
		[Header(Sun)] _SunSize ("Sun Size", Range(0.1, 3)) = 1
		_SunTint ("Sun Tint", Vector) = (0.5,0.5,0.5,1)
		[NoScaleOffset] _SunTex ("Sun Texture", 2D) = "grey" {}
		[Header(Moon)] _MoonSize ("Moon Size", Range(0.1, 3)) = 1
		_MoonTint ("Moon Tint", Vector) = (0.5,0.5,0.5,1)
		[NoScaleOffset] _MoonTex ("Moon Texture", 2D) = "grey" {}
		[Header(Clouds)] _CloudsHeight ("Clouds Height", Range(-0.75, 0.75)) = 0
		_CloudsOffset ("Clouds Offset", Range(0, 1)) = 0.2
		_CloudsRotationSpeed ("Clouds Rotation Speed", Range(-50, 50)) = 1
		[NoScaleOffset] _CloudsTex ("Clouds Cubemap", Cube) = "grey" {}
		[Header(General)] [Gamma] _Exposure ("Exposure", Range(0, 10)) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
}