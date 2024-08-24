using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{  
    public float moveSpeed = 5;
    public int deathZone = -20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deathZone)
        {
            Debug.Log("Pipe destroyed");
            Destroy(gameObject);
        }

        transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0, 0);
    }
}
