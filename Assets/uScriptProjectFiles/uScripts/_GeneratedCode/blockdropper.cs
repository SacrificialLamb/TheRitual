//uScript Generated Code - Build 1.0.3024
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class blockdropper : uScriptLogic
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
   public System.Int32 amount = (int) 0;
   public System.Int32 amount2 = (int) 0;
   System.String local_10_System_String = "PointCube";
   UnityEngine.GameObject local_2_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_2_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_33_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_33_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_9_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_9_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_1 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_1 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_1 = new System.String[] {};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_1 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_1 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_1 = true;
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_3 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_3 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_B_3 = (int) 1;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_3;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_3;
   bool logic_uScriptAct_AddInt_v2_Out_3 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_5 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_5 = (int) 0;
   System.Int32 logic_uScriptAct_SetInt_Target_5;
   bool logic_uScriptAct_SetInt_Out_5 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_7 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_7 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_7 = (int) 4;
   bool logic_uScriptCon_CompareInt_GreaterThan_7 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_7 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_7 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_7 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_7 = true;
   bool logic_uScriptCon_CompareInt_LessThan_7 = true;
   //pointer to script instanced logic node
   uScriptAct_Destroy logic_uScriptAct_Destroy_uScriptAct_Destroy_12 = new uScriptAct_Destroy( );
   UnityEngine.GameObject[] logic_uScriptAct_Destroy_Target_12 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_Destroy_DelayTime_12 = (float) 0;
   bool logic_uScriptAct_Destroy_Out_12 = true;
   bool logic_uScriptAct_Destroy_ObjectsDestroyed_12 = true;
   bool logic_uScriptAct_Destroy_WaitOneTick_12 = false;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_13 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_13 = (int) 0;
   System.Int32 logic_uScriptAct_SetInt_Target_13;
   bool logic_uScriptAct_SetInt_Out_13 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_6 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_8 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   System.String method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_methodName_31 = "EndGame";
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_2_UnityEngine_GameObject_previous != local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_2_UnityEngine_GameObject_previous = local_2_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_9_UnityEngine_GameObject = GameObject.Find( "/BlockDropperPlane" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_9_UnityEngine_GameObject_previous )
         {
            {
               uScript_Trigger component = local_9_UnityEngine_GameObject_previous.GetComponent<uScript_Trigger>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_9_UnityEngine_GameObject )
         {
            {
               uScript_Trigger component = local_9_UnityEngine_GameObject.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = local_9_UnityEngine_GameObject.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_0;
                  component.OnExitTrigger += Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_0;
               }
            }
         }
      }
      if ( null == local_33_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_33_UnityEngine_GameObject = GameObject.Find( "/BlockDropperPlane" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_33_UnityEngine_GameObject_previous != local_33_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_33_UnityEngine_GameObject_previous = local_33_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_2_UnityEngine_GameObject_previous != local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_2_UnityEngine_GameObject_previous = local_2_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_9_UnityEngine_GameObject_previous )
         {
            {
               uScript_Trigger component = local_9_UnityEngine_GameObject_previous.GetComponent<uScript_Trigger>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_9_UnityEngine_GameObject )
         {
            {
               uScript_Trigger component = local_9_UnityEngine_GameObject.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = local_9_UnityEngine_GameObject.AddComponent<uScript_Trigger>();
               }
               if ( null != component )
               {
                  component.OnEnterTrigger += Instance_OnEnterTrigger_0;
                  component.OnExitTrigger += Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger += Instance_WhileInsideTrigger_0;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_33_UnityEngine_GameObject_previous != local_33_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_33_UnityEngine_GameObject_previous = local_33_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_6 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_6 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_6 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_6.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_6.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_6;
                  component.OnLateUpdate += Instance_OnLateUpdate_6;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_6;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_8 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_8 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_8 )
         {
            {
               uScript_Global component = event_UnityEngine_GameObject_Instance_8.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_8.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_8;
                  component.uScriptLateStart += Instance_uScriptLateStart_8;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != local_9_UnityEngine_GameObject )
      {
         {
            uScript_Trigger component = local_9_UnityEngine_GameObject.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
               component.OnExitTrigger -= Instance_OnExitTrigger_0;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_6 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_6.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_6;
               component.OnLateUpdate -= Instance_OnLateUpdate_6;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_6;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_8 )
      {
         {
            uScript_Global component = event_UnityEngine_GameObject_Instance_8.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_8;
               component.uScriptLateStart -= Instance_uScriptLateStart_8;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_1.SetParent(g);
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_3.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_5.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_7.SetParent(g);
      logic_uScriptAct_Destroy_uScriptAct_Destroy_12.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_13.SetParent(g);
   }
   public void Awake()
   {
      
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
      
      if (true == logic_uScriptAct_Destroy_WaitOneTick_12)
      {
         Relay_WaitOneTick_12();
      }
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnEnterTrigger_0(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnEnterTrigger_0( );
   }
   
   void Instance_OnExitTrigger_0(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_OnExitTrigger_0( );
   }
   
   void Instance_WhileInsideTrigger_0(object o, uScript_Trigger.TriggerEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_GameObject_0 = e.GameObject;
      //relay event to nodes
      Relay_WhileInsideTrigger_0( );
   }
   
   void Instance_OnUpdate_6(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_6( );
   }
   
   void Instance_OnLateUpdate_6(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_6( );
   }
   
   void Instance_OnFixedUpdate_6(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_6( );
   }
   
   void Instance_uScriptStart_8(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_8( );
   }
   
   void Instance_uScriptLateStart_8(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_8( );
   }
   
   void Relay_OnEnterTrigger_0()
   {
      if (true == CheckDebugBreak("41a1f340-3116-482e-889d-9ef63214be8f", "Trigger_Event", Relay_OnEnterTrigger_0)) return; 
      local_2_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_2_UnityEngine_GameObject_previous != local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_2_UnityEngine_GameObject_previous = local_2_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_1();
   }
   
   void Relay_OnExitTrigger_0()
   {
      if (true == CheckDebugBreak("41a1f340-3116-482e-889d-9ef63214be8f", "Trigger_Event", Relay_OnExitTrigger_0)) return; 
      local_2_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_2_UnityEngine_GameObject_previous != local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_2_UnityEngine_GameObject_previous = local_2_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_WhileInsideTrigger_0()
   {
      if (true == CheckDebugBreak("41a1f340-3116-482e-889d-9ef63214be8f", "Trigger_Event", Relay_WhileInsideTrigger_0)) return; 
      local_2_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_2_UnityEngine_GameObject_previous != local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_2_UnityEngine_GameObject_previous = local_2_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("42030b77-57d4-42b9-8be1-10d31a2e931b", "GameObject_Has_Tag", Relay_In_1)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_2_UnityEngine_GameObject_previous != local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_2_UnityEngine_GameObject_previous = local_2_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_1 = local_2_UnityEngine_GameObject;
               
            }
            {
               int index = 0;
               if ( logic_uScriptCon_GameObjectHasTag_Tag_1.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptCon_GameObjectHasTag_Tag_1, index + 1);
               }
               logic_uScriptCon_GameObjectHasTag_Tag_1[ index++ ] = local_10_System_String;
               
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_1.In(logic_uScriptCon_GameObjectHasTag_GameObject_1, logic_uScriptCon_GameObjectHasTag_Tag_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_1.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_12();
            Relay_In_3();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_3()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b670b518-95aa-4a32-88c6-70f704de7511", "Add_Int", Relay_In_3)) return; 
         {
            {
               logic_uScriptAct_AddInt_v2_A_3 = amount;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_3.In(logic_uScriptAct_AddInt_v2_A_3, logic_uScriptAct_AddInt_v2_B_3, out logic_uScriptAct_AddInt_v2_IntResult_3, out logic_uScriptAct_AddInt_v2_FloatResult_3);
         amount2 = logic_uScriptAct_AddInt_v2_IntResult_3;
         amount = logic_uScriptAct_AddInt_v2_IntResult_3;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Add Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0e26a7b4-9463-4658-a616-06baa47e7296", "Set_Int", Relay_In_5)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_5.In(logic_uScriptAct_SetInt_Value_5, out logic_uScriptAct_SetInt_Target_5);
         amount = logic_uScriptAct_SetInt_Target_5;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_6()
   {
      if (true == CheckDebugBreak("7fc2410a-9e25-4bef-bcd0-5708313a4b69", "Global_Update", Relay_OnUpdate_6)) return; 
      Relay_In_7();
   }
   
   void Relay_OnLateUpdate_6()
   {
      if (true == CheckDebugBreak("7fc2410a-9e25-4bef-bcd0-5708313a4b69", "Global_Update", Relay_OnLateUpdate_6)) return; 
   }
   
   void Relay_OnFixedUpdate_6()
   {
      if (true == CheckDebugBreak("7fc2410a-9e25-4bef-bcd0-5708313a4b69", "Global_Update", Relay_OnFixedUpdate_6)) return; 
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d0aca918-70bc-4f56-ae16-66166fcf6118", "Compare_Int", Relay_In_7)) return; 
         {
            {
               logic_uScriptCon_CompareInt_A_7 = amount2;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_7.In(logic_uScriptCon_CompareInt_A_7, logic_uScriptCon_CompareInt_B_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_CompareInt_uScriptCon_CompareInt_7.GreaterThanOrEqualTo;
         
         if ( test_0 == true )
         {
            Relay_In_13();
            Relay_SendMessage_31();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_uScriptStart_8()
   {
      if (true == CheckDebugBreak("3bd6a49e-6206-40f6-ba9e-2b1b47a7f195", "uScript_Events", Relay_uScriptStart_8)) return; 
      Relay_In_5();
   }
   
   void Relay_uScriptLateStart_8()
   {
      if (true == CheckDebugBreak("3bd6a49e-6206-40f6-ba9e-2b1b47a7f195", "uScript_Events", Relay_uScriptLateStart_8)) return; 
   }
   
   void Relay_In_12()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0aaad8d7-ceb0-4ff5-8eb0-d133633b1c33", "Destroy", Relay_In_12)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_2_UnityEngine_GameObject_previous != local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_2_UnityEngine_GameObject_previous = local_2_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Destroy_Target_12.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_12, index + 1);
               }
               logic_uScriptAct_Destroy_Target_12[ index++ ] = local_2_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_uScriptAct_Destroy_12.In(logic_uScriptAct_Destroy_Target_12, logic_uScriptAct_Destroy_DelayTime_12);
         logic_uScriptAct_Destroy_WaitOneTick_12 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_WaitOneTick_12( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_2_UnityEngine_GameObject_previous != local_2_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_2_UnityEngine_GameObject_previous = local_2_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Destroy_Target_12.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_12, index + 1);
               }
               logic_uScriptAct_Destroy_Target_12[ index++ ] = local_2_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_WaitOneTick_12 = logic_uScriptAct_Destroy_uScriptAct_Destroy_12.WaitOneTick();
         if ( true == logic_uScriptAct_Destroy_WaitOneTick_12 )
         {
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_In_13()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("56015b9d-5255-4ba1-80d7-4514d92ec2e3", "Set_Int", Relay_In_13)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_13.In(logic_uScriptAct_SetInt_Value_13, out logic_uScriptAct_SetInt_Target_13);
         amount2 = logic_uScriptAct_SetInt_Target_13;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_SendMessage_31()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("9c879d00-ff9f-4848-87d7-8dbf266f63ca", "UnityEngine_Transform", Relay_SendMessage_31)) return; 
         {
            {
            }
         }
         {
            UnityEngine.Transform component;
            component = local_33_UnityEngine_GameObject.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.SendMessage(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_methodName_31);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "blockdropper.uscript:2", local_2_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "76906907-1bf6-4015-8834-025360ce0fae", local_2_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "blockdropper.uscript:amount", amount);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "9fad52fa-f998-4e59-8c5f-fe1519457335", amount);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "blockdropper.uscript:9", local_9_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "e2045d3e-196d-4203-90ee-2f6ee18b847b", local_9_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "blockdropper.uscript:10", local_10_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "86af6f67-678f-443b-9ad5-3c4db02bad72", local_10_System_String);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "blockdropper.uscript:amount2", amount2);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "613da578-106d-46de-a2b6-f123ca0b9e25", amount2);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "blockdropper.uscript:33", local_33_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "3c9d3864-e1f8-4bcc-871f-8d3c8b40bc04", local_33_UnityEngine_GameObject);
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
