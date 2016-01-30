using UnityEngine;
using System.Collections;

public class ToggleKinematic : MonoBehaviour {


    public void DisableKinematic()
    {
        Debug.Log("DISABLING KINEMATIC!!!");
        this.GetComponent<Rigidbody>().isKinematic = false;
    }

    public void EnableKinematic()
    {
        Debug.Log("ENABLING KINEMATIC!!!");
        this.GetComponent<Rigidbody>().isKinematic = true;
    }
    
}
