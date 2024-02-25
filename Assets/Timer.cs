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
            opponentCar.movingSpeed = 0f;
            opponentCar1.movingSpeed = 0f;
            opponentCar2.movingSpeed = 0f;
            opponentCar3.movingSpeed = 0f;
            opponentCar4.movingSpeed = 0f;
        }
        else if(countDownTimer == 0)
        {
            carMovement.accelarationForce = 300f;
            opponentCar.movingSpeed = 14f;
            opponentCar1.movingSpeed = 15f;
            opponentCar2.movingSpeed = 16f;
            opponentCar3.movingSpeed = 13f;
            opponentCar4.movingSpeed = 14f;
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
