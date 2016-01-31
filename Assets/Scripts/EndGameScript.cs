using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour {

    public void EndGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("EndScene");
    }

}
