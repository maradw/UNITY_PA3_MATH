using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpController : MonoBehaviour
{
    public Rigidbody2D rbd;
    public float fuerza;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rbd.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
        }*/
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rbd.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}