using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Set object as active if collision</summary>
public class ActivateObject : MonoBehaviour
{
    public GameObject ObjectToActivate;

    void OnTriggerEnter(Collider other)
    {
        ObjectToActivate.SetActive(true);
    }
}
