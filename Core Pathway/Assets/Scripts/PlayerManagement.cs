using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>Manage some non-movement keybindings</summary>
public class PlayerManagement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Reset();
    }
    
    /// <summary>Press [ESC] to reset level</summary>
    void Reset()
    {
        if (Input.GetButtonDown("Cancel"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
