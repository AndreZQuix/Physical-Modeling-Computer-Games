using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Объект вращается вокруг неподвижного центра равноускоренно.
 Расстояние от тела до центра – R. Известна частота вращения ν, с-1.
 Определить: угол поворота, координату и линейную скорость объекта в момент времени t. 

 -----------------------------------------------------------------

 The object uniformly spins around motionless center.
 R is a distance from center to body. Rotation frequency V is known, c-1.
 Calculate the angle of rotation, object's coordinate and linear speed at time t.*/

public class CircleMov : MonoBehaviour
{
    private float alpha, aV;
    [SerializeField]
    Transform centerPoint;
    [SerializeField]
    public float R, v, c, t, N, rotationAlpha, linearSpeed, angle;
    public Vector2 coordinate;
    public bool isCircle;

    void Start()
    {
        aV = 2 * Mathf.PI * v;
        rotationAlpha = aV * t;
        angle = rotationAlpha * (180 / Mathf.PI);
        coordinate = new Vector2(R * Mathf.Cos((angle % 360) * (Mathf.PI / 180)), R *
       Mathf.Sin((angle % 360) * (Mathf.PI / 180)));
        isCircle = true;
        alpha = 0.0f;
    }

    void Update()
    {
        if (isCircle)
        {
            alpha += aV * Time.deltaTime;
            transform.position = new Vector2(R * Mathf.Cos(alpha) + centerPoint.position.x,
           R * Mathf.Sin(alpha) + centerPoint.position.y);
        }
        else alpha = 0.0f;
    }
}
