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
   UnityEngine.GameObject local_10_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_10_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_11_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_11_UnityEngine_GameObject_previous = null;
   System.Int32 local_33_System_Int32 = (int) 0;
   UnityEngine.GameObject local_8_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_8_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_9_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_9_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_4 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_4 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_4 = new System.String[] {};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_4 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_4 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_4 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_5 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_5 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_5 = new System.String[] {};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_5 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_5 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_5 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_6 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_6 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_6 = new System.String[] {};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_6 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_6 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_6 = true;
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_7 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_7 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_7 = new System.String[] {};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_7 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_7 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_7 = true;
   //pointer to script instanced logic node
   uScriptAct_Destroy logic_uScriptAct_Destroy_uScriptAct_Destroy_24 = new uScriptAct_Destroy( );
   UnityEngine.GameObject[] logic_uScriptAct_Destroy_Target_24 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_Destroy_DelayTime_24 = (float) 0;
   bool logic_uScriptAct_Destroy_Out_24 = true;
   bool logic_uScriptAct_Destroy_ObjectsDestroyed_24 = true;
   bool logic_uScriptAct_Destroy_WaitOneTick_24 = false;
   //pointer to script instanced logic node
   uScriptAct_Destroy logic_uScriptAct_Destroy_uScriptAct_Destroy_26 = new uScriptAct_Destroy( );
   UnityEngine.GameObject[] logic_uScriptAct_Destroy_Target_26 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_Destroy_DelayTime_26 = (float) 0;
   bool logic_uScriptAct_Destroy_Out_26 = true;
   bool logic_uScriptAct_Destroy_ObjectsDestroyed_26 = true;
   bool logic_uScriptAct_Destroy_WaitOneTick_26 = false;
   //pointer to script instanced logic node
   uScriptAct_Destroy logic_uScriptAct_Destroy_uScriptAct_Destroy_27 = new uScriptAct_Destroy( );
   UnityEngine.GameObject[] logic_uScriptAct_Destroy_Target_27 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_Destroy_DelayTime_27 = (float) 0;
   bool logic_uScriptAct_Destroy_Out_27 = true;
   bool logic_uScriptAct_Destroy_ObjectsDestroyed_27 = true;
   bool logic_uScriptAct_Destroy_WaitOneTick_27 = false;
   //pointer to script instanced logic node
   uScriptAct_Destroy logic_uScriptAct_Destroy_uScriptAct_Destroy_28 = new uScriptAct_Destroy( );
   UnityEngine.GameObject[] logic_uScriptAct_Destroy_Target_28 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_Destroy_DelayTime_28 = (float) 0;
   bool logic_uScriptAct_Destroy_Out_28 = true;
   bool logic_uScriptAct_Destroy_ObjectsDestroyed_28 = true;
   bool logic_uScriptAct_Destroy_WaitOneTick_28 = false;
   //pointer to script instanced logic node
   uScriptAct_AddInt_v2 logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_32 = new uScriptAct_AddInt_v2( );
   System.Int32 logic_uScriptAct_AddInt_v2_A_32 = (int) 0;
   System.Int32 logic_uScriptAct_AddInt_v2_B_32 = (int) 1;
   System.Int32 logic_uScriptAct_AddInt_v2_IntResult_32;
   System.Single logic_uScriptAct_AddInt_v2_FloatResult_32;
   bool logic_uScriptAct_AddInt_v2_Out_32 = true;
   //pointer to script instanced logic node
   uScriptAct_SetInt logic_uScriptAct_SetInt_uScriptAct_SetInt_45 = new uScriptAct_SetInt( );
   System.Int32 logic_uScriptAct_SetInt_Value_45 = (int) 0;
   System.Int32 logic_uScriptAct_SetInt_Target_45;
   bool logic_uScriptAct_SetInt_Out_45 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareInt logic_uScriptCon_CompareInt_uScriptCon_CompareInt_49 = new uScriptCon_CompareInt( );
   System.Int32 logic_uScriptCon_CompareInt_A_49 = (int) 0;
   System.Int32 logic_uScriptCon_CompareInt_B_49 = (int) 4;
   bool logic_uScriptCon_CompareInt_GreaterThan_49 = true;
   bool logic_uScriptCon_CompareInt_GreaterThanOrEqualTo_49 = true;
   bool logic_uScriptCon_CompareInt_EqualTo_49 = true;
   bool logic_uScriptCon_CompareInt_NotEqualTo_49 = true;
   bool logic_uScriptCon_CompareInt_LessThanOrEqualTo_49 = true;
   bool logic_uScriptCon_CompareInt_LessThan_49 = true;
   
   //event nodes
   System.Int32 event_UnityEngine_GameObject_Level_44 = (int) 0;
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_44 = default(UnityEngine.GameObject);
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_48 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_44 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_44 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_44 )
         {
            {
               uScript_Level component = event_UnityEngine_GameObject_Instance_44.GetComponent<uScript_Level>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_44.AddComponent<uScript_Level>();
               }
               if ( null != component )
               {
                  component.LevelWasLoaded += Instance_LevelWasLoaded_44;
               }
            }
         }
      }
      if ( null == event_UnityEngine_GameObject_Instance_48 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_48 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_48 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_48.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_48.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_48;
                  component.OnLateUpdate += Instance_OnLateUpdate_48;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_48;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_44 )
      {
         {
            uScript_Level component = event_UnityEngine_GameObject_Instance_44.GetComponent<uScript_Level>();
            if ( null != component )
            {
               component.LevelWasLoaded -= Instance_LevelWasLoaded_44;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_48 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_48.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_48;
               component.OnLateUpdate -= Instance_OnLateUpdate_48;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_48;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_4.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_5.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_6.SetParent(g);
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_7.SetParent(g);
      logic_uScriptAct_Destroy_uScriptAct_Destroy_24.SetParent(g);
      logic_uScriptAct_Destroy_uScriptAct_Destroy_26.SetParent(g);
      logic_uScriptAct_Destroy_uScriptAct_Destroy_27.SetParent(g);
      logic_uScriptAct_Destroy_uScriptAct_Destroy_28.SetParent(g);
      logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_32.SetParent(g);
      logic_uScriptAct_SetInt_uScriptAct_SetInt_45.SetParent(g);
      logic_uScriptCon_CompareInt_uScriptCon_CompareInt_49.SetParent(g);
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
      
      if (true == logic_uScriptAct_Destroy_WaitOneTick_24)
      {
         Relay_WaitOneTick_24();
      }
      if (true == logic_uScriptAct_Destroy_WaitOneTick_26)
      {
         Relay_WaitOneTick_26();
      }
      if (true == logic_uScriptAct_Destroy_WaitOneTick_27)
      {
         Relay_WaitOneTick_27();
      }
      if (true == logic_uScriptAct_Destroy_WaitOneTick_28)
      {
         Relay_WaitOneTick_28();
      }
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_LevelWasLoaded_44(object o, uScript_Level.LevelWasLoadedEventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      event_UnityEngine_GameObject_Level_44 = e.Level;
      //relay event to nodes
      Relay_LevelWasLoaded_44( );
   }
   
   void Instance_OnUpdate_48(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_48( );
   }
   
   void Instance_OnLateUpdate_48(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_48( );
   }
   
   void Instance_OnFixedUpdate_48(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_48( );
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("42030b77-57d4-42b9-8be1-10d31a2e931b", "GameObject_Has_Tag", Relay_In_4)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_4 = local_11_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_4.In(logic_uScriptCon_GameObjectHasTag_GameObject_4, logic_uScriptCon_GameObjectHasTag_Tag_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_4.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_24();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("38a16077-06a2-4548-b821-4a1e970e8c42", "GameObject_Has_Tag", Relay_In_5)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_5 = local_8_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_5.In(logic_uScriptCon_GameObjectHasTag_GameObject_5, logic_uScriptCon_GameObjectHasTag_Tag_5);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_5.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_26();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e9b88760-76e2-4fa2-9d39-8cf44364ea8a", "GameObject_Has_Tag", Relay_In_6)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_6 = local_10_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_6.In(logic_uScriptCon_GameObjectHasTag_GameObject_6, logic_uScriptCon_GameObjectHasTag_Tag_6);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_6.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_27();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_7()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("cea366a5-6d7d-4e66-81f7-90a71f339154", "GameObject_Has_Tag", Relay_In_7)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_7 = local_9_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_7.In(logic_uScriptCon_GameObjectHasTag_GameObject_7, logic_uScriptCon_GameObjectHasTag_Tag_7);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_7.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_28();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_24()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5c11c9c9-5de9-491b-87d3-1cdebf617502", "Destroy", Relay_In_24)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Destroy_Target_24.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_24, index + 1);
               }
               logic_uScriptAct_Destroy_Target_24[ index++ ] = local_11_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_uScriptAct_Destroy_24.In(logic_uScriptAct_Destroy_Target_24, logic_uScriptAct_Destroy_DelayTime_24);
         logic_uScriptAct_Destroy_WaitOneTick_24 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Destroy_uScriptAct_Destroy_24.Out;
         
         if ( test_0 == true )
         {
            Relay_In_32();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_WaitOneTick_24( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_11_UnityEngine_GameObject_previous != local_11_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_11_UnityEngine_GameObject_previous = local_11_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Destroy_Target_24.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_24, index + 1);
               }
               logic_uScriptAct_Destroy_Target_24[ index++ ] = local_11_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_WaitOneTick_24 = logic_uScriptAct_Destroy_uScriptAct_Destroy_24.WaitOneTick();
         if ( true == logic_uScriptAct_Destroy_WaitOneTick_24 )
         {
            if ( logic_uScriptAct_Destroy_uScriptAct_Destroy_24.Out == true )
            {
               Relay_In_32();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_In_26()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("56cdaf85-b081-48fb-a8bd-c1d2b71a7a1b", "Destroy", Relay_In_26)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Destroy_Target_26.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_26, index + 1);
               }
               logic_uScriptAct_Destroy_Target_26[ index++ ] = local_8_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_uScriptAct_Destroy_26.In(logic_uScriptAct_Destroy_Target_26, logic_uScriptAct_Destroy_DelayTime_26);
         logic_uScriptAct_Destroy_WaitOneTick_26 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Destroy_uScriptAct_Destroy_26.Out;
         
         if ( test_0 == true )
         {
            Relay_In_32();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_WaitOneTick_26( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_8_UnityEngine_GameObject_previous != local_8_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_8_UnityEngine_GameObject_previous = local_8_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Destroy_Target_26.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_26, index + 1);
               }
               logic_uScriptAct_Destroy_Target_26[ index++ ] = local_8_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_WaitOneTick_26 = logic_uScriptAct_Destroy_uScriptAct_Destroy_26.WaitOneTick();
         if ( true == logic_uScriptAct_Destroy_WaitOneTick_26 )
         {
            if ( logic_uScriptAct_Destroy_uScriptAct_Destroy_26.Out == true )
            {
               Relay_In_32();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_In_27()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a6a1e525-e5df-40ab-aa7f-4390ecb027aa", "Destroy", Relay_In_27)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Destroy_Target_27.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_27, index + 1);
               }
               logic_uScriptAct_Destroy_Target_27[ index++ ] = local_10_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_uScriptAct_Destroy_27.In(logic_uScriptAct_Destroy_Target_27, logic_uScriptAct_Destroy_DelayTime_27);
         logic_uScriptAct_Destroy_WaitOneTick_27 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Destroy_uScriptAct_Destroy_27.Out;
         
         if ( test_0 == true )
         {
            Relay_In_32();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_WaitOneTick_27( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_10_UnityEngine_GameObject_previous != local_10_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_10_UnityEngine_GameObject_previous = local_10_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Destroy_Target_27.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_27, index + 1);
               }
               logic_uScriptAct_Destroy_Target_27[ index++ ] = local_10_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_WaitOneTick_27 = logic_uScriptAct_Destroy_uScriptAct_Destroy_27.WaitOneTick();
         if ( true == logic_uScriptAct_Destroy_WaitOneTick_27 )
         {
            if ( logic_uScriptAct_Destroy_uScriptAct_Destroy_27.Out == true )
            {
               Relay_In_32();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_In_28()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1f2586a4-35b5-4293-8c2a-6ae73d77f3f3", "Destroy", Relay_In_28)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Destroy_Target_28.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_28, index + 1);
               }
               logic_uScriptAct_Destroy_Target_28[ index++ ] = local_9_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_uScriptAct_Destroy_28.In(logic_uScriptAct_Destroy_Target_28, logic_uScriptAct_Destroy_DelayTime_28);
         logic_uScriptAct_Destroy_WaitOneTick_28 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Destroy_uScriptAct_Destroy_28.Out;
         
         if ( test_0 == true )
         {
            Relay_In_32();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_WaitOneTick_28( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_9_UnityEngine_GameObject_previous != local_9_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_9_UnityEngine_GameObject_previous = local_9_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_Destroy_Target_28.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_28, index + 1);
               }
               logic_uScriptAct_Destroy_Target_28[ index++ ] = local_9_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_WaitOneTick_28 = logic_uScriptAct_Destroy_uScriptAct_Destroy_28.WaitOneTick();
         if ( true == logic_uScriptAct_Destroy_WaitOneTick_28 )
         {
            if ( logic_uScriptAct_Destroy_uScriptAct_Destroy_28.Out == true )
            {
               Relay_In_32();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_In_32()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b670b518-95aa-4a32-88c6-70f704de7511", "Add_Int", Relay_In_32)) return; 
         {
            {
               logic_uScriptAct_AddInt_v2_A_32 = local_33_System_Int32;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AddInt_v2_uScriptAct_AddInt_v2_32.In(logic_uScriptAct_AddInt_v2_A_32, logic_uScriptAct_AddInt_v2_B_32, out logic_uScriptAct_AddInt_v2_IntResult_32, out logic_uScriptAct_AddInt_v2_FloatResult_32);
         local_33_System_Int32 = logic_uScriptAct_AddInt_v2_IntResult_32;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Add Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_LevelWasLoaded_44()
   {
      if (true == CheckDebugBreak("ffb45912-6000-4138-8800-d595d899ea2c", "Level_Load", Relay_LevelWasLoaded_44)) return; 
      Relay_In_45();
   }
   
   void Relay_In_45()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("0e26a7b4-9463-4658-a616-06baa47e7296", "Set_Int", Relay_In_45)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_SetInt_uScriptAct_SetInt_45.In(logic_uScriptAct_SetInt_Value_45, out logic_uScriptAct_SetInt_Target_45);
         local_33_System_Int32 = logic_uScriptAct_SetInt_Target_45;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Set Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_48()
   {
      if (true == CheckDebugBreak("7fc2410a-9e25-4bef-bcd0-5708313a4b69", "Global_Update", Relay_OnUpdate_48)) return; 
      Relay_In_49();
   }
   
   void Relay_OnLateUpdate_48()
   {
      if (true == CheckDebugBreak("7fc2410a-9e25-4bef-bcd0-5708313a4b69", "Global_Update", Relay_OnLateUpdate_48)) return; 
   }
   
   void Relay_OnFixedUpdate_48()
   {
      if (true == CheckDebugBreak("7fc2410a-9e25-4bef-bcd0-5708313a4b69", "Global_Update", Relay_OnFixedUpdate_48)) return; 
   }
   
   void Relay_In_49()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d0aca918-70bc-4f56-ae16-66166fcf6118", "Compare_Int", Relay_In_49)) return; 
         {
            {
               logic_uScriptCon_CompareInt_A_49 = local_33_System_Int32;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareInt_uScriptCon_CompareInt_49.In(logic_uScriptCon_CompareInt_A_49, logic_uScriptCon_CompareInt_B_49);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript blockdropper.uscript at Compare Int.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "blockdropper.uscript:8", local_8_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "bbef1cf5-c789-4ab5-8d3c-bc9d50c81b8e", local_8_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "blockdropper.uscript:9", local_9_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "044c0800-a50a-4fb7-a054-ae99fc3fd76a", local_9_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "blockdropper.uscript:10", local_10_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "b733942a-6162-47b3-83ff-750561583c50", local_10_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "blockdropper.uscript:11", local_11_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "76906907-1bf6-4015-8834-025360ce0fae", local_11_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "blockdropper.uscript:33", local_33_System_Int32);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "9fad52fa-f998-4e59-8c5f-fe1519457335", local_33_System_Int32);
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
