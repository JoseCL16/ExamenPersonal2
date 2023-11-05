using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EHomingShoot : EnemyShoot
{
    public GameObject BurstBullet2;
    public float canonShoot2;
    public float reload2 = 5f;

    public GameObject BurstBullet3;
    public float canonShoot3;
    public float reload3 = 5f;

    void Update()
    {
        canonShoot += Time.deltaTime;
        canonShoot2 += Time.deltaTime;
        canonShoot3 += Time.deltaTime;
        Eshoot();
    }

    public override void Eshoot()
    {
        if (canonShoot >= reload)
        {
            Instantiate(enemyBullet, EBulletPoint.position, Quaternion.identity);
            canonShoot = 0;
        }

        if (canonShoot2 >= reload2)
        {
            Instantiate(BurstBullet2, EBulletPoint.position, Quaternion.identity);
            canonShoot2 = 0.10f;
        }

        if (canonShoot3 >= reload3)
        {
            Instantiate(BurstBullet3, EBulletPoint.position, Quaternion.identity);
            canonShoot3 = 0.05f;
        }
    }
}