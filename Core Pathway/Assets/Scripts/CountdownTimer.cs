using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    /// <summary>The countdown's starting timer</summary>
    public float StartingTime = 10;

    float currentTime;
    Text countdownText;

    void Awake()
    {
        countdownText = GetComponent<Text>();
    }

    void Start()
    {
        currentTime = StartingTime;
    }

    void Update()
    {
        UpdateTimer();
        CheckEnd();
    }

    /// <summary>Update timer</summary>
    void UpdateTimer()
    {
        // count down every second
        currentTime -= 1 * Time.deltaTime;
        // set text to display current time formatted as a whole integer
        countdownText.text = currentTime.ToString("0");
    }

    /// <summary>Reset scene if timer runs out</summary>
    void CheckEnd()
    {
        if (currentTime <= 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
