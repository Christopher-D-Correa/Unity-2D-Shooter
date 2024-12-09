using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mgbullet : MonoBehaviour

{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] protected float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.velocity = transform.up * bulletSpeed;
        //transform.up gives movement on green axis 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player>().healthValue.DecreaseHealth(1);
            
        }

        Destroy(gameObject);
    }

   
}
