using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    public GameObject ObjectToActivate;

    void OnTriggerEnter(Collider other)
    {
        ObjectToActivate.SetActive(true);
    }
}
