using UnityEngine;

public abstract class Weapon : ScriptableObject
{
    public GameObject lightOrb;
    [SerializeField] protected float damage;
    [SerializeField] protected int ammo;
    [SerializeField] protected float fireRate;


    public void StartShooting()
    {
        //bool isShooting = true; 
    }

    public void StopShooting()
    {
        //bool isShooting = false; 
    }
       


    public abstract void Shoot(Transform weaponTip);



    public abstract void Reload();



    public bool HasAmmo()
    {
        return ammo > 0;
    }

    /*public Weapon(Transform tip)

    { 
        weaponTip = tip; 
    }
    */
}


























































