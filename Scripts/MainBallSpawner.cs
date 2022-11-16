using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBallSpawner : MonoBehaviour
{
    public GameObject mainSpawnPoint;
    public GameObject mainBall;
    public JuniorBallSpawner jbs;
    // Start is called before the first frame update
    void Start()
    {
        //Spawning Main Ball after a regular time interval
        InvokeRepeating(nameof(Spawn), 2f, 15f);

    }

    public void Spawn()
    {
        Instantiate(mainBall, mainSpawnPoint.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
