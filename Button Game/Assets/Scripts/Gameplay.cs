using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gameplay : MonoBehaviour
{
    [Header("Correct\n")]
    public int correctNumber = 0;
    public GameObject correctLabel;
    public TMP_Text correctText;

    [Header("Wrong\n")]
    public int wrongNumber = 0;
    public GameObject wrongLabel;
    public TMP_Text wrongText;

    [Header("SFX\n")]
    public AudioSource correctSound;
    public AudioSource wrongSound;

    public AudioSource winSound;
    public AudioSource drawSound;
    public AudioSource loseSound;

    [Header("Sections\n")]
    public GameObject sectionA;
    public GameObject sectionB;
    public GameObject sectionC;

    [Header("Results\n")]
    public GameObject resultsLabel;

    public TMP_Text correctAmount;
    public TMP_Text wrongAmount;

    public GameObject conclusionLabel;
    public TMP_Text conclusionText;

    public GameObject restartButton;
    public TMP_Text restartText;

    public GameObject menuButton;

    void Start()
    {
        resultsLabel.SetActive(false);
        conclusionLabel.SetActive(false);
        restartButton.SetActive(false);
        menuButton.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            sectionA.transform.position = new Vector3(0.0f, 0.0f, 10.0f);
        else
            sectionA.transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        if (Input.GetKey(KeyCode.B))
            sectionB.transform.position = new Vector3(0.0f, 0.0f, 10.0f);
        else
            sectionB.transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        if (Input.GetKey(KeyCode.C))
            sectionC.transform.position = new Vector3(0.0f, 0.0f, 10.0f);
        else
            sectionC.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    public void Correct()
    {
        correctNumber += 1;
        correctText.text = correctNumber.ToString();
        correctSound.Play();
    }

    public void Wrong()
    {
        wrongNumber += 1;
        wrongText.text = wrongNumber.ToString();
        wrongSound.Play();
    }

    public void Results()
    {
        resultsLabel.SetActive(true);
        conclusionLabel.SetActive(true);
        correctLabel.SetActive(false);
        wrongLabel.SetActive(false);
        restartButton.SetActive(true);
        menuButton.SetActive(true);

        if (correctNumber > wrongNumber)
        {
            correctAmount.text = correctNumber.ToString("N0");
            wrongAmount.text = wrongNumber.ToString("N0");

            conclusionText.text = "Congratulations, you've won!";
            restartText.text = "Play Again?";
            winSound.Play();
        }
        else if (correctNumber < wrongNumber)
        {
            correctAmount.text = correctNumber.ToString("N0");
            wrongAmount.text = wrongNumber.ToString("N0");

            conclusionText.text = "Congratulations, you've lost!";
            restartText.text = "Try Again?";
            loseSound.Play();
        }
        else
        {
            correctAmount.text = correctNumber.ToString("N0");
            wrongAmount.text = wrongNumber.ToString("N0");

            conclusionText.text = "Congratulations, it's a draw!";
            restartText.text = "Restart?";
            drawSound.Play();
        }
    }
}
