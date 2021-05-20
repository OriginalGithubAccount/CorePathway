using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    /// <summary>Bullet object</summary>
    public GameObject Bullet;

    public float SpawnTime;
    public float SpawnDelay;
    public float DestroyDelay;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", SpawnTime, SpawnDelay);
    }

    /// <summary>Manage bullets appearing from spawners</summary>
    void Shoot()
    {
        GameObject temp = Instantiate(Bullet, transform.position, transform.rotation);
        Destroy(temp, DestroyDelay);
    }
}
