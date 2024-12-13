using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExplodingEnemy : Enemy

{
    private Player target;

    // Start is called before the first frame update


    // Update is called once per frame


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            base.PlayDeadEffect();
            collision.gameObject.GetComponent<Player>().healthValue.DecreaseHealth(3);
        }
    }

}

