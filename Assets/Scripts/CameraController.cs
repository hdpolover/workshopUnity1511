using UnityEngine;

public class CameraController : MonoBehaviour
{
    /*
    public Transform target;

    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        // Vector3 to store the position
        Vector3 desiredPosition = target.position + offset;
        // Smooth the camera follow with lerp
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        transform.position = smoothedPosition;
        transform.LookAt(target);
    }
    */
    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
