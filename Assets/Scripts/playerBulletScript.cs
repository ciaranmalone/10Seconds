using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBulletScript : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    [SerializeField] private GameObject bullets;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);


    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}