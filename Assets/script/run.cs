using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class run : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float moveSpeed = 10f;
    public float score;
    bool isFacingRight = true;
    Animator anim;
    public float impulse = 4f;
    public Camera cam;

    bool isGrounded = false;

    public Transform groundCheck;

    float groundRadius = 0.2f;

    public LayerMask whatIsGround;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
        //cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Run();

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", isGrounded);
        anim.SetFloat("vSpeed", rigidBody.velocity.y);
        if (!isGrounded)
            return;
    }



    public void Run()
    {




        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(move));


        rigidBody.velocity = new Vector2(move * moveSpeed, rigidBody.velocity.y);
        if (move > 0 && !isFacingRight)
            Flip();
        else if (move < 0 && isFacingRight)
            Flip();
    }

    void Flip()
    {

        isFacingRight = !isFacingRight;

        Vector3 theScale = transform.localScale;

        theScale.x *= -1;

        transform.localScale = theScale;
    }

    void Update()
    {
        if (isGrounded && Input.GetKey(KeyCode.W)) 
        {
            anim.SetBool("Ground", false);
            rigidBody.AddForce(new Vector2(0, impulse*100));
        }
        if (isGrounded &&Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Ground", false);
            rigidBody.AddForce(new Vector2(0, impulse *100));
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Star")
        {
            Destroy(col.gameObject);
            score++;
        }
    }
    void OnGUI()
    {
        GUI.Box (new Rect(cam.pixelWidth /15, cam.pixelHeight /15, 100,100), "Player1 :" + score); 
    }
}