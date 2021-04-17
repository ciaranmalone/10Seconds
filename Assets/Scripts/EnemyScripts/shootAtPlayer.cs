using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootAtPlayer : MonoBehaviour
{
    private Transform Player;
    [SerializeField] private float speed = 30;
    [SerializeField] private Vector3 addtionalDegrees = new Vector3(0, 0, 0);
    void Awake()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            Player = GameObject.FindGameObjectWithTag("Player").transform;
        } else
        {
            Player = transform;
        }
        
        
        transform.LookAt(Player.position+ addtionalDegrees);
        StartCoroutine(SelfDestruct());
    }

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