//uScript Generated Code - Build 1.0.3024
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class lavaporter : uScriptLogic
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
   public UnityEngine.Vector3 cube1_final = new Vector3( (float)0, (float)0, (float)0 );
   public UnityEngine.Vector3 cube2_final = new Vector3( (float)100, (float)100, (float)100 );
   UnityEngine.Vector3 local_11_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_13_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_13_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_6_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_6_UnityEngine_GameObject_previous = null;
   public UnityEngine.Vector3 playerspawn = new Vector3( (float)0, (float)0, (float)0 );
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_MoveToLocation logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_0 = new uScriptAct_MoveToLocation( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocation_targetArray_0 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocation_location_0 = new Vector3( );
   System.Boolean logic_uScriptAct_MoveToLocation_asOffset_0 = (bool) false;
   System.Single logic_uScriptAct_MoveToLocation_totalTime_0 = (float) 0;
   bool logic_uScriptAct_MoveToLocation_Out_0 = true;
   bool logic_uScriptAct_MoveToLocation_Cancelled_0 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_1 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_1 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_1 = new System.String[] {"Returnable"};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_1 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_1 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_1 = true;
   //pointer to script instanced logic node
   uScriptAct_Log logic_uScriptAct_Log_uScriptAct_Log_2 = new uScriptAct_Log( );
   System.Object logic_uScriptAct_Log_Prefix_2 = "";
   System.Object[] logic_uScriptAct_Log_Target_2 = new System.Object[] {"KILLL FLOOORR!!!"};
   System.Object logic_uScriptAct_Log_Postfix_2 = "";
   bool logic_uScriptAct_Log_Out_2 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPositionAndRotation logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_3 = new uScriptAct_GetPositionAndRotation( );
   UnityEngine.GameObject logic_uScriptAct_GetPositionAndRotation_Target_3 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_GetPositionAndRotation_GetLocal_3 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Position_3;
   UnityEngine.Quaternion logic_uScriptAct_GetPositionAndRotation_Rotation_3;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_EulerAngles_3;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Forward_3;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Up_3;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Right_3;
   bool logic_uScriptAct_GetPositionAndRotation_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPositionAndRotation logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_4 = new uScriptAct_GetPositionAndRotation( );
   UnityEngine.GameObject logic_uScriptAct_GetPositionAndRotation_Target_4 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_GetPositionAndRotation_GetLocal_4 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Position_4;
   UnityEngine.Quaternion logic_uScriptAct_GetPositionAndRotation_Rotation_4;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_EulerAngles_4;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Forward_4;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Up_4;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Right_4;
   bool logic_uScriptAct_GetPositionAndRotation_Out_4 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_7 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_7 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_7 = new System.String[] {"Cube1"};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_7 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_7 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_7 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_8 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_8 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_8 = new System.String[] {"Cube2"};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_8 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_8 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_8 = true;
   //pointer to script instanced logic node
   uScriptAct_SetVector3 logic_uScriptAct_SetVector3_uScriptAct_SetVector3_9 = new uScriptAct_SetVector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_Value_9 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_TargetVector3_9;
   bool logic_uScriptAct_SetVector3_Out_9 = true;
   //pointer to script instanced logic node
   uScriptAct_SetVector3 logic_uScriptAct_SetVector3_uScriptAct_SetVector3_10 = new uScriptAct_SetVector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_Value_10 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_TargetVector3_10;
   bool logic_uScriptAct_SetVector3_Out_10 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_12 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_12 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_12;
   bool logic_uScriptAct_GetParent_Out_12 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_14 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_14 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_14 = new System.String[] {"Player"};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_14 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_14 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_14 = true;
   //pointer to script instanced logic node
   uScriptAct_SetVector3 logic_uScriptAct_SetVector3_uScriptAct_SetVector3_15 = new uScriptAct_SetVector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_Value_15 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_TargetVector3_15;
   bool logic_uScriptAct_SetVector3_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPositionAndRotation logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_17 = new uScriptAct_GetPositionAndRotation( );
   UnityEngine.GameObject logic_uScriptAct_GetPositionAndRotation_Target_17 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_GetPositionAndRotation_GetLocal_17 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Position_17;
   UnityEngine.Quaternion logic_uScriptAct_GetPositionAndRotation_Rotation_17;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_EulerAngles_17;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Forward_17;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Up_17;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Right_17;
   bool logic_uScriptAct_GetPositionAndRotation_Out_17 = true;
   //pointer to script instanced logic node
   uScriptAct_IgnoreCollision logic_uScriptAct_IgnoreCollision_uScriptAct_IgnoreCollision_20 = new uScriptAct_IgnoreCollision( );
   UnityEngine.GameObject logic_uScriptAct_IgnoreCollision_A_20 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_IgnoreCollision_B_20 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_IgnoreCollision_Ignore_20 = (bool) true;
   bool logic_uScriptAct_IgnoreCollision_Out_20 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_18 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_18 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_21 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == logic_uScriptAct_GetPositionAndRotation_Target_3 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_GetPositionAndRotation_Target_3 = GameObject.Find( "/GameObject (1)" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptAct_GetPositionAndRotation_Target_4 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_GetPositionAndRotation_Target_4 = GameObject.Find( "/GameObject (2)" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptAct_GetPositionAndRotation_Target_17 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_GetPositionAndRotation_Target_17 = GameObject.Find( "/PlayerRespawn/Sphere" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptAct_IgnoreCollision_A_20 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_IgnoreCollision_A_20 = GameObject.Find( "/KillFloor" ) as UnityEngine.GameObject;
      }
      if ( null == logic_uScriptAct_IgnoreCollision_B_20 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_IgnoreCollision_B_20 = GameObject.Find( "/DemoLevel" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_13_UnityEngine_GameObject_previous != local_13_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_13_UnityEngine_GameObject_previous = local_13_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_13_UnityEngine_GameObject_previous != local_13_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_13_UnityEngine_GameObject_previous = local_13_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_18 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_18 = GameObject.Find( "KillFloor" ) as UnityEngine.GameObject;
         if ( null != event_UnityEngine_GameObject_Instance_18 )
         {
            {
               uScript_Trigger component = event_UnityEngine_GameObject_Instance_18.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_18.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_18;
                  component.OnExitTrigger += Instance_OnExitTrigger_18;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_18;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_21 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_21 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_21 )
         {
            {
               uScript_Global component = event_UnityEngine_GameObject_Instance_21.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_21.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_21;
                  component.uScriptLateStart += Instance_uScriptLateStart_21;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_18 )
      {
         {
            uScript_Trigger component = event_UnityEngine_GameObject_Instance_18.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_18;
               component.OnExitTrigger -= Instance_OnExitTrigger_18;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_18;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_21 )
      {
         {
            uScript_Global component = event_UnityEngine_GameObject_Instance_21.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_21;
               component.uScriptLateStart -= Instance_uScriptLateStart_21;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_0.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_1.SetParent(g);
      logic_uScriptAct_Log_uScriptAct_Log_2.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_3.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_4.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_7.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_8.SetParent(g);
      logic_uScriptAct_SetVector3_uScriptAct_SetVector3_9.SetParent(g);
      logic_uScriptAct_SetVector3_uScriptAct_SetVector3_10.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_12.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_14.SetParent(g);
      logic_uScriptAct_SetVector3_uScriptAct_SetVector3_15.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_17.SetParent(g);
      logic_uScriptAct_IgnoreCollision_uScriptAct_IgnoreCollision_20.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_0.Finished += uScriptAct_MoveToLocation_Finished_0;
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
      
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_0.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_0.Finished -= uScriptAct_MoveToLocation_Finished_0;
   }
   
   void Instance_OnEnterTrigger_18(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_18 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_18( );
   }
   
   void Instance_OnExitTrigger_18(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_18 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_18( );
   }
   
   void Instance_WhileInsideTrigger_18(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_18 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_18( );
   }
   
   void Instance_uScriptStart_21(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_21( );
   }
   
   void Instance_uScriptLateStart_21(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_21( );
   }
   
   void uScriptAct_MoveToLocation_Finished_0(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_0( );
   }
   
   void Relay_Finished_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3ff32cc3-ce0c-4227-82aa-0a86ae25d2a4", "Move_To_Location", Relay_Finished_0)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Move To Location.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3ff32cc3-ce0c-4227-82aa-0a86ae25d2a4", "Move_To_Location", Relay_In_0)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_MoveToLocation_targetArray_0.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_MoveToLocation_targetArray_0, index + 1);
               }
               logic_uScriptAct_MoveToLocation_targetArray_0[ index++ ] = local_6_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_MoveToLocation_location_0 = local_11_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_0.In(logic_uScriptAct_MoveToLocation_targetArray_0, logic_uScriptAct_MoveToLocation_location_0, logic_uScriptAct_MoveToLocation_asOffset_0, logic_uScriptAct_MoveToLocation_totalTime_0);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Move To Location.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Cancel_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("3ff32cc3-ce0c-4227-82aa-0a86ae25d2a4", "Move_To_Location", Relay_Cancel_0)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_MoveToLocation_targetArray_0.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_MoveToLocation_targetArray_0, index + 1);
               }
               logic_uScriptAct_MoveToLocation_targetArray_0[ index++ ] = local_6_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_MoveToLocation_location_0 = local_11_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_0.Cancel(logic_uScriptAct_MoveToLocation_targetArray_0, logic_uScriptAct_MoveToLocation_location_0, logic_uScriptAct_MoveToLocation_asOffset_0, logic_uScriptAct_MoveToLocation_totalTime_0);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Move To Location.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e438967a-0204-4548-a684-c7b8a7af2d95", "GameObject_Has_Tag", Relay_In_1)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_13_UnityEngine_GameObject_previous != local_13_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_13_UnityEngine_GameObject_previous = local_13_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_1 = local_13_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_1.In(logic_uScriptCon_GameObjectHasTag_GameObject_1, logic_uScriptCon_GameObjectHasTag_Tag_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_1.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_7();
            Relay_In_8();
            Relay_In_14();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("53962bff-bff9-48af-88ce-27cf19a24135", "Log", Relay_In_2)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_Log_uScriptAct_Log_2.In(logic_uScriptAct_Log_Prefix_2, logic_uScriptAct_Log_Target_2, logic_uScriptAct_Log_Postfix_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Log_uScriptAct_Log_2.Out;
         
         if ( test_0 == true )
         {
            Relay_In_0();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Log.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b6e3ac72-781c-4c63-9d15-686fa5ce8de5", "Get_Position_and_Rotation", Relay_In_3)) return; 
         {
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
            {
            }
         }
         logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_3.In(logic_uScriptAct_GetPositionAndRotation_Target_3, logic_uScriptAct_GetPositionAndRotation_GetLocal_3, out logic_uScriptAct_GetPositionAndRotation_Position_3, out logic_uScriptAct_GetPositionAndRotation_Rotation_3, out logic_uScriptAct_GetPositionAndRotation_EulerAngles_3, out logic_uScriptAct_GetPositionAndRotation_Forward_3, out logic_uScriptAct_GetPositionAndRotation_Up_3, out logic_uScriptAct_GetPositionAndRotation_Right_3);
         cube2_final = logic_uScriptAct_GetPositionAndRotation_Position_3;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_3.Out;
         
         if ( test_0 == true )
         {
            Relay_In_17();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Get Position and Rotation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ab1eedd1-a534-4bd2-b16a-f799b2a2326b", "Get_Position_and_Rotation", Relay_In_4)) return; 
         {
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
            {
            }
         }
         logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_4.In(logic_uScriptAct_GetPositionAndRotation_Target_4, logic_uScriptAct_GetPositionAndRotation_GetLocal_4, out logic_uScriptAct_GetPositionAndRotation_Position_4, out logic_uScriptAct_GetPositionAndRotation_Rotation_4, out logic_uScriptAct_GetPositionAndRotation_EulerAngles_4, out logic_uScriptAct_GetPositionAndRotation_Forward_4, out logic_uScriptAct_GetPositionAndRotation_Up_4, out logic_uScriptAct_GetPositionAndRotation_Right_4);
         cube1_final = logic_uScriptAct_GetPositionAndRotation_Position_4;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_4.Out;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Get Position and Rotation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b448a37e-92e8-43dc-8e47-ef97d45b36e1", "GameObject_Has_Tag", Relay_In_7)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_7 = local_6_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_7.In(logic_uScriptCon_GameObjectHasTag_GameObject_7, logic_uScriptCon_GameObjectHasTag_Tag_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_7.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_9();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("573b879c-ae69-475c-bd4b-eeb96717233f", "GameObject_Has_Tag", Relay_In_8)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_8 = local_6_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_8.In(logic_uScriptCon_GameObjectHasTag_GameObject_8, logic_uScriptCon_GameObjectHasTag_Tag_8);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_8.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_10();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("74b7cdba-b11e-418c-aeb5-94ab2e09208b", "Set_Vector3", Relay_In_9)) return; 
         {
            {
               logic_uScriptAct_SetVector3_Value_9 = cube2_final;
               
            }
            {
            }
         }
         logic_uScriptAct_SetVector3_uScriptAct_SetVector3_9.In(logic_uScriptAct_SetVector3_Value_9, out logic_uScriptAct_SetVector3_TargetVector3_9);
         local_11_UnityEngine_Vector3 = logic_uScriptAct_SetVector3_TargetVector3_9;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetVector3_uScriptAct_SetVector3_9.Out;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Set Vector3.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("03ede5ba-85a8-4ff6-882a-9850b5c5cd2b", "Set_Vector3", Relay_In_10)) return; 
         {
            {
               logic_uScriptAct_SetVector3_Value_10 = cube1_final;
               
            }
            {
            }
         }
         logic_uScriptAct_SetVector3_uScriptAct_SetVector3_10.In(logic_uScriptAct_SetVector3_Value_10, out logic_uScriptAct_SetVector3_TargetVector3_10);
         local_11_UnityEngine_Vector3 = logic_uScriptAct_SetVector3_TargetVector3_10;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetVector3_uScriptAct_SetVector3_10.Out;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Set Vector3.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_12()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("007a1e51-55c7-47f8-846e-3b0199189a6c", "Get_Parent", Relay_In_12)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_GetParent_Target_12 = local_6_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_12.In(logic_uScriptAct_GetParent_Target_12, out logic_uScriptAct_GetParent_Parent_12);
         local_13_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_12;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_13_UnityEngine_GameObject_previous != local_13_UnityEngine_GameObject || false == m_RegisteredForEvents )
            {
               //tear down old listeners
               
               local_13_UnityEngine_GameObject_previous = local_13_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_12.Out;
         
         if ( test_0 == true )
         {
            Relay_In_1();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Get Parent.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_14()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4f16d4f2-dbcd-4e2a-8eb4-405fabd3d99d", "GameObject_Has_Tag", Relay_In_14)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_14 = local_6_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_14.In(logic_uScriptCon_GameObjectHasTag_GameObject_14, logic_uScriptCon_GameObjectHasTag_Tag_14);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_14.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_15();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a124256f-5135-4808-a251-f401b42c1716", "Set_Vector3", Relay_In_15)) return; 
         {
            {
               logic_uScriptAct_SetVector3_Value_15 = playerspawn;
               
            }
            {
            }
         }
         logic_uScriptAct_SetVector3_uScriptAct_SetVector3_15.In(logic_uScriptAct_SetVector3_Value_15, out logic_uScriptAct_SetVector3_TargetVector3_15);
         local_11_UnityEngine_Vector3 = logic_uScriptAct_SetVector3_TargetVector3_15;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetVector3_uScriptAct_SetVector3_15.Out;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Set Vector3.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_17()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("83f02e02-e4b1-43a3-a94e-334ba66e9cbb", "Get_Position_and_Rotation", Relay_In_17)) return; 
         {
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
            {
            }
         }
         logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_17.In(logic_uScriptAct_GetPositionAndRotation_Target_17, logic_uScriptAct_GetPositionAndRotation_GetLocal_17, out logic_uScriptAct_GetPositionAndRotation_Position_17, out logic_uScriptAct_GetPositionAndRotation_Rotation_17, out logic_uScriptAct_GetPositionAndRotation_EulerAngles_17, out logic_uScriptAct_GetPositionAndRotation_Forward_17, out logic_uScriptAct_GetPositionAndRotation_Up_17, out logic_uScriptAct_GetPositionAndRotation_Right_17);
         playerspawn = logic_uScriptAct_GetPositionAndRotation_Position_17;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Get Position and Rotation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnEnterTrigger_18()
   {
      if (true == CheckDebugBreak("f55c129b-8dd7-4ae7-bf21-fd145c56e24c", "Trigger_Event", Relay_OnEnterTrigger_18)) return; 
      local_6_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_18;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_20();
   }
   
   void Relay_OnExitTrigger_18()
   {
      if (true == CheckDebugBreak("f55c129b-8dd7-4ae7-bf21-fd145c56e24c", "Trigger_Event", Relay_OnExitTrigger_18)) return; 
      local_6_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_18;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_WhileInsideTrigger_18()
   {
      if (true == CheckDebugBreak("f55c129b-8dd7-4ae7-bf21-fd145c56e24c", "Trigger_Event", Relay_WhileInsideTrigger_18)) return; 
      local_6_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_18;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_6_UnityEngine_GameObject_previous != local_6_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_6_UnityEngine_GameObject_previous = local_6_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_In_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("edab6505-e546-4ca7-bcbe-b54ad2f5a734", "Ignore_Collision", Relay_In_20)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_IgnoreCollision_uScriptAct_IgnoreCollision_20.In(logic_uScriptAct_IgnoreCollision_A_20, logic_uScriptAct_IgnoreCollision_B_20, logic_uScriptAct_IgnoreCollision_Ignore_20);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_IgnoreCollision_uScriptAct_IgnoreCollision_20.Out;
         
         if ( test_0 == true )
         {
            Relay_In_12();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Ignore Collision.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_uScriptStart_21()
   {
      if (true == CheckDebugBreak("27f1966b-cd18-40d6-a83a-b3e7ad945f51", "uScript_Events", Relay_uScriptStart_21)) return; 
      Relay_In_4();
   }
   
   void Relay_uScriptLateStart_21()
   {
      if (true == CheckDebugBreak("27f1966b-cd18-40d6-a83a-b3e7ad945f51", "uScript_Events", Relay_uScriptLateStart_21)) return; 
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:cube2_final", cube2_final);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5231e109-341a-49f0-815b-a9fe193930de", cube2_final);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:6", local_6_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a6717267-3c67-42bb-ab8c-762ee62d9600", local_6_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:11", local_11_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "c7fe5a13-f291-4364-92e0-ef73153c2e19", local_11_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:13", local_13_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5364811f-876b-4e89-9d72-2429e1305ef4", local_13_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:playerspawn", playerspawn);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "1517affa-81b0-4a07-b1b7-9b00a9fc4ec3", playerspawn);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:cube1_final", cube1_final);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "e8aa76d2-1033-441b-ac10-770ce995b0e6", cube1_final);
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
