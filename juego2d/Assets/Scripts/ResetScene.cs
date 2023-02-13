using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("caida"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
