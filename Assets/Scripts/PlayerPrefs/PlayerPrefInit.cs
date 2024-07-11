using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("annacis", 1);
        PlayerPrefs.SetInt("boneyard", 1);
        PlayerPrefs.SetInt("burns", 1);               
        PlayerPrefs.SetInt("reworld", 1);       
        PlayerPrefs.SetInt("riverside", 1);       
        PlayerPrefs.SetInt("seymour", 1);
        PlayerPrefs.SetInt("buttonTooltip", 1);
        PlayerPrefs.SetInt("videoTooltip", 1);
    }
}
