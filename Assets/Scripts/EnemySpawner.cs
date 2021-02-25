﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float secondsBetweenSpawns=0.75f;
    [SerializeField] EnemyMovement enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(repeatedlySpawnEnemies(secondsBetweenSpawns));
    }

    IEnumerator repeatedlySpawnEnemies(float secondsBetweenSpawns)
    {
        while (true) {
            EnemyMovement Enemy = Instantiate(enemyPrefab, new Vector3(-10, 15, 0), Quaternion.Euler(0,0,0));
            Enemy.transform.parent = FindObjectOfType<EnemySpawner>().transform;
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
