using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D body;
    private Animator animator;
    public float moveSpeed = 10f;  
    private Vector2 direction;
    private Vector2 velocity;
    private Vector2 mousePosition;
    //private float lastDodge = 0f;
    //public float dodgeCooldown = 3f;
    private bool sprint = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (GameManager.inputEnabled == true)
        {
            ProcessInputs();
            animate();
        }
        if (body.rotation != 0)
        {
            body.rotation = 0;
        }
    }

    private void ProcessInputs()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector2(horizontal, vertical).normalized;
        bool sprint = Input.GetButton("Jump");
        
    }

    /*private void faceMouse()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 vectorToTarget = new Vector3(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y, 0);
        transform.rotation = Quaternion.LookRotation(forward: Vector3.forward, -vectorToTarget);
    }*/
    private void Move()
    {
        //Debug.Log(sprint);
        velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        if (sprint)
        {
            velocity *= 2;
        }
        //Debug.Log(velocity);
        body.velocity = velocity;
    }

    private void animate()
    {
        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", Mathf.Abs(velocity.x) + Mathf.Abs(velocity.y));
    }

    public void freeze()
    {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
    }

    public void unFreeze()
    {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        GetComponent<Rigidbody2D>().freezeRotation = true;
    }
   

        private void FixedUpdate()
    {
        //faceMouse();
        Move();
        
    }
}
