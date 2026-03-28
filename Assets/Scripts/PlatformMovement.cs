using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float xLimit = 1.8f;

    private void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null)
        {
            return;
        }

        var input = 0f;

        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {
            input -= 1f;
        }

        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {
            input += 1f;
        }

        var position = transform.position;
        position.x += input * moveSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
        transform.position = position;
    }
}
