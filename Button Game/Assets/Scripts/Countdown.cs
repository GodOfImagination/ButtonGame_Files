using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    [Header("Time\n")]
    public float _remainingTime = 1.0f;
    public TMP_Text _timerText;

    private bool _timerIsRunning = false;
    private Gameplay gameplayScript;

    void Start()
    {
        _timerIsRunning = true;

        gameplayScript = GameObject.FindObjectOfType<Gameplay>();
    }

    void Update()
    {
        if (_timerIsRunning)
        {
            if (_remainingTime > 0)
            {
                _remainingTime -= Time.deltaTime;
                DisplayTime(_remainingTime);
            }
            else
            {
                _remainingTime = 0;
                _timerIsRunning = false;
                gameplayScript.Results();
                Destroy(this.gameObject);
            }
        }
    }

    private void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        _timerText.text = $"{minutes:00}:{seconds:00}";
    }
}
