using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPinsActive : MonoBehaviour
{
    public GameObject annacisPin;
    public GameObject boneyardPin;
    public GameObject burnsPin;
    public GameObject reworldPin;
    public GameObject riversidePin;
    public GameObject seymourPin;
    public GameObject grousePin;

    public GameObject annacisButton;
    public GameObject boneyardButton;
    public GameObject burnsButton;
    public GameObject reworldButton;
    public GameObject riversideButton;
    public GameObject seymourButton;
    public GameObject grouseButton;

    public GameObject annacisButtonRing;
    public GameObject boneyardButtonRing;
    public GameObject burnsButtonRing;
    public GameObject grouseButtonRing;
    public GameObject reworldButtonRing;
    public GameObject riversideButtonRing;
    public GameObject seymourButtonRing;
    void Start()
    {
        if (PlayerPrefs.GetInt("annacis") != 1)
        {
            annacisPin.SetActive(false);
            annacisButton.GetComponent<MeshRenderer>().material.color = Color.gray;
            annacisButtonRing.GetComponent<MeshRenderer>().material.color = Color.gray;
        }
        if (PlayerPrefs.GetInt("boneyard") != 1)
        {
            boneyardPin.SetActive(false);
            boneyardButton.GetComponent<MeshRenderer>().material.color = Color.gray;
            boneyardButtonRing.GetComponent<MeshRenderer>().material.color = Color.gray;
        }
        if (PlayerPrefs.GetInt("burns") != 1)
        {
            burnsPin.SetActive(false);
            burnsButton.GetComponent<MeshRenderer>().material.color = Color.gray;
            burnsButtonRing.GetComponent<MeshRenderer>().material.color = Color.gray;
        }
        if (PlayerPrefs.GetInt("reworld") != 1)
        {
            reworldPin.SetActive(false);
            reworldButton.GetComponent<MeshRenderer>().material.color = Color.gray;
            reworldButtonRing.GetComponent<MeshRenderer>().material.color = Color.gray;
        }
        if (PlayerPrefs.GetInt("riverside") != 1)
        {
            riversidePin.SetActive(false);
            riversideButton.GetComponent<MeshRenderer>().material.color = Color.gray;
            riversideButtonRing.GetComponent<MeshRenderer>().material.color = Color.gray;
        }
        if (PlayerPrefs.GetInt("seymour") != 1)
        {
            seymourPin.SetActive(false);
            seymourButton.GetComponent<MeshRenderer>().material.color = Color.gray;
            seymourButtonRing.GetComponent<MeshRenderer>().material.color = Color.gray;
        }
        if (PlayerPrefs.GetInt("grouse") != 1)
        {
            grousePin.SetActive(false);
            grouseButton.GetComponent<MeshRenderer>().material.color = Color.gray;
            grouseButtonRing.GetComponent<MeshRenderer>().material.color = Color.gray;
        }
    }
}
