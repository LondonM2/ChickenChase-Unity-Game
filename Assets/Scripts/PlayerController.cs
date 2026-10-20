using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Movement tuning (editable in inspector)
    public float speed = 5.0f;
    public float turnSpeed;

    // Input System action exposed in Inspector for binding (WASD/Arrow Keys)
    public InputAction MoveAction;

    // Current input value (x = left/right, y = forward/bacl), Kept private for internal use
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enble the MoveAction so it starts reading inpur 
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Read the 2D vector from the MoveAction (x: horizontal, y: vertical)
        moveInput = MoveAction.ReadValue<Vector2>();

        // Move the vehicle forward/backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        //Move the vehicle left/right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
       
    }
}
