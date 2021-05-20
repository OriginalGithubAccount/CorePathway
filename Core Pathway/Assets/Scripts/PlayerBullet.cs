using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    /// <summary>Bullet travel speed</summary>
    public float Speed = 5;

    float mouseX;

    void Start()
    {
	mouseX = Input.GetAxis("Mouse X");
    }

    void Update()
    {
        transform.position += ((Vector3.up * mouseX) * Time.deltaTime * Speed);
    }
}
