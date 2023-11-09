using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedWeapon : MonoBehaviour
{
    [SerializeField] private GameObject pistol;
    [SerializeField] private GameObject shotgun;
    [SerializeField] private GameObject uzi;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ShowS(pistol);
            HideS(shotgun);
            HideS(uzi);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            HideS(pistol);
            ShowS(shotgun);
            HideS(uzi);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            HideS(pistol);
            HideS(shotgun);
            ShowS(uzi);
        }
    }

    void ShowS (GameObject weapon)
    {
        if (weapon != null)
        {
            weapon.SetActive(true);
        }
    }

    void HideS (GameObject weapon)
        
    {
        if (weapon != null)
        {
            weapon.SetActive(false);
        }
    }
}