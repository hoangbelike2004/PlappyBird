using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float height;
    float time;
    Gamecontronller gctl;
    Mesage ms;
    UImanager Ui;
    Spawn spPipe;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gctl = FindObjectOfType<Gamecontronller>();
        Ui = FindObjectOfType<UImanager>();
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            rb.gravityScale = 2.5f;
            Bird();
            gctl.Span(true);
            gctl.ShowInstruct(true);
            
        }
    }
   
    void Bird()
    {
       rb.velocity = new Vector2(rb.velocity.x, height);
        gctl.Sound2();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            gctl.GameOver(false);
            gctl.ShowScore();
            gctl.Sound3();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            gctl.GameOver(true);
            gctl.Sound();
        }
    }
}
