using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPinsActive : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject annacisPin;
    public GameObject boneyardPin;
    public GameObject burnsPin;
    public GameObject reworldPin;
    public GameObject riversidePin;
    public GameObject seymourPin;
    void Start()
    {
        if (PlayerPrefs.GetInt("annacis") != 1)
        {
            annacisPin.SetActive(false);
        }
        if (PlayerPrefs.GetInt("boneyard") != 1)
        {
            boneyardPin.SetActive(false);
        }
        if (PlayerPrefs.GetInt("burns") != 1)
        {
            burnsPin.SetActive(false);
        }
        if (PlayerPrefs.GetInt("reworld") != 1)
        {
            reworldPin.SetActive(false);
        }
        if (PlayerPrefs.GetInt("riverside") != 1)
        {
            riversidePin.SetActive(false);
        }
        if (PlayerPrefs.GetInt("seymour") != 1)
        {
            seymourPin.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
