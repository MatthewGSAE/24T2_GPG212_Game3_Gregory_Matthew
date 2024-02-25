using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("Timer")]
    public float countDownTimer = 5f;

    [Header("things to stop")]
    public CarMovement carMovement;
    public CarMovement carMovement1;
    public CarMovement carMovement2;
    public CarMovement carMovement3;
    public CarMovement carMovement4;
    public CarMovement carMovement5;
    public CarMovement carMovement6;
    public OpponentCar opponentCar;
    public OpponentCar opponentCar1;
    public OpponentCar opponentCar2;
    public OpponentCar opponentCar3;
    public OpponentCar opponentCar4;

    public Text countDownText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimeCount());
    }

    // Update is called once per frame
    void Update()
    {
        if(countDownTimer > 1)
        {
            carMovement.accelarationForce = 0f;
            carMovement1.accelarationForce = 0f;
            carMovement2.accelarationForce = 0f;
            carMovement3.accelarationForce = 0f;
            carMovement4.accelarationForce = 0f;
            carMovement5.accelarationForce = 0f;
            carMovement6.accelarationForce = 0f;
            opponentCar.movingSpeed = 0f;
            opponentCar1.movingSpeed = 0f;
            opponentCar2.movingSpeed = 0f;
            opponentCar3.movingSpeed = 0f;
            opponentCar4.movingSpeed = 0f;
        }
        else if(countDownTimer == 0)
        {
            carMovement.accelarationForce = 300f;
            carMovement1.accelarationForce = 300f;
            carMovement2.accelarationForce = 300f;
            carMovement3.accelarationForce = 300f;
            carMovement4.accelarationForce = 300f;
            carMovement5.accelarationForce = 300f;
            carMovement6.accelarationForce = 300f;
            opponentCar.movingSpeed = 15.8f;
            opponentCar1.movingSpeed = 15f;
            opponentCar2.movingSpeed = 16f;
            opponentCar3.movingSpeed = 15.5f;
            opponentCar4.movingSpeed = 15.2f;
        }
    }

    IEnumerator TimeCount()
    {
        while(countDownTimer > 0)
        {
            countDownText.text = countDownTimer.ToString();
            yield return new WaitForSeconds(1f);
            countDownTimer--;
        }

        countDownText.text = "GO";
        yield return new WaitForSeconds(1f);
        countDownText.gameObject.SetActive(false);
    }
}
