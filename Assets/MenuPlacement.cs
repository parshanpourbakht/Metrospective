using UnityEngine;

public class MenuPlacement : MonoBehaviour
{
    public Transform centerEyeAnchor; // Reference to the center eye anchor of the OVR Camera Rig
    public float distance = 3f; // Distance from player to menu

    void Start()
    {
        // Check if the centerEyeAnchor reference is set
        if(centerEyeAnchor == null)
        {
            Debug.LogError("Center Eye Anchor reference is not set in MenuPlacement script!");
            return;
        }

        // Calculate the position in front of the user
        Vector3 menuPosition = centerEyeAnchor.position + centerEyeAnchor.forward * distance;

        // Set the menu's position
        transform.position = menuPosition;

        // Make the menu face the user
        transform.LookAt(centerEyeAnchor);
    }
}
