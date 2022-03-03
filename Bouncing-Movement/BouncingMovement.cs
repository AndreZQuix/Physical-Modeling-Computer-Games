using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingMovement : MonoBehaviour
{
    public float velocity, alpha, acceleration;
    private Vector3 direction, startPosition, lastVelocity, acc;
    public Rigidbody sphere;

    void Start()
    {
        startPosition = transform.position;
        alpha *= Mathf.Deg2Rad;
        direction.x = (startPosition.x * Mathf.Cos(alpha)) - (startPosition.z * Mathf.Sin(alpha));  // calculate movement direction
        direction.y = startPosition.y;
        direction.z = (startPosition.x * Mathf.Sin(alpha)) + (startPosition.z * Mathf.Cos(alpha));
        sphere.velocity = direction * velocity;
        sphere = GetComponent<Rigidbody>();

        acc = new Vector3(acceleration, acceleration, acceleration);
        sphere.constraints = RigidbodyConstraints.FreezePositionY;
    }

    void FixedUpdate()
    {
        lastVelocity = sphere.velocity;
    }

    private void OnCollisionEnter(Collision collision)  // walls reflection
    {
        var speed = lastVelocity.magnitude;
        direction = Vector3.Reflect(lastVelocity.normalized, collision.GetContact(0).normal);

        sphere.velocity = direction * Mathf.Max(speed, 0f);

        if (collision.gameObject.tag.Equals("ADD ACC")) // add this tag to obstacle you want to make able to increase object acceleration
            sphere.velocity += acc;
    }
}