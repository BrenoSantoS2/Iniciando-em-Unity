using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpForce = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = new Vector2(0,1) * jumpForce;
 //           myRigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
            
    }
}
