
using UnityEngine;
using UnityEngine.InputSystem;

public class GreyboxPlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector2 input = Vector2.zero;

        if (Keyboard.current == null) return;

        if (Keyboard.current.wKey.isPressed ||
            Keyboard.current.upArrowKey.isPressed)
            input.y += 1;

        if (Keyboard.current.sKey.isPressed ||
            Keyboard.current.downArrowKey.isPressed)
            input.y -= 1;

        if (Keyboard.current.aKey.isPressed ||
            Keyboard.current.leftArrowKey.isPressed)
            input.x -= 1;

        if (Keyboard.current.dKey.isPressed ||
            Keyboard.current.rightArrowKey.isPressed)
            input.x += 1;

        Vector3 movement = new Vector3(input.x, 0, input.y);

        transform.position += movement.normalized * speed * Time.deltaTime;

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -14f, 14f);
        pos.z = Mathf.Clamp(pos.z, -14f, 14f);

        transform.position = pos;
    }
}
