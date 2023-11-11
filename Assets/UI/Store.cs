using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Store : MonoBehaviour
{
    public static bool StoreIsOpen = false;
    public GameObject StoreUI;


    void Update()
    {
        if (EnemyCount.Entities <= 0)
        {
            if (StoreIsOpen)
            {
                //CloseStore();
            }
            else
            {
                OpenStore();
            }
        }
    }

    public void OpenStore()
    {
        StoreUI.SetActive(true);
        Time.timeScale = 0f;
        StoreIsOpen = true;
    }

    public void CloseStore()
    {
        StoreUI.SetActive(false);
        Time.timeScale = 1f;
        StoreIsOpen = false;
    }
}
