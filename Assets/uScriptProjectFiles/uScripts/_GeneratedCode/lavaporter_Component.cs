//uScript Generated Code - Build 1.0.3024
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/lavaporter")]
public class lavaporter_Component : uScriptCode
{
   #pragma warning disable 414
   public lavaporter ExposedVariables = new lavaporter( ); 
   #pragma warning restore 414
   
   public UnityEngine.Vector3 cube2_final { get { return ExposedVariables.cube2_final; } set { ExposedVariables.cube2_final = value; } } 
   public UnityEngine.Vector3 playerspawn { get { return ExposedVariables.playerspawn; } set { ExposedVariables.playerspawn = value; } } 
   public UnityEngine.Vector3 cube1_final { get { return ExposedVariables.cube1_final; } set { ExposedVariables.cube1_final = value; } } 
   
   void Awake( )
   {
      #if !(UNITY_FLASH)
      useGUILayout = false;
      #endif
      ExposedVariables.Awake( );
      ExposedVariables.SetParent( this.gameObject );
      if ( "1.PLE" != uScript_MasterComponent.Version )
      {
         uScriptDebug.Log( "The generated code is not compatible with your current uScript Runtime " + uScript_MasterComponent.Version, uScriptDebug.Type.Error );
         ExposedVariables = null;
         UnityEngine.Debug.Break();
      }
   }
   void Start( )
   {
      ExposedVariables.Start( );
   }
   void OnEnable( )
   {
      ExposedVariables.OnEnable( );
   }
   void OnDisable( )
   {
      ExposedVariables.OnDisable( );
   }
   void Update( )
   {
      ExposedVariables.Update( );
   }
   void OnDestroy( )
   {
      ExposedVariables.OnDestroy( );
   }
   #if UNITY_EDITOR
      void OnDrawGizmos( )
      {
         {
            GameObject gameObject;
            gameObject = GameObject.Find( "KillFloor" ); 
            if ( null != gameObject ) Gizmos.DrawIcon(gameObject.transform.position, "uscript_gizmo_events.png");
         }
      }
   #endif
}
