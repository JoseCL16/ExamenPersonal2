using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCountShotgun : MonoBehaviour
{
    Text text;
    public static int Ammo = 12;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = Ammo.ToString();
    }
}