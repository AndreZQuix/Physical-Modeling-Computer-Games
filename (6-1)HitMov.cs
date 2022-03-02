using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Объект 1 массой m1 движется со скоростью V. По пути встречает
 неподвижный объект 2 массой m2. Удар - прямой центральный.

 -----------------------------------------------------------------

 The object 1 with mass m1 moves with speed V. There is an object 2 at rest on the object 1 way.
 Impact is colliear.*/

public class HitMov : MonoBehaviour
{
    public float m1, V, m2, u;
    public bool isFirstObject;  // two objects in this simulation: m1 (first object, isFirstObject = true) and m2 (second object, isFirstObject = false)
    private bool isHit; // if there was a hit
    
    void Start()
    {
        isHit = false;
        if (isFirstObject)
            u = (V * (m1 - m2)) / (m1 + m2);
        else
            u = (2 * m1 * V) / (m1 + m2);
    }
    
    void Update()
    {
        if (!isHit && isFirstObject)
            transform.Translate(Vector3.forward * V * Time.deltaTime);

        if (isHit)
            transform.Translate(Vector3.forward * u * Time.deltaTime);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (isFirstObject)
            isHit = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!isFirstObject)
            isHit = true;
    }

}
