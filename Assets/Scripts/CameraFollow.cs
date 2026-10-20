using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public Vector3 offset = new Vector3(0f, 5f, -7f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
            transform.LookAt(player);
        }
        
    }
}
