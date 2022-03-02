using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Объект находится в начальной точке. Через промежуток времени t
 начинает движение по винтовой линии радиуса R вдоль одной из осей координат.
 Движение с ускорением, определяемом по закону вида a=A+B*t. Исходные
 данные: скорость, ускорение, время. Определить путь, пройденный телом.

 -----------------------------------------------------------------

 The object is set on start position. After t time starts screw moving on radius R along one axis.
 It gets acceleration a, where a = A + B * t. Speed, acceleration and time values are known. 
 Calculate the covered distance length.*/

public class ScrewMov : MonoBehaviour
{
    private Vector3 startPosition;
    public float speed, time, R, L, movTime, acceleration, A, B, S;
    private float h, an;
    private float x, y, z;
    void Start()
    {
        startPosition = transform.position;
        movTime = 0;
        L = 0;
        S = 0;
    }
    void Update()
    {
        movTime += Time.deltaTime;
        if (movTime >= time)
        {
            an -= 0.1f;
            x = Mathf.Sin(an) * R;
            y = an / 10;
            z = Mathf.Cos(an) * R;
            Vector3 pos = new Vector3(x, y, z) * speed;
            transform.position = startPosition + pos;
            h = 2 * Mathf.PI * R * Mathf.Tan(an);
            L = Mathf.Sqrt(Mathf.Pow((Mathf.PI * R * 2), 2) + Mathf.Pow(h, 2));
            acceleration = A + B * time;
            speed += Mathf.Sqrt(acceleration * R);
            S += speed * time + (acceleration * Mathf.Pow(time, 2)) / 2;
        }
    }
}
