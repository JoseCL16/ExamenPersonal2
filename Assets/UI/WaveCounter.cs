using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveCounter : MonoBehaviour
{
    Text text;
    public static int Wave = 1;
    
    void Start()
    {
        text = GetComponent<Text>();
    }

    public void Update()
    {
        text.text = Wave.ToString();

        if (EnemyCount.Entities == 0)
        {
            Wave++;
        }
    }
}
