using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTooltipDisplayWindow : MonoBehaviour
{
    public GameObject handTooltip;
    void Start()
    {
        if (PlayerPrefs.GetInt("videoTooltip") != 0)
        {
            Invoke("SetHandActive", 5.0f);
            PlayerPrefs.SetInt("videoTooltip", 0);
        }
    }
    void SetHandActive()
    {
        handTooltip.SetActive(true);
    }
}
