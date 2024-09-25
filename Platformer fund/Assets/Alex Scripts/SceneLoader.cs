using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    public void LvL1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
