using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    [SerializeField] private Transform playerBody;
    [SerializeField] private float cameraSensitivity;
    private float xRotation = 0f;


    private void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        CameraRotate();
    }

    private void CameraRotate()
    {
        var hzLook = Input.GetAxis("Mouse X")* cameraSensitivity* Time.deltaTime;
        var vLook = Input.GetAxis("Mouse Y") * cameraSensitivity* Time.deltaTime;

        xRotation -= vLook;
        xRotation = Mathf.Clamp(xRotation, -30f, 30f);


        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * hzLook);
        
    }

}
