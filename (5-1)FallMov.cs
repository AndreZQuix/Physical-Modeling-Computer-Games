using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Объект бросили со скорость v c высоты h. 
 Определить время и дальность полёта.

 -----------------------------------------------------------------

 The object was thrown from height (h). 
 Calculate the time and length distance of the flight.*/

public class FallMov : MonoBehaviour
{
    public float V, time, h, S;
    private float x, y;
    
    void Start()
    {
        h = transform.position.y;
    }
    
    void Update()
    {
        x = V * Time.time;
        S = x;
        y = h - (9.8f * Mathf.Pow(x, 2) / (2 * Mathf.Pow(V, 2)));
        if (y <= 0)
            Time.timeScale = 0;
        transform.position = new Vector2(x, y);
    }

}
