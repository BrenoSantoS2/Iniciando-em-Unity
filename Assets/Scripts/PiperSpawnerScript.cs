using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiperSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime = 4f;
    public float referenceHeight = 10f;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnPipe();
        }
    }

    void spawnPipe()
    {
        float lowestHeight = transform.position.y - referenceHeight;
        float highestHeight = transform.position.y + referenceHeight;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestHeight, highestHeight), 0), Quaternion.identity);
    }
}
