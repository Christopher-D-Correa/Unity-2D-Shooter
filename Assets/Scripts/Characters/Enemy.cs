using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private float distanceToStop = 2f;
    [SerializeField] protected float attackCooldown = 3f;


    private Player target;
    public GameObject bulletPrefab;
    public Transform weaponTip;


    protected override void Start()
    {
        base.Start();
        target = FindObjectOfType<Player>();
        
    }

    private void Update()
    {
        if (healthValue.GetHealthValue() <= 0)
        {
            Destroy(gameObject);
        }

        if (!target) return;

        Vector2 destination = target.transform.position;
        Vector2 currentPosition = transform.position;
        Vector2 direction = destination - currentPosition;
        if (Vector2.Distance(destination, currentPosition) > distanceToStop)
        {
            Move(direction.normalized);
        }

        else
        {
            Attack();

        }

        Look(direction.normalized);

    }

    public override void Attack()
    {
        base.Attack();
    }

    public override void PlayDeadEffect()
    {
        GameManager.instance.RemoveEnemyFromList(gameObject);
        base.PlayDeadEffect();
    }


}
