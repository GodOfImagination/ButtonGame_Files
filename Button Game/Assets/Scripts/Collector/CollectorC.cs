using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorC : MonoBehaviour
{
    private Gameplay gameplayScript;

    void Start()
    {
        gameplayScript = GameObject.FindObjectOfType<Gameplay>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ToyC")
        {
            Destroy(other.gameObject);
            gameplayScript.Correct();
        }
        else
        {
            Destroy(other.gameObject);
            gameplayScript.Wrong();
        }
    }
}
