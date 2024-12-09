using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private Weapon pickUp;
    [SerializeField] private float increaseHealthBy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.attachedRigidbody.CompareTag("Player"))
        {
            collision.attachedRigidbody.GetComponent<Player>().currentWeapon = pickUp;
            //direct assignment or call a method to send the pickup weapon, add script to trigger
            //healthValue.IncreaseHealth(increaseHealthBy);
        }
    }
}
