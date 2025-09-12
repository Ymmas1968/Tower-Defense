using UnityEngine;

public class EdgeCameraMovement : MonoBehaviour
{
    public float panSpeed = 20f;
    public float panBorderThickness = 10f;
    public Vector2 panLimit = new Vector2(50f, 50f);

    public float smoothTime = 0.2f; // higher = slower smoothing
    private Vector3 velocity = Vector3.zero;

    private Vector3 targetPos;

    void Start()
    {
        targetPos = transform.position; // start where the camera is
    }

    void Update()
    {
        // Start from current target (not transform.position, so smoothing works)
        Vector3 newPos = targetPos;

        // Mouse edge detection
        if (Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            newPos.z += panSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.y <= panBorderThickness)
        {
            newPos.z -= panSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            newPos.x += panSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.x <= panBorderThickness)
        {
            newPos.x -= panSpeed * Time.deltaTime;
        }

        // Clamp the new target position
        newPos.x = Mathf.Clamp(newPos.x, -panLimit.x, panLimit.x);
        newPos.z = Mathf.Clamp(newPos.z, -panLimit.y, panLimit.y);

        // Update target
        targetPos = newPos;

        // Smoothly move camera toward target
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}