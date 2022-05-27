using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{

    [SerializeField]
    private playerStats ps;
    
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    public void move(InputAction.CallbackContext context) {
        rb.velocity = context.ReadValue<Vector2>() * ps.moveSpeed;
    }
}
