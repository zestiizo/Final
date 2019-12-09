using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevelTwo()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
        Cursor.visible = true;
    }
}
