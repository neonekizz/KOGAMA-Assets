Shader "RTUnityApp/CylindricalTorusCull" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_IsLit ("Is lit", Float) = 1
		_LightDir ("Light direction", Vector) = (1,1,1,0)
		_LightIntensity ("Light intensity", Float) = 1.5
		_TorusCenter ("Torus center", Vector) = (0,0,0,0)
		_TorusCoreRadius ("Torus core radius", Float) = 1
		_TorusHrzRadius ("Torus hrz radius", Float) = 1
		_TorusVertRadius ("Torus vert radius", Float) = 1
		_CullAlphaScale ("Cull alpha scale", Float) = 0.1
		_CamLook ("Cam Look", Vector) = (0,0,1,0)
		_OrthoCam ("Ortho camera", Float) = 0
		_ZTest ("ZTest", Float) = 4
		_ZWrite ("ZWrite", Float) = 1
		_CullMode ("Cull mode", Float) = 2
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
}