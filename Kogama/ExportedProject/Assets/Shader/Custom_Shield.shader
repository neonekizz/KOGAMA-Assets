Shader "Custom/Shield" {
	Properties {
		_Color ("Color", Vector) = (0,1,0,1)
		_Inside ("Inside", Range(0, 2)) = 0
		_Rim ("Rim", Range(0, 5)) = 1.2
		_Texture ("Texture", 2D) = "white" {}
		_Speed ("Speed", Range(0.5, 5)) = 0.5
		_Tile ("Tile", Range(1, 10)) = 5
		_Strength ("Strength", Range(0, 5)) = 1.5
		_Emissiveness ("Emissiveness", Range(1, 2)) = 0
		_Gloss ("Gloss", Range(0, 1)) = 0.5
		_Specularintensity ("SpecularIntensity", Range(0, 1)) = 0.5
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
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

			float4 _Color;

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return _Color; // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
}