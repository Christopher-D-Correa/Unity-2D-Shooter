using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUp : MonoBehaviour
{
    [SerializeField] private Weapon pickUp;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody.CompareTag("Player"))
        {

            PickMeUp(collision.attachedRigidbody.GetComponent<Player>());
            //collision.attachedRigidbody.GetComponent<Player>().currentWeapon = pickUp;
            //direct assignment or call a method to send the pickup weapon, add script to trigger
            //healthValue.IncreaseHealth(increaseHealthBy);
        }
    }

    protected abstract void PickMeUp(Player playerInTrigger);

}
