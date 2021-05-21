using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// adapted from https://www.youtube.com/watch?v=FXIJFVwxUbU
public class SlidingDoorController : MonoBehaviour
{
    /// <summary>Door to open</summary>
    public GameObject Door;
    public float doorSpeed = 100;

    bool open = false;
    bool doorMoving = false;
    float originalPos;

    void Awake()
    {
        originalPos = Door.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (doorMoving)
            ManageDoorState();
    }

    void OnMouseDown()
    {
        open = !open;
        doorMoving = true;
    }

    /// <summary>Tell door when to open</summary>
    void ManageDoorState()
    {
        if (open)
            OpenDoor();
        else
            CloseDoor();
    }

    /// <summary>Open the door</summary>
    void OpenDoor()
    {
        Door.transform.position += (new Vector3(0, 0, 1) * Time.deltaTime * doorSpeed);
        if (Door.transform.position.z > originalPos + 10f) // stop moving if it has moved +10 in the z
            doorMoving = false;
    }

    /// <summary>Close the door</summary>
    void CloseDoor()
    {
        Door.transform.position += (new Vector3(0, 0, -1) * Time.deltaTime * doorSpeed);
        if (Door.transform.position.z <= originalPos) // stop moving if it is equal to original position
            doorMoving = false;
    }
}
