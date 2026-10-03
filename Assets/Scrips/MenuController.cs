using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject MenuControllerUI;

    private bool isPaused = false;

    public static bool inputBlocked = false;

    void Start()
    {
        MenuControllerUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (isPaused)
            Resume();
        else
            Pause();
    }

    void Pause()
    {
        MenuControllerUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        inputBlocked = true;
    }

    void Resume()
    {
        MenuControllerUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        inputBlocked = false;
    }
}
