using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 5f;


    private Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
}
