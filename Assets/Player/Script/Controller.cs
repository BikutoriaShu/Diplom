using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public Animator animation2d;
    public Collider2D groundCollider;
    public float RunSpeed = 100f;
    float hMove = 0f;
    bool facingRight = true;
    bool canJump = false;
    public float jumpForce =35f;
    public int gems = 0;
    public int cherry = 0;
    public bool cherryAp = false;
    public static float timeleft = 10f;
    public GameObject finishCanvas;
    public int hearts = 3;

    void Start()
    {
        
    }
    void HeartLoss(int x) {
        hearts-=x;
    }
    private void Update() 
    {
        animation2d.SetFloat("speed",Mathf.Abs(hMove));
        hMove = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("jump") && canJump && Time.timeScale==1) 
        {
            animation2d.SetBool("jump", true);
            MakeJump();
        }
        if(cherryAp){
         timeleft -= Time.deltaTime;
            if(timeleft < 0){
                cherryAp = false;
                jumpForce = 8f;
                GameObject.Find("CanvasPause").transform.Find("ImageCherry").gameObject.SetActive(false);
            }
        }
    }

    private void MakeJump() 
    {
    
            rigidbody2d.AddForce(new Vector2(0f, jumpForce),ForceMode2D.Impulse);

    }

    void FixedUpdate()
    {
        PlayerMove(hMove);
        if (hMove > 0 && !facingRight)
        {
           PlayerFlip();
        }
        else if (hMove < 0 && facingRight)
        {
            PlayerFlip();
        }
    }

    private void PlayerMove(float hMoveValey)
    {
        rigidbody2d.velocity = new Vector2(hMoveValey*RunSpeed*Time.fixedDeltaTime,rigidbody2d.velocity.y);  
    }

    private void PlayerFlip()
    {
        facingRight = !facingRight;
        transform.Rotate(0,180f,0);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag =="PORTAL") {
            finishCanvas.SetActive(true);
        }
        if (other.name =="GroundAktiv"|| other.name == "Blocks") 
        {
            canJump = true;
            animation2d.SetBool("jump", false);
            animation2d.SetBool("fall", false);
        }
        if(other.tag == "Gem")
        {
            Score.gems++;
            Score.gemsfinish++;
            Destroy(other.gameObject);
        }
        if(other.tag == "cherry")
        {
            jumpForce = 10f;
            Destroy(other.gameObject);
            cherryAp = true;
            timeleft = 10;
            GameObject.Find("CanvasPause").transform.Find("ImageCherry").gameObject.SetActive(true);
        }
        if (other.tag=="PossumJaw") {
            HeartLoss(1);
        }
    }   

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.name == "GroundAktiv"|| other.name == "Blocks") 
        {
            canJump = false;
            animation2d.SetBool("fall", true);
        }
    }
}