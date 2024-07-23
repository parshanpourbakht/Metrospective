using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class HandTooltipStart : MonoBehaviour
{
    public GameObject handTooltip;

    void Start()
    {
        if (PlayerPrefs.GetInt("startTooltip") != 0)
        {
            UnityEngine.Debug.Log("**invoke hand tooltip**");
            Invoke("SetHandActive", 5.0f);
            PlayerPrefs.SetInt("startTooltip", 0);
        }
    }

    void SetHandActive()
    {
        handTooltip.SetActive(true);
    }
}