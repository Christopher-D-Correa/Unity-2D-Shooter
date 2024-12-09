using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperEnemy : Enemy
{
    [SerializeField] protected float Bulletspeed = 15f;
    private float attackTimer;


    protected override void Start()
    {
        base.Start();

    }

    public override void Attack()
    {
        base.Attack();
        if (attackTimer >= attackCooldown)
        {
            StartCoroutine(FireSnipe());
        }

        else
        {
            attackTimer += Time.deltaTime;
        }
    }

    public IEnumerator FireSnipe()
    {
        attackTimer = 0;
        int count = 1;
        while (count > 0)
        {
            count--;
            ShootGun();
            yield return new WaitForSeconds(4.4f);

        }

    }

    public void ShootGun()
    {
        Instantiate(bulletPrefab, weaponTip.position, transform.rotation);
        //object, position and rotation (quaternion means not rotated from where it starts from, same as 0,0,0 null rotation

    }
}



