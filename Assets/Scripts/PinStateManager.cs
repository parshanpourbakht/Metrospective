using UnityEngine;

public class PinStateManager : MonoBehaviour
{
    // Initialize pin states (call this method at the start of your game or scene)
    public void InitializePinStates()
    {
        // Set default states if not already set
        if (!PlayerPrefs.HasKey("annacis_State")) PlayerPrefs.SetInt("annacis_State", 0);
        if (!PlayerPrefs.HasKey("boneyard_State")) PlayerPrefs.SetInt("boneyard_State", 0);
        if (!PlayerPrefs.HasKey("burns_State")) PlayerPrefs.SetInt("burns_State", 0);
        if (!PlayerPrefs.HasKey("reworld_State")) PlayerPrefs.SetInt("reworld_State", 0);
        if (!PlayerPrefs.HasKey("riverside_State")) PlayerPrefs.SetInt("riverside_State", 0);
        if (!PlayerPrefs.HasKey("seymourlake_State")) PlayerPrefs.SetInt("seymourlake_State", 0);
        if (!PlayerPrefs.HasKey("grouse_State")) PlayerPrefs.SetInt("grouse_State", 0);
        
        PlayerPrefs.Save();
    }

    // Setters for each pin state
    public void SetAnnacisState(bool state)
    {
        PlayerPrefs.SetInt("annacis_State", state ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void SetBoneyardState(bool state)
    {
        PlayerPrefs.SetInt("boneyard_State", state ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void SetBurnsState(bool state)
    {
        PlayerPrefs.SetInt("burns_State", state ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void SetReworldState(bool state)
    {
        PlayerPrefs.SetInt("reworld_State", state ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void SetRiversideState(bool state)
    {
        PlayerPrefs.SetInt("riverside_State", state ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void SetSeymourLakeState(bool state)
    {
        PlayerPrefs.SetInt("seymourlake_State", state ? 1 : 0);
        PlayerPrefs.Save();
    }
    public void SetGrouseState(bool state)
    {
        PlayerPrefs.SetInt("grouse_State", state ? 1 : 0);
        PlayerPrefs.Save();
    }
}
