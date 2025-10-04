using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void PlayMadDriver()
    {
        SceneManager.LoadScene("MadDriverScene"); 
    }

    public void PlayFlyLikeBird()
    {
        SceneManager.LoadScene("FlyLikeBirdScene");
    }

    public void PlaySumoBall()
    {
        SceneManager.LoadScene("SumoBallScene");
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // quit in editor
#endif
    }
}
