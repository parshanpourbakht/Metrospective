using UnityEngine;

public class CameraAligner : MonoBehaviour
{
    public OVRCameraRig ovrCameraRig; // Reference to the OVRCameraRig
    public GameObject uiCanvas; // The UI canvas you want to align with

    void Start()
    {
        AlignCameraToUICanvas();
    }

    void AlignCameraToUICanvas()
    {
        // Get the center eye anchor from the OVRCameraRig
        Transform centerEyeAnchor = ovrCameraRig.centerEyeAnchor;

        // Get the forward direction of the UI canvas
        Vector3 uiForward = uiCanvas.transform.forward;
        uiForward.y = 0; // Ignore vertical tilt
        uiForward.Normalize();

        // Calculate the rotation required to align the camera with the UI canvas
        Quaternion targetRotation = Quaternion.LookRotation(uiForward);

        // Apply the rotation to the center eye anchor
        centerEyeAnchor.rotation = targetRotation;

        // Optionally, if you need to move the camera to be in front of the UI canvas
        // you can adjust the camera's position. This example does not do so because
        // it only rotates the camera.
    }
}
