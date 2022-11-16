using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsFire : MonoBehaviour
{
    public GameObject bulletSpawnPoint;
    public Rigidbody bullet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bullet fire functionality
        if (Input.GetKeyDown(KeyCode.Space)){
            var a = Instantiate(bullet, bulletSpawnPoint.transform.position, bullet.transform.rotation);
            a.AddForce(new Vector3(0f, 2000f, 0f));
        }
    }
}
