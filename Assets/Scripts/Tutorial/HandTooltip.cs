using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTooltip : MonoBehaviour
{
    public GameObject handTooltip;  

    void Start()
    {
        if (PlayerPrefs.GetInt("buttonTooltip") != 0)
        { 
            Invoke("SetHandActive", 5.0f);
            PlayerPrefs.SetInt("buttonTooltip", 0);
        }
    }

    void SetHandActive()
    {
        handTooltip.SetActive(true);
    }
}
