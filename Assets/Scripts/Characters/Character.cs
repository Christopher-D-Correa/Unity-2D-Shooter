using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] private float movementspeed = 10f;
    protected float speed;
    //Protected is same as private but can be accessed by inherited classes 
    public Health healthValue;
    public Weapon currentWeapon;
    [SerializeField] private float health;


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
        Destroy(gameObject);
    }
    

    public void Interact()

    {

    }

    public virtual void Attack()

    {


    }




}


