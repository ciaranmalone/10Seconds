using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollsion : MonoBehaviour
{
    [SerializeField] private string nextLevel;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            death();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
    void death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Destroy(gameObject);
    }

}
