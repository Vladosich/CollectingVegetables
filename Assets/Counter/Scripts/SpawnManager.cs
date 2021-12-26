using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] vegetablePrefab;

    float startDelay = 2f;
    float repeatRate = 1f;
   
    void Start()
    {
        InvokeRepeating("SpawnVegetable", startDelay, repeatRate);
    }

    void SpawnVegetable()
    {
        int fruitIndex = Random.Range(0, vegetablePrefab.Length);
        Instantiate(vegetablePrefab[fruitIndex], RandomPosition(), vegetablePrefab[fruitIndex].transform.rotation);
    }
    Vector3 RandomPosition()
    {
        float xPosition = 0;
        float yPosition = 16;
        float zPosition = Random.Range(-12, 12);
        return new Vector3(xPosition, yPosition, zPosition);
    }
}
