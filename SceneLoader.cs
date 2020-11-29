using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadScene()
    {

        int CurrenScenetIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrenScenetIndex + 1);
    }


    public void GameQuit()
    {

        Application.Quit();
    }

}
