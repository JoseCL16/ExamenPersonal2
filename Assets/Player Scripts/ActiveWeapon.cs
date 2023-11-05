using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWeapon : MonoBehaviour
{

    public int slot= 0;
    [SerializeField]
    private Transform weapons;

    void Start()
    {
        GetWeapon();
    }

    void Update()
    {
        int prevSlot = slot;

        //Change Weapon with number keys
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            slot = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && weapons.childCount >= 2)
        {
            slot = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && weapons.childCount >= 3)
        {
            slot = 2;
        }

        if (prevSlot != slot)
        {
            GetWeapon();
        }
    }

    void GetWeapon()
    {
        int i = 0;

        foreach (Transform weapons in weapons)
        {
            if (i == slot)
                weapons.gameObject.SetActive(true);
            else
                weapons.gameObject.SetActive(false);
            i++;
        }
    }
    
}