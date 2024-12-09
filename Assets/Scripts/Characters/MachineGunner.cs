using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunner : Enemy
{
    private float attackTimer;
    public override void Attack()
    {
        base.Attack();
        if (attackTimer >= attackCooldown)
        {
            StartCoroutine(FireMachinegun());
        }

        else
        {
            attackTimer += Time.deltaTime;
        }
    }

    public IEnumerator FireMachinegun()
    {
        attackTimer = 0;
        int count = 5;
        while (count > 0)
        {
            count--;
            ShootGun();
            yield return new WaitForSeconds(.25f);

        }
        
    }

    public void ShootGun()
    {
        Vector3 bulletRotation = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + Random.Range(-2f, 2f));
        Instantiate(bulletPrefab, weaponTip.position, Quaternion.Euler(bulletRotation)); 
        //object, position and rotation (quaternion means not rotated from where it starts from, same as 0,0,0 null rotation

    }
}

