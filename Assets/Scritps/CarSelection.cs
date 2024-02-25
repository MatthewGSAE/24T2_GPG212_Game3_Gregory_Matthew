using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarSelection : MonoBehaviour
{
    [Header("Button and Canvas")]
    public Button nextButton;
    public Button previousButton;

    private int currentCar;
    private GameObject[] carList;

    private void Awake()
    {
        chooseCar(0);
    }

    private void Start()
    {

        currentCar = PlayerPrefs.GetInt("CarSelected");
        carList = new GameObject[transform.childCount];

        for(int i = 0; i < transform.childCount; i++)
        {
            carList[i] = transform.GetChild(i).gameObject;
        }

        foreach (GameObject go in carList)
        {
            go.SetActive(false);
        }

        if (carList[currentCar])
        {
            carList[currentCar].SetActive(true);
        }
    }

    private void chooseCar(int index)
    {
        previousButton.interactable = (currentCar != 0);
        nextButton.interactable = (currentCar != transform.childCount - 1);

        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }

    public void swithCar(int switchCars)
    {
        currentCar += switchCars;
        chooseCar(currentCar);  
    }

    public void playGame()
    {
        PlayerPrefs.SetInt("CarSelected", currentCar);
        SceneManager.LoadScene("GameScene");
    }
}
