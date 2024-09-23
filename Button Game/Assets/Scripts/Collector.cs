using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [Header("Section\n")]
    public bool isToyA = false;
    public bool isToyB = false;
    public bool isToyC = false;

    private Gameplay gameplayScript;

    void Start()
    {
        gameplayScript = GameObject.FindObjectOfType<Gameplay>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ToyA")
        {
            if (isToyA)
            {
                Destroy(this.gameObject);
                gameplayScript.Correct();
            }
        }
        else
        {
            Destroy(this.gameObject);
            gameplayScript.Wrong();
        }
    }
}
