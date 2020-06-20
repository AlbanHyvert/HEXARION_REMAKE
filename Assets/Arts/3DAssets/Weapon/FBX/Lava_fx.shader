// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:34078,y:32621,varname:node_3138,prsc:2|emission-2955-OUT,clip-7717-OUT;n:type:ShaderForge.SFN_Tex2d,id:6515,x:32824,y:32238,varname:node_6515,prsc:2,tex:54644553d48d21548b1980bc4707a68a,ntxv:0,isnm:False|UVIN-7507-OUT,TEX-1827-TEX;n:type:ShaderForge.SFN_Multiply,id:2406,x:31951,y:32447,varname:node_2406,prsc:2|A-7553-TSL,B-2009-OUT;n:type:ShaderForge.SFN_Add,id:9242,x:32032,y:32730,varname:node_9242,prsc:2|A-2406-OUT,B-716-V;n:type:ShaderForge.SFN_ValueProperty,id:2009,x:31730,y:32424,ptovrint:False,ptlb:speed,ptin:_speed,varname:_speed,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-10;n:type:ShaderForge.SFN_Time,id:7553,x:31578,y:32598,varname:node_7553,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:716,x:31796,y:32644,varname:node_716,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Append,id:3552,x:32281,y:32807,varname:node_3552,prsc:2|A-9736-U,B-9242-OUT;n:type:ShaderForge.SFN_Tex2d,id:4193,x:32500,y:33013,varname:node_4193,prsc:2,tex:54644553d48d21548b1980bc4707a68a,ntxv:0,isnm:False|UVIN-2458-OUT,TEX-1827-TEX;n:type:ShaderForge.SFN_Add,id:6218,x:32870,y:33060,varname:node_6218,prsc:2|A-6515-R,B-4320-R;n:type:ShaderForge.SFN_Clamp01,id:7717,x:33192,y:32874,varname:node_7717,prsc:2|IN-9582-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:1827,x:31730,y:32155,ptovrint:False,ptlb:node_1827,ptin:_node_1827,varname:_node_1827,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:54644553d48d21548b1980bc4707a68a,ntxv:2,isnm:False;n:type:ShaderForge.SFN_RemapRange,id:4156,x:33444,y:32770,varname:node_4156,prsc:2,frmn:0.4,frmx:0.45,tomn:0,tomx:1|IN-7717-OUT;n:type:ShaderForge.SFN_TexCoord,id:9736,x:31478,y:33092,varname:node_9736,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:7981,x:31527,y:32968,ptovrint:False,ptlb:speed_dispor,ptin:_speed_dispor,varname:_speed_dispor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-10;n:type:ShaderForge.SFN_Multiply,id:9331,x:31760,y:32873,varname:node_9331,prsc:2|A-7553-TSL,B-7981-OUT;n:type:ShaderForge.SFN_Add,id:7826,x:31993,y:33101,varname:node_7826,prsc:2|A-9331-OUT,B-9736-V;n:type:ShaderForge.SFN_Append,id:2458,x:32242,y:33073,varname:node_2458,prsc:2|A-5070-OUT,B-7826-OUT;n:type:ShaderForge.SFN_Tex2d,id:4320,x:32526,y:33299,varname:node_4320,prsc:2,tex:54644553d48d21548b1980bc4707a68a,ntxv:0,isnm:False|UVIN-2458-OUT,TEX-1827-TEX;n:type:ShaderForge.SFN_Multiply,id:1221,x:33117,y:33429,varname:node_1221,prsc:2|A-7410-OUT,B-112-OUT;n:type:ShaderForge.SFN_RemapRange,id:112,x:32851,y:33380,varname:node_112,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-4320-G;n:type:ShaderForge.SFN_ValueProperty,id:7410,x:33117,y:33258,ptovrint:False,ptlb:distort,ptin:_distort,varname:_distort,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.08;n:type:ShaderForge.SFN_Add,id:7507,x:32698,y:32704,varname:node_7507,prsc:2|A-3552-OUT,B-1221-OUT;n:type:ShaderForge.SFN_ObjectPosition,id:754,x:31812,y:34411,varname:node_754,prsc:2;n:type:ShaderForge.SFN_Vector3,id:4502,x:32257,y:34420,varname:node_4502,prsc:2,v1:1,v2:0,v3:0;n:type:ShaderForge.SFN_Subtract,id:2162,x:32496,y:34332,varname:node_2162,prsc:2|A-754-XYZ,B-4502-OUT;n:type:ShaderForge.SFN_Normalize,id:2461,x:32724,y:34401,varname:node_2461,prsc:2|IN-2162-OUT;n:type:ShaderForge.SFN_Subtract,id:2489,x:32553,y:34552,varname:node_2489,prsc:2|A-754-XYZ,B-5792-OUT;n:type:ShaderForge.SFN_ViewPosition,id:4454,x:31995,y:34630,varname:node_4454,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:8643,x:32124,y:34777,ptovrint:False,ptlb:node_8643,ptin:_node_8643,varname:_node_8643,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Append,id:5792,x:32356,y:34716,varname:node_5792,prsc:2|A-4454-X,B-8643-OUT,C-4454-Z;n:type:ShaderForge.SFN_Normalize,id:3321,x:32724,y:34593,varname:node_3321,prsc:2|IN-2489-OUT;n:type:ShaderForge.SFN_Dot,id:7359,x:33059,y:34461,varname:node_7359,prsc:2,dt:0|A-2461-OUT,B-3321-OUT;n:type:ShaderForge.SFN_Cross,id:5542,x:33089,y:34660,varname:node_5542,prsc:2|A-2461-OUT,B-3321-OUT;n:type:ShaderForge.SFN_ArcTan2,id:3048,x:33395,y:33857,varname:node_3048,prsc:2,attp:2|A-7359-OUT,B-5542-OUT;n:type:ShaderForge.SFN_ComponentMask,id:6706,x:33728,y:33827,varname:node_6706,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-3048-OUT;n:type:ShaderForge.SFN_Add,id:5070,x:31993,y:32948,varname:node_5070,prsc:2|A-9736-U,B-8812-OUT,C-8812-OUT;n:type:ShaderForge.SFN_Multiply,id:8812,x:33861,y:33492,varname:node_8812,prsc:2|A-5191-OUT,B-6706-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5191,x:33650,y:33542,ptovrint:False,ptlb:camera_offset,ptin:_camera_offset,varname:_camera_offset,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_TexCoord,id:9771,x:31374,y:33438,varname:node_9771,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:9587,x:31729,y:33609,varname:node_9587,prsc:2|A-4372-OUT,B-9771-V,C-8159-OUT;n:type:ShaderForge.SFN_Append,id:197,x:31937,y:33556,varname:node_197,prsc:2|A-2064-OUT,B-9587-OUT;n:type:ShaderForge.SFN_Tex2d,id:8827,x:32486,y:33504,varname:node_8827,prsc:2,tex:54644553d48d21548b1980bc4707a68a,ntxv:0,isnm:False|UVIN-197-OUT,TEX-1827-TEX;n:type:ShaderForge.SFN_ValueProperty,id:1352,x:31431,y:33307,ptovrint:False,ptlb:speed_2,ptin:_speed_2,varname:_speed_2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-2;n:type:ShaderForge.SFN_Multiply,id:4372,x:31758,y:33236,varname:node_4372,prsc:2|A-7553-TSL,B-1352-OUT;n:type:ShaderForge.SFN_Add,id:2064,x:31706,y:33383,varname:node_2064,prsc:2|A-9771-U,B-2690-OUT,C-8812-OUT;n:type:ShaderForge.SFN_Negate,id:2690,x:33874,y:33314,varname:node_2690,prsc:2|IN-8812-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8159,x:31337,y:33739,ptovrint:False,ptlb:node_8159,ptin:_node_8159,varname:_node_8159,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_TexCoord,id:8325,x:31301,y:33834,varname:node_8325,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_RemapRange,id:410,x:31526,y:33834,varname:node_410,prsc:2,frmn:1,frmx:0,tomn:-1,tomx:1|IN-8325-U;n:type:ShaderForge.SFN_Abs,id:7385,x:31669,y:33887,varname:node_7385,prsc:2|IN-410-OUT;n:type:ShaderForge.SFN_RemapRange,id:9184,x:31889,y:33962,varname:node_9184,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-7385-OUT;n:type:ShaderForge.SFN_Clamp01,id:7834,x:32082,y:33925,varname:node_7834,prsc:2|IN-9184-OUT;n:type:ShaderForge.SFN_OneMinus,id:5566,x:32285,y:33925,varname:node_5566,prsc:2|IN-7834-OUT;n:type:ShaderForge.SFN_Multiply,id:3071,x:33064,y:33096,varname:node_3071,prsc:2|A-6218-OUT,B-5566-OUT;n:type:ShaderForge.SFN_Add,id:9582,x:33269,y:33032,varname:node_9582,prsc:2|A-3071-OUT,B-5047-B;n:type:ShaderForge.SFN_Tex2d,id:5047,x:32455,y:32642,varname:node_5047,prsc:2,tex:54644553d48d21548b1980bc4707a68a,ntxv:0,isnm:False|TEX-1827-TEX;n:type:ShaderForge.SFN_Color,id:5554,x:33553,y:32307,ptovrint:False,ptlb:node_5554,ptin:_node_5554,varname:node_5554,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9338235,c2:0.8594773,c3:0.5905061,c4:1;n:type:ShaderForge.SFN_Color,id:4464,x:33609,y:32613,ptovrint:False,ptlb:node_4464,ptin:_node_4464,varname:node_4464,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.5441177,c3:0.6101419,c4:1;n:type:ShaderForge.SFN_Lerp,id:2955,x:33943,y:32439,varname:node_2955,prsc:2|A-5554-RGB,B-4464-RGB,T-843-OUT;n:type:ShaderForge.SFN_Add,id:843,x:32743,y:32909,varname:node_843,prsc:2|A-4193-RGB,B-5047-B;proporder:2009-1827-7981-7410-8643-5191-1352-5554-4464;pass:END;sub:END;*/

Shader "Shader Forge/Lava_fx" {
    Properties {
        _speed ("speed", Float ) = -10
        _node_1827 ("node_1827", 2D) = "black" {}
        _speed_dispor ("speed_dispor", Float ) = -10
        _distort ("distort", Float ) = 0.08
        _node_8643 ("node_8643", Float ) = 0
        _camera_offset ("camera_offset", Float ) = 0
        _speed_2 ("speed_2", Float ) = -2
        _node_5554 ("node_5554", Color) = (0.9338235,0.8594773,0.5905061,1)
        _node_4464 ("node_4464", Color) = (1,0.5441177,0.6101419,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _speed;
            uniform sampler2D _node_1827; uniform float4 _node_1827_ST;
            uniform float _speed_dispor;
            uniform float _distort;
            uniform float _node_8643;
            uniform float _camera_offset;
            uniform float4 _node_5554;
            uniform float4 _node_4464;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float4 node_7553 = _Time;
                float3 node_2461 = normalize((objPos.rgb-float3(1,0,0)));
                float3 node_3321 = normalize((objPos.rgb-float3(_WorldSpaceCameraPos.r,_node_8643,_WorldSpaceCameraPos.b)));
                float node_8812 = (_camera_offset*((atan2(dot(node_2461,node_3321),cross(node_2461,node_3321))/6.28318530718)+0.5).g);
                float2 node_2458 = float2((i.uv0.r+node_8812+node_8812),((node_7553.r*_speed_dispor)+i.uv0.g));
                float4 node_4320 = tex2D(_node_1827,TRANSFORM_TEX(node_2458, _node_1827));
                float2 node_7507 = (float2(i.uv0.r,((node_7553.r*_speed)+i.uv0.g))+(_distort*(node_4320.g*2.0+-1.0)));
                float4 node_6515 = tex2D(_node_1827,TRANSFORM_TEX(node_7507, _node_1827));
                float4 node_5047 = tex2D(_node_1827,TRANSFORM_TEX(i.uv0, _node_1827));
                float node_7717 = saturate((((node_6515.r+node_4320.r)*(1.0 - saturate((abs((i.uv0.r*-2.0+1.0))*2.0+-1.0))))+node_5047.b));
                clip(node_7717 - 0.5);
////// Lighting:
////// Emissive:
                float4 node_4193 = tex2D(_node_1827,TRANSFORM_TEX(node_2458, _node_1827));
                float3 emissive = lerp(_node_5554.rgb,_node_4464.rgb,(node_4193.rgb+node_5047.b));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _speed;
            uniform sampler2D _node_1827; uniform float4 _node_1827_ST;
            uniform float _speed_dispor;
            uniform float _distort;
            uniform float _node_8643;
            uniform float _camera_offset;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                float4 node_7553 = _Time;
                float3 node_2461 = normalize((objPos.rgb-float3(1,0,0)));
                float3 node_3321 = normalize((objPos.rgb-float3(_WorldSpaceCameraPos.r,_node_8643,_WorldSpaceCameraPos.b)));
                float node_8812 = (_camera_offset*((atan2(dot(node_2461,node_3321),cross(node_2461,node_3321))/6.28318530718)+0.5).g);
                float2 node_2458 = float2((i.uv0.r+node_8812+node_8812),((node_7553.r*_speed_dispor)+i.uv0.g));
                float4 node_4320 = tex2D(_node_1827,TRANSFORM_TEX(node_2458, _node_1827));
                float2 node_7507 = (float2(i.uv0.r,((node_7553.r*_speed)+i.uv0.g))+(_distort*(node_4320.g*2.0+-1.0)));
                float4 node_6515 = tex2D(_node_1827,TRANSFORM_TEX(node_7507, _node_1827));
                float4 node_5047 = tex2D(_node_1827,TRANSFORM_TEX(i.uv0, _node_1827));
                float node_7717 = saturate((((node_6515.r+node_4320.r)*(1.0 - saturate((abs((i.uv0.r*-2.0+1.0))*2.0+-1.0))))+node_5047.b));
                clip(node_7717 - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
