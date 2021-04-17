using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunEnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;
    [SerializeField] private Transform parent;
    [SerializeField] private float spawnTime = 0.3f;
    [SerializeField] private float startPos, endPos;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.4f, spawnTime);
    }

    void SpawnEnemy()
    {

        GameObject enemy = Instantiate(Enemy, transform.position + new Vector3(Random.Range(startPos, endPos), 0, 0), transform.rotation);
        enemy.transform.parent = parent;
    }
}
