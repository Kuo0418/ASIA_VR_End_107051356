using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("VR期末");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
