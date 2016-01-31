using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public void EndGame() { UnityEngine.SceneManagement.SceneManager.LoadScene("the_end"); }
}
