﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    [Header("Shape Object")]
    public GameObject[] shapePrefabs;
    [Header("Default spawn Delay Time")]
    public float spawnDelay = 2f;
     [Header("Default spawn Time")]
     public float spawnTime = 3f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
