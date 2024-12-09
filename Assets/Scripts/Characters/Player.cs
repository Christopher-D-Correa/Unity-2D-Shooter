using UnityEngine;

public class Player : Character


{
    public GameObject lightOrb;
    public float rotationAngle = 360f;
    public float rotationTime = 3f;
    [SerializeField] private Transform playerWeaponTip;
    //[SerializeField] private GameObject bulletReference;

    public override void Attack()
    {
        base.Attack();

        currentWeapon.Shoot(playerWeaponTip);
    }

    
    

    /*
    public void ShootlightOrb()
    {
        Instantiate(lightOrb, transform.position + (transform.right * .001f), transform.rotation);
    }
    
    private void Update()
    {
        if (healthValue.GetHealthValue() <= 0)
        {
            Destroy(gameObject);
        }
    }

    */

}

