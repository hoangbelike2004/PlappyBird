using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=1.3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveGround();
    }

    void MoveGround()
    {
        transform.position += Vector3.left*speed*Time.deltaTime;
    }
}
