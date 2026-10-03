using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void GoToScene(string name)
    {
        Time.timeScale = 1f;
        MenuController.inputBlocked = false;
        SceneManager.LoadScene(name);
    }
}