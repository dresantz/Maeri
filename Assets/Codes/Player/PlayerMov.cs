using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public static PlayerMov instance;

    public DialogueUI dialogueUI;

    public Animator animator;

    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 movement;
    private bool move = true;

    private GrabDrop grabDrop;


    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);

        grabDrop = gameObject.GetComponent<GrabDrop>();
        grabDrop.Direction = new Vector2(movement.x, movement.y);

    }

    void Update()
    {
        if (dialogueUI.IsOpen)
        {
            move = false;
        }
        else
        {
            move = true;
        }

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = new Vector2(movement.x, movement.y).normalized;
        if (movement.sqrMagnitude > .1f)
        {
            grabDrop.Direction = movement.normalized;
        }

        if (movement != Vector2.zero)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
        }
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate() 
    {
        if (!move)
        {
            rb.MovePosition(rb.position);
        }
        else
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}
