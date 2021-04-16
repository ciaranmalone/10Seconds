using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootAtPlayer : MonoBehaviour
{
    private Transform Player;
    [SerializeField] private float speed = 30;
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        transform.LookAt(Player.position);
        StartCoroutine(SelfDestruct());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
