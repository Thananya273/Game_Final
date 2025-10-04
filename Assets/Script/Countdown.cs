using UnityEngine;
using TMPro; // if using TextMeshPro
using UnityEngine.UI; // if using normal Text

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI countdownText; // assign your CountdownText
    // public Text countdownText; // if using normal Text

    public float countdownTime = 3f; // start from 3 seconds

    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    System.Collections.IEnumerator StartCountdown()
    {
        float count = countdownTime;

        while (count > 0)
        {
            countdownText.text = count.ToString("0"); // show integer
            yield return new WaitForSeconds(1f);
            count--;
        }

        countdownText.text = "GO!";
        yield return new WaitForSeconds(1f);
        countdownText.text = "";

        // Start your game here
        Time.timeScale = 1f; // unpause if you paused game
    }
}
