using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Pipe;
    public float TimeBtw=2f;
    private float timebtw;

    // Update is called once per frame
    private void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, 1.7f);
    }
    void Update()
    {
    //    timebtw -= Time.deltaTime;
    //    if(timebtw <= 0)
    //    {
    //        SpawnPipe();
    //    }
    }
    void SpawnPipe()
    {
        //timebtw = TimeBtw;
        Vector2 spawnPos = new Vector2(transform.position.x,Random.Range(0.5f,6.5f));
        Instantiate(Pipe, spawnPos, Quaternion.identity);
    }
}
