using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBoost : MonoBehaviour
{
    // Start is called before the first frame update



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            collision.transform.parent.parent.gameObject.GetComponent<PlayerInput>().startBlossom();
            //transform.parent gets us to parent of game object
            //"collision" references sphere collider

            //#1 add script on laser box to destroy
            // # destroy pickup object
            //put tag on pickups and check on laser destroy is not destroying pick ups
            // attach pick up prefabs to explosions for enemies 
        }

        Destroy(gameObject);
    }
}
