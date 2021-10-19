using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit something");
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("touched player");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
