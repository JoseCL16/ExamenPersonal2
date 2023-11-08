using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4Shoot : MonoBehaviour
{
    public Transform target;

    public Transform EBulletPoint;
    public GameObject enemyBullet;
    public float canonShoot;
    public float reload = 5f;

    public float radius;

    void Awake()
    {
        target = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) <= radius)
        {
            canonShoot += Time.deltaTime;
            if (canonShoot >= reload)
            {
                Shoot();
                canonShoot = 0;
            }
        }
    }

    void Shoot()
    { 
        Instantiate(enemyBullet, EBulletPoint.position, EBulletPoint.rotation);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
