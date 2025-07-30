Shader "RTUnityApp/GizmoSolidHandle" {
	Properties {
		_Color ("Color", Vector) = (1,1,1,1)
		_IsLit ("Is lit", Float) = 1
		_LightDir ("Light direction", Vector) = (1,1,1,0)
		_LightIntensity ("Light intensity", Float) = 1.5
		_CullMode ("Cull mode", Float) = 2
		_ZTest ("ZTest", Float) = 4
		_ZWrite ("ZWrite", Float) = 1
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