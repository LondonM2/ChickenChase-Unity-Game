using UnityEngine;

public class SpinProeller : MonoBehaviour
{

    public float spinspeed = 900f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * spinspeed * Time.deltaTime);
    }
}
