using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuniorBallSpawner : MonoBehaviour
{
    public Rigidbody juniorBall;
    public GameObject MainSpawnPoint;
    public GameObject SpawnPoint1;
    public GameObject SpawnPoint2;
    public GameObject SpawnPoint3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    //When bullet hit with main ball, scale of main ball decreases and junior balls spawns, after a limit mzin ball destroys
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
            if (transform.localScale.x == 1f)
            {
                Destroy(this.gameObject);
            }
            Instantiate(juniorBall, SpawnPoint1.transform.position, Quaternion.identity);
            Instantiate(juniorBall, SpawnPoint2.transform.position, Quaternion.identity);
            Instantiate(juniorBall, SpawnPoint3.transform.position, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
