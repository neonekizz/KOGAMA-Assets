Shader "RTUnityApp/XZGrid_Plane" {
	Properties {
		_LineColor ("Line Color", Vector) = (1,1,1,1)
		_CellSizeX ("Cell Size X", Float) = 1
		_CellSizeZ ("Cell Size Z", Float) = 1
		_CamFarPlaneDist ("Camera far plane", Float) = 1000
		_CamWorldPos ("Camera position", Vector) = (0,0,0,0)
		_GridOrigin ("Grid origin", Vector) = (0,0,0,0)
		_GridRight ("Grid right", Vector) = (1,0,0,0)
		_GridLook ("grid look", Vector) = (0,0,1,0)
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