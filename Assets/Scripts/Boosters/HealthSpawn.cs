using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawn : MonoBehaviour

{
    [SerializeField] private GameObject boosterPrefab;
   
    void Start() 
    {
        Instantiate(boosterPrefab, gameObject.transform.position, Quaternion.identity);
        
    }

    
} 
