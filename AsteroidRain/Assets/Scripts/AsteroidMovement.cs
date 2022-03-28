using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{

    public float maxSpeed;
    public float minSpeed;


    public float rotationSpeedMin;
    public float rotationSpeedMax;

    private float rotationSpeed;
    private float xAngle, yAngle, zAngle;

    public Vector3 movementDirection;

    private float _asteroidSpeed = 10f;


    void Start()
    {

        _asteroidSpeed = Random.Range(minSpeed, maxSpeed);


        xAngle = Random.Range(0, 360);
        yAngle = Random.Range(0, 360);
        zAngle = Random.Range(0, 360);

        transform.GetChild(0).transform.Rotate(xAngle, yAngle, zAngle, Space.Self);

        rotationSpeed = Random.Range(rotationSpeedMin, rotationSpeedMax);
    }

    void Update()
    {
        transform.Translate(movementDirection * Time.deltaTime * _asteroidSpeed);

        transform.GetChild(0).transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
    }
}
