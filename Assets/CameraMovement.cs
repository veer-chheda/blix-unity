using UnityEngine;

public class CameraMovement : MonoBehaviour {
    float speed = 20f;
    float sensitivity = 0.2f;
    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X")*speed*Mathf.Deg2Rad*sensitivity;
        float rotY = Input.GetAxis("Mouse Y")*speed*Mathf.Deg2Rad*sensitivity;

        transform.RotateAround(Vector3.up, -rotX);

        transform.RotateAround(Vector3.right, rotY);

    }
}