using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpossumControl : MonoBehaviour
{
   
    private Rigidbody2D rb;
    private Animator anim;
    int dir = -1;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        rb.velocity = new Vector2(dir,rb.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag=="PossumWall") {
            dir=-dir;
            transform.Rotate(0,180f,0);
        }
    }
    public void PossumDestroy() {
        anim.SetBool("possumDeath",true);
        rb.mass=0;
        gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
    }
    public void PossumDestroyTotal() {
        Destroy(gameObject);
    }
}
