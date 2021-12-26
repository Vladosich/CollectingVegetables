using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyer : MonoBehaviour
{
    public Text missedCounterText;

    int missedCounter;

    void Start()
    {
        missedCounter = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        missedCounter++;
        Destroy(collision.gameObject);
        missedCounterText.text = "Missed : " + missedCounter;

    }
}
