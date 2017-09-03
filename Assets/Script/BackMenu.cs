using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    public void OpenMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
