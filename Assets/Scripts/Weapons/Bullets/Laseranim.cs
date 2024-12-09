using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laseranim : MonoBehaviour
{
    public float speed = 1f;
    [SerializeField] private Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.localEulerAngles;
        rot.y += Time.time * speed;
        transform.localEulerAngles = rot;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "Enemy")
        {
            //Destroy(other.gameObject);
        }

    }

}
