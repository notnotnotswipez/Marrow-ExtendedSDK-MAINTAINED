Shader "Hidden/Sentis/ScalarMad"
{
    Properties
    {
    }
    SubShader
    {
        // No culling or depth
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            CGPROGRAM
            #pragma ScalarMad

            #pragma vertex vert
            #pragma fragment frag

            #include "CommonVertexShader.cginc"
            #include "CommonPixelShader.cginc"

            DECLARE_TENSOR(X, float);

            float S;
            float B;

            float4 frag(v2f i, UNITY_VPOS_TYPE screenPos : VPOS) : SV_Target
            {
                uint blockIndexO = GetBlockIndexO(screenPos);
                float4 v = 0;
                float4 vx = SampleBlockX(blockIndexO);

                v = S * vx + B;

                return v;
            }
            ENDCG
        }
    }
}
