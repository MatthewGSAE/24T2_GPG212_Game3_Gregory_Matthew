using UnityEngine;
using System.Collections;
using System;

public class PersistentObject : MonoBehaviour
{
    public bool isUsingWheel;
    private static PersistentObject instance;

    private void Awake()
    {
        // Check if an instance already exists
        if (instance == null)
        {
            // If not, set this instance as the main instance
            instance = this;
            // Make the object persistent across scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If another instance already exists, destroy this one
            Destroy(gameObject);
        }
    }

    // You can add more functionality or behaviors here as needed
}