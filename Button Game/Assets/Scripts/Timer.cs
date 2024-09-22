using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLeft = 1.0f;

    public TMP_Text timeText;
    public TMP_Text winLabel;

    public GameObject restartButton;

    public AudioSource sfxSource;

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
            winLabel.text = "You Survived!";
            sfxSource.Play();
            restartButton.SetActive(true);
        }
    }

    public void DecreaseTime(float timeToDecrease)
    {
        timeLeft -= timeToDecrease;
    }

    void OnGUI()
    {
        timeText.text = "Time: " + timeLeft.ToString("N0");
    }
}
