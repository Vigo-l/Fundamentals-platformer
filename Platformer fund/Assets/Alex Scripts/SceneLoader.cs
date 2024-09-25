using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    public void LvL1()
    {
        SceneManager.LoadScene("Fennas Scene");
    }
    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public static void Died()
    {
        SceneManager.LoadScene("Died");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
