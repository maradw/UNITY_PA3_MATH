using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    private float _horizontal;
    [SerializeField] private float velocityModifier = 5f;
    [SerializeField] private Rigidbody2D myRBD;
    void Start()
    {
        
    }
    public void OnMovement(InputAction.CallbackContext move)
    {

        _horizontal = move.ReadValue<float>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myRBD.AddForce(Vector2.right * velocityModifier);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            myRBD.AddForce(Vector2.left * velocityModifier);
        }


         // transform.position  = new Vector2(_horizontal * velocityModifier, 0);
         // _horizontal = 
    }
    void Update()
    {
        //transform.position = 
    }
}
