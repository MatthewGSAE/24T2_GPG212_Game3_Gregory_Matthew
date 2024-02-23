using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [Header("Wheels collider")]
    public WheelCollider frontRightWheelCollider;
    public WheelCollider frontLeftWheelCollider;
    public WheelCollider backRightWheelCollider;
    public WheelCollider backLeftWheelCollider;

    [Header("Wheels Transform")]
    public Transform frontRightWheelTransform;
    public Transform frontLeftWheelTransform;
    public Transform backRightWheelTransform;
    public Transform backLeftWheelTransform;

    [Header("Car Engine")]
    public float accelarationForce = 300f;
    public float breakingForce = 3000f;
    private float presentBreakForce = 0f;
    private float presentAcceleration = 0f;

    [Header("CarMovement Steering")]
    public float wheelsTorque = 35f;
    private float presentTurnAngle = 0f;

    private void Update()
    {
        MoveCar();
        CarSteering();
    }

    private void MoveCar()
    {
        frontLeftWheelCollider.motorTorque = presentAcceleration;
        frontRightWheelCollider.motorTorque = presentAcceleration;
        backLeftWheelCollider.motorTorque = presentAcceleration;
        backRightWheelCollider.motorTorque = presentAcceleration;

        presentAcceleration = accelarationForce * Input.GetAxis("Vertical");
    }

    private void CarSteering()
    {
        presentTurnAngle = wheelsTorque * Input.GetAxis("Horizontal");
        frontLeftWheelCollider.steerAngle = presentTurnAngle;
        frontRightWheelCollider.steerAngle = presentTurnAngle;
    }
}
