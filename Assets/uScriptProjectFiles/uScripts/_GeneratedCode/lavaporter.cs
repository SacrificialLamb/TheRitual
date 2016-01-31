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
   UnityEngine.Vector3 local_10_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Vector3 local_11_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_12_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_12_UnityEngine_GameObject_previous = null;
   UnityEngine.Vector3 local_17_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_19_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_19_UnityEngine_GameObject_previous = null;
   UnityEngine.Vector3 local_22_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_Cube1_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_Cube1_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_Cube2_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_Cube2_UnityEngine_GameObject_previous = null;
   
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
   uScriptAct_SetGameObject logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_3 = new uScriptAct_SetGameObject( );
   UnityEngine.GameObject logic_uScriptAct_SetGameObject_Value_3 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_SetGameObject_TargetGameObject_3;
   bool logic_uScriptAct_SetGameObject_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_SetGameObject logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_4 = new uScriptAct_SetGameObject( );
   UnityEngine.GameObject logic_uScriptAct_SetGameObject_Value_4 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_SetGameObject_TargetGameObject_4;
   bool logic_uScriptAct_SetGameObject_Out_4 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPositionAndRotation logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_8 = new uScriptAct_GetPositionAndRotation( );
   UnityEngine.GameObject logic_uScriptAct_GetPositionAndRotation_Target_8 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_GetPositionAndRotation_GetLocal_8 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Position_8;
   UnityEngine.Quaternion logic_uScriptAct_GetPositionAndRotation_Rotation_8;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_EulerAngles_8;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Forward_8;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Up_8;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Right_8;
   bool logic_uScriptAct_GetPositionAndRotation_Out_8 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPositionAndRotation logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_9 = new uScriptAct_GetPositionAndRotation( );
   UnityEngine.GameObject logic_uScriptAct_GetPositionAndRotation_Target_9 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_GetPositionAndRotation_GetLocal_9 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Position_9;
   UnityEngine.Quaternion logic_uScriptAct_GetPositionAndRotation_Rotation_9;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_EulerAngles_9;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Forward_9;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Up_9;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Right_9;
   bool logic_uScriptAct_GetPositionAndRotation_Out_9 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_13 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_13 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_13 = new System.String[] {"Cube1"};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_13 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_13 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_13 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_14 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_14 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_14 = new System.String[] {"Cube2"};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_14 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_14 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_14 = true;
   //pointer to script instanced logic node
   uScriptAct_SetVector3 logic_uScriptAct_SetVector3_uScriptAct_SetVector3_15 = new uScriptAct_SetVector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_Value_15 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_TargetVector3_15;
   bool logic_uScriptAct_SetVector3_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_SetVector3 logic_uScriptAct_SetVector3_uScriptAct_SetVector3_16 = new uScriptAct_SetVector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_Value_16 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_TargetVector3_16;
   bool logic_uScriptAct_SetVector3_Out_16 = true;
   //pointer to script instanced logic node
   uScriptAct_GetParent logic_uScriptAct_GetParent_uScriptAct_GetParent_18 = new uScriptAct_GetParent( );
   UnityEngine.GameObject logic_uScriptAct_GetParent_Target_18 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_GetParent_Parent_18;
   bool logic_uScriptAct_GetParent_Out_18 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_20 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_20 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_20 = new System.String[] {"Player"};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_20 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_20 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_20 = true;
   //pointer to script instanced logic node
   uScriptAct_SetVector3 logic_uScriptAct_SetVector3_uScriptAct_SetVector3_21 = new uScriptAct_SetVector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_Value_21 = new Vector3( );
   UnityEngine.Vector3 logic_uScriptAct_SetVector3_TargetVector3_21;
   bool logic_uScriptAct_SetVector3_Out_21 = true;
   //pointer to script instanced logic node
   uScriptAct_GetPositionAndRotation logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_23 = new uScriptAct_GetPositionAndRotation( );
   UnityEngine.GameObject logic_uScriptAct_GetPositionAndRotation_Target_23 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_GetPositionAndRotation_GetLocal_23 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Position_23;
   UnityEngine.Quaternion logic_uScriptAct_GetPositionAndRotation_Rotation_23;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_EulerAngles_23;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Forward_23;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Up_23;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionAndRotation_Right_23;
   bool logic_uScriptAct_GetPositionAndRotation_Out_23 = true;
   
   //event nodes
   System.Int32 event_UnityEngine_GameObject_Level_5 = (int) 0;
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_5 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_61 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_61 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == logic_uScriptAct_GetPositionAndRotation_Target_23 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_GetPositionAndRotation_Target_23 = GameObject.Find( "/PlayerRespawn/Sphere" ) as UnityEngine.GameObject;
      }
      if ( null == local_Cube1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_Cube1_UnityEngine_GameObject = GameObject.Find( "/GameObject (1)/UpperCube" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_Cube1_UnityEngine_GameObject_previous != local_Cube1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Cube1_UnityEngine_GameObject_previous = local_Cube1_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_Cube2_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_Cube2_UnityEngine_GameObject = GameObject.Find( "/GameObject (2)/LowerCube" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_Cube2_UnityEngine_GameObject_previous != local_Cube2_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Cube2_UnityEngine_GameObject_previous = local_Cube2_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_19_UnityEngine_GameObject_previous != local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_19_UnityEngine_GameObject_previous = local_19_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_Cube1_UnityEngine_GameObject_previous != local_Cube1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Cube1_UnityEngine_GameObject_previous = local_Cube1_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_Cube2_UnityEngine_GameObject_previous != local_Cube2_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Cube2_UnityEngine_GameObject_previous = local_Cube2_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_19_UnityEngine_GameObject_previous != local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_19_UnityEngine_GameObject_previous = local_19_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_5 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_5 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_5 )
         {
            {
               uScript_Level component = event_UnityEngine_GameObject_Instance_5.GetComponent<uScript_Level>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_5.AddComponent<uScript_Level>();
               }
               if ( null != component )
               {
                  component.LevelWasLoaded += Instance_LevelWasLoaded_5;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_61 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_61 = GameObject.Find( "/KillFloor" ) as UnityEngine.GameObject;
         if ( null != event_UnityEngine_GameObject_Instance_61 )
         {
            {
               uScript_Trigger component = event_UnityEngine_GameObject_Instance_61.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_61.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_61;
                  component.OnExitTrigger += Instance_OnExitTrigger_61;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_61;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_5 )
      {
         {
            uScript_Level component = event_UnityEngine_GameObject_Instance_5.GetComponent<uScript_Level>();
            if ( null != component )
            {
               component.LevelWasLoaded -= Instance_LevelWasLoaded_5;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_61 )
      {
         {
            uScript_Trigger component = event_UnityEngine_GameObject_Instance_61.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_61;
               component.OnExitTrigger -= Instance_OnExitTrigger_61;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_61;
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
      logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_3.SetParent(g);
      logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_4.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_8.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_9.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_13.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_14.SetParent(g);
      logic_uScriptAct_SetVector3_uScriptAct_SetVector3_15.SetParent(g);
      logic_uScriptAct_SetVector3_uScriptAct_SetVector3_16.SetParent(g);
      logic_uScriptAct_GetParent_uScriptAct_GetParent_18.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_20.SetParent(g);
      logic_uScriptAct_SetVector3_uScriptAct_SetVector3_21.SetParent(g);
      logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_23.SetParent(g);
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
   
   void Instance_LevelWasLoaded_5(object o, uScript_Level.LevelWasLoadedEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_Level_5 = e.Level;
      //relay event to nodes
      Relay_LevelWasLoaded_5( );
   }
   
   void Instance_OnEnterTrigger_61(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_61 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_61( );
   }
   
   void Instance_OnExitTrigger_61(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_61 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_61( );
   }
   
   void Instance_WhileInsideTrigger_61(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_61 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_61( );
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
                  if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_MoveToLocation_targetArray_0.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_MoveToLocation_targetArray_0, index + 1);
               }
               logic_uScriptAct_MoveToLocation_targetArray_0[ index++ ] = local_12_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_MoveToLocation_location_0 = local_17_UnityEngine_Vector3;
               
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
                  if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_MoveToLocation_targetArray_0.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_MoveToLocation_targetArray_0, index + 1);
               }
               logic_uScriptAct_MoveToLocation_targetArray_0[ index++ ] = local_12_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_MoveToLocation_location_0 = local_17_UnityEngine_Vector3;
               
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
                  if ( local_19_UnityEngine_GameObject_previous != local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_19_UnityEngine_GameObject_previous = local_19_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_1 = local_19_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_1.In(logic_uScriptCon_GameObjectHasTag_GameObject_1, logic_uScriptCon_GameObjectHasTag_Tag_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_1.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_13();
            Relay_In_14();
            Relay_In_20();
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
         if (true == CheckDebugBreak("0881843e-a552-41ed-a528-62da0cc957fd", "Set_GameObject", Relay_In_3)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_3.In(logic_uScriptAct_SetGameObject_Value_3, out logic_uScriptAct_SetGameObject_TargetGameObject_3);
         local_Cube2_UnityEngine_GameObject = logic_uScriptAct_SetGameObject_TargetGameObject_3;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_Cube2_UnityEngine_GameObject_previous != local_Cube2_UnityEngine_GameObject || false == m_RegisteredForEvents )
            {
               //tear down old listeners
               
               local_Cube2_UnityEngine_GameObject_previous = local_Cube2_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_3.Out;
         
         if ( test_0 == true )
         {
            Relay_In_9();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Set GameObject.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d8f62d66-f18e-4347-ad7f-49d4e0bea6a9", "Set_GameObject", Relay_In_4)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_4.In(logic_uScriptAct_SetGameObject_Value_4, out logic_uScriptAct_SetGameObject_TargetGameObject_4);
         local_Cube1_UnityEngine_GameObject = logic_uScriptAct_SetGameObject_TargetGameObject_4;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_Cube1_UnityEngine_GameObject_previous != local_Cube1_UnityEngine_GameObject || false == m_RegisteredForEvents )
            {
               //tear down old listeners
               
               local_Cube1_UnityEngine_GameObject_previous = local_Cube1_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_4.Out;
         
         if ( test_0 == true )
         {
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Set GameObject.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_LevelWasLoaded_5()
   {
      if (true == CheckDebugBreak("35866d13-1be7-44d8-a485-14faf3810b2b", "Level_Load", Relay_LevelWasLoaded_5)) return; 
      Relay_In_4();
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b6e3ac72-781c-4c63-9d15-686fa5ce8de5", "Get_Position_and_Rotation", Relay_In_8)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_Cube2_UnityEngine_GameObject_previous != local_Cube2_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_Cube2_UnityEngine_GameObject_previous = local_Cube2_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_GetPositionAndRotation_Target_8 = local_Cube2_UnityEngine_GameObject;
               
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
         logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_8.In(logic_uScriptAct_GetPositionAndRotation_Target_8, logic_uScriptAct_GetPositionAndRotation_GetLocal_8, out logic_uScriptAct_GetPositionAndRotation_Position_8, out logic_uScriptAct_GetPositionAndRotation_Rotation_8, out logic_uScriptAct_GetPositionAndRotation_EulerAngles_8, out logic_uScriptAct_GetPositionAndRotation_Forward_8, out logic_uScriptAct_GetPositionAndRotation_Up_8, out logic_uScriptAct_GetPositionAndRotation_Right_8);
         local_11_UnityEngine_Vector3 = logic_uScriptAct_GetPositionAndRotation_Position_8;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_8.Out;
         
         if ( test_0 == true )
         {
            Relay_In_23();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Get Position and Rotation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("ab1eedd1-a534-4bd2-b16a-f799b2a2326b", "Get_Position_and_Rotation", Relay_In_9)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_Cube1_UnityEngine_GameObject_previous != local_Cube1_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_Cube1_UnityEngine_GameObject_previous = local_Cube1_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_GetPositionAndRotation_Target_9 = local_Cube1_UnityEngine_GameObject;
               
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
         logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_9.In(logic_uScriptAct_GetPositionAndRotation_Target_9, logic_uScriptAct_GetPositionAndRotation_GetLocal_9, out logic_uScriptAct_GetPositionAndRotation_Position_9, out logic_uScriptAct_GetPositionAndRotation_Rotation_9, out logic_uScriptAct_GetPositionAndRotation_EulerAngles_9, out logic_uScriptAct_GetPositionAndRotation_Forward_9, out logic_uScriptAct_GetPositionAndRotation_Up_9, out logic_uScriptAct_GetPositionAndRotation_Right_9);
         local_10_UnityEngine_Vector3 = logic_uScriptAct_GetPositionAndRotation_Position_9;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_9.Out;
         
         if ( test_0 == true )
         {
            Relay_In_8();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Get Position and Rotation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_13()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b448a37e-92e8-43dc-8e47-ef97d45b36e1", "GameObject_Has_Tag", Relay_In_13)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_13 = local_12_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_13.In(logic_uScriptCon_GameObjectHasTag_GameObject_13, logic_uScriptCon_GameObjectHasTag_Tag_13);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_13.HasAllTags;
         
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
   
   void Relay_In_14()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("573b879c-ae69-475c-bd4b-eeb96717233f", "GameObject_Has_Tag", Relay_In_14)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_14 = local_12_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_14.In(logic_uScriptCon_GameObjectHasTag_GameObject_14, logic_uScriptCon_GameObjectHasTag_Tag_14);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_14.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_16();
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
         if (true == CheckDebugBreak("74b7cdba-b11e-418c-aeb5-94ab2e09208b", "Set_Vector3", Relay_In_15)) return; 
         {
            {
               logic_uScriptAct_SetVector3_Value_15 = local_11_UnityEngine_Vector3;
               
            }
            {
            }
         }
         logic_uScriptAct_SetVector3_uScriptAct_SetVector3_15.In(logic_uScriptAct_SetVector3_Value_15, out logic_uScriptAct_SetVector3_TargetVector3_15);
         local_17_UnityEngine_Vector3 = logic_uScriptAct_SetVector3_TargetVector3_15;
         
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
   
   void Relay_In_16()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("03ede5ba-85a8-4ff6-882a-9850b5c5cd2b", "Set_Vector3", Relay_In_16)) return; 
         {
            {
               logic_uScriptAct_SetVector3_Value_16 = local_10_UnityEngine_Vector3;
               
            }
            {
            }
         }
         logic_uScriptAct_SetVector3_uScriptAct_SetVector3_16.In(logic_uScriptAct_SetVector3_Value_16, out logic_uScriptAct_SetVector3_TargetVector3_16);
         local_17_UnityEngine_Vector3 = logic_uScriptAct_SetVector3_TargetVector3_16;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetVector3_uScriptAct_SetVector3_16.Out;
         
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
   
   void Relay_In_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("007a1e51-55c7-47f8-846e-3b0199189a6c", "Get_Parent", Relay_In_18)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_GetParent_Target_18 = local_12_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_GetParent_uScriptAct_GetParent_18.In(logic_uScriptAct_GetParent_Target_18, out logic_uScriptAct_GetParent_Parent_18);
         local_19_UnityEngine_GameObject = logic_uScriptAct_GetParent_Parent_18;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_19_UnityEngine_GameObject_previous != local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
            {
               //tear down old listeners
               
               local_19_UnityEngine_GameObject_previous = local_19_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetParent_uScriptAct_GetParent_18.Out;
         
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
   
   void Relay_In_20()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("4f16d4f2-dbcd-4e2a-8eb4-405fabd3d99d", "GameObject_Has_Tag", Relay_In_20)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_20 = local_12_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_20.In(logic_uScriptCon_GameObjectHasTag_GameObject_20, logic_uScriptCon_GameObjectHasTag_Tag_20);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_20.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_21();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_21()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a124256f-5135-4808-a251-f401b42c1716", "Set_Vector3", Relay_In_21)) return; 
         {
            {
               logic_uScriptAct_SetVector3_Value_21 = local_22_UnityEngine_Vector3;
               
            }
            {
            }
         }
         logic_uScriptAct_SetVector3_uScriptAct_SetVector3_21.In(logic_uScriptAct_SetVector3_Value_21, out logic_uScriptAct_SetVector3_TargetVector3_21);
         local_17_UnityEngine_Vector3 = logic_uScriptAct_SetVector3_TargetVector3_21;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetVector3_uScriptAct_SetVector3_21.Out;
         
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
   
   void Relay_In_23()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("83f02e02-e4b1-43a3-a94e-334ba66e9cbb", "Get_Position_and_Rotation", Relay_In_23)) return; 
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
         logic_uScriptAct_GetPositionAndRotation_uScriptAct_GetPositionAndRotation_23.In(logic_uScriptAct_GetPositionAndRotation_Target_23, logic_uScriptAct_GetPositionAndRotation_GetLocal_23, out logic_uScriptAct_GetPositionAndRotation_Position_23, out logic_uScriptAct_GetPositionAndRotation_Rotation_23, out logic_uScriptAct_GetPositionAndRotation_EulerAngles_23, out logic_uScriptAct_GetPositionAndRotation_Forward_23, out logic_uScriptAct_GetPositionAndRotation_Up_23, out logic_uScriptAct_GetPositionAndRotation_Right_23);
         local_22_UnityEngine_Vector3 = logic_uScriptAct_GetPositionAndRotation_Position_23;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript lavaporter.uscript at Get Position and Rotation.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnEnterTrigger_61()
   {
      if (true == CheckDebugBreak("f55c129b-8dd7-4ae7-bf21-fd145c56e24c", "Trigger_Event", Relay_OnEnterTrigger_61)) return; 
      local_12_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_61;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_18();
   }
   
   void Relay_OnExitTrigger_61()
   {
      if (true == CheckDebugBreak("f55c129b-8dd7-4ae7-bf21-fd145c56e24c", "Trigger_Event", Relay_OnExitTrigger_61)) return; 
      local_12_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_61;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_WhileInsideTrigger_61()
   {
      if (true == CheckDebugBreak("f55c129b-8dd7-4ae7-bf21-fd145c56e24c", "Trigger_Event", Relay_WhileInsideTrigger_61)) return; 
      local_12_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_61;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_12_UnityEngine_GameObject_previous != local_12_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_12_UnityEngine_GameObject_previous = local_12_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:Cube1", local_Cube1_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a9491510-3503-4c65-a4b0-20644e7484c3", local_Cube1_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:Cube2", local_Cube2_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "6581509c-cfc2-46a1-9b7a-f540c4a73a18", local_Cube2_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:10", local_10_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3c418325-1e65-4d26-a719-f893cbf850f5", local_10_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:11", local_11_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5231e109-341a-49f0-815b-a9fe193930de", local_11_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:12", local_12_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "a6717267-3c67-42bb-ab8c-762ee62d9600", local_12_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:17", local_17_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "c7fe5a13-f291-4364-92e0-ef73153c2e19", local_17_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:19", local_19_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5364811f-876b-4e89-9d72-2429e1305ef4", local_19_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "lavaporter.uscript:22", local_22_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "1517affa-81b0-4a07-b1b7-9b00a9fc4ec3", local_22_UnityEngine_Vector3);
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
