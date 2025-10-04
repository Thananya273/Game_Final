using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;  // assign the Panel here
    private bool isPaused = false;

    void Update()
    {
        // Press ESC to toggle pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);  // hide menu
        Time.timeScale = 1f;           // resume game
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);   // show menu
        Time.timeScale = 0f;           // freeze game
        isPaused = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f; // reset time
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f; // reset time
        SceneManager.LoadScene("MainMenu"); // make sure MainMenu is in Build Settings
    }
}
