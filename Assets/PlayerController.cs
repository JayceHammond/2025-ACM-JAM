using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float sensitivity;
    public GameObject camPOV;
    private Vector2 rotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotation = Vector2.zero;  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rotation.x += Input.GetAxis("Mouse X") * sensitivity;
        rotation.y += Input.GetAxis("Mouse Y") * sensitivity;
        rotation.y = Mathf.Clamp(rotation.y, -90, 90f);
        Quaternion xQat = Quaternion.AngleAxis(rotation.x, Vector3.up);
        Quaternion yQat = Quaternion.AngleAxis(rotation.y, Vector3.left);
        transform.localRotation = xQat;
        camPOV.transform.localRotation = yQat;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * moveSpeed * Time.deltaTime;
        }

    }
}
