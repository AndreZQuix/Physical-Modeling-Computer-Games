using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Объект находится в начальной точке. Через промежуток времени t1 объект получает ускорение aх, 
 изменяющееся по закону: a=A+B*t; и ay, изменяющееся по закону: a=C+D*t. Определить путь, 
 пройденный объектом за время t2, величину скорости и ускорения в момент времени t3 (t1<t3<t2). 
 Движение вдоль 2-х координатных осей.


 -----------------------------------------------------------------

 The object is set on start position. After t1 time the object receives an accelartion ax,
 where ax = A + B*t and ay, where ay = C + D * t. Calculate the distance length in time t2, 
 speed value and acceleration at time t3 (t1 < t3 < t2). Movement is set along two axes.*/

public class AccMov : MonoBehaviour
{
    public int t1, t2, t3;
    public float ax, ay, Vx, Vy, timer, S;
    public Vector2 direction;
    public float A, B, C, D;
    
    void Start()
    {
        timer = 0;
        S = 0;
    }
    
    void Update()
    {
        transform.Translate(Vx * Time.deltaTime, Vy * Time.deltaTime, 0);
        timer += Time.deltaTime;
        if (timer >= t1 && timer <= t2)
        {
            ax = A + B * timer;
            Vx += ax;
            ay = C + D * timer;
            Vy += ay;
        }
        if (timer <= t2)
        {
            S = Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) +
           Mathf.Pow(transform.position.y, 2));
        }
    }
}
