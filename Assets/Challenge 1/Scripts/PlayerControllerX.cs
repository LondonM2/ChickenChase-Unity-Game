using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    // Moving tuning 
    public float speed = 5.0f;
    public float rotationSpeed;
    public float verticalInput;


    // Input systems actions 
    public InputAction MoveAction;

    private Vector2 moveInput;


    // Start is called before the first frame update
    void Start()
    {
        // Enble the MoveAction so it starts reading inpur 
        MoveAction.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        moveInput = MoveAction.ReadValue<Vector2>();

        // Always move the plane forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Translate(Vector3.up * moveInput.y * speed * Time.deltaTime);

        // move the plane forward at a constant rate
        transform.Rotate(Vector3.forward * -moveInput.x * rotationSpeed * verticalInput * Time.deltaTime);
    }
}
