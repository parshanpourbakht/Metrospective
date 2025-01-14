using UnityEngine;

public class PinStateReader : MonoBehaviour
{
    public GameObject annacisPin;
    public GameObject boneyardPin;
    public GameObject burnsPin;
    public GameObject reworldPin;
    public GameObject riversidePin;
    public GameObject seymourLakePin;
    public GameObject grousePin;

    private void Start()
    {
        annacisPin.SetActive(PlayerPrefs.GetInt("annacis_State", 0) == 1);
        boneyardPin.SetActive(PlayerPrefs.GetInt("boneyard_State", 0) == 1);
        burnsPin.SetActive(PlayerPrefs.GetInt("burns_State", 0) == 1);
        reworldPin.SetActive(PlayerPrefs.GetInt("reworld_State", 0) == 1);
        riversidePin.SetActive(PlayerPrefs.GetInt("riverside_State", 0) == 1);
        seymourLakePin.SetActive(PlayerPrefs.GetInt("seymourlake_State", 0) == 1);
        grousePin.SetActive(PlayerPrefs.GetInt("grouse_State", 0) == 1);
    }
}
