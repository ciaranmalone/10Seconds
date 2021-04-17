using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollsion : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            Debug.Log("pain");
            death();
        }
    }

    void death()
    {
        SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
        Destroy(gameObject);
    }

}
