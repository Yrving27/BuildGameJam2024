using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public string scene;

    private void Start()
    {
       
        
    }

    public void ChangeScene(string sceneName)
    {
        sceneName = scene;
        SceneManager.LoadScene(sceneName);
    }    

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Fechou o jogo");
    }
}
