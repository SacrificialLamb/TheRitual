//uScript Generated Code - Build 1.0.3024
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Endgame : uScriptLogic
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
   public UnityEngine.GameObject EndDoor = default(UnityEngine.GameObject);
   UnityEngine.GameObject EndDoor_previous = null;
   public UnityEngine.GameObject EndDoor2 = default(UnityEngine.GameObject);
   UnityEngine.GameObject EndDoor2_previous = null;
   UnityEngine.GameObject local_Player_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_Player_UnityEngine_GameObject_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptCon_GameObjectHasTag logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_2 = new uScriptCon_GameObjectHasTag( );
   UnityEngine.GameObject logic_uScriptCon_GameObjectHasTag_GameObject_2 = default(UnityEngine.GameObject);
   System.String[] logic_uScriptCon_GameObjectHasTag_Tag_2 = new System.String[] {"Player"};
   bool logic_uScriptCon_GameObjectHasTag_HasAllTags_2 = true;
   bool logic_uScriptCon_GameObjectHasTag_HasTag_2 = true;
   bool logic_uScriptCon_GameObjectHasTag_MissingTags_2 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_GameObject_0 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   System.String method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_methodName_4 = "EndGame";
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( EndDoor_previous != EndDoor || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != EndDoor_previous )
         {
            {
               uScript_Trigger component = EndDoor_previous.GetComponent<uScript_Trigger>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         EndDoor_previous = EndDoor;
         
         //setup new listeners
         if ( null != EndDoor )
         {
            {
               uScript_Trigger component = EndDoor.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = EndDoor.AddComponent<uScript_Trigger>();
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
      if ( local_Player_UnityEngine_GameObject_previous != local_Player_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Player_UnityEngine_GameObject_previous = local_Player_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( EndDoor2_previous != EndDoor2 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         EndDoor2_previous = EndDoor2;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( EndDoor_previous != EndDoor || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != EndDoor_previous )
         {
            {
               uScript_Trigger component = EndDoor_previous.GetComponent<uScript_Trigger>();
               if ( null != component )
               {
                  component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
                  component.OnExitTrigger -= Instance_OnExitTrigger_0;
                  component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
               }
            }
         }
         
         EndDoor_previous = EndDoor;
         
         //setup new listeners
         if ( null != EndDoor )
         {
            {
               uScript_Trigger component = EndDoor.GetComponent<uScript_Trigger>();
               if ( null == component )
               {
                  component = EndDoor.AddComponent<uScript_Trigger>();
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
      if ( local_Player_UnityEngine_GameObject_previous != local_Player_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_Player_UnityEngine_GameObject_previous = local_Player_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( EndDoor2_previous != EndDoor2 || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         EndDoor2_previous = EndDoor2;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != EndDoor )
      {
         {
            uScript_Trigger component = EndDoor.GetComponent<uScript_Trigger>();
            if ( null != component )
            {
               component.OnEnterTrigger -= Instance_OnEnterTrigger_0;
               component.OnExitTrigger -= Instance_OnExitTrigger_0;
               component.WhileInsideTrigger -= Instance_WhileInsideTrigger_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_2.SetParent(g);
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
   
   void Relay_OnEnterTrigger_0()
   {
      if (true == CheckDebugBreak("a4c12d38-c25a-4b01-8b84-a37a58f54e09", "Trigger_Event", Relay_OnEnterTrigger_0)) return; 
      local_Player_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Player_UnityEngine_GameObject_previous != local_Player_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Player_UnityEngine_GameObject_previous = local_Player_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_2();
   }
   
   void Relay_OnExitTrigger_0()
   {
      if (true == CheckDebugBreak("a4c12d38-c25a-4b01-8b84-a37a58f54e09", "Trigger_Event", Relay_OnExitTrigger_0)) return; 
      local_Player_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Player_UnityEngine_GameObject_previous != local_Player_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Player_UnityEngine_GameObject_previous = local_Player_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_WhileInsideTrigger_0()
   {
      if (true == CheckDebugBreak("a4c12d38-c25a-4b01-8b84-a37a58f54e09", "Trigger_Event", Relay_WhileInsideTrigger_0)) return; 
      local_Player_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_Player_UnityEngine_GameObject_previous != local_Player_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_Player_UnityEngine_GameObject_previous = local_Player_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("18f06280-846f-4cfa-ae01-dc1d32b00db3", "GameObject_Has_Tag", Relay_In_2)) return; 
         {
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_Player_UnityEngine_GameObject_previous != local_Player_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_Player_UnityEngine_GameObject_previous = local_Player_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_2 = local_Player_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_2.In(logic_uScriptCon_GameObjectHasTag_GameObject_2, logic_uScriptCon_GameObjectHasTag_Tag_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_2.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_SendMessage_4();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Endgame.uscript at GameObject Has Tag.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_SendMessage_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("8a0f5afd-7ed1-4240-8e6d-86eeaf53fbcc", "UnityEngine_Transform", Relay_SendMessage_4)) return; 
         {
            {
            }
         }
         {
            UnityEngine.Transform component;
            component = EndDoor2.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.SendMessage(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_methodName_4);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript Endgame.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Endgame.uscript:EndDoor", EndDoor);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "1553b7ce-1520-498f-8646-ef694eb4c170", EndDoor);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Endgame.uscript:Player", local_Player_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "8e49ce60-4759-45fd-a25c-5121a34d9b68", local_Player_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "Endgame.uscript:EndDoor2", EndDoor2);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "989f7f45-b5e2-4af5-b36f-e0c507c478e4", EndDoor2);
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
