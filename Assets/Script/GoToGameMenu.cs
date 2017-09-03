using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGameMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
