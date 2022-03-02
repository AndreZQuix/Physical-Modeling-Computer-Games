using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Объект находится в начальной точке. Через промежуток времени t1 объект получает 
 ускорение a, изменяющееся по закону: a=A+B*t. 
 Определить путь, пройденный объектом за время t2, величину скорости и ускорения 
 в момент t3 (t1<t3<t2). Движение вдоль 1 координатной оси.

 -----------------------------------------------------------------

 The object is set on start position. After t1 time the object receives an accelartion a,
 where a = A + B*t. Calculate the distance length in time t2, speed value and acceleration at time t3 (t1 < t3 < t2).
 Movement is set along one axis.*/

public class AccMov : MonoBehaviour
{
    public int t1, t2, t3;
    public float a, V, timer, S;
    public Vector2 direction;
    public float A, B;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        S = 0;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction.normalized * V);
        timer += Time.deltaTime;
        if (timer >= t1 && timer <= t2)
        {
            a = A + B * timer;
            V += a;
        }
        if (timer <= t2)
        {
            S = Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) +
           Mathf.Pow(transform.position.y, 2));
        }
    }
}
