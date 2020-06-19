// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:0,trmd:0,grmd:1,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:32962,y:32647,varname:node_2865,prsc:2|diff-7763-OUT,spec-3186-OUT,gloss-6165-OUT,normal-7040-OUT,clip-5613-OUT;n:type:ShaderForge.SFN_Slider,id:1813,x:32124,y:32651,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:_Gloss,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1182079,max:1;n:type:ShaderForge.SFN_Color,id:8172,x:31546,y:32040,ptovrint:False,ptlb:color_deep,ptin:_color_deep,varname:_color_deep,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.6117647,c2:0.6117647,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:9339,x:31526,y:32278,ptovrint:False,ptlb:color_clair,ptin:_color_clair,varname:_color_clair,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.6117647,c2:0.6117647,c3:0,c4:1;n:type:ShaderForge.SFN_Lerp,id:7763,x:32039,y:32162,varname:node_7763,prsc:2|A-8172-RGB,B-9339-RGB,T-7213-OUT;n:type:ShaderForge.SFN_Fresnel,id:7213,x:31614,y:32479,varname:node_7213,prsc:2|NRM-7040-OUT,EXP-4231-OUT;n:type:ShaderForge.SFN_Vector1,id:3186,x:32346,y:32567,varname:node_3186,prsc:2,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:4231,x:31410,y:32576,ptovrint:False,ptlb:color_fresnel,ptin:_color_fresnel,varname:_color_fresnel,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1.33;n:type:ShaderForge.SFN_Tex2dAsset,id:4748,x:29043,y:32457,ptovrint:False,ptlb:node_4748,ptin:_node_4748,varname:_node_4748,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Tex2d,id:6719,x:29483,y:32538,varname:_node_6719,prsc:2,ntxv:0,isnm:False|UVIN-7062-UVOUT,TEX-4748-TEX;n:type:ShaderForge.SFN_Tex2d,id:6696,x:29507,y:32783,varname:_node_6696,prsc:2,ntxv:0,isnm:False|UVIN-6709-UVOUT,TEX-4748-TEX;n:type:ShaderForge.SFN_TexCoord,id:2771,x:28262,y:32738,varname:node_2771,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:9117,x:28707,y:33095,varname:node_9117,prsc:2;n:type:ShaderForge.SFN_Panner,id:7062,x:29084,y:32882,varname:node_7062,prsc:2,spu:1,spv:0|UVIN-8012-OUT,DIST-9117-TSL;n:type:ShaderForge.SFN_Slider,id:9727,x:29339,y:33406,ptovrint:False,ptlb:node_9727,ptin:_node_9727,varname:_node_9727,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Lerp,id:7040,x:30261,y:33049,varname:node_7040,prsc:2|A-6719-RGB,B-6696-RGB,T-9727-OUT;n:type:ShaderForge.SFN_Panner,id:6709,x:29084,y:33118,varname:node_6709,prsc:2,spu:0.3,spv:0|UVIN-8012-OUT,DIST-9117-T;n:type:ShaderForge.SFN_ComponentMask,id:6165,x:32010,y:33037,varname:node_6165,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-6719-R;n:type:ShaderForge.SFN_Tex2d,id:5394,x:27850,y:32429,ptovrint:False,ptlb:node_5394,ptin:_node_5394,varname:_node_5394,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3c1f33ec9097ea0409046851ba63bd06,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:5141,x:28262,y:32518,varname:node_5141,prsc:2|A-5394-R,B-9473-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9473,x:27955,y:32835,ptovrint:False,ptlb:Spot power,ptin:_Spotpower,varname:_Spotpower,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:8012,x:28802,y:32500,varname:node_8012,prsc:2|A-1565-OUT,B-2771-UVOUT;n:type:ShaderForge.SFN_ConstantClamp,id:1565,x:28452,y:32518,varname:node_1565,prsc:2,min:0,max:1|IN-5141-OUT;n:type:ShaderForge.SFN_Add,id:7477,x:28603,y:32665,varname:node_7477,prsc:2|A-1565-OUT,B-2771-UVOUT;n:type:ShaderForge.SFN_Append,id:8386,x:28107,y:32332,varname:node_8386,prsc:2|A-5394-R,B-5394-G;n:type:ShaderForge.SFN_Tex2d,id:7231,x:32108,y:33202,ptovrint:False,ptlb:node_7231,ptin:_node_7231,varname:_node_7231,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3c1f33ec9097ea0409046851ba63bd06,ntxv:2,isnm:False;n:type:ShaderForge.SFN_ComponentMask,id:5613,x:32391,y:33048,varname:node_5613,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-7231-R;proporder:8172-9339-4231-1813-4748-9727-5394-9473-7231;pass:END;sub:END;*/

Shader "Shader Forge/flaque_acide" {
    Properties {
        _color_deep ("color_deep", Color) = (0.6117647,0.6117647,0,1)
        _color_clair ("color_clair", Color) = (0.6117647,0.6117647,0,1)
        _color_fresnel ("color_fresnel", Float ) = 1.33
        _Gloss ("Gloss", Range(0, 1)) = 0.1182079
        _node_4748 ("node_4748", 2D) = "bump" {}
        _node_9727 ("node_9727", Range(0, 1)) = 1
        _node_5394 ("node_5394", 2D) = "white" {}
        _Spotpower ("Spot power", Float ) = 0
        _node_7231 ("node_7231", 2D) = "black" {}
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
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _color_deep;
            uniform float4 _color_clair;
            uniform float _color_fresnel;
            uniform sampler2D _node_4748; uniform float4 _node_4748_ST;
            uniform float _node_9727;
            uniform sampler2D _node_5394; uniform float4 _node_5394_ST;
            uniform float _Spotpower;
            uniform sampler2D _node_7231; uniform float4 _node_7231_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_9117 = _Time;
                float4 _node_5394_var = tex2D(_node_5394,TRANSFORM_TEX(i.uv0, _node_5394));
                float node_1565 = clamp((_node_5394_var.r*_Spotpower),0,1);
                float2 node_8012 = (node_1565*i.uv0);
                float2 node_7062 = (node_8012+node_9117.r*float2(1,0));
                float3 _node_6719 = UnpackNormal(tex2D(_node_4748,TRANSFORM_TEX(node_7062, _node_4748)));
                float2 node_6709 = (node_8012+node_9117.g*float2(0.3,0));
                float3 _node_6696 = UnpackNormal(tex2D(_node_4748,TRANSFORM_TEX(node_6709, _node_4748)));
                float3 node_7040 = lerp(_node_6719.rgb,_node_6696.rgb,_node_9727);
                float3 normalLocal = node_7040;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float4 _node_7231_var = tex2D(_node_7231,TRANSFORM_TEX(i.uv0, _node_7231));
                clip(_node_7231_var.r.r - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = 1.0 - _node_6719.r.r; // Convert roughness to gloss
                float perceptualRoughness = _node_6719.r.r;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float node_3186 = 0.0;
                float3 specularColor = float3(node_3186,node_3186,node_3186);
                float specularMonochrome;
                float3 diffuseColor = lerp(_color_deep.rgb,_color_clair.rgb,pow(1.0-max(0,dot(node_7040, viewDirection)),_color_fresnel)); // Need this for specular when using metallic
                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _color_deep;
            uniform float4 _color_clair;
            uniform float _color_fresnel;
            uniform sampler2D _node_4748; uniform float4 _node_4748_ST;
            uniform float _node_9727;
            uniform sampler2D _node_5394; uniform float4 _node_5394_ST;
            uniform float _Spotpower;
            uniform sampler2D _node_7231; uniform float4 _node_7231_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_9117 = _Time;
                float4 _node_5394_var = tex2D(_node_5394,TRANSFORM_TEX(i.uv0, _node_5394));
                float node_1565 = clamp((_node_5394_var.r*_Spotpower),0,1);
                float2 node_8012 = (node_1565*i.uv0);
                float2 node_7062 = (node_8012+node_9117.r*float2(1,0));
                float3 _node_6719 = UnpackNormal(tex2D(_node_4748,TRANSFORM_TEX(node_7062, _node_4748)));
                float2 node_6709 = (node_8012+node_9117.g*float2(0.3,0));
                float3 _node_6696 = UnpackNormal(tex2D(_node_4748,TRANSFORM_TEX(node_6709, _node_4748)));
                float3 node_7040 = lerp(_node_6719.rgb,_node_6696.rgb,_node_9727);
                float3 normalLocal = node_7040;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float4 _node_7231_var = tex2D(_node_7231,TRANSFORM_TEX(i.uv0, _node_7231));
                clip(_node_7231_var.r.r - 0.5);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = 1.0 - _node_6719.r.r; // Convert roughness to gloss
                float perceptualRoughness = _node_6719.r.r;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float node_3186 = 0.0;
                float3 specularColor = float3(node_3186,node_3186,node_3186);
                float specularMonochrome;
                float3 diffuseColor = lerp(_color_deep.rgb,_color_clair.rgb,pow(1.0-max(0,dot(node_7040, viewDirection)),_color_fresnel)); // Need this for specular when using metallic
                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
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
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _node_7231; uniform float4 _node_7231_ST;
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
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 _node_7231_var = tex2D(_node_7231,TRANSFORM_TEX(i.uv0, _node_7231));
                clip(_node_7231_var.r.r - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
