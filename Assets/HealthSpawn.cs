using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawn : MonoBehaviour

{
    public GameObject healthPrefab;
   
    void Start()
    {
        Instantiate(healthPrefab, gameObject.transform.position, Quaternion.identity);
    }

 
}
