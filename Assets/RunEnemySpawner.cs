using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunEnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;
    [SerializeField] private Transform parent;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.4f, 0.3f);
    }

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(Enemy, transform.position, transform.rotation);
        enemy.transform.parent = parent;
    }
}
