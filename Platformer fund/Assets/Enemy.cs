using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Kamiels Scene");
        }
    }
}
