using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PersistentObject persistentObj;

    [Header("Steering")]
    public GameObject wheel;
    public GameObject arrows;

    private void Awake()
    {
        persistentObj = FindAnyObjectByType<PersistentObject>();
    }

    private void Start()
    {
        wheel.SetActive(persistentObj.isUsingWheel);
        arrows.SetActive(!persistentObj.isUsingWheel);
    }
}