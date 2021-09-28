using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void loadStartScreen()
    {
        SceneManager.LoadScene(0);
    }
    public void loadWinScreen()
    {
        SceneManager.LoadScene(2);
    }
    public void loadGameScreen()
    {
        SceneManager.LoadScene(1);
    }
}
