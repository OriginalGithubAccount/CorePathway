using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// adapted from spawners/repeaters tutorial
public class BulletSpawner : MonoBehaviour
{
    /// <summary>Bullet object</summary>
    public GameObject Bullet;

    /// <summary>Time it take for first bullet to spawn</summary>
    public float SpawnTime;
    /// <summary>Cooldown before shots</summary>
    public float SpawnDelay;
    /// <summary>Lifetime of bullet in seconds</summary>
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
