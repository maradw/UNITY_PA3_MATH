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
        //myRBD.AddForce(Vector2.right * velocityModifier)
          //transform.position  = new Vector2(_horizontal * velocityModifier, 0);
        if (Input.GetKey(KeyCode.D))
        {
            myRBD.AddForce(Vector2.right * velocityModifier);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            myRBD.AddForce(Vector2.left * velocityModifier);
        }
    }
    void Update()
    {
        //transform.position = 
    }

}
