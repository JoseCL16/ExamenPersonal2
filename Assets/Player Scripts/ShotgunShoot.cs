using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunShoot : WeaponShoot
{
    public int MaxAmmo = 12;
    [SerializeField] private int Ammo;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Ammo > 0)
        {
            Shoot();
            Ammo -= 1;
        }
    }

    public override void Shoot()
    {
        //Instantiate(playerBullet, bulletPoint.position, bulletPoint.rotation);

        Quaternion rotation = Quaternion.Euler(0, 15, 0);
        Vector3 direction = rotation * Vector3.forward;
        Instantiate(playerBullet, bulletPoint.position, Quaternion.LookRotation(direction) * bulletPoint.rotation);

        Quaternion rotation1 = Quaternion.Euler(0, 0, 0);
        Vector3 direction1 = rotation1 * Vector3.forward;
        Instantiate(playerBullet, bulletPoint.position, Quaternion.LookRotation(direction1) * bulletPoint.rotation);

        Quaternion rotation2 = Quaternion.Euler(0, -15, 0);
        Vector3 direction2 = rotation2 * Vector3.forward;
        Instantiate(playerBullet, bulletPoint.position, Quaternion.LookRotation(direction2) * bulletPoint.rotation);

        AmmoCountShotgun.Ammo -= 1;
    }
}