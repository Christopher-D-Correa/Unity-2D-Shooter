using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] private float movementspeed = 10f;
    protected float speed;
    public Health healthValue;
    public Weapon currentWeapon;
    [SerializeField] private float health;
    [SerializeField] private GameObject dieEffect;
    public GameObject healthPickUp;

    protected virtual void Start()
    {
        healthValue = new Health(health);
        healthValue.OnDied.AddListener(PlayDeadEffect);
        Instantiate(currentWeapon);
    }

    public virtual void Move(Vector2 direction)
    //If you call a move you must dictate a direction 
    //playerObject.Move and enemyObject.Move added in Game Manager equates


    {

        myRigidbody.AddForce(direction * Time.deltaTime * movementspeed, ForceMode2D.Impulse);
    }

    public virtual void Look(Vector2 direction)
    {
        float angle; // = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        angle = Vector2.SignedAngle(Vector2.up, direction);
        myRigidbody.SetRotation(angle);
    }

    public virtual void PlayDeadEffect()
    {
        Instantiate(dieEffect, transform.position, Quaternion.identity);
        Invoke("spawnHealthPickUp", .5f);
        Destroy(gameObject);
    }

    public void spawnHealthPickUp()
    {
        Debug.Log("spawnHealthPickUp");
        Instantiate(healthPickUp, transform.position, Quaternion.identity);
    }

   

    public void Interact()

    {

    }

    public virtual void Attack()

    {


    }




}


