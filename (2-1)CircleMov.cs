using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Объект вращается вокруг неподвижного центра равноускоренно.
 Расстояние от тела до центра – R. Известна частота вращения ν, с-1. 

 -----------------------------------------------------------------

 The object uniformly spins around motionless center.
 R is a distance from center to body. Rotation frequency V is known, c-1.*/

public class CircleMov : MonoBehaviour
{
    private float alpha;
    [SerializeField]
    Transform centerPoint;
    [SerializeField]
    public float R, v, c, aV, t, N;
    public bool isCircle;
    void Start()
    {
        N = v * t;
        aV = 2 * Mathf.PI * v;
        isCircle = true;
        alpha = 0.0f;
    }
    // Update is called once per frame
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
