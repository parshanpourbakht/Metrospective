using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class SnapPosition : MonoBehaviour
{
    Transform _OVRCameraRig;
    Transform _centreEyeAnchor;

    void FindOVRCameraRig()
    {
        OVRCameraRig ovr = FindObjectOfType<OVRCameraRig>();

        if (ovr)
        {
            _OVRCameraRig = ovr.transform;
            _centreEyeAnchor = ovr.centerEyeAnchor;
            Debug.Log("********************OVRCameraRig object found*********************");
        }
        else
        {
            Debug.Log("No OVRCameraRig object found");
        }
    }

    void Start()
    {
        OVRManager.HMDMounted += HandleHMDMounted;
        OVRManager.HMDUnmounted += HandleHMDUnmounted;
        FindOVRCameraRig();
        RecenterHeadset();
    }

    void OnDestroy()
    {
        OVRManager.HMDMounted -= HandleHMDMounted;
        OVRManager.HMDUnmounted -= HandleHMDUnmounted;
    }

    public void RecenterHeadset()
    {
        FindOVRCameraRig();
        if (_OVRCameraRig != null && _centreEyeAnchor != null)
        {
            StartCoroutine(ResetCamera(new Vector3(0, 0, 0), 0));
        }
    }

    IEnumerator ResetCamera(Vector3 targetPosition, float targetYRotation)
    {
        yield return new WaitForEndOfFrame();
        if (_OVRCameraRig != null && _centreEyeAnchor != null)
        {
            float currentRotY = _centreEyeAnchor.eulerAngles.y;
            float difference = targetYRotation - currentRotY;
            _OVRCameraRig.Rotate(0, difference, 0);

            Vector3 newPos = new Vector3(targetPosition.x - _centreEyeAnchor.position.x, 0, targetPosition.z - _centreEyeAnchor.position.z);
            _OVRCameraRig.transform.position += newPos;
        }
    }

    void HandleHMDMounted()
    {
        FindOVRCameraRig();
        RecenterHeadset();
        Debug.Log("*******************HMD MOUNTED***********************");
    }

    void HandleHMDUnmounted()
    {
        // Load the scene with index 0 (or replace with the desired scene index or name)
        SceneManager.LoadScene(0);
    }
}
