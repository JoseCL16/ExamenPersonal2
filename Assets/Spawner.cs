using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawner;
    public GameObject[] enemies;
    public float spawn;
    public float create= 4.0f;


    private void Update()
    {
        spawn += Time.deltaTime;
        if (spawn>= create)
        {
            Espawn();
            spawn = 0;
        }
    }

    public virtual void Espawn()
    {
        Instantiate(enemies[Random.Range(0, 4)]);
    }
}
