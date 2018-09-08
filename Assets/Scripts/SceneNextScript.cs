using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNextScript : MonoBehaviour {

    public void GetNextScene()
    {
        int currentSCeneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSCeneIndex + 1);
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
