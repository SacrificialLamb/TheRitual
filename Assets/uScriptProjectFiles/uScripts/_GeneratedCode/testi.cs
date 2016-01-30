//uScript Generated Code - Build 1.0.3024
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class testi : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   System.Boolean local_16_System_Boolean = (bool) false;
   System.Single local_23_System_Single = (float) 0;
   UnityEngine.Vector3 local_28_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_31_System_Single = (float) 0;
   System.Single local_32_System_Single = (float) 0;
   System.Single local_33_System_Single = (float) 0;
   System.Boolean local_6_System_Boolean = (bool) false;
   UnityEngine.GameObject local_collider_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_collider_UnityEngine_GameObject_previous = null;
   System.Single local_pickDist_System_Single = (float) 0;
   UnityEngine.GameObject local_pickedObj_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_pickedObj_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_2 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_2 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_2 = new System.String[] {"Respawn"};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_2 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_2 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_2 = true;
   //pointer to script instanced logic node
   uScriptCon_IsNull logic_uScriptCon_IsNull_uScriptCon_IsNull_4 = new uScriptCon_IsNull( );
   UnityEngine.GameObject[] logic_uScriptCon_IsNull_Target_4 = new UnityEngine.GameObject[] {};
   bool logic_uScriptCon_IsNull_IsNull_4 = true;
   bool logic_uScriptCon_IsNull_IsNotNull_4 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBoolState logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_7 = new uScriptCon_CompareBoolState( );
   System.Boolean logic_uScriptCon_CompareBoolState_target_7 = (bool) false;
   System.Boolean logic_uScriptCon_CompareBoolState_previousState_7 = (bool) false;
   bool logic_uScriptCon_CompareBoolState_Out_7 = true;
   bool logic_uScriptCon_CompareBoolState_IsTrue_7 = true;
   bool logic_uScriptCon_CompareBoolState_IsFalse_7 = true;
   bool logic_uScriptCon_CompareBoolState_WasTrue_7 = true;
   bool logic_uScriptCon_CompareBoolState_WasFalse_7 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObject logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_8 = new uScriptAct_SetGameObject( );
   UnityEngine.GameObject logic_uScriptAct_SetGameObject_Value_8 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_SetGameObject_TargetGameObject_8;
   bool logic_uScriptAct_SetGameObject_Out_8 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBoolState logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_9 = new uScriptCon_CompareBoolState( );
   System.Boolean logic_uScriptCon_CompareBoolState_target_9 = (bool) false;
   System.Boolean logic_uScriptCon_CompareBoolState_previousState_9 = (bool) false;
   bool logic_uScriptCon_CompareBoolState_Out_9 = true;
   bool logic_uScriptCon_CompareBoolState_IsTrue_9 = true;
   bool logic_uScriptCon_CompareBoolState_IsFalse_9 = true;
   bool logic_uScriptCon_CompareBoolState_WasTrue_9 = true;
   bool logic_uScriptCon_CompareBoolState_WasFalse_9 = true;
   //pointer to script instanced logic node
   uScriptCon_CheckDistance logic_uScriptCon_CheckDistance_uScriptCon_CheckDistance_11 = new uScriptCon_CheckDistance( );
   UnityEngine.GameObject logic_uScriptCon_CheckDistance_A_11 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptCon_CheckDistance_B_11 = default(UnityEngine.GameObject);
   System.Single logic_uScriptCon_CheckDistance_Distance_11 = (float) 0;
   bool logic_uScriptCon_CheckDistance_Closer_11 = true;
   bool logic_uScriptCon_CheckDistance_Further_11 = true;
   bool logic_uScriptCon_CheckDistance_Equal_11 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObject logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_12 = new uScriptAct_SetGameObject( );
   UnityEngine.GameObject logic_uScriptAct_SetGameObject_Value_12 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_SetGameObject_TargetGameObject_12;
   bool logic_uScriptAct_SetGameObject_Out_12 = true;
   //pointer to script instanced logic node
   uScriptAct_GetDistance logic_uScriptAct_GetDistance_uScriptAct_GetDistance_14 = new uScriptAct_GetDistance( );
   UnityEngine.GameObject logic_uScriptAct_GetDistance_A_14 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetDistance_B_14 = default(UnityEngine.GameObject);
   System.Single logic_uScriptAct_GetDistance_Distance_14;
   bool logic_uScriptAct_GetDistance_Out_14 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_15 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_15 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_15 = (float) 1.5;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_15;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_15;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_17 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_17;
   bool logic_uScriptAct_SetBool_Out_17 = true;
   bool logic_uScriptAct_SetBool_SetTrue_17 = true;
   bool logic_uScriptAct_SetBool_SetFalse_17 = true;
   //pointer to script instanced logic node
   uScriptCon_IsNull logic_uScriptCon_IsNull_uScriptCon_IsNull_18 = new uScriptCon_IsNull( );
   UnityEngine.GameObject[] logic_uScriptCon_IsNull_Target_18 = new UnityEngine.GameObject[] {};
   bool logic_uScriptCon_IsNull_IsNull_18 = true;
   bool logic_uScriptCon_IsNull_IsNotNull_18 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_19 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_19 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_19 = true;
   bool logic_uScriptCon_CompareBool_False_19 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBool logic_uScriptCon_CompareBool_uScriptCon_CompareBool_20 = new uScriptCon_CompareBool( );
   System.Boolean logic_uScriptCon_CompareBool_Bool_20 = (bool) false;
   bool logic_uScriptCon_CompareBool_True_20 = true;
   bool logic_uScriptCon_CompareBool_False_20 = true;
   //pointer to script instanced logic node
   uScriptAct_SetBool logic_uScriptAct_SetBool_uScriptAct_SetBool_21 = new uScriptAct_SetBool( );
   System.Boolean logic_uScriptAct_SetBool_Target_21;
   bool logic_uScriptAct_SetBool_Out_21 = true;
   bool logic_uScriptAct_SetBool_SetTrue_21 = true;
   bool logic_uScriptAct_SetBool_SetFalse_21 = true;
   //pointer to script instanced logic node
   uScriptAct_GetFacingAngle logic_uScriptAct_GetFacingAngle_uScriptAct_GetFacingAngle_22 = new uScriptAct_GetFacingAngle( );
   UnityEngine.GameObject logic_uScriptAct_GetFacingAngle_A_22 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetFacingAngle_B_22 = default(UnityEngine.GameObject);
   System.Single logic_uScriptAct_GetFacingAngle_Angle_22;
   bool logic_uScriptAct_GetFacingAngle_Out_22 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_24 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_24 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_24 = (float) 45;
   bool logic_uScriptCon_CompareFloat_GreaterThan_24 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_24 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_24 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_24 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_24 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_24 = true;
   //pointer to script instanced logic node
   uScriptAct_SetParent logic_uScriptAct_SetParent_uScriptAct_SetParent_26 = new uScriptAct_SetParent( );
   UnityEngine.GameObject[] logic_uScriptAct_SetParent_Target_26 = new UnityEngine.GameObject[] {};
   UnityEngine.GameObject logic_uScriptAct_SetParent_Parent_26 = default(UnityEngine.GameObject);
   bool logic_uScriptAct_SetParent_Out_26 = true;
   //pointer to script instanced logic node
   uScriptAct_SetParent logic_uScriptAct_SetParent_uScriptAct_SetParent_27 = new uScriptAct_SetParent( );
   UnityEngine.GameObject[] logic_uScriptAct_SetParent_Target_27 = new UnityEngine.GameObject[] {};
   UnityEngine.GameObject logic_uScriptAct_SetParent_Parent_27 = default(UnityEngine.GameObject);
   bool logic_uScriptAct_SetParent_Out_27 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPositionAndRotation logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_29 = new uScriptAct_GetPositionAndRotation( );
   UnityEngine.GameObject logic_uScriptAct_GetPositionAndRotation_Target_29 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_GetPositionAndRotation_GetLocal_29 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Position_29;
   UnityEngine.Quaternion logic_uScriptAct_GetPositionAndRotation_Rotation_29;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_EulerAngles_29;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Forward_29;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Up_29;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Right_29;
   bool logic_uScriptAct_GetPositionAndRotation_Out_29 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_30 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_30 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_30;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_30;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_30;
   bool logic_uScriptAct_GetComponentsVector3_Out_30 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_34 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_34 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_34 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_34 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_34;
   bool logic_uScriptAct_SetComponentsVector3_Out_34 = true;
   //pointer to script instanced logic node
   uScriptAct_AddFloat_v2 logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_35 = new uScriptAct_AddFloat_v2( );
   System.Single logic_uScriptAct_AddFloat_v2_A_35 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_B_35 = (float) 0.125;
   System.Single logic_uScriptAct_AddFloat_v2_FloatResult_35;
   System.Int32 logic_uScriptAct_AddFloat_v2_IntResult_35;
   bool logic_uScriptAct_AddFloat_v2_Out_35 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocationFixed logic_uScriptAct_MoveToLocationFixed_uScriptAct_MoveToLocationFixed_36 = new uScriptAct_MoveToLocationFixed( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocationFixed_targetArray_36 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocationFixed_location_36 = new Vector3( );
   System.Boolean logic_uScriptAct_MoveToLocationFixed_asOffset_36 = (bool) false;
   System.Single logic_uScriptAct_MoveToLocationFixed_speed_36 = (float) 10;
   bool logic_uScriptAct_MoveToLocationFixed_Out_36 = true;
   bool logic_uScriptAct_MoveToLocationFixed_Cancelled_36 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_104 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_104 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_104 = new Vector3( (float)0, (float)0, (float)0 );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_104 = (bool) true;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_104 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_104 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObjectPosition logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_105 = new uScriptAct_SetGameObjectPosition( );
   UnityEngine.GameObject[] logic_uScriptAct_SetGameObjectPosition_Target_105 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_SetGameObjectPosition_Position_105 = new Vector3( (float)0, (float)0, (float)0 );
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsOffset_105 = (bool) true;
   System.Boolean logic_uScriptAct_SetGameObjectPosition_AsLocal_105 = (bool) false;
   bool logic_uScriptAct_SetGameObjectPosition_Out_105 = true;
   
   //event nodes
   UnityEngine.Vector3 event_UnityEngine_GameObject_RelativeVelocity_0 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Rigidbody event_UnityEngine_GameObject_RigidBody_0 = default(UnityEngine.Rigidbody);
   UnityEngine.Collider event_UnityEngine_GameObject_Collider_0 = default(UnityEngine.Collider);
   UnityEngine.Transform event_UnityEngine_GameObject_Transform_0 = default(UnityEngine.Transform);
   UnityEngine.ContactPoint[] event_UnityEngine_GameObject_Contacts_0 = new UnityEngine.ContactPoint[ 0 ];
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_0 = default(UnityEngine.GameObject);
   System.Single event_UnityEngine_GameObject_Horizontal_5 = (float) 0;
   System.Single event_UnityEngine_GameObject_Vertical_5 = (float) 0;
   System.Boolean event_UnityEngine_GameObject_Fire1_5 = (bool) false;
   System.Boolean event_UnityEngine_GameObject_Fire2_5 = (bool) false;
   System.Boolean event_UnityEngine_GameObject_Fire3_5 = (bool) false;
   System.Boolean event_UnityEngine_GameObject_Jump_5 = (bool) false;
   System.Single event_UnityEngine_GameObject_MouseX_5 = (float) 0;
   System.Single event_UnityEngine_GameObject_MouseY_5 = (float) 0;
   System.Single event_UnityEngine_GameObject_MouseScrollWheel_5 = (float) 0;
   System.Single event_UnityEngine_GameObject_WindowShakeX_5 = (float) 0;
   System.Single event_UnityEngine_GameObject_WindowShakeY_5 = (float) 0;
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_5 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_value_25 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_Return_25 = (float) 0;
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == logic_uScriptCon_CheckDistance_B_11 || false == m_RegisteredForEvents )
      {
         logic_uScriptCon_CheckDistance_B_11 = GameObject.Find( "/ThirdPersonController" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptAct_GetDistance_B_14 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_GetDistance_B_14 = GameObject.Find( "/ThirdPersonController" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptAct_GetFacingAngle_A_22 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_GetFacingAngle_A_22 = GameObject.Find( "/ThirdPersonController" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptAct_SetParent_Parent_27 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_SetParent_Parent_27 = GameObject.Find( "/ThirdPersonController" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_collider_UnityEngine_GameObject_previous != local_collider_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_collider_UnityEngine_GameObject_previous = local_collider_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_pickedObj_UnityEngine_GameObject_previous )
         {
            {
               uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
               if ( null != component )
               {
                  component.OnUpdate -= Instance_OnUpdate_10;
                  component.OnLateUpdate -= Instance_OnLateUpdate_10;
                  component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
               }
            }
         }
         
         local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_pickedObj_UnityEngine_GameObject )
         {
            {
               uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_10;
                  component.OnLateUpdate += Instance_OnLateUpdate_10;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_10;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_collider_UnityEngine_GameObject_previous != local_collider_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_collider_UnityEngine_GameObject_previous = local_collider_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_pickedObj_UnityEngine_GameObject_previous )
         {
            {
               uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
               if ( null != component )
               {
                  component.OnUpdate -= Instance_OnUpdate_10;
                  component.OnLateUpdate -= Instance_OnLateUpdate_10;
                  component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
               }
            }
         }
         
         local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_pickedObj_UnityEngine_GameObject )
         {
            {
               uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_10;
                  component.OnLateUpdate += Instance_OnLateUpdate_10;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_10;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_0 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_0 = GameObject.Find( "ThirdPersonController" ) as UnityEngine.GameObject;
         if ( null != event_UnityEngine_GameObject_Instance_0 )
         {
            {
               uScript_Collision component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Collision>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_0.AddComponent<uScript_Collision>();
               }
               if ( null != component )
               {
                  component.OnEnterCollision += Instance_OnEnterCollision_0;
                  component.OnExitCollision += Instance_OnExitCollision_0;
                  component.WhileInsideCollision += Instance_WhileInsideCollision_0;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_5 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_5 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_5 )
         {
            {
               uScript_ManagedInput component = event_UnityEngine_GameObject_Instance_5.GetComponent<uScript_ManagedInput>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_5.AddComponent<uScript_ManagedInput>();
               }
               if ( null != component )
               {
                  component.OnInputEvent += Instance_OnInputEvent_5;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != local_pickedObj_UnityEngine_GameObject )
      {
         {
            uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_10;
               component.OnLateUpdate -= Instance_OnLateUpdate_10;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_0 )
      {
         {
            uScript_Collision component = event_UnityEngine_GameObject_Instance_0.GetComponent<uScript_Collision>();
            if ( null != component )
            {
               component.OnEnterCollision -= Instance_OnEnterCollision_0;
               component.OnExitCollision -= Instance_OnExitCollision_0;
               component.WhileInsideCollision -= Instance_WhileInsideCollision_0;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_5 )
      {
         {
            uScript_ManagedInput component = event_UnityEngine_GameObject_Instance_5.GetComponent<uScript_ManagedInput>();
            if ( null != component )
            {
               component.OnInputEvent -= Instance_OnInputEvent_5;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_2.SetParent(g);
      logic_uScriptCon_IsNull_uScriptCon_IsNull_4.SetParent(g);
      logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_7.SetParent(g);
      logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_8.SetParent(g);
      logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_9.SetParent(g);
      logic_uScriptCon_CheckDistance_uScriptCon_CheckDistance_11.SetParent(g);
      logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_12.SetParent(g);
      logic_uScriptAct_GetDistance_uScriptAct_GetDistance_14.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_15.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_17.SetParent(g);
      logic_uScriptCon_IsNull_uScriptCon_IsNull_18.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_19.SetParent(g);
      logic_uScriptCon_CompareBool_uScriptCon_CompareBool_20.SetParent(g);
      logic_uScriptAct_SetBool_uScriptAct_SetBool_21.SetParent(g);
      logic_uScriptAct_GetFacingAngle_uScriptAct_GetFacingAngle_22.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_24.SetParent(g);
      logic_uScriptAct_SetParent_uScriptAct_SetParent_26.SetParent(g);
      logic_uScriptAct_SetParent_uScriptAct_SetParent_27.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_29.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_30.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_34.SetParent(g);
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_35.SetParent(g);
      logic_uScriptAct_MoveToLocationFixed_uScriptAct_MoveToLocationFixed_36.SetParent(g);
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_104.SetParent(g);
      logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_105.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_MoveToLocationFixed_uScriptAct_MoveToLocationFixed_36.Finished += uScriptAct_MoveToLocationFixed_Finished_36;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      logic_uScriptAct_MoveToLocationFixed_uScriptAct_MoveToLocationFixed_36.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_MoveToLocationFixed_uScriptAct_MoveToLocationFixed_36.Finished -= uScriptAct_MoveToLocationFixed_Finished_36;
   }
   
   void Instance_OnEnterCollision_0(object o, uScript_Collision.CollisionEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_RelativeVelocity_0 = e.RelativeVelocity;
      event_UnityEngine_GameObject_RigidBody_0 = e.RigidBody;
      event_UnityEngine_GameObject_Collider_0 = e.Collider;
      event_UnityEngine_GameObject_Transform_0 = e.Transform;
      event_UnityEngine_GameObject_Contacts_0 = e.Contacts;
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterCollision_0( );
   }
   
   void Instance_OnExitCollision_0(object o, uScript_Collision.CollisionEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_RelativeVelocity_0 = e.RelativeVelocity;
      event_UnityEngine_GameObject_RigidBody_0 = e.RigidBody;
      event_UnityEngine_GameObject_Collider_0 = e.Collider;
      event_UnityEngine_GameObject_Transform_0 = e.Transform;
      event_UnityEngine_GameObject_Contacts_0 = e.Contacts;
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnExitCollision_0( );
   }
   
   void Instance_WhileInsideCollision_0(object o, uScript_Collision.CollisionEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_RelativeVelocity_0 = e.RelativeVelocity;
      event_UnityEngine_GameObject_RigidBody_0 = e.RigidBody;
      event_UnityEngine_GameObject_Collider_0 = e.Collider;
      event_UnityEngine_GameObject_Transform_0 = e.Transform;
      event_UnityEngine_GameObject_Contacts_0 = e.Contacts;
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideCollision_0( );
   }
   
   void Instance_OnInputEvent_5(object o, uScript_ManagedInput.CustomEventBoolArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_Horizontal_5 = e.Horizontal;
      event_UnityEngine_GameObject_Vertical_5 = e.Vertical;
      event_UnityEngine_GameObject_Fire1_5 = e.Fire1;
      event_UnityEngine_GameObject_Fire2_5 = e.Fire2;
      event_UnityEngine_GameObject_Fire3_5 = e.Fire3;
      event_UnityEngine_GameObject_Jump_5 = e.Jump;
      event_UnityEngine_GameObject_MouseX_5 = e.MouseX;
      event_UnityEngine_GameObject_MouseY_5 = e.MouseY;
      event_UnityEngine_GameObject_MouseScrollWheel_5 = e.MouseScrollWheel;
      event_UnityEngine_GameObject_WindowShakeX_5 = e.WindowShakeX;
      event_UnityEngine_GameObject_WindowShakeY_5 = e.WindowShakeY;
      //relay event to nodes
      Relay_OnInputEvent_5( );
   }
   
   void Instance_OnUpdate_10(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_10( );
   }
   
   void Instance_OnLateUpdate_10(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_10( );
   }
   
   void Instance_OnFixedUpdate_10(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_10( );
   }
   
   void uScriptAct_MoveToLocationFixed_Finished_36(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_36( );
   }
   
   void Relay_OnEnterCollision_0()
   {
      if (true == CheckDebugBreak("7e541fea-1cf4-4bc0-9867-93f7096f374c", "On_Collision", Relay_OnEnterCollision_0)) return; 
      local_collider_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_collider_UnityEngine_GameObject_previous != local_collider_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_collider_UnityEngine_GameObject_previous = local_collider_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_OnExitCollision_0()
   {
      if (true == CheckDebugBreak("7e541fea-1cf4-4bc0-9867-93f7096f374c", "On_Collision", Relay_OnExitCollision_0)) return; 
      local_collider_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_collider_UnityEngine_GameObject_previous != local_collider_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_collider_UnityEngine_GameObject_previous = local_collider_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_WhileInsideCollision_0()
   {
      if (true == CheckDebugBreak("7e541fea-1cf4-4bc0-9867-93f7096f374c", "On_Collision", Relay_WhileInsideCollision_0)) return; 
      local_collider_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_collider_UnityEngine_GameObject_previous != local_collider_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_collider_UnityEngine_GameObject_previous = local_collider_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1cb56659-7691-41b9-abd5-8fa6b2393d06", "GameObject_Has_Tag", Relay_In_2)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_collider_UnityEngine_GameObject_previous != local_collider_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_collider_UnityEngine_GameObject_previous = local_collider_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_2 = local_collider_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_2.In(logic_uScriptCon_GameObjectHasTag_GameObject_2, logic_uScriptCon_GameObjectHasTag_Tag_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_2.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_20();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fcfd50a5-4bd9-4be4-ad40-eb263f5c32b1", "Is_GameObject_Null", Relay_In_4)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject_previous )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                           if ( null != component )
                           {
                              component.OnUpdate -= Instance_OnUpdate_10;
                              component.OnLateUpdate -= Instance_OnLateUpdate_10;
                              component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                     
                     local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
                     
                     //setup new listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                           if ( null == component )
                           {
                              component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                           }
                           if ( null != component )
                           {
                              component.OnUpdate += Instance_OnUpdate_10;
                              component.OnLateUpdate += Instance_OnLateUpdate_10;
                              component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                  }
               }
               if ( logic_uScriptCon_IsNull_Target_4.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptCon_IsNull_Target_4, index + 1);
               }
               logic_uScriptCon_IsNull_Target_4[ index++ ] = local_pickedObj_UnityEngine_GameObject;
               
            }
         }
         logic_uScriptCon_IsNull_uScriptCon_IsNull_4.In(logic_uScriptCon_IsNull_Target_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_IsNull_uScriptCon_IsNull_4.IsNull;
         
         if ( test_0 == true )
         {
            Relay_In_7();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Is GameObject Null.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnInputEvent_5()
   {
      if (true == CheckDebugBreak("d655103f-3d0d-475d-823d-f5615398399c", "Managed_Input_Events", Relay_OnInputEvent_5)) return; 
      local_6_System_Boolean = event_UnityEngine_GameObject_Fire1_5;
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9327a5ca-23f6-42e9-a8fa-9b3cfb9d30f8", "Compare_Bool_State", Relay_In_7)) return; 
         {
            {
               logic_uScriptCon_CompareBoolState_target_7 = local_6_System_Boolean;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_7.In(logic_uScriptCon_CompareBoolState_target_7, ref logic_uScriptCon_CompareBoolState_previousState_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_7.IsTrue;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Compare Bool State.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1c3a13ab-bf27-4e42-ba82-85823350b2aa", "Set_GameObject", Relay_In_8)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_collider_UnityEngine_GameObject_previous != local_collider_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_collider_UnityEngine_GameObject_previous = local_collider_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_SetGameObject_Value_8 = local_collider_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_8.In(logic_uScriptAct_SetGameObject_Value_8, out logic_uScriptAct_SetGameObject_TargetGameObject_8);
         local_pickedObj_UnityEngine_GameObject = logic_uScriptAct_SetGameObject_TargetGameObject_8;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
            {
               //tear down old listeners
               if ( null != local_pickedObj_UnityEngine_GameObject_previous )
               {
                  {
                     uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                     if ( null != component )
                     {
                        component.OnUpdate -= Instance_OnUpdate_10;
                        component.OnLateUpdate -= Instance_OnLateUpdate_10;
                        component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                     }
                  }
               }
               
               local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
               
               //setup new listeners
               if ( null != local_pickedObj_UnityEngine_GameObject )
               {
                  {
                     uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                     if ( null == component )
                     {
                        component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                     }
                     if ( null != component )
                     {
                        component.OnUpdate += Instance_OnUpdate_10;
                        component.OnLateUpdate += Instance_OnLateUpdate_10;
                        component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                     }
                  }
               }
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_8.Out;
         
         if ( test_0 == true )
         {
            Relay_In_14();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Set GameObject.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e7ec3327-f42c-46d5-b45b-de3402b96df2", "Compare_Bool_State", Relay_In_9)) return; 
         {
            {
               logic_uScriptCon_CompareBoolState_target_9 = local_6_System_Boolean;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_9.In(logic_uScriptCon_CompareBoolState_target_9, ref logic_uScriptCon_CompareBoolState_previousState_9);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_9.IsTrue;
         bool test_1 = logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_9.IsFalse;
         
         if ( test_0 == true )
         {
            Relay_In_19();
         }
         if ( test_1 == true )
         {
            Relay_False_17();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Compare Bool State.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_10()
   {
      if (true == CheckDebugBreak("656584d9-4d1a-4dc9-b0ba-9e29f7b4b2eb", "Global_Update", Relay_OnUpdate_10)) return; 
      Relay_In_11();
      Relay_In_22();
   }
   
   void Relay_OnLateUpdate_10()
   {
      if (true == CheckDebugBreak("656584d9-4d1a-4dc9-b0ba-9e29f7b4b2eb", "Global_Update", Relay_OnLateUpdate_10)) return; 
   }
   
   void Relay_OnFixedUpdate_10()
   {
      if (true == CheckDebugBreak("656584d9-4d1a-4dc9-b0ba-9e29f7b4b2eb", "Global_Update", Relay_OnFixedUpdate_10)) return; 
      Relay_In_29();
   }
   
   void Relay_In_11()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("bd7bb00a-87c1-4a32-9e79-20397d65ac1a", "Check_Distance", Relay_In_11)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject_previous )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                           if ( null != component )
                           {
                              component.OnUpdate -= Instance_OnUpdate_10;
                              component.OnLateUpdate -= Instance_OnLateUpdate_10;
                              component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                     
                     local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
                     
                     //setup new listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                           if ( null == component )
                           {
                              component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                           }
                           if ( null != component )
                           {
                              component.OnUpdate += Instance_OnUpdate_10;
                              component.OnLateUpdate += Instance_OnLateUpdate_10;
                              component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                  }
               }
               logic_uScriptCon_CheckDistance_A_11 = local_pickedObj_UnityEngine_GameObject;
               
            }
            {
            }
            {
               logic_uScriptCon_CheckDistance_Distance_11 = local_pickDist_System_Single;
               
            }
         }
         logic_uScriptCon_CheckDistance_uScriptCon_CheckDistance_11.In(logic_uScriptCon_CheckDistance_A_11, logic_uScriptCon_CheckDistance_B_11, logic_uScriptCon_CheckDistance_Distance_11);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CheckDistance_uScriptCon_CheckDistance_11.Further;
         
         if ( test_0 == true )
         {
            Relay_In_26();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Check Distance.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_12()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("074d1b0e-7307-41b4-9e1a-2caa0e31b1f1", "Set_GameObject", Relay_In_12)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_12.In(logic_uScriptAct_SetGameObject_Value_12, out logic_uScriptAct_SetGameObject_TargetGameObject_12);
         local_pickedObj_UnityEngine_GameObject = logic_uScriptAct_SetGameObject_TargetGameObject_12;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
            {
               //tear down old listeners
               if ( null != local_pickedObj_UnityEngine_GameObject_previous )
               {
                  {
                     uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                     if ( null != component )
                     {
                        component.OnUpdate -= Instance_OnUpdate_10;
                        component.OnLateUpdate -= Instance_OnLateUpdate_10;
                        component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                     }
                  }
               }
               
               local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
               
               //setup new listeners
               if ( null != local_pickedObj_UnityEngine_GameObject )
               {
                  {
                     uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                     if ( null == component )
                     {
                        component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                     }
                     if ( null != component )
                     {
                        component.OnUpdate += Instance_OnUpdate_10;
                        component.OnLateUpdate += Instance_OnLateUpdate_10;
                        component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                     }
                  }
               }
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Set GameObject.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_14()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f2e332ec-a3e0-4c63-800f-bf0fca0cc879", "Get_Distance", Relay_In_14)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject_previous )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                           if ( null != component )
                           {
                              component.OnUpdate -= Instance_OnUpdate_10;
                              component.OnLateUpdate -= Instance_OnLateUpdate_10;
                              component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                     
                     local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
                     
                     //setup new listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                           if ( null == component )
                           {
                              component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                           }
                           if ( null != component )
                           {
                              component.OnUpdate += Instance_OnUpdate_10;
                              component.OnLateUpdate += Instance_OnLateUpdate_10;
                              component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                  }
               }
               logic_uScriptAct_GetDistance_A_14 = local_pickedObj_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetDistance_uScriptAct_GetDistance_14.In(logic_uScriptAct_GetDistance_A_14, logic_uScriptAct_GetDistance_B_14, out logic_uScriptAct_GetDistance_Distance_14);
         local_pickDist_System_Single = logic_uScriptAct_GetDistance_Distance_14;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetDistance_uScriptAct_GetDistance_14.Out;
         
         if ( test_0 == true )
         {
            Relay_In_15();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Get Distance.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d27af1a8-6181-42a7-9a3d-d4d8a37c916f", "Multiply_Float", Relay_In_15)) return; 
         {
            {
               logic_uScriptAct_MultiplyFloat_v2_A_15 = local_pickDist_System_Single;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_15.In(logic_uScriptAct_MultiplyFloat_v2_A_15, logic_uScriptAct_MultiplyFloat_v2_B_15, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_15, out logic_uScriptAct_MultiplyFloat_v2_IntResult_15);
         local_pickDist_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_15;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_15.Out;
         
         if ( test_0 == true )
         {
            Relay_In_27();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Multiply Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_True_17()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("79c73a9c-14cc-47b0-8406-99ff5ad793ed", "Set_Bool", Relay_True_17)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_17.True(out logic_uScriptAct_SetBool_Target_17);
         local_16_System_Boolean = logic_uScriptAct_SetBool_Target_17;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_17.SetTrue;
         
         if ( test_0 == true )
         {
            Relay_In_8();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_False_17()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("79c73a9c-14cc-47b0-8406-99ff5ad793ed", "Set_Bool", Relay_False_17)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_17.False(out logic_uScriptAct_SetBool_Target_17);
         local_16_System_Boolean = logic_uScriptAct_SetBool_Target_17;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetBool_uScriptAct_SetBool_17.SetTrue;
         
         if ( test_0 == true )
         {
            Relay_In_8();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9ab08280-764a-4980-9265-b8b5db17c71f", "Is_GameObject_Null", Relay_In_18)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject_previous )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                           if ( null != component )
                           {
                              component.OnUpdate -= Instance_OnUpdate_10;
                              component.OnLateUpdate -= Instance_OnLateUpdate_10;
                              component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                     
                     local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
                     
                     //setup new listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                           if ( null == component )
                           {
                              component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                           }
                           if ( null != component )
                           {
                              component.OnUpdate += Instance_OnUpdate_10;
                              component.OnLateUpdate += Instance_OnLateUpdate_10;
                              component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                  }
               }
               if ( logic_uScriptCon_IsNull_Target_18.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptCon_IsNull_Target_18, index + 1);
               }
               logic_uScriptCon_IsNull_Target_18[ index++ ] = local_pickedObj_UnityEngine_GameObject;
               
            }
         }
         logic_uScriptCon_IsNull_uScriptCon_IsNull_18.In(logic_uScriptCon_IsNull_Target_18);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_IsNull_uScriptCon_IsNull_18.IsNotNull;
         
         if ( test_0 == true )
         {
            Relay_True_21();
            Relay_In_26();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Is GameObject Null.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_19()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d7edae1d-76c4-45df-911a-64487b03353a", "Compare_Bool", Relay_In_19)) return; 
         {
            {
               logic_uScriptCon_CompareBool_Bool_19 = local_16_System_Boolean;
               
            }
         }
         logic_uScriptCon_CompareBool_uScriptCon_CompareBool_19.In(logic_uScriptCon_CompareBool_Bool_19);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_19.False;
         
         if ( test_0 == true )
         {
            Relay_In_18();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Compare Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fad6a57c-7231-45f6-87a1-57255fa3db64", "Compare_Bool", Relay_In_20)) return; 
         {
            {
               logic_uScriptCon_CompareBool_Bool_20 = local_16_System_Boolean;
               
            }
         }
         logic_uScriptCon_CompareBool_uScriptCon_CompareBool_20.In(logic_uScriptCon_CompareBool_Bool_20);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareBool_uScriptCon_CompareBool_20.False;
         
         if ( test_0 == true )
         {
            Relay_True_17();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Compare Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_True_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("c73a4ba1-7c17-4f9e-ae30-1f697b34f65e", "Set_Bool", Relay_True_21)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_21.True(out logic_uScriptAct_SetBool_Target_21);
         local_16_System_Boolean = logic_uScriptAct_SetBool_Target_21;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_False_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("c73a4ba1-7c17-4f9e-ae30-1f697b34f65e", "Set_Bool", Relay_False_21)) return; 
         {
            {
            }
         }
         logic_uScriptAct_SetBool_uScriptAct_SetBool_21.False(out logic_uScriptAct_SetBool_Target_21);
         local_16_System_Boolean = logic_uScriptAct_SetBool_Target_21;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Set Bool.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_22()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("dadaeaae-360d-458e-8057-f3f2be7ccab3", "Get_Facing_Angle", Relay_In_22)) return; 
         {
            {
            }
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject_previous )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                           if ( null != component )
                           {
                              component.OnUpdate -= Instance_OnUpdate_10;
                              component.OnLateUpdate -= Instance_OnLateUpdate_10;
                              component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                     
                     local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
                     
                     //setup new listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                           if ( null == component )
                           {
                              component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                           }
                           if ( null != component )
                           {
                              component.OnUpdate += Instance_OnUpdate_10;
                              component.OnLateUpdate += Instance_OnLateUpdate_10;
                              component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                  }
               }
               logic_uScriptAct_GetFacingAngle_B_22 = local_pickedObj_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_GetFacingAngle_uScriptAct_GetFacingAngle_22.In(logic_uScriptAct_GetFacingAngle_A_22, logic_uScriptAct_GetFacingAngle_B_22, out logic_uScriptAct_GetFacingAngle_Angle_22);
         local_23_System_Single = logic_uScriptAct_GetFacingAngle_Angle_22;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetFacingAngle_uScriptAct_GetFacingAngle_22.Out;
         
         if ( test_0 == true )
         {
            Relay_Abs_25();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Get Facing Angle.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_24()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4c789f57-841d-4c9a-89f0-d001b0c0e2c4", "Compare_Float", Relay_In_24)) return; 
         {
            {
               logic_uScriptCon_CompareFloat_A_24 = local_23_System_Single;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_24.In(logic_uScriptCon_CompareFloat_A_24, logic_uScriptCon_CompareFloat_B_24);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_24.GreaterThan;
         
         if ( test_0 == true )
         {
            Relay_In_26();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Compare Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Abs_25()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("43d8844f-3d3c-4441-a05f-bf1fb0c93a38", "System_Math", Relay_Abs_25)) return; 
         {
            {
               method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_value_25 = local_23_System_Single;
               
            }
            {
            }
         }
         method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_Return_25 = System.Math.Abs(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_value_25);
         local_23_System_Single = method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_Return_25;
         Relay_In_24();
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at System.Math.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_26()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9233e001-8cc4-470a-abb9-864db71008ce", "Set_Parent", Relay_In_26)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject_previous )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                           if ( null != component )
                           {
                              component.OnUpdate -= Instance_OnUpdate_10;
                              component.OnLateUpdate -= Instance_OnLateUpdate_10;
                              component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                     
                     local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
                     
                     //setup new listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                           if ( null == component )
                           {
                              component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                           }
                           if ( null != component )
                           {
                              component.OnUpdate += Instance_OnUpdate_10;
                              component.OnLateUpdate += Instance_OnLateUpdate_10;
                              component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                  }
               }
               if ( logic_uScriptAct_SetParent_Target_26.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_SetParent_Target_26, index + 1);
               }
               logic_uScriptAct_SetParent_Target_26[ index++ ] = local_pickedObj_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_SetParent_uScriptAct_SetParent_26.In(logic_uScriptAct_SetParent_Target_26, logic_uScriptAct_SetParent_Parent_26);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetParent_uScriptAct_SetParent_26.Out;
         
         if ( test_0 == true )
         {
            Relay_In_12();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Set Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_27()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9791cd8b-ad8f-4932-8062-bc4e3dba9001", "Set_Parent", Relay_In_27)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject_previous )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                           if ( null != component )
                           {
                              component.OnUpdate -= Instance_OnUpdate_10;
                              component.OnLateUpdate -= Instance_OnLateUpdate_10;
                              component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                     
                     local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
                     
                     //setup new listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                           if ( null == component )
                           {
                              component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                           }
                           if ( null != component )
                           {
                              component.OnUpdate += Instance_OnUpdate_10;
                              component.OnLateUpdate += Instance_OnLateUpdate_10;
                              component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                  }
               }
               if ( logic_uScriptAct_SetParent_Target_27.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_SetParent_Target_27, index + 1);
               }
               logic_uScriptAct_SetParent_Target_27[ index++ ] = local_pickedObj_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_SetParent_uScriptAct_SetParent_27.In(logic_uScriptAct_SetParent_Target_27, logic_uScriptAct_SetParent_Parent_27);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Set Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_29()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("f61d0c6b-7aef-419d-8706-5e0accf54d80", "Get_Position_and_Rotation", Relay_In_29)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject_previous )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                           if ( null != component )
                           {
                              component.OnUpdate -= Instance_OnUpdate_10;
                              component.OnLateUpdate -= Instance_OnLateUpdate_10;
                              component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                     
                     local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
                     
                     //setup new listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                           if ( null == component )
                           {
                              component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                           }
                           if ( null != component )
                           {
                              component.OnUpdate += Instance_OnUpdate_10;
                              component.OnLateUpdate += Instance_OnLateUpdate_10;
                              component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                  }
               }
               logic_uScriptAct_GetPositionAndRotation_Target_29 = local_pickedObj_UnityEngine_GameObject;
               
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_29.In(logic_uScriptAct_GetPositionAndRotation_Target_29, logic_uScriptAct_GetPositionAndRotation_GetLocal_29, out logic_uScriptAct_GetPositionAndRotation_Position_29, out logic_uScriptAct_GetPositionAndRotation_Rotation_29, out logic_uScriptAct_GetPositionAndRotation_EulerAngles_29, out logic_uScriptAct_GetPositionAndRotation_Forward_29, out logic_uScriptAct_GetPositionAndRotation_Up_29, out logic_uScriptAct_GetPositionAndRotation_Right_29);
         local_28_UnityEngine_Vector3 = logic_uScriptAct_GetPositionAndRotation_Position_29;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_29.Out;
         
         if ( test_0 == true )
         {
            Relay_In_30();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Get Position and Rotation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_30()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("387850fb-67b6-4ed5-b04f-04ef2b439378", "Get_Components__Vector3_", Relay_In_30)) return; 
         {
            {
               logic_uScriptAct_GetComponentsVector3_InputVector3_30 = local_28_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_30.In(logic_uScriptAct_GetComponentsVector3_InputVector3_30, out logic_uScriptAct_GetComponentsVector3_X_30, out logic_uScriptAct_GetComponentsVector3_Y_30, out logic_uScriptAct_GetComponentsVector3_Z_30);
         local_31_System_Single = logic_uScriptAct_GetComponentsVector3_X_30;
         local_32_System_Single = logic_uScriptAct_GetComponentsVector3_Y_30;
         local_33_System_Single = logic_uScriptAct_GetComponentsVector3_Z_30;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_30.Out;
         
         if ( test_0 == true )
         {
            Relay_In_35();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Get Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_34()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4b1d150d-6d33-4654-8749-018c5ce2a7a5", "Set_Components__Vector3_", Relay_In_34)) return; 
         {
            {
               logic_uScriptAct_SetComponentsVector3_X_34 = local_31_System_Single;
               
            }
            {
               logic_uScriptAct_SetComponentsVector3_Y_34 = local_32_System_Single;
               
            }
            {
               logic_uScriptAct_SetComponentsVector3_Z_34 = local_33_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_34.In(logic_uScriptAct_SetComponentsVector3_X_34, logic_uScriptAct_SetComponentsVector3_Y_34, logic_uScriptAct_SetComponentsVector3_Z_34, out logic_uScriptAct_SetComponentsVector3_OutputVector3_34);
         local_28_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_34;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_34.Out;
         
         if ( test_0 == true )
         {
            Relay_In_36();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Set Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_35()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a0186fa4-e7b1-4fcd-bbd7-171a834ec664", "Add_Float", Relay_In_35)) return; 
         {
            {
               logic_uScriptAct_AddFloat_v2_A_35 = local_32_System_Single;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_35.In(logic_uScriptAct_AddFloat_v2_A_35, logic_uScriptAct_AddFloat_v2_B_35, out logic_uScriptAct_AddFloat_v2_FloatResult_35, out logic_uScriptAct_AddFloat_v2_IntResult_35);
         local_32_System_Single = logic_uScriptAct_AddFloat_v2_FloatResult_35;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_35.Out;
         
         if ( test_0 == true )
         {
            Relay_In_34();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Add Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_36()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4968b585-8b1f-4464-ba26-748e49be33f3", "Move_To_Location_Fixed", Relay_Finished_36)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Move To Location Fixed.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_36()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4968b585-8b1f-4464-ba26-748e49be33f3", "Move_To_Location_Fixed", Relay_In_36)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject_previous )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                           if ( null != component )
                           {
                              component.OnUpdate -= Instance_OnUpdate_10;
                              component.OnLateUpdate -= Instance_OnLateUpdate_10;
                              component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                     
                     local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
                     
                     //setup new listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                           if ( null == component )
                           {
                              component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                           }
                           if ( null != component )
                           {
                              component.OnUpdate += Instance_OnUpdate_10;
                              component.OnLateUpdate += Instance_OnLateUpdate_10;
                              component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                  }
               }
               if ( logic_uScriptAct_MoveToLocationFixed_targetArray_36.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_MoveToLocationFixed_targetArray_36, index + 1);
               }
               logic_uScriptAct_MoveToLocationFixed_targetArray_36[ index++ ] = local_pickedObj_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_MoveToLocationFixed_location_36 = local_28_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MoveToLocationFixed_uScriptAct_MoveToLocationFixed_36.In(logic_uScriptAct_MoveToLocationFixed_targetArray_36, logic_uScriptAct_MoveToLocationFixed_location_36, logic_uScriptAct_MoveToLocationFixed_asOffset_36, logic_uScriptAct_MoveToLocationFixed_speed_36);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Move To Location Fixed.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Cancel_36()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4968b585-8b1f-4464-ba26-748e49be33f3", "Move_To_Location_Fixed", Relay_Cancel_36)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_pickedObj_UnityEngine_GameObject_previous != local_pickedObj_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject_previous )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject_previous.GetComponent<uScript_Update>();
                           if ( null != component )
                           {
                              component.OnUpdate -= Instance_OnUpdate_10;
                              component.OnLateUpdate -= Instance_OnLateUpdate_10;
                              component.OnFixedUpdate -= Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                     
                     local_pickedObj_UnityEngine_GameObject_previous = local_pickedObj_UnityEngine_GameObject;
                     
                     //setup new listeners
                     if ( null != local_pickedObj_UnityEngine_GameObject )
                     {
                        {
                           uScript_Update component = local_pickedObj_UnityEngine_GameObject.GetComponent<uScript_Update>();
                           if ( null == component )
                           {
                              component = local_pickedObj_UnityEngine_GameObject.AddComponent<uScript_Update>();
                           }
                           if ( null != component )
                           {
                              component.OnUpdate += Instance_OnUpdate_10;
                              component.OnLateUpdate += Instance_OnLateUpdate_10;
                              component.OnFixedUpdate += Instance_OnFixedUpdate_10;
                           }
                        }
                     }
                  }
               }
               if ( logic_uScriptAct_MoveToLocationFixed_targetArray_36.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_MoveToLocationFixed_targetArray_36, index + 1);
               }
               logic_uScriptAct_MoveToLocationFixed_targetArray_36[ index++ ] = local_pickedObj_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_MoveToLocationFixed_location_36 = local_28_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MoveToLocationFixed_uScriptAct_MoveToLocationFixed_36.Cancel(logic_uScriptAct_MoveToLocationFixed_targetArray_36, logic_uScriptAct_MoveToLocationFixed_location_36, logic_uScriptAct_MoveToLocationFixed_asOffset_36, logic_uScriptAct_MoveToLocationFixed_speed_36);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Move To Location Fixed.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_104()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("7e37cd81-44b4-481c-bf9c-983224216eb1", "Set_Position", Relay_In_104)) return; 
         {
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_104.In(logic_uScriptAct_SetGameObjectPosition_Target_104, logic_uScriptAct_SetGameObjectPosition_Position_104, logic_uScriptAct_SetGameObjectPosition_AsOffset_104, logic_uScriptAct_SetGameObjectPosition_AsLocal_104);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_104.Out;
         
         if ( test_0 == true )
         {
            Relay_In_105();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Set Position.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_105()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b3482d76-4480-40a3-aee7-49763b386972", "Set_Position", Relay_In_105)) return; 
         {
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SetGameObjectPosition_uScriptAct_SetGameObjectPosition_105.In(logic_uScriptAct_SetGameObjectPosition_Target_105, logic_uScriptAct_SetGameObjectPosition_Position_105, logic_uScriptAct_SetGameObjectPosition_AsOffset_105, logic_uScriptAct_SetGameObjectPosition_AsLocal_105);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Set Position.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:collider", local_collider_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "67aaacfb-a75f-4300-bbfe-a13d80138a08", local_collider_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:pickedObj", local_pickedObj_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "609167f6-a5ac-4949-a403-1113bd11f1d5", local_pickedObj_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:6", local_6_System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "84eca832-261c-41e2-9634-e2ad8791152c", local_6_System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:pickDist", local_pickDist_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3f491e2c-2825-4b46-8a9c-758ec933bb98", local_pickDist_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:16", local_16_System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3b2a1d17-1a99-47e5-a6c7-0d310808689d", local_16_System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:23", local_23_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "2afbcfe9-80a5-4368-93c5-ebbeaa550e2f", local_23_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:28", local_28_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "705e1b45-0efa-47c7-ae24-f4677739aa50", local_28_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:31", local_31_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cd51470b-6dff-4f1c-a6a9-7ead95f231b5", local_31_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:32", local_32_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "be673f16-3ced-430d-a027-cd7db924744f", local_32_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:33", local_33_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "fe813776-c713-4fd9-ba04-5508eb53dc08", local_33_System_Single);
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
