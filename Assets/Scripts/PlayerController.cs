using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float maxSpeed;
    public float jumpHeight;

    bool facingRight;
    bool grounded;

    public Transform gunTip;
    public GameObject bullet;
    float fireRate = 0.5f;
    float nextFire = 0;

    Rigidbody2D myBody;
    Animator myAnimator;
	// Use this for initialization
	void Start () {
        myBody = GetComponent<Rigidbody2D>();
        myAnimator  = GetComponent<Animator>();
        facingRight = true;
	}

    // Update is called once per frame
    void FixedUpdate() {
        // get name input
        float move = Input.GetAxis("Horizontal");

        // set speed based keyboard
        myAnimator.SetFloat("speed", Mathf.Abs(move));

        myBody.velocity = new Vector2(move * maxSpeed, myBody.velocity.y);

        if(move > 0 && !facingRight)
        {
            filp();
        } else if(move < 0 && facingRight) {
            filp();
        }

        if (Input.GetKey(KeyCode.Space)) {
            if (grounded)
            {
                grounded = false;
                myBody.velocity = new Vector2(myBody.velocity.x, jumpHeight);
            }

        }

        if(Input.GetAxisRaw("Fire1")>0)
        {
            fireBullet();
        }

    } 

    void filp()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    void fireBullet()
    {
        if(Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            if(facingRight)
            {
                // tao nhieu bang sao vien dan
                Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0,0,0)));
            } else if(!facingRight) {
                Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 180)));
            }
        }
    }
}
