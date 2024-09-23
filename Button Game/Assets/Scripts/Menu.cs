using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [Header("Camera\n")]
    public Camera MainCamera;

    [Header("Screens\n")]
    public GameObject MenuScreen;
    public GameObject HowToPlayScreen;
    public GameObject CreditsScreen;

    void Start()
    {
        MainCamera.transform.position = new Vector3(0, 10, -15);

        MenuScreen.SetActive(true);
        HowToPlayScreen.SetActive(false);
        CreditsScreen.SetActive(false);
    }

    public void Back()
    {
        MainCamera.transform.position = new Vector3(0, 10, -15);

        MenuScreen.SetActive(true);
        HowToPlayScreen.SetActive(false);
        CreditsScreen.SetActive(false);
    }

    public void HowToPlay()
    {
        MainCamera.transform.position = new Vector3(-60, 10, -15);

        MenuScreen.SetActive(false);
        HowToPlayScreen.SetActive(true);
        CreditsScreen.SetActive(false);
    }

    public void Credits()
    {
        MainCamera.transform.position = new Vector3(60, 10, -15);

        MenuScreen.SetActive(false);
        HowToPlayScreen.SetActive(false);
        CreditsScreen.SetActive(true);
    }
}
