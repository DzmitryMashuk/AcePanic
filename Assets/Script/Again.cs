using UnityEngine;
using UnityEngine.SceneManagement;

public class Again : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
