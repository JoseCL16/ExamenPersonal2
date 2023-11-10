using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
    Text text;
    public static int Entities = 10;

    void Start()
    {
        text = GetComponent<Text>();
    }

    public void Update()
    {
        text.text = Entities.ToString();

        if (Entities == 0)
        {
             Entities += 11;         
        }
    }    
}