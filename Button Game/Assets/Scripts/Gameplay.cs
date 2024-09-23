using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gameplay : MonoBehaviour
{
    [Header("Correct\n")]
    public int correctNumber = 0;
    public TMP_Text correctText;

    [Header("Wrong\n")]
    public int wrongNumber = 0;
    public TMP_Text wrongText;

    [Header("SFX\n")]
    public AudioSource correctSound;
    public AudioSource wrongSound;

    [Header("Pushers\n")]
    public GameObject pusherA;
    public GameObject pusherB;
    public GameObject pusherC;

    public float timeToMove = 1.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Correct();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Wrong();
        }

        if (Input.GetKey(KeyCode.A))
        {
            pusherA.transform.position += -transform.forward * timeToMove;
        }
    }

    public void Correct()
    {
        correctNumber += 1;
        correctText.text = "Correct: " + correctNumber.ToString();
        correctSound.Play();
    }

    public void Wrong()
    {
        wrongNumber += 1;
        wrongText.text = "Wrong: " + wrongNumber.ToString();
        wrongSound.Play();
    }
}
