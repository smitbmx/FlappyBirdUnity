using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCollector : MonoBehaviour
{
    private GameObject[] pipeHolders;
    private float pipeDistance = 2.5f;
    private float lastPipesX;
    private float pipeMin = -1.15f;
    private float pipeMax = 3;

    // Start is called before the first frame update
    void Awake()
    {
        pipeHolders = GameObject.FindGameObjectsWithTag("PipeHolder");

        for (int i = 0; i < pipeHolders.Length; i++)
        {
            Vector3 temp = pipeHolders[i].transform.position;
            temp.y = Random.Range(pipeMin, pipeMax);
            pipeHolders[i].transform.position = temp;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
