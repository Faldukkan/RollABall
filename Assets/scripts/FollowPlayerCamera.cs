using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    public Transform target; 
    // Reference to the player's
    
    public Vector3 offset; 
    // Offset from the player's position

    void LateUpdate()
    {
        if (target != null) // Check if the target is valid
        {
            // Set the camera's position to match the player's position with the offset
            transform.position = target.position + offset;
        }
    }
}
