using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    /// <summary>Bullet object</summary>
    public GameObject Bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }
}
