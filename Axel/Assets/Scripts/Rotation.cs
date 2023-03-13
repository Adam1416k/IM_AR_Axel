using UnityEngine;

public class RotateWithCamera : MonoBehaviour
{
    public Camera cam; // The camera to track

    private Vector3 previousCamRotation; // The previous rotation of the camera

    void Start()
    {
        // Store the initial rotation of the camera
        previousCamRotation = cam.transform.rotation.eulerAngles;
    }

    void Update()
    {
        // Get the current rotation of the camera
        Vector3 currentCamRotation = cam.transform.rotation.eulerAngles;

        // Calculate the difference between the current and previous rotations of the camera
        Vector3 rotationDelta = currentCamRotation - previousCamRotation;

        // Apply the difference to the game object's rotation
        transform.Rotate(rotationDelta, Space.World);

        // Store the current rotation of the camera as the previous rotation for the next frame
        previousCamRotation = currentCamRotation;
    }
}