using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int Elife = 5;

    void Update()
    {
        if (Elife <= 0)
        {
            Destroy(gameObject);
            CoinCount.coinAmount += 1;
            EnemyCount.Entities -= 1;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            Elife -= 1;
        }

        if (collision.gameObject.CompareTag("Limit"))
        {
            Destroy(gameObject);
        }
    }
}
