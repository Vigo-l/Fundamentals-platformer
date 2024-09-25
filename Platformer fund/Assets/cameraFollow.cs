using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;    // Reference to the player's transform.
    public float smoothSpeed = 0.125f;  // Adjust for smoothness of camera movement.
    public Vector3 offset;  // Offset for camera position from player.

    void LateUpdate()
    {
        if (player != null)
        {
            // Calculate the target position of the camera.
            Vector3 desiredPosition = player.position + offset;

            // Smoothly interpolate between the current position and the desired position.
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Set the camera's position to the smoothed position.
            transform.position = smoothedPosition;
        }
    }
}


