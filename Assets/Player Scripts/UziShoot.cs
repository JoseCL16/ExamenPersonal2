using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UziShoot : WeaponShoot 
{
    public float fireRate = 0.3f;
    public float maxFireRate;

    public int MaxAmmo = 30;
    public static int Ammo;

    private void Start()
    {
        Ammo = MaxAmmo;
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time - maxFireRate >= fireRate && Ammo >0)
        {
            Shoot();
            Ammo -= 1;
        }
    }

    public override void Shoot()
    { 
        maxFireRate = Time.time;
        Instantiate(playerBullet, bulletPoint.position, bulletPoint.rotation);
        AmmoCountUzi.Ammo -= 1;
    }
}