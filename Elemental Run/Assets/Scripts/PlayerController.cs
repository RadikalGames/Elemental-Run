using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour {
    //public members
    public float moveSpeed;
    public float SpeedMultiplier;
    public float SpeedMilestone;
    private float SpeedMilestoneCount;
    private float SpeedCap = 23.0f;
    public float jumpForce;
    public bool grounded;
    public LayerMask PlatformLayer;
    public Transform Gcheck;
    public float GcheckRadius;
    //private members
    private Rigidbody2D rb;
    private Collider2D PlayerCollider;
	private SpriteRenderer sr;
    private Animator Anim;
    public  bool Invulnerable = false;
	public static bool collided;
    
	// Use this for initialization
	void Start () 
    {
        Anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        PlayerCollider = GetComponent<Collider2D>();
		sr = GetComponent<SpriteRenderer> ();
        SpeedMilestoneCount = SpeedMilestone;
    }
	
	// Update is called once per frame  
	void Update () 
    {
       // KeepMoving();
       // grounded = Physics2D.IsTouchingLayers(PlayerCollider, PlatformLayer);
        grounded = Physics2D.OverlapCircle(Gcheck.position, GcheckRadius, PlatformLayer);

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        Anim.SetBool("isGrounded", grounded);
        

		if(Input.GetKey(KeyCode.X))
        {
			Anim.SetBool("isGrounded", grounded);
			if(grounded)
				rb.velocity = new Vector2(rb.velocity.x,jumpForce);
        }
		if (Input.GetKey (KeyCode.Space)) 
		{
			Anim.SetBool ("isSliding", true);
			if(grounded)
				rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
			Invoke ("StopSlideAnimation", 0.12f);
		}

        if(transform.position.x > SpeedMilestoneCount)
        {
			SpeedMilestoneCount += SpeedMilestone * SpeedMultiplier;
			moveSpeed *= SpeedMultiplier;
        }
        if (moveSpeed >= SpeedCap)
            moveSpeed = SpeedCap;

		if (collided) 
		{
			Anim.SetTrigger ("Hurt");
			print ("hurt");
		}
		else if (collided == false) 
		{
			Anim.SetTrigger ("Normal");
			print ("normal");
		}
	}
    public void Jump()
    {   if(grounded)
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

	void StopSlideAnimation()
	{
		Anim.SetBool ("isSliding", false);
	}

    public void Switch()
    {
        Invulnerable = true;
        StartCoroutine(SwitchRoutine());
    }
    IEnumerator SwitchRoutine()
    {
        print("Invulnerable Now");
		sr.color = new Color (1f, 1f, 1f, 0.4f);
        yield return new WaitForSeconds(1.15f);
        print("vulnerable");
        Invulnerable = false;
		sr.color = new Color (1f, 1f, 1f, 1f);
    }
    IEnumerator DamageRoutine()
	{	//print("hurt"); 
        //Anim.SetTrigger("Hurt");
        yield return new WaitForSeconds(0.085f);
        Invulnerable = false;
        Anim.SetTrigger("Normal");
    }
    public static void Damage()
    {
        
    }
   

}
