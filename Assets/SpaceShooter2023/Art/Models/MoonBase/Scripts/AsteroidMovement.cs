using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    [Header("control the speed of the asteroid")]
    public float maxSpeed;
    public float minSpeed;
    [Header("control the rotational speed")]
    public float rotationalSpeedMax;
    public float rotationalSpeedMin;
    private float rotationalSpeed;
    private float xAngle,yAngle,zAngle;

    public Vector3 movementDirection;
    private float asteroidSpeed;

    void start()
    {
        //get a random speed
        asteroidSpeed = Random.Range(minSpeed,maxSpeed);
        // get a random rotation
        xAngle = Random.Range(0,360);
        yAngle = Random.Range(0,360);
        zAngle = Random.Range(0,360);

        transform.Rotate(xAngle,yAngle,zAngle);
    
    }

    void update()
    {
        transform.Translate(movementDirection * Time.deltaTime * asteroidSpeed, Space.World);
    }
    
}
