using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // "Trasnform player" connects the camera to the camera (1st Person)
    public Transform player;
    // Vector3 contains 3floats (x,y,z)
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // player.position + offset (3rd Person)
        transform.position = player.position + offset;
    }
}
