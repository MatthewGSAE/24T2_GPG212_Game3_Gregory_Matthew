using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleAnimation : MonoBehaviour
{
    [Header("Car Selection")]
    public GameObject carSelectionCanvas;

    private void Start()
    {
        carSelectionCanvas.SetActive(false);
        StartCoroutine(Canvas());
    }

    IEnumerator Canvas()
    {
        yield return new WaitForSeconds(2f);
        carSelectionCanvas.SetActive(true);
    }
}
