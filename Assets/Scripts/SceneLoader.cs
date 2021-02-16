using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadRematchScene()
    {
        SceneManager.LoadScene(6);
    }
    public void RiddlerWins()
    {
        SceneManager.LoadScene(8);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
