using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private Gameplay gameplayScript;

    void Start()
    {
        gameplayScript = GameObject.FindObjectOfType<Gameplay>();
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        gameplayScript.Wrong();
    }
}
