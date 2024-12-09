using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Projectile Weapon")]

public class ProjectileWeapon : Weapon
{
    [SerializeField] private GameObject projectilePrefab;


    public override void Shoot(Transform weaponTip)
    {
        GameObject.Instantiate(projectilePrefab, weaponTip.position, weaponTip.rotation);
    }

    public override void Reload()
    {

    } 
}






