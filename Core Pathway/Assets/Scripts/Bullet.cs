using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    /// <summary>Bullet moving speed</summary>
    public float Speed = 3;

    // Update is called once per frame
    void Update()
    {
        transform.position += (new Vector3(0, 0, 1) * Time.deltaTime * Speed);
    }
}
