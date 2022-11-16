using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementLimitController : MonoBehaviour
{
    public float leftBound = -11.41f;
    public float rightBound = 11.3f;
    public float upperBound = 9.671485f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Adding the limitations in ball movement 
        if(transform.position.x < leftBound)
        {
            transform.position = new Vector3(leftBound, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > rightBound)
        {
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);
        }

        if (transform.position.y > upperBound)
        {
            transform.position = new Vector3(transform.position.x,upperBound, transform.position.z);
        }
    }
}
