using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDuringTrigger : MonoBehaviour
{
    /// <summary>Object to toggle on and off</summary>
    public GameObject ObjectToToggle;

    void OnTriggerEnter(Collider other)
    {
        ObjectToToggle.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        ObjectToToggle.SetActive(false);
    }
}
