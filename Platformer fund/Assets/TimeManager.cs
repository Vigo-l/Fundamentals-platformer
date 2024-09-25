using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public static float timer;
    private bool endReached;
    [SerializeField] private TextMeshProUGUI TimeText;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name != "Win" && SceneManager.GetActiveScene().name != "Died")
        {
            endReached = false;
            timer = 0;
        }
        else
        {
            endReached = true;
        }
    }

    private void Update()
    {
        if (!endReached)
        {
            timer += Time.deltaTime;
        }

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        float milliseconds = (timer % 1) * 1000;


        TimeText.text = $"<Time: {minutes:00}:{seconds:00}.{milliseconds:0}>";

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ending"))
        {
            Debug.Log("help");
            endReached = true;
            SceneLoader.Died();
        }
    }
}
