using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    //Bullet destroy condition
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject, 2f);
        }

        if (collision.gameObject.tag == "MainBall")
        {
            Destroy(this.gameObject);
        }

    }
}
