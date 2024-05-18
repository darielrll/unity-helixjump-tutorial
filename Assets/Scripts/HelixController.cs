using UnityEngine;
using UnityEngine.InputSystem;

public class HelixController : MonoBehaviour
{
    private Vector2 lastTapPosition;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.localEulerAngles;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 currentTapPosition = Input.mousePosition;
            if(lastTapPosition == Vector2.zero)
            {
                lastTapPosition = currentTapPosition;
            }

            float distance = lastTapPosition.x - currentTapPosition.x;
            lastTapPosition = currentTapPosition;

            transform.Rotate(Vector3.up * distance);
        }

        if(Input.GetMouseButtonUp(0))
        {
            lastTapPosition = Vector2.zero;
        }
    }
}
