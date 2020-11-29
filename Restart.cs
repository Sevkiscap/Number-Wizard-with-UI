using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public void LoadScene()
    {

        int CurrenScenetIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0);
    }

}
