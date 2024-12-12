using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperElite : SniperEnemy

{
    public Vector2 movingDirection;
    public GameObject sniperElite;
    [SerializeField] private Rigidbody2D sniperRigidbody;
    [SerializeField] private float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Blossom", 1f, .5f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(8 * Time.deltaTime, 0, 0);
        
    }

    public void Blossom()
    {
        transform.Rotate(90, 180, 0);

    }
    


}





