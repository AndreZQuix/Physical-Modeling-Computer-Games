using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Объекту, покоящемуся на высоте h, в момент времени t однократно
 придали ускорение A, направленное под углом к горизонту α. 
 Определить время полёта, среднюю скорость в полёте, скорость в момент приземления, 
 дальность полета объекта.

 -----------------------------------------------------------------

 The object, which was at rest at height h, receives at time t acceleration a directed 
 at an α (alpha) angle to the horizon. Calculate flight time, average flight speed value, 
 speed value at moment of lending, flight distance length.*/

public class FallMov : MonoBehaviour
{
    public float V, h, S, alpha, a, time;
    private float x, y;
    
    void Start()
    {
        x = 0;
        y = h;
        transform.position = new Vector2(x, y);
        V = 0;
    }
    
    void Update()
    {
        if (y > 0)
        {
            time += Time.deltaTime;
            x += (a * Mathf.Cos((alpha / 180) * Mathf.PI)) * time;
            y += ((a * Mathf.Sin((alpha / 180) * Mathf.PI)) * time) - (9.8f *
           Mathf.Pow(time, 2) / 2);
            transform.position = new Vector2(x, y);
            S = (a * a * Mathf.Sin(2 * alpha)) / 10;
            V = S / time;
        }
    }

}
