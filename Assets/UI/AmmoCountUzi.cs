using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCountUzi : MonoBehaviour
{
    Text text;
    public static int Ammo = 30;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = Ammo.ToString();
    }
}
