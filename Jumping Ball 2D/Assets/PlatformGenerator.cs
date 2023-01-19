using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    
    public GameObject platform;

    public int numberOfPlatforms;
    public float width = 3f;
    public float minY = 1.5f;
    public float maxY = 5f;

    void Start()
    {
        Vector3 spawnPos = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(-width, width);
            Instantiate(platform, spawnPos, Quaternion.identity);
        }        
    }

}
