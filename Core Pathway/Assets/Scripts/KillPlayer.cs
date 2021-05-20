using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    CharacterController controller;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            controller = other.GetComponent<CharacterController>();

            if(controller != null)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
