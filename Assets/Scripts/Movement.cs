using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;

    private Vector2 movement;
    private Vector2 idleMovement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
         
        //animator.SetFloat("Speed", movement.sqrMagnitude);

        if(movement.x != 0 || movement.y != 0)
        {
            idleMovement.x = movement.x;
            idleMovement.y = movement.y;
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

        if (idleMovement.x != 0 || idleMovement.y != 0)
        {
            animator.SetFloat("idleMoveX", idleMovement.x);
            animator.SetFloat("idleMoveY", idleMovement.y);
        }

        if (Input.GetMouseButtonDown(0))// && !transitioning)
        {
            //transitioning = true;
            animator.SetTrigger("transition");

            Debug.Log("transition made");
        }
        /*else
        {
            transitioning = false;
            Debug.Log("beep");
        }
        */

        animator.SetFloat("moveX", movement.x);
        animator.SetFloat("moveY", movement.y);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
