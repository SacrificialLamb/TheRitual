using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonHandlerScript : MonoBehaviour {

    public void OnStartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("testi");
    }

    public void OnExitGame()
    {
        Application.Quit();
    }
}
 