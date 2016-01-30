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
   UnityEngine.GameObject local_1_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_1_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_3_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_3_UnityEngine_GameObject_previous = null;
   System.Boolean local_6_System_Boolean = (bool) false;
   
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
   uScriptAct_AttachToGameObject logic_uScriptAct_AttachToGameObject_uScriptAct_AttachToGameObject_9 = new uScriptAct_AttachToGameObject( );
   UnityEngine.GameObject logic_uScriptAct_AttachToGameObject_Target_9 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_AttachToGameObject_Attachment_9 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptAct_AttachToGameObject_UseRelativeOffset_9 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_AttachToGameObject_RelativeOffset_9 = new Vector3( (float)0, (float)0, (float)0 );
   System.Boolean logic_uScriptAct_AttachToGameObject_UseRelativeRotation_9 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_AttachToGameObject_RelativeRotation_9 = new Vector3( (float)0, (float)0, (float)0 );
   bool logic_uScriptAct_AttachToGameObject_Out_9 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareBoolState logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_10 = new uScriptCon_CompareBoolState( );
   System.Boolean logic_uScriptCon_CompareBoolState_target_10 = (bool) false;
   System.Boolean logic_uScriptCon_CompareBoolState_previousState_10 = (bool) false;
   bool logic_uScriptCon_CompareBoolState_Out_10 = true;
   bool logic_uScriptCon_CompareBoolState_IsTrue_10 = true;
   bool logic_uScriptCon_CompareBoolState_IsFalse_10 = true;
   bool logic_uScriptCon_CompareBoolState_WasTrue_10 = true;
   bool logic_uScriptCon_CompareBoolState_WasFalse_10 = true;
   
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
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == logic_uScriptAct_AttachToGameObject_Target_9 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_AttachToGameObject_Target_9 = GameObject.Find( "/ThirdPersonController" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
         
         //setup new listeners
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
      logic_uScriptAct_AttachToGameObject_uScriptAct_AttachToGameObject_9.SetParent(g);
      logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_10.SetParent(g);
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
   
   void Relay_OnEnterCollision_0()
   {
      if (true == CheckDebugBreak("7e541fea-1cf4-4bc0-9867-93f7096f374c", "On_Collision", Relay_OnEnterCollision_0)) return; 
      local_1_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_OnExitCollision_0()
   {
      if (true == CheckDebugBreak("7e541fea-1cf4-4bc0-9867-93f7096f374c", "On_Collision", Relay_OnExitCollision_0)) return; 
      local_1_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
   }
   
   void Relay_WhileInsideCollision_0()
   {
      if (true == CheckDebugBreak("7e541fea-1cf4-4bc0-9867-93f7096f374c", "On_Collision", Relay_WhileInsideCollision_0)) return; 
      local_1_UnityEngine_GameObject = event_UnityEngine_GameObject_GameObject_0;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
            
            //setup new listeners
         }
      }
      Relay_In_4();
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
                  if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptCon_GameObjectHasTag_GameObject_2 = local_1_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_2.In(logic_uScriptCon_GameObjectHasTag_GameObject_2, logic_uScriptCon_GameObjectHasTag_Tag_2);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_GameObjectHasTag_uScriptCon_GameObjectHasTag_2.HasAllTags;
         
         if ( test_0 == true )
         {
            Relay_In_8();
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
                  if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptCon_IsNull_Target_4.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptCon_IsNull_Target_4, index + 1);
               }
               logic_uScriptCon_IsNull_Target_4[ index++ ] = local_3_UnityEngine_GameObject;
               
            }
         }
         logic_uScriptCon_IsNull_uScriptCon_IsNull_4.In(logic_uScriptCon_IsNull_Target_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptCon_IsNull_uScriptCon_IsNull_4.IsNull;
         bool test_1 = logic_uScriptCon_IsNull_uScriptCon_IsNull_4.IsNotNull;
         
         if ( test_0 == true )
         {
            Relay_In_7();
         }
         if ( test_1 == true )
         {
            Relay_In_10();
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
      Relay_In_4();
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
                  if ( local_1_UnityEngine_GameObject_previous != local_1_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_1_UnityEngine_GameObject_previous = local_1_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_SetGameObject_Value_8 = local_1_UnityEngine_GameObject;
               
            }
            {
            }
         }
         logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_8.In(logic_uScriptAct_SetGameObject_Value_8, out logic_uScriptAct_SetGameObject_TargetGameObject_8);
         local_3_UnityEngine_GameObject = logic_uScriptAct_SetGameObject_TargetGameObject_8;
         {
            //if our game object reference was changed then we need to reset event listeners
            if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
            {
               //tear down old listeners
               
               local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
               
               //setup new listeners
            }
         }
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetGameObject_uScriptAct_SetGameObject_8.Out;
         
         if ( test_0 == true )
         {
            Relay_In_9();
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
         if (true == CheckDebugBreak("1cbd1733-d30d-4cf0-8180-ea480d5bb1dc", "Attach_To_GameObject", Relay_In_9)) return; 
         {
            {
            }
            {
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_3_UnityEngine_GameObject_previous != local_3_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_3_UnityEngine_GameObject_previous = local_3_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               logic_uScriptAct_AttachToGameObject_Attachment_9 = local_3_UnityEngine_GameObject;
               
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
         logic_uScriptAct_AttachToGameObject_uScriptAct_AttachToGameObject_9.In(logic_uScriptAct_AttachToGameObject_Target_9, logic_uScriptAct_AttachToGameObject_Attachment_9, logic_uScriptAct_AttachToGameObject_UseRelativeOffset_9, logic_uScriptAct_AttachToGameObject_RelativeOffset_9, logic_uScriptAct_AttachToGameObject_UseRelativeRotation_9, logic_uScriptAct_AttachToGameObject_RelativeRotation_9);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Attach To GameObject.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("e7ec3327-f42c-46d5-b45b-de3402b96df2", "Compare_Bool_State", Relay_In_10)) return; 
         {
            {
               logic_uScriptCon_CompareBoolState_target_10 = local_6_System_Boolean;
               
            }
            {
            }
         }
         logic_uScriptCon_CompareBoolState_uScriptCon_CompareBoolState_10.In(logic_uScriptCon_CompareBoolState_target_10, ref logic_uScriptCon_CompareBoolState_previousState_10);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript testi.uscript at Compare Bool State.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:1", local_1_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "67aaacfb-a75f-4300-bbfe-a13d80138a08", local_1_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:3", local_3_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "609167f6-a5ac-4949-a403-1113bd11f1d5", local_3_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "testi.uscript:6", local_6_System_Boolean);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "84eca832-261c-41e2-9634-e2ad8791152c", local_6_System_Boolean);
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
