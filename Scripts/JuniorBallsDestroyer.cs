using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuniorBallsDestroyer : MonoBehaviour
{

    public float LeftBound = -11.41f;
    public float RightBound = 11.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < LeftBound)
        {
            transform.position = new Vector3(LeftBound, transform.position.y, transform.position.z);
        }

        if (transform.position.x > RightBound)
        {
            transform.position = new Vector3(RightBound, transform.position.y, transform.position.z);
        }

        if (transform.position.z < 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
