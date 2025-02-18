using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefGetSet : MonoBehaviour
{
    public void SetAnnacisVisited()
    {
        PlayerPrefs.SetInt("annacis", 0);    
    }
    public void SetBoneyardVisited()
    {
        PlayerPrefs.SetInt("boneyard", 0);
    }
    public void SetBurnsVisited()
    {
        PlayerPrefs.SetInt("burns", 0);
    }
    public void SetReworldVisited()
    {
        PlayerPrefs.SetInt("reworld", 0);
    }
    public void SetRiverworldVisited()
    {
        PlayerPrefs.SetInt("riverworld", 0);
    }
    public void SetSeymourVisited()
    {
        PlayerPrefs.SetInt("seymour", 0);
    }
    public void SetGrouseVisited()
    {
        PlayerPrefs.SetInt("grouse", 0);
    }
}
